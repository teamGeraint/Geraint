<%@ Page Title="" Language="C#" MasterPageFile="~/Crowd.Master" AutoEventWireup="true" CodeBehind="Interest.aspx.cs" Inherits="Crowd.web.interest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <meta http-equiv="Content-Type" content="text/html;charset=utf-8">
		<title>Interest</title>
		<meta name="keywords" content="jquery,div,css,javascript">
		<meta name="description" content="this is a .. page.">
		<meta name="author" content="cslg">

        <link href="Styles/Interest.css" rel="stylesheet" type="text/css" />
        <script src="Scripts/jquery-1.9.1.min.js" type="text/javascript"></script>
        <script src="Scripts/Interest.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div id="bd">
		<div id="top">
			<h2 class="txt">兴趣</h2>
		</div>
		<div id="mid">
			<div id="Div4">
				<ul id="Ul1">
					<li>
						<div class="good3">
							<a href="#"><img src="../images/Interest/1.jpg"></a>
							<span class="zi">电影</span>
							<div class="gou"><img id="Img1" src="../images/Interest/11.png"></div>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/2.jpg"></a>
							<span class="zi">玩具</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/3.png"></a>
							<span class="zi">ul</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/4.jpg"></a>
							<span class="zi">电影</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/5.jpg"></a>
							<span class="zi">水墨</span>
						</div>
					</li>
						<li>
						<div class="good3">
							<a href="#"><img src="../images/Interest/6.jpg"></a>
							<span class="zi">旅游</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/7.jpg"></a>
							<span class="zi">商务</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/8.png"></a>
							<span class="zi">聊天</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/9.jpg"></a>
							<span class="zi">人像</span>
						</div>
						<div class="good3">
							<a href="#"><img src="../images/Interest/10.jpg"></a>
							<span class="zi">动漫</span>
						</div>
					</li>
				</ul>
			</div>
		</div>
		<div id="Div5">
			<a class="txt" href="#">更多标签>></a>
		</div>
	</div>
</asp:Content>

