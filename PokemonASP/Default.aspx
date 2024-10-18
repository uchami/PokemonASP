<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PokemonASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <span>Bienvenido a pokemon!</span> 
         <asp:Button ID="btnNavegar" Text="Que empiece el juego :)" runat="server" OnClick="NavegarASelecccionDePokemon" />
    </main>
</asp:Content>
