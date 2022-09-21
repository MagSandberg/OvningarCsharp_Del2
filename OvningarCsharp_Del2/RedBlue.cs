using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCsharp_Del2
{
    internal class RedBlue
    {
        //Skapa en en klass som har en property “red” och en property “blue”.
        //Båda ska vara en float och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara “sammankopplade”
        //på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex. sätter “blue” till 8.5
        //och sedan läser av “red” så ska den returnera 91.5

        public RedBlue()
        {
            
        }

        private float _red;
        public float Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
            }
        }

        private float _blue;
        public float Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
            }
        }


    }
}
