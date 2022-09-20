using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCsharp_Del2
{
    internal class StepCounter
    {
        //.26
        //Skapa en klass som kan användas som stegräknare.
        //Den ska ha en property Steps som bara går att läsa;
        //en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
        //och en metod Reset() som nollställer räknaren.

        //Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.
        
        private readonly int Steps;
        public int MySteps { get { return Steps; } }
        public int Step(int step)
        {
            step++;
            return step;
        }
        public int Reset(int Steps)
        {
            Steps = 0;
            return Steps;
        }

    }
}
