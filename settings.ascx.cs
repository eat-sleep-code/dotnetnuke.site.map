using System;
using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Tabs;
using DotNetNuke.Services.Exceptions;
using System.Web.UI.WebControls;

namespace DONEIN_NET.Site_Map
{

	public partial class Settings : PortalModuleBase
	{

		#region "Declare: Shared Classes"
			ModuleLocalization localization = new ModuleLocalization();
		#endregion

		

		#region "Page: Load"

			private void Page_Load(Object sender, EventArgs e)
			{
				LocalizeModule();
				try
				{
					if (this.Page.IsPostBack == false)
					{
						if (ModuleId > 0)
						{
							SiteMapRoot_Bind();
							
							string titleValue = Convert.ToString(Settings["doneinSiteMap.Title"]);
							string clickableTitleValue = Convert.ToString(Settings["doneinSiteMap.ClickableTitle"]);
							string defaultStateValue = Convert.ToString(Settings["doneinSiteMap.DefaultState"]);
							string controlVisibilityValue = Convert.ToString(Settings["doneinSiteMap.ControlVisibility"]);
							string mapTypeValue = Convert.ToString(Settings["doneinSiteMap.mapType"]);
							string usePageBasedPrioritiesValue = Convert.ToString(Settings["doneinSiteMap.UsePageBasedPriorities"]);
							string minimumPriorityValue = Convert.ToString(Settings["doneinSiteMap.MinimumPriority"]);
							string showHiddenValue = Convert.ToString(Settings["doneinSiteMap.ShowHidden"]);
							string showDisabledValue = Convert.ToString(Settings["doneinSiteMap.ShowDisabled"]);
							string showLinksValue = Convert.ToString(Settings["doneinSiteMap.ShowLink"]);
							string showResultsValue = Convert.ToString(Settings["doneinSiteMap.ShowResults"]);
							string expandToCurrentPageValue = Convert.ToString(Settings["doneinSiteMap.ExpandToCurrentPage"]);
							string siteMapRootValue = Convert.ToString(Settings["doneinSiteMap.siteMapRoot"]);
							string limitBasedOnSiteSettingsValue = Convert.ToString(Settings["doneinSiteMap.LimitBasedOnSiteSettings"]);
							string imagePathValue = Convert.ToString(Settings["doneinSiteMap.ImagePath"]);
							string imageFileExtensionValue = Convert.ToString(Settings["doneinSiteMap.imageFileExtension"]);

							if (string.IsNullOrEmpty(titleValue))
							{
								Title.Text = PortalSettings.PortalName.Trim();
							}
							else
							{
								Title.Text = titleValue;
							}


							if (string.IsNullOrEmpty(clickableTitleValue))
							{
								ClickableTitle.SelectedValue = "1";
							}
							else
							{
								ClickableTitle.SelectedValue = clickableTitleValue;
							}


							if (string.IsNullOrEmpty(defaultStateValue))
							{
								DefaultState.SelectedValue = "0";
							}
							else
							{
								DefaultState.SelectedValue = defaultStateValue;
							}


							if (string.IsNullOrEmpty(controlVisibilityValue))
							{
								ControlVisibility.SelectedValue = "1";
							}
							else
							{
								ControlVisibility.SelectedValue = controlVisibilityValue;
							}


							if (string.IsNullOrEmpty(mapTypeValue))
							{
								MapType.SelectedValue = "1";
							}
							else
							{
								MapType.SelectedValue = mapTypeValue;
							}


							if (string.IsNullOrEmpty(usePageBasedPrioritiesValue))
							{
								UsePageBasedPriorities.SelectedValue = "-1";
							}
							else
							{
								UsePageBasedPriorities.SelectedValue = usePageBasedPrioritiesValue;
							}


							if (string.IsNullOrEmpty(minimumPriorityValue))
							{
								MinimumPriority.Text = "0.1";
							}
							else
							{
								MinimumPriority.Text = minimumPriorityValue;
							}


							if (string.IsNullOrEmpty(showHiddenValue))
							{
								ShowHidden.SelectedValue = "1";
							}
							else
							{
								ShowHidden.SelectedValue = showHiddenValue;
							}


							if (string.IsNullOrEmpty(showDisabledValue))
							{
								ShowDisabled.SelectedValue = "0";
							}
							else
							{
								ShowDisabled.SelectedValue = showDisabledValue;
							}


							if (string.IsNullOrEmpty(showLinksValue))
							{
								ShowLinks.SelectedValue = "1";
							}
							else
							{
								ShowLinks.SelectedValue = showLinksValue;
							}


							if (string.IsNullOrEmpty(showResultsValue))
							{
								ShowResults.SelectedValue = "1";
							}
							else
							{
								ShowResults.SelectedValue = showResultsValue;
							}


							if (string.IsNullOrEmpty(expandToCurrentPageValue))
							{
								ExpandToCurrentPage.SelectedValue = "-1";
							}
							else
							{
								ExpandToCurrentPage.SelectedValue = expandToCurrentPageValue;
							}


							if (string.IsNullOrEmpty(siteMapRootValue))
							{
								SiteMapRoot.SelectedIndex = 0;
							}
							else
							{
								SiteMapRoot.SelectedValue = siteMapRootValue;
							}


							if (string.IsNullOrEmpty(limitBasedOnSiteSettingsValue))
							{
								LimitBasedOnSiteSettings.SelectedValue = "1";
							}
							else
							{
								LimitBasedOnSiteSettings.SelectedValue = limitBasedOnSiteSettingsValue;
							}


							if (string.IsNullOrEmpty(imagePathValue))
							{
								ImagePath.Text = "/DesktopModules/DONEIN_NET/Site_Map/images/_default/";
							}
							else
							{
								ImagePath.Text = imagePathValue;
							}


							if (string.IsNullOrEmpty(imageFileExtensionValue))
							{
								ImageFileExtension.SelectedValue = "png";
							}
							else
							{
								ImageFileExtension.SelectedValue = imageFileExtensionValue;
							}

						}
					}
				}
				catch (Exception ex)
				{
					Exceptions.ProcessModuleLoadException(this, ex);
				}
			}

		#endregion



		#region "Localize Module"

			private void LocalizeModule()
			{
				UpdateButton.Text = localization.GetString("UpdateButton.Text", LocalResourceFile);
				CancelButton.Text = localization.GetString("CancelButton.Text", LocalResourceFile);

				TitleLabel.Text = localization.GetString("TitleLabel.Text", LocalResourceFile);
				TitleLabel.ToolTip = localization.GetString("TitleLabel.ToolTip", LocalResourceFile);

				ClickableTitleLabel.Text = localization.GetString("ClickableTitleLabel.Text", LocalResourceFile);
				ClickableTitleLabel.ToolTip = localization.GetString("ClickableTitleLabel.ToolTip", LocalResourceFile);

				DefaultStateLabel.Text = localization.GetString("DefaultStateLabel.Text", LocalResourceFile);
				DefaultStateLabel.ToolTip = localization.GetString("DefaultStateLabel.ToolTip", LocalResourceFile);

				ControlVisibilityLabel.Text = localization.GetString("ControlVisibilityLabel.Text", LocalResourceFile);
				ControlVisibilityLabel.ToolTip = localization.GetString("ControlVisibilityLabel.ToolTip", LocalResourceFile);

				MapTypeLabel.Text = localization.GetString("MapTypeLabel.Text", LocalResourceFile);
				MapTypeLabel.ToolTip = localization.GetString("MapTypeLabel.ToolTip", LocalResourceFile);

				UsePageBasedPrioritiesLabel.Text = localization.GetString("UsePageBasedPrioritiesLabel.Text", LocalResourceFile);
				UsePageBasedPrioritiesLabel.ToolTip = localization.GetString("UsePageBasedPrioritiesLabel.ToolTip", LocalResourceFile);

				MinimumPriorityLabel.Text = localization.GetString("MinimumPriorityLabel.Text", LocalResourceFile);
				MinimumPriorityLabel.ToolTip = localization.GetString("MinimumPriorityLabel.ToolTip", LocalResourceFile);
				
				ShowHiddenLabel.Text = localization.GetString("ShowHiddenLabel.Text", LocalResourceFile);
				ShowHiddenLabel.ToolTip = localization.GetString("ShowHiddenLabel.ToolTip", LocalResourceFile);

				ShowDisabledLabel.Text = localization.GetString("ShowDisabledLabel.Text", LocalResourceFile);
				ShowDisabledLabel.ToolTip = localization.GetString("ShowDisabledLabel.ToolTip", LocalResourceFile);

				ShowLinksLabel.Text = localization.GetString("ShowLinksLabel.Text", LocalResourceFile);
				ShowLinksLabel.ToolTip = localization.GetString("ShowLinksLabel.ToolTip", LocalResourceFile);

				ShowResultsLabel.Text = localization.GetString("ShowResultsLabel.Text", LocalResourceFile);
				ShowResultsLabel.ToolTip = localization.GetString("ShowResultsLabel.ToolTip", LocalResourceFile);

				ExpandToCurrentPageLabel.Text = localization.GetString("ExpandToCurrentPageLabel.Text", LocalResourceFile);
				ExpandToCurrentPageLabel.ToolTip = localization.GetString("ExpandToCurrentPageLabel.ToolTip", LocalResourceFile);

				SiteMapRootLabel.Text = localization.GetString("SiteMapRootLabel.Text", LocalResourceFile);
				SiteMapRootLabel.ToolTip = localization.GetString("SiteMapRootLabel.ToolTip", LocalResourceFile);

				LimitBasedOnSiteSettingsLabel.Text = localization.GetString("LimitBasedOnSiteSettingsLabel.Text", LocalResourceFile);
				LimitBasedOnSiteSettingsLabel.ToolTip = localization.GetString("LimitBasedOnSiteSettingsLabel.ToolTip", LocalResourceFile);

				ImagePathLabel.Text = localization.GetString("ImagePathLabel.Text", LocalResourceFile);
				ImagePathLabel.ToolTip = localization.GetString("ImagePathLabel.ToolTip", LocalResourceFile);

				ImageFileExtensionLabel.Text = localization.GetString("ImageFileExtensionLabel.Text", LocalResourceFile);
				ImageFileExtensionLabel.ToolTip = localization.GetString("ImageFileExtensionLabel.ToolTip", LocalResourceFile);
				
				ClickableTitle.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				ClickableTitle.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				DefaultState.Items.Add(new ListItem(localization.GetString("NoPreference.Text", LocalResourceFile), "0"));
				DefaultState.Items.Add(new ListItem(localization.GetString("Expanded.Text", LocalResourceFile), "1"));
				DefaultState.Items.Add(new ListItem(localization.GetString("Collapsed.Text", LocalResourceFile), "-1"));

				ControlVisibility.Items.Add(new ListItem(localization.GetString("Visible.Text", LocalResourceFile), "1"));
				ControlVisibility.Items.Add(new ListItem(localization.GetString("Hidden.Text", LocalResourceFile), "-1"));

				MapType.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				MapType.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				UsePageBasedPriorities.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile),"1"));
				UsePageBasedPriorities.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile),"-1"));
				
				ShowHidden.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				ShowHidden.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				ShowDisabled.Items.Add(new ListItem(localization.GetString("YesEnabled.Text", LocalResourceFile), "1"));
				ShowDisabled.Items.Add(new ListItem(localization.GetString("YesDisabled.Text", LocalResourceFile), "0"));
				ShowDisabled.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				ShowLinks.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				ShowLinks.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				ShowResults.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				ShowResults.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				ExpandToCurrentPage.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				ExpandToCurrentPage.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				LimitBasedOnSiteSettings.Items.Add(new ListItem(localization.GetString("Yes.Text", LocalResourceFile), "1"));
				LimitBasedOnSiteSettings.Items.Add(new ListItem(localization.GetString("No.Text", LocalResourceFile), "-1"));

				ImageFileExtension.Items.Add(new ListItem(localization.GetString("GIF.Text", LocalResourceFile), "gif"));
				ImageFileExtension.Items.Add(new ListItem(localization.GetString("JPEG.Text", LocalResourceFile), "jpg"));
				ImageFileExtension.Items.Add(new ListItem(localization.GetString("PNG.Text", LocalResourceFile), "png"));
				ImageFileExtension.Items.Add(new ListItem(localization.GetString("SVG.Text", LocalResourceFile), "svg"));
			}
		#endregion



		#region "Handle: Update Button (UpdateButton)"

			private void UpdateButton_Click(object sender, EventArgs e)
			{
				try
				{
					ModuleController obj_modules = new ModuleController();
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMaptitle", Title.Text.Trim());
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMaptitle_clickable", ClickableTitle.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapdefault_state", DefaultState.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapcontrol_visibility", ControlVisibility.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinmapType", MapType.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapuse_page_based_priorities", UsePageBasedPriorities.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapminimum_priority", MinimumPriority.Text.Trim());
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapshow_hidden", ShowHidden.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapshow_disabled", ShowDisabled.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapshow_links", ShowLinks.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapshow_results", ShowResults.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapexpand_to_current_page", ExpandToCurrentPage.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapsiteMapRoot", SiteMapRoot.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMaplimit_based_on_site_settings", LimitBasedOnSiteSettings.SelectedValue);
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapimage_path", ImagePath.Text.Trim());
					obj_modules.UpdateModuleSetting(ModuleId, "doneinSiteMapimage_extension", ImageFileExtension.SelectedValue);
					Response.Redirect(Globals.NavigateURL(), true);
				}
				catch (Exception ex)
				{
					Exceptions.ProcessModuleLoadException(this, ex);
				}
			}

		#endregion



		#region "Handle: Cancel Button (CancelButton)"

			private void CancelButton_Click(object sender, EventArgs e)
			{
				try
				{
					Response.Redirect(Globals.NavigateURL(), true);
				}
				catch (Exception ex)
				{
					Exceptions.ProcessModuleLoadException(this, ex);
				}
			}

		#endregion



		#region "Bind: Site Map Root Dropdown List (SiteMapRoot)"

			private void SiteMapRoot_Bind()
			{
				System.Collections.Generic.List<TabInfo> tabCollection = TabController.GetPortalTabs(PortalId, 0, true, true);
				TabInfo tabInfo = default(TabInfo);
				foreach (TabInfo tabInfoAttribute in tabCollection)
				{
					tabInfo = tabInfoAttribute;
					SiteMapRoot.Items.Add(new ListItem(tabInfo.TabName, tabInfo.TabID.ToString()));
				}

			}

		#endregion

	}
}