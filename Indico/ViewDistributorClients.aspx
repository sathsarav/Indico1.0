﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Indico.Master" AutoEventWireup="true"
    CodeBehind="ViewDistributorClients.aspx.cs" Inherits="Indico.ViewDistributorClients" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="iContentPlaceHolder" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <!-- Page -->
    <div class="page">
        <!-- Page Header -->
        <div class="page-header">
            <div class="header-actions">
                <a id="btnAddClient" runat="server" class="btn btn-link iadd pull-right">New Client</a>
            </div>
            <h3>
                <asp:Literal ID="litHeaderText" runat="server"></asp:Literal></h3>
        </div>
        <!-- / -->
        <!-- Page Content -->
        <div class="page-content">
            <div class="row-fluid">
                <!-- Empty Content -->
                <div id="dvEmptyContent" runat="server" class="alert alert-info">
                    <h2>
                        <a href="javascript:ClientAddEdit(this, true, 'New MYOB Card File');" title="Add an MYOB Card File.">Add the first Client.</a>
                    </h2>
                    <p>
                        You can add as many Clients as you like.
                    </p>
                </div>
                <!-- / -->
                <%--Data Content--%>
                <div id="dvDataContent" runat="server">
                    <!-- Search Control -->
                    <div class="search-control clearfix">
                        <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnSearch" Visible="">
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="search-control-query" placeholder="Search"></asp:TextBox>
                            <asp:Button ID="btnSearch" runat="server" CssClass="search-control-button" Text="Search"
                                OnClick="btnSearch_Click" />
                        </asp:Panel>
                    </div>
                    <!-- / -->
                    <!-- Data Table -->
                    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Metro"
                        EnableEmbeddedSkins="true">
                    </telerik:RadAjaxLoadingPanel>
                    <%-- <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" DefaultLoadingPanelID="RadAjaxLoadingPanel1">
                        <AjaxSettings>
                            <telerik:AjaxSetting AjaxControlID="RadGridAgeGroup">
                                <UpdatedControls>
                                    <telerik:AjaxUpdatedControl ControlID="RadGridAgeGroup"></telerik:AjaxUpdatedControl>
                                </UpdatedControls>
                            </telerik:AjaxSetting>
                        </AjaxSettings>
                    </telerik:RadAjaxManager>--%>
                    <telerik:RadGrid ID="RadGridClient" runat="server" AllowPaging="true" AllowFilteringByColumn="true" ShowGroupPanel="false" OnPageSizeChanged="RadGridClient_PageSizeChanged"
                        PageSize="20" OnPageIndexChanged="RadGridClient_PageIndexChanged" ShowFooter="false" EnableHeaderContextMenu="true" EnableHeaderContextFilterMenu="true"
                        AutoGenerateColumns="false" OnItemDataBound="RadGridClient_ItemDataBound"
                        Skin="Metro" CssClass="RadGrid" AllowSorting="true" EnableEmbeddedSkins="true"
                        OnItemCommand="RadGridClient_ItemCommand"
                        OnSortCommand="RadGridClient_SortCommand">
                        <HeaderContextMenu OnItemClick="HeaderContextMenu_ItemCLick"></HeaderContextMenu>
                        <GroupingSettings CaseSensitive="false" />
                        <PagerStyle Mode="NextPrevNumericAndAdvanced"></PagerStyle>
                        <MasterTableView AllowFilteringByColumn="true">
                            <Columns>
                                <telerik:GridBoundColumn UniqueName="Name" SortExpression="Name" HeaderText="Name" AllowSorting="true" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" Groupable="false"
                                    FilterControlWidth="150px" DataField="Name">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="Distributor" DataField="objDistributor.Name" SortExpression="Distributor" HeaderText="Distributor" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" Groupable="false"
                                    FilterControlWidth="150px">
                                    <ItemTemplate>
                                        <asp:Literal ID="litDistributor" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn UniqueName="Description" SortExpression="Description" HeaderText="Description" AllowSorting="true" CurrentFilterFunction="Contains" Groupable="false"
                                    FilterControlWidth="150px" AutoPostBackOnFilter="true" DataField="Description">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="FOCPenalty" DataField="objDistributor.FOCPenalty" SortExpression="FOCPenalty" HeaderText="FOC Penalty" CurrentFilterFunction="Contains" AutoPostBackOnFilter="true" Groupable="false"
                                    FilterControlWidth="150px">
                                    <ItemTemplate>
                                        <asp:Literal ID="litFOCPenalty" runat="server"></asp:Literal>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn HeaderText="" AllowFiltering="false">
                                    <ItemTemplate>
                                        <div class="btn-group pull-right">
                                            <a class="btn btn-mini dropdown-toggle" data-toggle="dropdown" href="javascript:void(0);">
                                                <i class="icon-cog"></i><span class="caret"></span></a>
                                            <ul class="dropdown-menu pull-right">
                                                <li>
                                                    <asp:HyperLink ID="linkEdit" runat="server" CssClass="btn-link iedit" ToolTip="Edit MYOB Card File"><i class="icon-pencil"></i>Edit</asp:HyperLink></li>
                                                <li>
                                                    <asp:HyperLink ID="linkDelete" runat="server" CssClass="btn-link idelete" ToolTip="Delete MYOB Card File"><i class="icon-trash"></i>Delete</asp:HyperLink>
                                                </li>
                                            </ul>
                                        </div>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                        </MasterTableView>
                        <ClientSettings AllowDragToGroup="false">
                        </ClientSettings>
                        <GroupingSettings ShowUnGroupButton="false" />
                    </telerik:RadGrid>
                    <!-- / -->
                    <!-- No Search Result -->
                    <div id="dvNoSearchResult" runat="server" class="message search" visible="false">
                        <h4>Your search - <strong>
                            <asp:Label ID="lblSerchKey" runat="server"></asp:Label></strong> - did not match
                            any documents.</h4>
                    </div>
                </div>
                <!-- / -->
            </div>
            <!-- / -->
        </div>
        <!-- / -->
    </div>
    <!-- / -->
    <asp:HiddenField ID="hdnSelectedClientID" runat="server" Value="0" />
    <!-- Add / Edit Item -->
    <div id="requestAddEdit" class="modal fade" role="dialog" aria-hidden="true"
        keyboard="false" data-backdrop="static">
        <!-- Popup Header -->
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                ×</button>
            <h3>
                <asp:Label ID="lblPopupHeaderText" runat="server"></asp:Label></h3>
        </div>
        <!-- / -->
        <!-- Popup Content -->
        <div class="modal-body">
            <!-- Popup Validation -->
            <asp:ValidationSummary ID="validationSummary" runat="server" CssClass="alert alert-danger"
                DisplayMode="BulletList" HeaderText="<strong>Errors were encountered while trying to process the form below</strong>"></asp:ValidationSummary>
            <!-- / -->
            <fieldset>
                <div class="control-group">
                    <label class="control-label required">
                        Distributor</label>
                    <div class="controls">
                        <asp:DropDownList ID="ddlDistributor" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvDistributor" runat="server" ErrorMessage="Distributor is required." CssClass="error"
                            ControlToValidate="ddlDistributor" InitialValue="0" EnableClientScript="false"
                            Display="Dynamic">
                                            <img src="Content/img/icon_warning.png"  title="Distributor is required." alt="Distributor is required." />
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label required">
                        Name</label>
                    <div class="controls">
                        <asp:TextBox ID="txtClientName" runat="server" MaxLength="128"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvClientName" runat="server" CssClass="error"
                            ControlToValidate="txtClientName" Display="Dynamic" EnableClientScript="False"
                            ErrorMessage="Name is required">
                                <img src="Content/img/icon_warning.png" title="Name is required" alt="Name is required" />
                        </asp:RequiredFieldValidator>
                         <asp:CustomValidator ID="cvTxtName" runat="server" OnServerValidate="cvTxtName_ServerValidate" ErrorMessage="Name is already in use"
                            ControlToValidate="txtClientName" EnableClientScript="false">
                             <img src="Content/img/icon_warning.png"  title="Name is already in use" alt="Name is already in use" />
                        </asp:CustomValidator>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">
                        Description</label>
                    <div class="controls">
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="topic_d" MaxLength="255"
                            TextMode="MultiLine" Rows="2"></asp:TextBox>
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label">
                        FOC Penalty</label>
                    <div class="controls">
                        <asp:CheckBox ID="chkFocPenalty" runat="server"></asp:CheckBox>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="modal-footer">
            <button class="btn" data-dismiss="modal" aria-hidden="true">
                Close</button>
            <button id="btnSaveChanges" runat="server" class="btn btn-primary" onserverclick="btnSaveChanges_Click"
                data-loading-text="Saving..." type="submit" text="">
                Save Changes</button>
        </div>
    </div>
    <!-- Delete Item -->
    <div id="requestDelete" class="modal fade" role="dialog" aria-hidden="true"
        keyboard="false" data-backdrop="static">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                ×</button>
            <h3>Delete Client</h3>
        </div>
        <div class="modal-body">
            Are you sure you wish to delete this Client?
        </div>
        <div class="modal-footer">
            <button class="btn" data-dismiss="modal" aria-hidden="true">
                No</button>
            <button id="btnDelete" runat="server" class="btn btn-primary" onserverclick="btnDelete_Click"
                data-loading-text="Deleting..." type="submit">
                Yes</button>
        </div>
    </div>
    <!-- / -->
    <script type="text/javascript">
        var IsPageValid = ('<%=ViewState["IsPageValid"]%>' == 'True') ? true : false;
        var clientName = "<%=txtClientName.ClientID%>";
        var clientDescription = "<%=txtDescription.ClientID%>";
        var btnSaveChanges = "<%=btnSaveChanges.ClientID%>";
        var hdnSelectedID = "<%=hdnSelectedClientID.ClientID %>";
        var ddlDistributor = "<%=ddlDistributor.ClientID %>";
        var chkFocPenalty = "<%=chkFocPenalty.ClientID%>";
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.iadd').click(function () {
                //resetFieldsDefault('requestAddEdit');

                if ($('#' + ddlDistributor).is(':disabled') == false) {
                    $('#' + ddlDistributor).val('0');
                }

                $('#' + clientName)[0].value = '';
                $('#' + clientDescription)[0].value = '';
                $('#' + chkFocPenalty).attr('checked', false);
                ClientAddEdit(this, true);
            });

            $('.iedit').click(function () {
                fillText(this);
                ClientAddEdit(this, false);
            });

            $('.idelete').click(function () {
                $('#' + hdnSelectedID)[0].value = $(this).attr('qid');
                $('#requestDelete').modal('show');
            });

            if (!IsPageValid) {
                // window.setTimeout(function () {
                $('#requestAddEdit').modal('show');
                // }, 10);
            }

            function ClientAddEdit(o, n) {
                $('div.alert-danger, span.error').hide();
                $('#requestAddEdit div.modal-header h3 span')[0].innerHTML = (n ? 'Add Client' : 'Edit Client');
                $('#' + btnSaveChanges)[0].innerHTML = (n) ? 'Save Changes' : 'Update';
                $('#' + hdnSelectedID).val(n ? '0' : $(o).attr('qid'));
                $('#requestAddEdit').modal('show');
            }

            function fillText(o) {
                $('#' + clientName)[0].value = $(o).parents('tr').children('td')[0].innerHTML;
                $('#' + clientDescription)[0].value = (($(o).parents('tr').children('td')[2].innerHTML == '&nbsp;') ? '' : $(o).parents('tr').children('td')[2].innerHTML);
                $('#' + ddlDistributor).val($(o).attr('did'));                

                if ($(o).attr('foc') == 'Yes') {
                    $('#' + chkFocPenalty)[0].checked = true;
                }
                else {
                    $('#' + chkFocPenalty)[0].checked = false;
                }
            }
        });
    </script>
</asp:Content>
