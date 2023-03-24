<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="RGZIS_Ann.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Бронирование</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
.list{
        margin-left: 3%;
        margin-right: 6%;
        font-size:100%;
    }
.button{
    margin-top:5%;
    font-size:110%;
    font-family:'Arial';
}
.button2{
    margin-top:5%;
    font-size:110%;
    font-family:'Arial';
    margin-left:2%;
}
.h {
    font-size: 180%; 
    font-family: 'Arial';
    margin-bottom:2%;
    line-height:60px;
  }
</style>
<br/>
<div style="background:#dddddd; width:70%; height:900px; margin-left:auto; margin-right:auto; text-align:center;">
    <h1 style="line-height:80px; font-family: 'Arial'; font-size: 150%;">Бронирование</h1><br/>

    <h2 style="font-family: 'Arial'; font-size: 120%;">Выбор мероприятия</h2><br/>
    <text style="font-size: 110%; font-family: 'Arial'; margin-right:3%;">Выберите мероприятие:</text>

    <asp:DropDownList ID="DropDownList3" runat="server" Font-Names="Arial" Height="31px" Width="214px" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" CssClass="list"/>
    <br/><br/>
    <h2 style="line-height:60px; font-family: 'Arial'; font-size: 120%;">Выбор места</h2>

    
    <center><text style="font-size: 110%; font-family: 'Arial';">Выберите номер места:</text>
    <asp:DropDownList ID="DropDownList4" runat="server" Font-Names="Arial" Height="31px" Width="114px" CssClass="list" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"/>
        <text style="font-size: 110%; font-family: 'Arial';">Ряд:</text>
        <asp:Label ID="Label1" runat="server" Text="" CssClass="button2"></asp:Label></center>

    <br/><br/>
    <center><text style="font-size: 110%; font-family: 'Arial';">Стоимость:</text>
        <asp:Label ID="Label2" runat="server" Text="" CssClass="button2"></asp:Label></center>
    <br/><br/>
    <center><img style="height: 400px; width: 690px" src="schema1.png"/></center>
    <center><asp:Button ID="Button2" runat="server" Text="Подтвердить" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button2_Click"/></center>
    <br/>
</div>
</asp:Content>
