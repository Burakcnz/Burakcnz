using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje04_SayiBulmacaWithMethods
{
    internal class Rnd
    {
        public static int GetNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1,101);
        }

    }
}
