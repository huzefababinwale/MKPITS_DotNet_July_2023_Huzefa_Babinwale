<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_Basics.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center">
            TOTAL ASSIGNMENTS</div>
        <p style="text-align: center">
            1.To Accept 3 Subject Marks and print <span lang="EN-US" style="font-size: 9.5pt; line-height: 107%; font-family: Consolas; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-fareast-theme-font: minor-fareast; mso-bidi-font-family: Consolas; color: black; mso-font-kerning: 0pt; mso-ansi-language: EN-US; mso-fareast-language: EN-IN; mso-bidi-language: HI; text-align: center;">total,per and grade </span>
        </p>
        <p style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="M1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; M2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; M3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate " />
        </p>
        <p style="text-align: center">
            Grade :&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="187px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Percentage&nbsp; :&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Enabled="False" Width="187px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total:&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <h1 class="auto-style1" style="text-align: center">EMPLOYEE TABLE</h1>
        <p style="text-align: center">
            <asp:Label ID="Label2" runat="server" Text="EMP NAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="BASIC SALARY"></asp:Label>
        </p>
    </form>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
