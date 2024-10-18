using PokemonASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace PokemonASP
{
    public partial class ResultadoRound : System.Web.UI.Page
    {
        Entrenador e1;
        Entrenador e2;
        Pokemon poke1;
        Pokemon poke2;
        protected void Page_Load(object sender, EventArgs e)
        {
            e1 = BaseDeDatos.Entrenador1;
            e2 = BaseDeDatos.Entrenador2;
            
            if(e1 == null || e2 == null) { return; }
            if(e1.GetPokemonElegido() == null || e2.GetPokemonElegido()==null) { return; }
            poke1 = e1.GetPokemonElegido();
            poke2 = e2.GetPokemonElegido();
            LoadPokemonData();


        }
        public void LucharRound(object sender, EventArgs e)
        {   
            e1.CombatirRound(e2);
            lucharRound.Visible = false;
            LoadPokemonData();
            int pokemonesVivosEntrenador1 = e1.GetPokemonesVivos().Count();
            int pokemonesVivosEntrenador2 = e2.GetPokemonesVivos().Count();
            if ( pokemonesVivosEntrenador1 > 0 && pokemonesVivosEntrenador2 > 0 )
            {
                siguienteRound.Visible = true;
            } else
            {
                //Termino la batalla. 
                resultadoFinalBatalla.Visible = true;
                if (pokemonesVivosEntrenador1 == 0 && pokemonesVivosEntrenador2 == 0)
                {
                    //empate
                    resultadoFinalBatalla.Text = $"Todos los pokemones de {e1.getNombre()} han muerto, pero los de {e2.getNombre()} tambien. Nadie gana.";
                }
                else if (pokemonesVivosEntrenador1 == 0)
                {
                    //gano entrenador 2
                    resultadoFinalBatalla.Text = $"Victoria! Gano {e2.getNombre()}!";
                } else
                {
                    //gano entrenador 1
                    resultadoFinalBatalla.Text = $"Victoria! Gano {e1.getNombre()}!";
                }
            }
        }

        public void SiguienteRound(object sender, EventArgs e)
        {
            Response.Redirect("~/SeleccionarPokemon.aspx?entrenadorId=1");
        }

        public void LoadPokemonData()
        {
            nombrePokemon.Text = $"{poke1.Nombre} de {e1.getNombre()}";
            ataqueBase.Text = poke1.AtaqueBase.ToString();
            nivel.Text = poke1.Nivel.ToString();
            vida.Text = $"{poke1.VidaActual}/{poke1.VidaTotal()}";
            imagen.ImageUrl = poke1.ImageURL;
            if(poke1.VidaActual == 0)
            {
                imagen.ImageUrl = DeadImg();
            } else if(poke2.VidaActual == 0) { 
                trofeo.Visible = true;
            }

            nombrePokemon2.Text = $"{poke2.Nombre} de {e2.getNombre()}";
            ataqueBase2.Text = poke2.AtaqueBase.ToString();
            nivel2.Text = poke2.Nivel.ToString();
            vida2.Text = $"{poke2.VidaActual}/{poke2.VidaTotal()}";
            imagen2.ImageUrl = poke2.ImageURL;
            if (poke2.VidaActual == 0)
            {
                imagen2.ImageUrl = DeadImg();
            }
            else if(poke1.VidaActual == 0) {
                trofeo2.Visible = true;
            }
        }

        private string DeadImg() => "https://th.bing.com/th/id/R.fd7ade6ad2f59fc30d35c76c83826728?rik=WDHyQC0bl%2fx6xA&riu=http%3a%2f%2fcliparts.co%2fcliparts%2fRki%2fK4X%2fRkiK4XLcj.jpg&ehk=EdQMmDdiD8yNGVGTApn55R%2bHUa%2bLvLDHSgN0xwzF4ko%3d&risl=&pid=ImgRaw&r=0";
    }
}