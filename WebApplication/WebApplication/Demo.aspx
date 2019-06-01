<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplication.Demo" %>
<%@ Register tagPrefix="TWebControl" src="~/jcflorezvControl.ascx" tagName="WebControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JuanCa JuanCa</title>
</head>
<body>
    <form id="form1" runat="server">
        <TWebControl:WebControl id="header" runat="server" MinValue="100"/>
	</form>
    <div style="color:#0000FF">
        Demo form
    </div>
</body>
</html>