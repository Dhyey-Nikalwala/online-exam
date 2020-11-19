<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studreg.aspx.cs" Inherits="OnlineExam.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 382px;
        }
        body{
            background-image:url(images/2.jpg);
            background-size: cover;

        }
        h2{
             background-color:white;
            font-size:50px;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
     
            <h2>Student Registration Form</h2>
            
        <div>
           
                <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enter Student Name" Font-Size="Large" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Enter Student Email Address" Font-Size="Large" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Large"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Enter Password" Font-Size="Large" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Font-Size="Large"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Enter Sem" Font-Size="Large" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Large">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" Font-Size="Large" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
    </form>
    
</body>
</html>
