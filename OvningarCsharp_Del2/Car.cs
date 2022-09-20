using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCsharp_Del2
{
    internal class Car
    {
        //.25
        //Skriv en ny klass som motsvarar en bil.
        //Den ska ha privata fields för modell, pris och färg.
        //Skapa publika properties för att hämta eller ändra värdet på varje field.
        private string _make;
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}
