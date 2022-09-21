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

        //Skriv en konstruktor till bilklassen som inte tar några parametrar.
        //Skriv en till konstruktor som tar en parameter för varje property som klassen har.
        //Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

        //Skriv en metod till bilklassen med namnet HalfPrice.
        //När den anropas ska priset på bilen sänkas till hälften.

        //Konstruktor utan parametrar

        public Car()
        {
            Console.WriteLine("New car");
        }

        //Konstruktor med parametrar
        public Car(string Make, int PriceOne, string Color)
        {
            _price = PriceOne;
            Console.WriteLine($"{Make}, {PriceOne}, {Color}");
        }


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

        public int HalfPrice()
        {
            Price /= 2;
            return Price;
        }

    }
}
