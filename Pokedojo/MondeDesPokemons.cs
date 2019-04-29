using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedojo
{
    class MondeDesPokemons
    {
        //Attribut(s)
        List<Pokemon> _listePokemons; //Notre liste des 151 pokemons
        
        //Accesseur
        public List<Pokemon> ListePokemons
        {
            get;
            set;
        }

        //Constructeur
        public MondeDesPokemons(List<Pokemon> listePokemons)
        {
            _listePokemons = listePokemons;
        }
        //Surdéfinition
        public MondeDesPokemons() : this(new List<Pokemon>())
        {
        }

        //Fonction pour ajouter les pokemons dans _listePokemons du MondeDesPokemons 
        //A utiliser dans le Program main dans la boucle de lecture du fichier.csv pour referencer tous les pokemons
        public void ReferencerPokemon(Pokemon pokemon)
        {
            _listePokemons.Add(pokemon);
        }
    }
}
