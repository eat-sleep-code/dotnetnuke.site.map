<%@ control language="C#" autoeventwireup="True" codebehind="base.ascx.cs" inherits="DONEIN_NET.Site_Map.Base" %>
<%@ register tagprefix="telerik" namespace="Telerik.Web.UI" assembly="Telerik.Web.UI" %>

<div class="donein-site-map dnnClear">
	<asp:panel runat="server" id="controlsPanel" visible="true">
		<asp:hyperlink runat="server" id="ExpandSiteMapLink" />
		<asp:label runat="server" id="Divider" cssclass="divider" />
		<asp:hyperlink runat="server" id="CollapseSiteMapLink" />
		<br />
		<br />
	</asp:panel>
	<telerik:radtreeview runat="server" id="SiteMapTreeview" />
	<asp:literal runat="server" id="SiteMapScript" />
</div>
