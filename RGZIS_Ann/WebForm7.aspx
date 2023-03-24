<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="RGZIS_Ann.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
.button2{
    font-size:110%;
    font-family:'Arial';
    margin-left:2%;
}
.button{
    margin-top:5%;
    font-size:110%;
    font-family:'Arial';
}
</style>
<div style="background:#dddddd; width:70%; height:650px; margin-left:auto; margin-right:auto; text-align:center; margin-top:20px;">
<div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 150%;">Регистрация</h1>
</div>
<div style="margin-left:auto; margin-right:auto;">
     <center><p><text style="font-size: 100%; font-family: 'Arial';">Имя:</text>
    <asp:TextBox ID="TextBox1" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/>
    <p><text style="font-size: 100%; font-family: 'Arial';">Фамилия:</text>
    <asp:TextBox ID="TextBox2" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/>
         <p><text style="font-size: 100%; font-family: 'Arial';">Дата рождения:</text>
    <asp:TextBox ID="TextBox3" runat="server" textmode="Date" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/>
         <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Font-Names="Arial" Font-Size="Medium" Width="248px">
             <asp:ListItem>Мужской</asp:ListItem>
             <asp:ListItem>Женский</asp:ListItem>
         </asp:RadioButtonList>
         <br/>
    <center><p><text style="font-size: 100%; font-family: 'Arial';">Логин:</text>
    <asp:TextBox ID="TextBox4" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/><br/>
    <p><text style="font-size: 100%; font-family: 'Arial';">Пароль:</text>
    <asp:TextBox ID="TextBox5" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px" TextMode="Password"></asp:TextBox></p><br/></center><br/>
    <center><asp:Button ID="Button1" runat="server" Text="Зарегистрироваться" BackColor="#CC3300" Font-Size="Medium" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
</div>
</div>
</asp:Content>
