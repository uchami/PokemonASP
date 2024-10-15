<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarPokemon.aspx.cs" Inherits="PokemonASP.SeleccionarPokemon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblEntrenador" runat="server" />
        <asp:ListView ID="ListaDePokemones" runat="server">
            <ItemTemplate>
                <tr class="row-data">
                    <td>
                        <asp:Label ID="PokemonDetail" runat="server" Text='<%# Bind("Detalle") %>' />
                    </td>
                    <td>
                        <div class="btn-area">
                            <asp:Button runat="server" ID="boton" Text="Elegir pokemon" CommandArgument='<%#Eval("Indice")%>' OnClick="ElegirPokemon"/>
                        </div>
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                    <tr runat="server" style="">
                        <th runat="server">
                            Detalles pokemon
                        </th>
                        <th>
                        </th>
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:ListView>
        <asp:label id="myLabel" runat="server" />
    </form>
</body>
</html>
