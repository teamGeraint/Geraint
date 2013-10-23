<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Crowd.web.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
       <meta http-equiv="Content-type" content="text/html;charset=utf-8">
       <title>Crowd-中国新兴社交网站</title>
       <meta name="keywords" content="jQuery,div,css,javascript">
       <meta name="description" content="This is a contact page.">
       <meta name="author" content="txd，jt，wxf，xc，jjj">
       <link rel="shortcut icon" href="images/index/crowdlogo.png"></link>
       <link rel="stylesheet" type="text/css" href="Styles/Index.css"></link>
       <script type="text/javascript"  src="Scripts/jquery-1.9.1.min.js"></script>
       <script type="text/javascript"  src="Scripts/Index.js"></script>
    <script type="text/javascript">
        

    
    </script>



</head>
<body>
    <form id="form1" runat="server">
	<div id="wapper">
       <div id="header">
           <span id="headerpic">
               <img id="headerpicmain" src="images/index/crowdlogo.png"/>
           </span>
           <div id="headertext">Crowd-中国新兴社交网站</div>
       </div>
       <div id="content">
           <div id="loginBlock">
                   <div class="loginFunc">
                       <div id="login" >登录</div>
                       <div id="register" class="sel">注册</div>
                   </div>
                   <div class="loginForm">
                           <div class="loginCrowd">
                           
                               <div class="InputLine">
                                  <span class="idPic"></span>
                                  <input id="loginidInput1" class="idInput" type="text" runat="server"/>
                                   <asp:Label ID="tipid" class="errortip" Text="" runat="server" />
                               </div>
                               <div id="regid" class="InputLine">
                                  <span class="idPic"></span>
                                  <input id="regidInput" class="idInput" type="text" runat="server"/>
                                   <asp:Label ID="tipregid" class="errortip" Text="" runat="server" />
                               </div>
                               <div class="InputLine">
                                  <span class="pwdPic"></span>
                                  <input id="loginpwdInput1" class="pwdInput" type="text" runat="server"/>
                                  <asp:Label ID="tippwd" class="errortip" Text="" runat="server" />
                               </div>
                               <div class="InputLine">
                                  <span class="pwdPic"></span>
                                  <input id="regpwdInput2" type="text" runat="server"/>
                                  <asp:Label ID="tippwd2" class="errortip" Text="" runat="server" />
                               </div>
                               <div class="InputLine">
                                  <span class="idPic"></span>
                                  <input id="regemailInput"  type="text" runat="server"/>
                                  <asp:Label ID="tipemail" class="errortip" Text="" runat="server" />
                               </div>
                               
                               
                               
                           </div>
                           
                   </div>
                   <div class="loginFormbtn">
                        <asp:Button ID="btnlogin" class="loginbtn" Text="登 录" runat="server" onclick="loginbtn_Click" />
                        <asp:Button ID="btnreg" class="loginbtn" Text="注 册" runat="server" onclick="regbtn_Click" />
                   </div>   
           </div>
         <%--  <div id="loginBlock1">
                   <div class="loginFunc">
                       <div class="login">登录</div>
                       <div class="register">注册</div>
                   </div>
                   <div class="loginForm">
                           <div class="loginCrowd">
                               <div class="idInputLine">
                                  <span class="idPic"></span>
                                  <input id="regidInput" class="idInput" type="text" runat="server"/>
                               </div>
                               <div class="pwdInputLine">
                                  <span class="pwdPic"></span>
                                  <input id="regpwdInput" class="pwdInput" type="text" runat="server"/>
                               </div>
                               <div class="pwdInputLine">
                                  <span class="pwdPic"></span>
                                  <input id="regpwdInput2" type="text" runat="server"/>
                               </div>
                               <div class="idInputLine">
                                  <span class="idPic"></span>
                                  <input id="regemailInput"  type="text" runat="server"/>
                               </div>
                               <div class="loginFormbtn">
                                     <asp:Button ID="btnreg" class="loginbtn" Text="注 册" runat="server" 
                                       onclick="regbtn_Click" />
                               </div>   
                           </div>
                   </div>
           </div>--%>

       </div>
	</div>
    </form>
</body>
</html>