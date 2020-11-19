<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="OnlineExam.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lemonchiffon;">
    <form id="form1" runat="server">
        <div>
            
            <h1>Hello 
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />

            </h1>
            <hr />
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <%#Eval("id")%>   : <%#Eval("name")%>
                            </td>
                         </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton1" runat="server" Text='<%#Eval("op1")%>'  GroupName="rdexam" ViewStateMode="Enabled"/>
                                    <asp:RadioButton ID="RadioButton2" runat="server" Text='<%#Eval("op2")%>' GroupName="rdexam" ViewStateMode="Enabled"/>
                                    <asp:RadioButton ID="RadioButton3" runat="server" Text='<%#Eval("op3")%>' GroupName="rdexam" ViewStateMode="Enabled"/>
                                    <asp:RadioButton ID="RadioButton4" runat="server" Text='<%#Eval("op4")%>' GroupName="rdexam" ViewStateMode="Enabled"/>
                                    <br />
                                    <asp:Label ID="labcorrected" runat="server" Text='<%#Eval("opc")%>' Visible="false"></asp:Label>

                                </td>
                            </tr> 
                        <tr>
                            <td>
                                <asp:Label ID="userselectedans" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                       
                    </table>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="Button1" runat="server" Text="Submit And View Correct Answers" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Marks Obtained" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Font-Strikeout="False" Visible="False"></asp:Label>
        </div>
       
        
       
    </form>
</body>
</html>
