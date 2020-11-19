<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="OnlineExam.ResultPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       body{
            background-image: url("images/1.jpeg");
            background-size: cover;
        }

     </style>
</head>
<body >
    <form id="form1" runat="server">
        <center>
        <div >
            <br />
            <br /><br /><br /><br /><br /><br /><br />
            <asp:Label ID="Label1" runat="server" OnDataBinding="Page_Load" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
        <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="LOGOUT" />
        </div>
            </center>
        
    </form>
</body>
</html>
