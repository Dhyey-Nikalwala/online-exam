<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="onlineexam.aspx.cs" Inherits="OnlineExam.onlineexam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        h1 {
            background-color:white;
            font-size:100px;
        }
        .auto-style3 {
            width: 310px;
        }
        .auto-style6 {
            height: 54px;
        }
        .auto-style7 {
            height: 54px;
            width: 310px;
        }
        body{
            background-image: url("images/1.jpeg");
            background-size: cover;
        }
    </style>
</head>
<body >
    
    <form id="form1" runat="server">
        <div>
            
                <h1>Login Page</h1>
                <table style="width:70%;">
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Email"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Password"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Font-Size="Large"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Font-Size="Large" />
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Not Registered?" Font-Size="Large" ForeColor="White"></asp:Label>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" Font-Size="Large" />
            </td>
        </tr>
    </table>
           
        </div>
    </form>
    
</body>
</html>
