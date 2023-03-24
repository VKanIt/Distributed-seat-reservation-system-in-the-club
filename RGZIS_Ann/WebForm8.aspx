<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="RGZIS_Ann.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <style>
    .h {
    font-size: 200%; 
    font-family: 'Arial';
    margin-bottom:2%;
    line-height:60px;
  }
    .button{
    margin-top:5%;
    font-size:110%;
    font-family:'Arial';
}
</style>
    <div>
        <br/><br/><br/>
    <center><h3 class="h">Операция выполнена успешна!</h3></center>
        <br/><br/><br/>
        <center><asp:Button ID="Button2" runat="server" Text="Вернуться на главную" BackColor="#CC3300" Font-Size="Medium" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button2_Click"/>
    </center><br/><br/>
        <center><asp:Button ID="Button1" runat="server" Text="Оплатить бронь" BackColor="#CC3300" Font-Size="Medium" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
        <br/><br/>
    </div>
</asp:Content>
