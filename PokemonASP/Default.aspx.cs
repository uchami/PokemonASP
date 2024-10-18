using PokemonASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokemonASP
{
    //Uriel estuvo aqui!
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDeDatos.PreCargarDB();
        }
        public void NavegarASelecccionDePokemon(object sender, EventArgs e)
        {
            Response.Redirect("~/SeleccionarPokemon.aspx?entrenadorId=1");
        }
    }
}