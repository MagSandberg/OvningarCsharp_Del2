using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCsharp_Del2
{
    public struct CarStruct
    {
        public CarStruct(string make, int price, string color)
        {
            userMake = make;
            userPrice = price;
            userColor = color;
        }
        public string userMake { get; }
        public int userPrice { get; }
        public string userColor { get; }
    }
}
