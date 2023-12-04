using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casadei.Michele._4i.stampante
{
    public class Pagina
    {
        //4 attributi CMYB che, se usata per stampare, consuma i serbatoi della stampante
        public int B { get; set; }
        public int Y { get; set; }
        public int M { get; set; }
        public int C { get; set; }
        
        //un costruttore che accetta colori specifici al massimo di valore 3
        public Pagina(int c, int m, int y, int b)
        {
            if (c > 3 || m > 3 || y > 3 || b > 3)
                throw new ArgumentException("L'inchiostro è insufficiente");

            C = c;
            M = m;
            Y = y;
            B = b;
        }

        //un costruttore che crea una Pagina con colori random
        public Pagina()
        {
            var r = new Random();

            C = r.Next(4);
            M = r.Next(4);
            Y = r.Next(4);
            B = r.Next(4);
        }
    }
}
