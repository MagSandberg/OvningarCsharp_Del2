using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Console = System.Console;

namespace OvningarCsharp_Del2
{
    public class StepCounter
    {
        //.26
        //Skapa en klass som kan användas som stegräknare.
        //Den ska ha en property Steps som bara går att läsa;
        //en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
        //och en metod Reset() som nollställer räknaren.

        //Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.

        //Fields
        public int steps { get; private set; }

        //Methods
        public int Step()
        {
            steps ++;
            return steps;
        }

        public int Reset()
        {
            int steps = 0;
            return steps;
        }
        //Constructor
        public StepCounter()
        {

        }
    }
}
