using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casadei.Michele._4i.stampante
{
    public class Stampante
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public int Fogli { get; set; }

        public Stampante()
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }
        public int StatoInchiostro(string s)
        {
            switch (s)
            {
                case "cyan":
                    return C;

                case "magenta":
                    return M;

                case "yellow":
                    return Y;

                case "black":
                    return B;

            }
            return 0;
        }
        public void SostituisiciColore(string s)
        {
            switch (s)
            {
                case "cyan":
                    C = 100;
                    return;

                case "magenta":
                    M = 100;
                    return;

                case "yellow":
                    Y = 100;
                    return;

                case "black":
                    B = 100;
                    return;
            }

        }       
        public int StatoCarta()
        {
            return Fogli;
        }
        public void AggiungiCarta(int qta)
        {
            if (qta < 0) qta = 0;

            Fogli += qta;

            if (Fogli > 200) Fogli = 200;
        }

        public bool Stampa(Pagina p)
        {
            if (Fogli == 0) return false;

            if ((p.C >= C) || (p.M >= M) || (p.Y >= Y) || (p.B >= B)) return false;

            Fogli--;

            B -= p.B;
            Y -= p.Y;
            M -= p.M;
            C -= p.C;

            return true;
        }
    }
}