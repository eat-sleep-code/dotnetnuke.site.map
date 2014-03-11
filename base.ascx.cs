using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Tabs;
using System;
using Telerik.Web.UI;

namespace DONEIN_NET.Site_Map
{

	public partial class Base : DotNetNuke.Entities.Modules.PortalModuleBase, IActionable
	{

		#region "Declare: Shared Classes"

			ModuleLocalization localization = new ModuleLocalization();

		#endregion



		#region "Declare: Local Objects"

			protected Int32 siteMapRoot;
			protected String title;
			protected Int32 clickableTitle;
			protected Int32 defaultState;
			protected Int32 controlVisibility;
			protected Int32 mapType;
			protected Int32 usePageBasedPriorities;
			protected Decimal minimumPriority;
			protected Int32 showHidden;
			protected Int32 showDisabled;
			protected Int32 showLinks;
			protected Int32 showResults;
			protected Int32 expandToCurrentPage;
			protected Int32 limitBasedOnSiteSettings;
			protected String imagePath;
			protected String imageFileExtension;
		
		#endregion



		#region "Page: Load"

			private void Page_Load(object sender, EventArgs e)
			{
				LocalizeModule();
				
				// Retrieve Settings From Database
				siteMapRoot = Convert.ToInt32(Settings["doneinSiteMap.siteMapRoot"]);
				title = Convert.ToString(Settings["doneinSiteMap.Title"]);
				clickableTitle = Convert.ToInt32(Settings["doneinSiteMap.ClickableTitle"]);
				defaultState = Convert.ToInt32(Settings["doneinSiteMap.DefaultState"]);
				controlVisibility = Convert.ToInt32(Settings["doneinSiteMap.ControlVisibility"]);
				mapType = Convert.ToInt32(Settings["doneinSiteMap.mapType"]);
				usePageBasedPriorities = Convert.ToInt32(Settings["doneinSiteMap.UsePageBasedPriorities"]);
				minimumPriority = Convert.ToDecimal(Settings["doneinSiteMap.MinimumPriority"]);
				showHidden = Convert.ToInt32(Settings["doneinSiteMap.ShowHidden"]);
				showDisabled = Convert.ToInt32(Settings["doneinSiteMap.ShowDisabled"]);
				showLinks = Convert.ToInt32(Settings["doneinSiteMap.ShowLink"]);
				showResults = Convert.ToInt32(Settings["doneinSiteMap.ShowResults"]);
				expandToCurrentPage = Convert.ToInt32(Settings["doneinSiteMap.ExpandToCurrentPage"]);
				limitBasedOnSiteSettings = Convert.ToInt32(Settings["doneinSiteMap.LimitBasedOnSiteSettings"]);
				imagePath = Convert.ToString(Settings["doneinSiteMap.ImagePath"]);
				imageFileExtension = Convert.ToString(Settings["doneinSiteMap.imageFileExtension"]);

				// Handle Default File Extension For Site Map Images
				if (String.IsNullOrEmpty(imageFileExtension))
				{
					imageFileExtension = "png";
				}

				// Set Expand/Collapse Control Visibility
				if (controlVisibility < 1)
				{
					controlsPanel.Visible = false;
				}

				// Create The Site Map
				RadTreeNode siteMapNode = GenerateNode(siteMapRoot);
				SiteMapTreeview.Nodes.Add(siteMapNode);
			}

		#endregion



		#region "Localize: Module"

			private void LocalizeModule()
			{
				// Localize Text
				ExpandSiteMapLink.Text = localization.GetString("ExpandSiteMapLink.Text", LocalResourceFile);
				CollapseSiteMapLink.Text = localization.GetString("CollapseSiteMapLink.Text", LocalResourceFile);
				Divider.Text = localization.GetString("Divider.Text", LocalResourceFile);
			}

		#endregion



		#region "Generate SiteMap"

			public RadTreeNode GenerateNode(Int32 int_node_siteMapRoot)
			{
				System.Collections.Generic.List<TabInfo> tabs = TabController.GetTabsByParent(int_node_siteMapRoot, PortalId);

				foreach (TabInfo tab in tabs)
				{
					Boolean showLink = true;
					// DOES USER HAVE PERMISSION TO VIEW THIS TAB?
					if (DotNetNuke.Security.Permissions.TabPermissionController.CanViewPage(tab) == false)
					{
						showLink = false;
					}
			
					// IS SITE MAP PRIORITY BELOW MINIMUM (IF MODULE IS CONFIGURED TO USE PAGE-BASED PRIORITIES)?
					if (usePageBasedPriorities == 1 & Convert.ToDecimal(tab.SiteMapPriority) < minimumPriority)
					{
						showLink = false;
					}

					// IS TAB HIDDEN, IF SO SHOULD WE SHOW IT?
					if (showHidden == -1 & tab.IsVisible == false)
					{
						showLink = false;
					}

					// IS TAB DISABLED, IF SO SHOULD WE SHOW IT?
					if (showDisabled == -1 & tab.DisableLink == true)
					{
						showLink = false;
					}

					if (showLinks == -1 & (tab.Url.Contains("http://") | tab.Url.Contains("https://")))
					{
						showLink = false;	
					}

					if (showResults == -1 & tab.TabName.Contains("Search Results") == true)
					{
						showLink = false;
					}

					if (showLink == true)
					{
						// Add Link To Treeview Control
						RadTreeNode siteMapNode = new RadTreeNode();
						siteMapNode.NavigateUrl = DotNetNuke.Common.Globals.NavigateURL(tab.Url);
						siteMapNode.ToolTip = localization.GetString("NavigationAltTag.Text", LocalResourceFile);
						//siteMapNode.Target = "_self";

						// Get Child Tabs
						GenerateNode(tab.TabID);
						return siteMapNode;
					}
					return null;
				}
				return null;
			}

		#endregion



		#region "Interfaces"

			public ModuleActionCollection ModuleActions
			{
				get
				{
					ModuleActionCollection actions = new ModuleActionCollection();
					actions.Add(GetNextActionID(), localization.GetString("ContentOptions.Action", LocalResourceFile), DotNetNuke.Entities.Modules.Actions.ModuleActionType.ContentOptions, "", "", EditUrl(), false, DotNetNuke.Security.SecurityAccessLevel.Edit, true, false);
					return actions;
				}
			}

		#endregion

	}
}
