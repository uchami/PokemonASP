using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.WebRequestMethods;

namespace PokemonASP.Models
{
    public class Pokemon
    {
        public int AtaqueBase { get; set; }
        public TipoPokemon Tipo { get; set; }
        public int Nivel { get; set; }
        public string Nombre { get; set; }
        public int VidaActual { get; set; }
        public string ImageURL {  get; set; }


        public int VidaTotal()
        {
            return (Nivel * 100);
        }

        public void SubirDeNivel()
        {
            Nivel += 1;
        }

        public TipoPokemon getTipo()
        {
            return Tipo;
        }

        public Pokemon(int ataqueBase, TipoPokemon tipo, string nombre, int nivel)
        {
            AtaqueBase = ataqueBase;
            Tipo = tipo;
            Nombre = nombre;
            Nivel = nivel;
            VidaActual = VidaTotal();
            ImageURL = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/201.png";
        }
        public Pokemon(int ataqueBase, TipoPokemon tipo, string nombre, int nivel, string imagen)
        {
            AtaqueBase = ataqueBase;
            Tipo = tipo;
            Nombre = nombre;
            Nivel = nivel;
            VidaActual = VidaTotal();
            ImageURL = imagen;
        }
        //ataqueBase + nivel * random(10, 100) - buff por ser del mismo tipo( -100)
        public int calcularDanio(Pokemon oponente)
        {
            Random r = new Random();
            int buff = 0;
            if (oponente.getTipo() == Tipo)
            {
                buff = 10;
            }
            int ataqueSinBuff = AtaqueBase + Nivel * r.Next(1, 5);
            int danio = 0;
            if (ataqueSinBuff - buff > 0)
            {
                danio = ataqueSinBuff - buff;
            }
            return danio;
        }

        public int getVidaActual()
        {
            return VidaActual;
        }
        public void bajarVida(int danio)
        {
            if (danio >= VidaActual)
            {
                VidaActual = 0;
            }
            else
            {
                VidaActual -= danio;
            }
        }
        public string toString()
        {
            return Nombre + ": Nivel: " + Nivel + ", AtaqueBase: " + AtaqueBase + ", Vida: " + VidaActual + "/" + VidaTotal() + ", Tipo:" + Tipo;
        }

    }
}