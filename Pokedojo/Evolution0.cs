using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedojo
{
    class Evolution0 : Pokemon 
    {

        protected int _nbVictoiresConsecutives;
        protected bool _actif;
        protected string _etat; // Permet de gérer les états mort, vivant, brulé, noyé, empoisonné ...
        protected int _marqueurDeDegats;


        //CONSTRUCTEUR
        public Evolution0(string nom, int HP, int atk, string type, string faiblesse, int nbVictoiresConsecutives, bool actif, string etat, int marqueurDeDegats, int index)
        {
            _nom = nom;
            _HP = HP;
            _atk = atk;
            _type = type;
            _faiblesse = faiblesse;
            _nbVictoiresConsecutives = nbVictoiresConsecutives;
            _actif = actif;
            _etat = etat;
            _marqueurDeDegats = marqueurDeDegats;
            _index = index;
        }

        public Evolution0(string nom, int HP, int atk, string type, string faiblesse, int index): this (nom,HP,atk,type,faiblesse, 0, false, "vivant", 0, index)
        {
        }



        public virtual void RechercheEvolution()
        {
            //Rechercher l'évolution suivante du pokemon
            //A coder avec index2>index1>index0. 
            //A voir avec liste récupérée du CSV  
        }

        //A effectuer sur le pokemon vainqueur de l'affrontement
        public virtual bool testEvolution()  // si plus de 2 victoires consecutives, le pokemon évolue
        {
            if (_nbVictoiresConsecutives >= 2)
            {
                return true;
            }
            return false;
        }

    }
}
