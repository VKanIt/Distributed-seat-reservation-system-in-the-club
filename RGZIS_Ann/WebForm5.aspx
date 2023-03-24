<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="RGZIS_Ann.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
.button{
    margin-top:5%;
    font-size:110%;
    font-family:'Arial';
}
</style>
<div style="background:#dddddd; width:70%; height:500px; margin-left:auto; margin-right:auto; text-align:center; margin-top:20px;">
<div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 150%;">Вход в личный кабинет</h1>
</div>
<div style="margin-left:auto; margin-right:auto;">
     <center><p><text style="font-size: 100%; font-family: 'Arial';">Логин:</text>
    <asp:TextBox ID="TextBox1" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/><br/>
    <p><text style="font-size: 100%; font-family: 'Arial';">Пароль:</text>
    <asp:TextBox ID="TextBox2" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px" TextMode="Password"></asp:TextBox></p><br/></center>
    <center><asp:Button ID="Button2" runat="server" Text="Вход" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button2_Click"/></center>
    <center><asp:Button ID="Button1" runat="server" Text="Регистрация" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
    <br/>
</div>

</div>
</asp:Content>
