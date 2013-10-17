<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Crowd.Web.admin.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		adminID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladminID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adminName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladminName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adminPwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladminPwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		creatAdmin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreatAdmin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		deleteAdmin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldeleteAdmin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ban
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblban" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		postInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpostInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		see
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsee" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		updateV
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupdateV" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




