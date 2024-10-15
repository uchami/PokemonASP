using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonASP.Models
{
    public class BaseDeDatos
    {
        public static Entrenador Entrenador1;
        public static Entrenador Entrenador2;

        private static bool fuePrecargada = false;
        public static bool FuePrecargada()
        {
            return BaseDeDatos.fuePrecargada;
        }
        public static void PreCargarDB() {
            Pokemon pikachu = new Pokemon(30, TipoPokemon.agua, "Pikachu", 1, "https://i.pinimg.com/736x/dc/ab/b7/dcabb7fbb2f763d680d20a3d228cc6f9.jpg");
            Pokemon charizard = new Pokemon(15, TipoPokemon.fuego, "Charizard", 1, "https://oyster.ignimgs.com/mediawiki/apis.ign.com/pokemon-blue-version/9/95/Charizard.png");
            Pokemon blastois = new Pokemon(40, TipoPokemon.tierra, "Blastois", 3, "https://img.pokemondb.net/sprites/scarlet-violet/normal/blastoise.png");
            List<Pokemon> pokemonesDeUri = new List<Pokemon>();
            pokemonesDeUri.Add(charizard);
            pokemonesDeUri.Add(pikachu);
            pokemonesDeUri.Add(blastois);
            BaseDeDatos.Entrenador1 = new Entrenador(pokemonesDeUri, "Uri");

            Pokemon charmander = new Pokemon(5, TipoPokemon.agua, "Charmander", 5, "https://cdn-images-1.medium.com/max/424/1*Hxptm5gIRc3HyYXzw5nfpw.png");
            Pokemon miutu = new Pokemon(20, TipoPokemon.fuego, "Miutu", 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/150.png");
            List<Pokemon> pokemonesDeGianfranco = new List<Pokemon>();
            pokemonesDeGianfranco.Add(charmander);
            pokemonesDeGianfranco.Add(miutu);
            BaseDeDatos.Entrenador2 = new Entrenador(pokemonesDeGianfranco, "Gianfranco");
            BaseDeDatos.fuePrecargada = true;
        }

    }
}