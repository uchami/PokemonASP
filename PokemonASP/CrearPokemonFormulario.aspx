<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearPokemonFormulario.aspx.cs" Inherits="PokemonASP.CrearPokemonFormulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Formulario para crear pokemones
        </div>
        <div>
            <label>Ataque base</label>
            <asp:TextBox runat="server" Placeholder="Ingrese ataque base" Type="number" ID="txtAtaqueBase"/>
        </div>
        <div>
            <asp:DropDownList id="selectorTipoPokemon"
                        OnSelectedIndexChanged="TipoPokemonCambio"
                        runat="server">

                <asp:ListItem Selected="True" Value="agua"> Agua </asp:ListItem>
                <asp:ListItem Value="fuego"> Fuego </asp:ListItem>
                <asp:ListItem Value="tierra"> Tierra </asp:ListItem>
                <asp:ListItem Value="electricidad"> Electricidad </asp:ListItem>

            </asp:DropDownList>
        </div>
        <div>

            <label>Nivel</label>
            <asp:TextBox runat="server" Placeholder="Ingrese nivel" Type="number" ID="txtNivel"/>
        </div>
        <div>
            <label>Nombre</label>
            <asp:TextBox runat="server" Placeholder="Ingrese nombre" Type="text" ID="txtNombre"/>
        </div>

        <div>
            <label>Imagen</label>
            <asp:TextBox runat="server" Placeholder="Ingrese imagen" Type="text" ID="txtImagen"/>
        </div>
        
        <div>
            <asp:Label runat="server" ID="lblError" Visible="false" Text="Algun dato es invalido, no seas gil"/>
            <asp:Button runat="server" Text="Crear pokemon" OnClick="CrearPokemon"/> 
        </div>

    </form>
</body>
</html>
