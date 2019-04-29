using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedojo
{
    abstract class Pokemon
    {
        
        protected string _nom;
        protected int _HP;
        protected int _atk;
        protected string _type;
        protected string _faiblesse;
        protected int _index;

        public Pokemon()
        {

        }


        public virtual void RechercheEvolution()
        {
            //Rechercher l'évolution suivante du pokemon
            //A coder avec index2>index1>index0. 
            //A voir avec liste récupérée du CSV  
        }

        public virtual void Evolution(Evolution0 pok1, Evolution1 pok2)
        {
            
        }
    }
}
