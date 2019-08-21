<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="RoleManager.aspx.cs" Inherits="Session_4.RoleManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="row">
    <div class="col-md-8" col-md-offset="2">
        <table class="table table-bordered">
        <tr>
            <th>
                Enter the Role Details
            </th>
        </tr>
        <tr>
            <th>
                <asp:TextBox ID="txtRoleDetails" runat="server" CssClass="form-control"></asp:TextBox>
            </th>
        </tr>
             <tr>
                <th>
                    <asp:CheckBox runat="server" ID="chkEnabled" Text="Is Enabled?" />
                </th>
            </tr>
        <tr>
            <th>
                <asp:Button runat="server" Text="submit" Id="btnSave" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            </th>
        </tr>
            <tr>
                <th>
                    <div style="display:none" class="alert alert-info" id="lblmsg" runat="server"></div>
                </th>
            </tr>
           
    </table></div></div>
 
</asp:Content>
