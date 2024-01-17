<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Series_of_number.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>
            <h1>GOOGLE</h1>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="Enter Number to print Series"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="font-size: medium"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" BackColor="#FFFFCC" ForeColor="Black" OnClick="Button1_Click" Text="Generate Series" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Enter Number To Display Pattern"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="font-size: medium"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Generate Pattern" />
        </p>
        <p style="text-align: left">
            <asp:Label ID="Label4" runat="server" Text="Pattern"></asp:Label>
        </p>
        <p style="text-align: left">
            &nbsp;</p>
        <h1>GOOGLE1</h1>
        Let us try to build some common used terms of Geometry<br />
        <br />
        <span class="auto-style1">1. Area Of Rectangle</span><br />
        <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Text="Enter Length"></asp:Label>
        <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br class="auto-style2" />
        <asp:Label ID="Label6" runat="server" CssClass="auto-style2" Text="Enter Breadth"></asp:Label>
        <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Claculate Area" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="..."></asp:Label>
        <br />
        <br />
        <span class="auto-style1">1. Area Of Circle &amp; Circum<br />
        </span>
        <br />
        <asp:Label ID="Label8" runat="server" CssClass="auto-style2" Text="Enter Radius Here"></asp:Label>
        <br class="auto-style2" />
        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Enter" Width="114px" />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="..."></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
