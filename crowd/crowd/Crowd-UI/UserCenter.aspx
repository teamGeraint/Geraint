<%@ Page Title="" Language="C#" MasterPageFile="~/Crowd.Master" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="Crowd_UI.UserCenter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/UserCenter.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="main">
        <div id="left">
            <div id="publish">
                <div id="head">
                    <asp:Image ID="headimage" runat="server"/>
                </div>
                <ul>
                    <li>
                        <span></span>
                    </li>
                    <li>
                        <span></span>
                    </li>
                    <li>
                        <span></span>
                    </li>
                    <li>
                        <span></span>
                    </li>
                </ul>
            </div>
            <div>
                
            </div>
        </div>
        <div id="right"></div>
   </div>
</asp:Content>
