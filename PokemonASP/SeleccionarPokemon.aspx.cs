using PokemonASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokemonASP
{
    public partial class SeleccionarPokemon : System.Web.UI.Page
    {
        Entrenador Entrenador;
        int idxEntrenador;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!BaseDeDatos.FuePrecargada())
            {
                BaseDeDatos.PreCargarDB();
            }
            string entrenadorId = Request.QueryString["entrenadorId"];
            idxEntrenador = -1;
            try
            {
                idxEntrenador = Int32.Parse(entrenadorId);
            }
            catch (Exception ex)
            {
                myLabel.Text = "Error. Se esperaba ?entrenadorId=X en la URL";
            }

            if (idxEntrenador == 1)
            {
                Entrenador = BaseDeDatos.Entrenador1;
            }
            else if (idxEntrenador == 2)
            {
                Entrenador = BaseDeDatos.Entrenador2;
            }

            if (!IsPostBack)
            {                
                if(Entrenador != null)
                {
                    List<PokemonDTO> list = new List<PokemonDTO>();
                    for (int i = 0; i < Entrenador.GetPokemones().Count(); i++)
                    {
                        Pokemon poke = Entrenador.GetPokemones()[i];
                        PokemonDTO pokemonDTO = new PokemonDTO();
                        pokemonDTO.Detalle = poke.toString();
                        pokemonDTO.Nombre = poke.Nombre;
                        pokemonDTO.Indice = i;
                        list.Add(pokemonDTO);
                    }
                    ListaDePokemones.DataSource = list;

                    ListaDePokemones.DataBind();
                }
            }
        }

        public void ElegirPokemon(object sender, EventArgs e)
        {
            int indicePokemon = Int32.Parse(((Button)sender).CommandArgument);
            if(Entrenador.GetPokemones()[indicePokemon].VidaActual == 0)
            {
                ((Button)sender).Visible = false;
            } else
            {
                Entrenador.ElegirPokemon(indicePokemon);
                if (idxEntrenador == 1)
                {
                    Response.Redirect("~/SeleccionarPokemon.aspx?entrenadorId=2");
                }
                else
                {
                    Response.Redirect("~/ResultadoRound.aspx");
                }
            }
        }
    }
}