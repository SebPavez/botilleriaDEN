<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Botilleria.Login" %>


<!DOCTYPE HTML>

<html>
	<head>
		<title>Login</title>

        <%--MasterCode Head--%>
        

		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="description" content="" />
		<meta name="keywords" content="" />
		<link href='http://fonts.googleapis.com/css?family=Oxygen:400,300,700' rel='stylesheet' type='text/css'>
		<!--[if lte IE 8]><script src="js/html5shiv.js"></script><![endif]-->
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
		<script src="js/skel.min.js"></script>
		<script src="js/skel-panels.min.js"></script>
		<script src="js/init.js"></script>
		<noscript>
			<link rel="stylesheet" href="css/skel-noscript.css" />
			<link rel="stylesheet" href="css/style.css" />
		</noscript>
		<!--[if lte IE 8]><link rel="stylesheet" href="css/ie/v8.css" /><![endif]-->
		<!--[if lte IE 9]><link rel="stylesheet" href="css/ie/v9.css" /><![endif]-->
	    <style type="text/css">
            .container
            {
                text-align: center;
            }
        </style>
	</head>
	<body class="homepage">

    
       

	    <form id="form1" runat="server">

    
       

	<!-- Header -->
		<div id="header">
			<div class="container">
					
				<!-- Logo -->
					<div id="logo">
						<h1><a href="#">Bienvenido</a></h1>
						<span>desde aqui puede iniciar sesion</span>
					</div>
				
				

			</div>
		</div>
	<!-- Header -->
			
	<!-- Main -->
		<div id="mainLogin">
			<div class="container">
				&nbsp;<br />
                <br />
&nbsp;<asp:Login ID="Login1" runat="server" BackColor="#090909" BorderColor="#090909" 
                    BorderPadding="0" BorderStyle="None" BorderWidth="0px" Font-Names="Calibri" 
                    Font-Size="X-Large" ForeColor="White" 
                    style="text-align: left; margin-left: 372px" Font-Overline="False" 
                    Height="440px" onauthenticate="Login1_Authenticate1">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                        BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#090909" Font-Bold="True" Font-Size="0.9em" 
                        ForeColor="White" />
                </asp:Login>
				<header> 
                
                <br />
                
                <asp:Label ID="lblSalida" runat="server" ForeColor="White" 
                    style="text-align: center"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Generar usuario y Admin para testing" />
					
                    
				</header>
			
			</div>
		</div>
       
	    </form>
       
	</body>
</html>