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
                       <input type="button" id="btnnext" class="loginbtn" name="name" value="下一步" />
                   </div>   
           </div>
           <div id="mainb">
			<div id="mpadding">
				<div id="mbh1"><a id="mbha" href="#">基本资料</a></div>
				<div id="userhead">
					<img id="headimg" src="../images/userInfo/1.jpg" style="width:80px;height:80px;"/>
					<div class="uh2">
						<a id="lblname"  class="lbl" href="#">昵称: </a>
						
                        <asp:TextBox ID="txtname" class="inp" runat="server" text="" ></asp:TextBox>

					</div>
					<div class="uh2">
					<a class="example" href="#">事例：沾血的小黄瓜</a>
                        
					</div>
				</div>

				<div class="divc">
					<a id="lblsex" class="lbl" href="#">性别:</a>
					<input id="txtsex" class="inp" type="text"></input>
					<div class="uh1">
						<a class="example" href="#">事例：男</a> 
					</div>
				
				</div>
				<div class="divc">
					<a id="lblbir" class="lbl" href="#">生日:</a>
					<input id="txtbir" class="inp" type="text"></input>
					<div class="uh1">
							<a class="example" href="#">事例：1991-01-01</a>  
					</div>
				
				</div>
				<div class="divc">
					<a id="lblgschool" class="lbl" href="#">高中:</a>
					<input id="txgschool" class="inp" type="text"></input>
						<div class="uh1">
							<a class="example" href="#">事例：启中学动</a> 
						</div>
					
				</div>
				<div class="divc">
					<a id="lbldschool" class="lbl" href="#">大学:</a>
					<input id="txtdschool" class="inp" type="text"></input>
					<div class="uh1">
						<a class="example" href="#">事例：清华大学</a> 
					</div>
					
				</div>
				<div class="divc">
					<a id="lbldes" class="lbl" href="#">个人说明:</a>
					<input id="txtdes" class="inp" type="text"></input>
					<div class="uh1">
						<a class="example" href="#">事例：这个人很懒，什么都没留下</a> 
					</div>
					
				</div>

				<div class="divc">
					<a id="lblloc" class="lbl" href="#">所在地:</a>
					<input id="txtloc" class="inp" type="text"></input>
					<div class="uh1">
						<a class="example" href="#">事例：苏州</a> 
					</div>
					
				</div>

				<div class="divc">
					<a id="lblpro" class="lbl" href="#">职业:</a>
					<input id="txtpro" class="inp" type="text"></input>
					<div class="uh1">
						<a class="example" href="#">事例：程序员</a> 
					</div>
					
				</div>

				<div class="divc">
                    <asp:Button ID="btnsave" class="btns" Text="注 册" runat="server" 
                                        />

                    <asp:Button ID="btnnotsav" class="btns" Text="取 消" runat="server" 
                                        />
					
				</div>
				
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