using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedojo
{
    class Evolution1 : Evolution0
    {
        public Evolution1(string nom, int HP, int atk, string type, string faiblesse, int nbVictoiresConsecutives, bool actif, string etat, int marqueurDeDegats, int index) : base(nom, HP, atk, type, faiblesse, nbVictoiresConsecutives, actif, etat, marqueurDeDegats, index)
        {
            //Stats a modifier avec csv
        }

        public Evolution1(string nom, int HP, int atk, string type, string faiblesse, int index) : this(nom, HP, atk, type, faiblesse, 0, false, "vivant", 0, index)
        {
            //Stats a modifier avec csv
        }
    }
}
