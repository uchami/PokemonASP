using PokemonASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokemonASP
{
    public partial class CrearPokemonFormulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            
        }

        public void TipoPokemonCambio(object sender, EventArgs e)
        {
        }
        
        public void CrearPokemon(object sender, EventArgs e)
        {
            Int32.TryParse(txtAtaqueBase.Text, out int ataqueBase);
            string valorElegidoEnElSelector = selectorTipoPokemon.SelectedValue;
            TipoPokemon.TryParse(valorElegidoEnElSelector, out TipoPokemon tipoPokemonElegido);
            Int32.TryParse(txtNivel.Text, out int nivel);
            string nombre = txtNombre.Text; 
            string imagen = txtImagen.Text;

            Pokemon pokemoncito = new Pokemon(ataqueBase, tipoPokemonElegido, nombre, nivel, imagen);
            if (datosEstanCompletos(ataqueBase, nombre, imagen, nivel) == true)
            {
                BaseDeDatos.Pokemones.Add(pokemoncito);
            } else
            {
                //HACER ALGO, avisarle al usuario
                lblError.Visible = true;
            }
        }

        public bool datosEstanCompletos(int ataqueBase, string nombre, string imagen, int nivel)
        {
            if(ataqueBase == 0 || nombre == "" || imagen == "" || nivel == 0)
            { 
                return false; 
            } else { 
                return true; 
            }
        }
    }
}