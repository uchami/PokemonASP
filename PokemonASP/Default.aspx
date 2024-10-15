<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PokemonASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         Bienvenido a pokemon! 
         <asp:Button ID="btnNavegar" Text="Que empiece el juego :)" runat="server" OnClick="NavegarASelecccionDePokemon" />
    </main>
    <a href="Default.aspx">Default.aspx</a>
</asp:Content>
