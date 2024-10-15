<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultadoRound.aspx.cs" Inherits="PokemonASP.ResultadoRound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="roundPokemon">
            <div class="pokemonPresentacion">
                <div class="imagenPokemon">
                    <asp:Image runat="server" ID="imagen" />
                    <asp:Image ID="trofeo" runat="server" Visible="false" src="https://th.bing.com/th/id/OIP.5P9DYIcvXUcRI_k8oBs6TQHaJC?rs=1&pid=ImgDetMain" />
                </div>
                <div class="datosPokemon">
                    <div>
                        <asp:Label runat="server" ID="nombrePokemon" CssClass="nombrepokemon"/>
                    </div>
                    <div>
                        <span>Ataque base: </span>
                        <asp:Label runat="server" ID="ataqueBase"/>
                    </div>
                    <div>
                        <span>Nivel: </span>
                        <asp:Label runat="server" ID="nivel"/>
                    </div>
                    <div>
                        <span>Vida: </span>
                        <asp:Label runat="server" ID="vida"/>
                    </div>
                </div>
            </div>
            <img id="separador" src="https://th.bing.com/th/id/OIP.GXNJyePeGr2Q-xE9-JfbeQHaOL?rs=1&pid=ImgDetMain"/>
            <div class="pokemonPresentacion">
                <div class="imagenPokemon">
                    <asp:Image runat="server" ID="imagen2" />
                    <asp:Image ID="trofeo2" runat="server" Visible="false" src="https://th.bing.com/th/id/OIP.5P9DYIcvXUcRI_k8oBs6TQHaJC?rs=1&pid=ImgDetMain" />
                </div>
                <div class="datosPokemon">
                    <div>
                        <asp:Label runat="server" ID="nombrePokemon2" CssClass="nombrepokemon"/>
                    </div>
                    <div>
                        <span>Ataque base: </span>
                        <asp:Label runat="server" ID="ataqueBase2"/>
                    </div>
                    <div>
                        <span>Nivel: </span>
                        <asp:Label runat="server" ID="nivel2"/>
                    </div>
                    <div>
                        <span>Vida: </span>
                        <asp:Label runat="server" ID="vida2"/>
                    </div>
                </div>
            </div>
        </div>
        <asp:Button runat="server" CssClass="mainAction" ID="lucharRound" OnClick="LucharRound" Text="Que inicie el round!"/>
        <asp:Button runat="server" Visible="false" CssClass="mainAction" ID="siguienteRound" OnClick="SiguienteRound" Text="Siguiente round!"/>
        <asp:Label runat="server" Visible="false" CssClass="lblResultadoFinalBatalla" ID="resultadoFinalBatalla"/>
    </form>
</body>
</html>

<style>
    .lblResultadoFinalBatalla {
        color: forestgreen;
        font-size: 50px;
        font-family: sans-serif;
    }
    #roundPokemon {
        display: flex;
        width: 100%;
        justify-content: space-between;
    }
    #roundPokemon #separador {
        width: 20%;
        height: 400px;
    }
    .pokemonPresentacion {
        border: 1px solid black;
        border-radius:15px;
        background-color: grey;
        display:flex;
        width: 38%;
        height: 400px;
        flex-direction: column;
    }
    .imagenPokemon{
        display: flex;
        align-items: center;
        justify-content: center;
    }
    .imagenPokemon img {
        max-height: 200px;
    }
    .datosPokemon {
        margin: 20px;
        color: greenyellow;
        line-height: 30px;
        font-family: sans-serif;
    }
    .nombrepokemon {
        font-size: 20px;
        font-weight: 700;
        font-family: sans-serif;
    }
    .mainAction {
        width: 70%;
        padding: 20px;
        font-size: 20px;
        color: white;
        background-color: black;
        font-family: sans-serif;
        margin: 25px 15%;
        cursor: pointer;
        border-radius: 15px;
    }
</style>
