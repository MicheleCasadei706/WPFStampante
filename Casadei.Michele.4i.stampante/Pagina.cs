using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casadei.Michele._4i.stampante
{
    public class Pagina
    {
        // Variabili private per i livelli di colore (ciano, magenta, giallo, nero)
        private int c;
        private int m;
        private int y;
        private int k;

        // Proprietà per l'accesso e la modifica del livello di colore ciano
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                // Assicura che il valore sia compreso tra 0 e MAX-1, altrimenti solleva un'eccezione
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito è' proibito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                c = value;
            }
        }

        // Proprietà per l'accesso e la modifica del livello di colore magenta
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito e' proibito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                m = value;
            }
        }

        // Proprietà per l'accesso e la modifica del livello di colore giallo
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito e' proibito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                y = value;
            }
        }

        // Proprietà per l'accesso e la modifica del livello di colore nero
        public int K
        {
            get
            {
                return k;
            }
            set
            {
                if (value >= MAX || value < 0)
                    throw new ArgumentOutOfRangeException($"Il valore inserito è' proibito \n (il valore deve essere compreso tra 0 e {MAX - 1})");
                k = value;
            }
        }

        // Costante che rappresenta il massimo valore consentito per i livelli di colore
        private const int MAX = 4;


        // Costruttore che inizializza la Pagina con valori specifici per i livelli di colore
        public Pagina(int c, int m, int y, int k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }

        // Costruttore predefinito che inizializza la Pagina con valori casuali per i livelli di colore
        public Pagina()
        {
            var r = new Random();

            C = r.Next(MAX);
            M = r.Next(MAX);
            Y = r.Next(MAX);
            K = r.Next(MAX);
        }
    }
}
