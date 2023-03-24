<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="RGZIS_Ann.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
.button2{
    font-size:110%;
    font-family:'Arial';
    margin-left:2%;
}
</style>
<div style="background:#dddddd; width:80%; height:900px; margin-left:auto; margin-right:auto; text-align:center; margin-top:20px;">
<div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 120%;">Личные данные</h1>
</div>
<div>
    <center><p><text style="font-size: 100%; font-family: 'Arial';">Имя:</text>
    <asp:Label ID="Label2" runat="server" Text="" CssClass="button2"/></p><br/>
    <p><text style="font-size: 100%; font-family: 'Arial';">Фамилия:</text>
    <asp:Label ID="Label1" runat="server" Text="" CssClass="button2"/></p><br/>
         <p><text style="font-size: 100%; font-family: 'Arial';">Дата рождения:</text>
    <asp:Label ID="Label3" runat="server" Text="" CssClass="button2"/></p><br/></center>
</div>
<div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 120%;">Забронированные билеты</h1>
</div>
<br/>
<div>
    <center><asp:GridView ID="GridView1" runat="server" Height="196px" Width="596px" BackColor="White" BorderColor="#990813" BorderStyle="Groove" OnRowCommand="GridView1_RowCommand">
        <HeaderStyle Font-Names="Arial" Font-Size="Medium" HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle Font-Names="Arial" Font-Size="Medium" HorizontalAlign="Center" VerticalAlign="Middle" />
        <Columns>
        <asp:buttonfield buttontype="button" commandname="delet" text="Удалить" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" FooterStyle-BorderStyle="Double" FooterStyle-BackColor="#CC3300" FooterStyle-ForeColor="White" />
            </Columns>
            </asp:GridView></center>
</div>
    <br/><br/>
    <div style="text-align:center;">
    <h1 style="line-height:100px; font-family: 'Arial'; font-size: 120%;">Оплата брони</h1>
</div>
<br/>
    <center><p><text style="font-size: 100%; font-family: 'Arial';">Номера брони:</text>
    <asp:TextBox ID="TextBox4" runat="server" Width="215px"  Font-Names="Arial" Font-Size="Medium" Height="20px"></asp:TextBox></p><br/><br/></center>
    <div>
        <center><asp:Button ID="Button1" runat="server" Text="Оплатить бронь" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
    </div>
</div>
</asp:Content>
