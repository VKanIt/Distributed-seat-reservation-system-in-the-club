<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="RGZIS_Ann.WebForm9" %>
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
<div style="background:#dddddd; width:70%; height:600px; margin-left:auto; margin-right:auto; text-align:center; margin-top:20px;">
<div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 130%;">Заполните реквизиты карты</h1>
</div>
    <div style="margin-left:auto; margin-right:auto;">
     <center><p><text style="font-size: 100%; font-family: 'Arial';">Фамилия и имя держателя:</text>
    <asp:TextBox ID="TextBox1" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/>
    <p><text style="font-size: 100%; font-family: 'Arial';">Номер карты:</text>
    <asp:TextBox ID="TextBox2" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/>
        <p><text style="font-size: 100%; font-family: 'Arial';">Срок действия карты:</text></p><br/></center>
    </div>
    <div>
        <asp:TextBox ID="TextBox3" runat="server" Width="108px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox>
        <text style="font-size: 100%; font-family: 'Arial';">/</text>
        <asp:TextBox ID="TextBox4" runat="server" Width="108px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox>
    </div>
    <br/>
    <div>
        <text style="font-size: 100%; font-family: 'Arial';">CVV2/CVC2:</text>
    <asp:TextBox ID="TextBox5" runat="server" Width="119px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox>
    </div><br/><br/>
    <div>
        <center><asp:Button ID="Button1" runat="server" Text="Оплатить" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
    </div>
</div>
</asp:Content>
