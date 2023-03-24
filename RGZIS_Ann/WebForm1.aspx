<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RGZIS_Ann.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
.resdiv{
    height:80px; 
    width:700px;
    margin-top:50px;
    margin-left: auto;
    margin-right: auto;
    line-height: 80px;
    background: rgba(205, 213, 213, 0.84);
}
.button{
    margin-left:7%;
}
.label1 {
    font-size:170%;
    position:relative;
    top:15%;
}
.label2 {
    font-size:140%;
    position:relative;
    top:25%;
}
.label3 {
    font-size:180%;
    position:relative;
    top:100px;
}
.panel{
    text-align:center;
}
.button1{
    position:relative;
    font-size:110%;
    font-family:Arial;
    top:200px;
}
.title{
    line-height:300px;
    font-size:180%;
    font-family:Arial;
}
</style>
<div class="resdiv">
    <center>
    <text style="color:#000000; font-size: 110%; font-family: 'Arial'; margin-right:1%;">Дата мероприятия:</text>
    <asp:TextBox ID="TextBox1" runat="server" textmode="Date" Font-Names="Arial" Height="24px" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Найти" BackColor="#CC3300" BorderStyle="Double" Font-Names="Arial" Height="32px" Width="192px" ForeColor="White" Font-Size="Medium" OnClick="Button1_Click" CssClass="button"/>
    </center>
</div><br/>
<div><center>
    <asp:Table ID="Table1" runat="server" CellPadding="4" CellSpacing="50"></asp:Table></center>
</div>
    <div>
    <center>
    <asp:Panel ID="Panel1" runat="server" CssClass="panel"></asp:Panel></center></div>
</asp:Content>
