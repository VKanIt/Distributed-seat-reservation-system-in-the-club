<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="RGZIS_Ann.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
.label{
    margin-right:30px;
    margin-left:5px;
    font-size: 120%;
    font-family: 'Arial';
}
.button{
    font-size: 110%;
    font-family: 'Arial';
}
.text{
    font-size: 100%; 
    font-family: 'Arial';
}
.h1 {
    line-height:130px;   
    margin-bottom:10px; 
    font-family: 'Arial';
    font-size:180%;
    }
</style>
<div style="background:#dddddd; width:80%; height:700px; margin-left:auto; margin-right:auto;">
    <div><center>
        <asp:Label ID="Label5" runat="server" Text="" CssClass="h1"></asp:Label></center>
    </div>
    <div style="margin-top:50px; margin-left:20%;">
        <text style="font-size: 120%; font-family: 'Arial';">Дата проведения:</text>
        <asp:Label ID="Label1" runat="server" Text="" CssClass="label"></asp:Label>
        <text style="font-size: 120%; font-family: 'Arial';">Время начала:</text>
        <asp:Label ID="Label2" runat="server" Text="" CssClass="label"></asp:Label>
        <text style="font-size: 120%; font-family: 'Arial';">Ограничения по возрасту:</text>
        <asp:Label ID="Label4" runat="server" Text="" CssClass="label"></asp:Label>
    </div><br/><br/>
    <div style="margin-left:20%;">
        <h2 style="font-size: 120%; font-family: 'Arial';">Описание</h2><br/>
        <p style="font-size: 100%; font-family: 'Arial';">Твоя первая вечеринка 2021 года<br/>

Для всех выживших в 2020-ом!<br/>

Ударно и громко проводим этот непростой год и встречаем новый.<br/>

Устраивать адовые пляски на костях 2020-го будут:<br/>

TO HAVE BALLS<br/>

ПИРОКИНЕЗ<br/>

OVERMINDS<br/>

ZARTIER<br/>
        </p><br/>
    </div>
    
    <div>
        <br/>
    <center><asp:Button ID="Button1" runat="server" Text="Забронировать" BackColor="#CC3300" BorderStyle="Double" Height="48px" Width="263px" ForeColor="White" CssClass="button" OnClick="Button1_Click"/></center>
    <br/>
    </div>
</div>
</asp:Content>
