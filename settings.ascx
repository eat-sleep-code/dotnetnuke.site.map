<%@ control language="C#" autoeventwireup="True" codebehind="settings.ascx.cs" inherits="DONEIN_NET.Site_Map.Settings" %>
<div class="dnnForm dnnClear">

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="TitleLabel" associatedcontrolid="Title" />
		<asp:textbox runat="server" id="Title" />
	</div>
	
	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ClickableTitleLabel" associatedcontrolid="ClickableTitle" />
		<asp:radiobuttonlist runat="server" id="ClickableTitle" repeatdirection="Horizontal" />
	</div>
	
	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="DefaultStateLabel" associatedcontrolid="DefaultState" />
		<asp:radiobuttonlist runat="server" id="DefaultState" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ControlVisibilityLabel" associatedcontrolid="ControlVisibility" />
		<asp:radiobuttonlist runat="server" id="ControlVisibility" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="MapTypeLabel" associatedcontrolid="MapType" />
		<asp:radiobuttonlist runat="server" id="MapType" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="UsePageBasedPrioritiesLabel" associatedcontrolid="UsePageBasedPriorities" />
		<asp:radiobuttonlist runat="server" id="UsePageBasedPriorities" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="MinimumPriorityLabel" associatedcontrolid="MinimumPriority" />
		<asp:textbox runat="server" id="MinimumPriority" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ShowHiddenLabel" associatedcontrolid="ShowHidden" />
		<asp:radiobuttonlist runat="server" id="ShowHidden" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ShowDisabledLabel" associatedcontrolid="ShowDisabled" />
		<asp:radiobuttonlist runat="server" id="ShowDisabled" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ShowLinksLabel" associatedcontrolid="ShowLinks" />
		<asp:radiobuttonlist runat="server" id="ShowLinks" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ShowResultsLabel" associatedcontrolid="ShowResults" />
		<asp:radiobuttonlist runat="server" id="ShowResults" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ExpandToCurrentPageLabel" associatedcontrolid="ExpandToCurrentPage" />
		<asp:radiobuttonlist runat="server" id="ExpandToCurrentPage" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="SiteMapRootLabel" associatedcontrolid="SiteMapRoot" />
		<asp:dropdownlist runat="server" id="SiteMapRoot" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="LimitBasedOnSiteSettingsLabel" associatedcontrolid="LimitBasedOnSiteSettings" />
		<asp:radiobuttonlist runat="server" id="LimitBasedOnSiteSettings" repeatdirection="Horizontal" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ImagePathLabel" associatedcontrolid="ImagePath" />
		<asp:textbox runat="server" id="ImagePath" />
	</div>

	<div class="dnnFormItem">
		<asp:label cssclass="dnnLabel" runat="server" id="ImageFileExtensionLabel" associatedcontrolid="ImageFileExtension" />
		<asp:radiobuttonlist runat="server" id="ImageFileExtension" repeatdirection="Horizontal" />
	</div>
	
	<ul class="dnnActions dnnClear">
		<li><asp:linkbutton runat="server" id="UpdateButton" cssclass="dnnPrimaryAction" /></li>
		<li><asp:linkbutton runat="server" id="CancelButton" cssclass="dnnSecondaryAction" /></li>
	</ul>

</div>
