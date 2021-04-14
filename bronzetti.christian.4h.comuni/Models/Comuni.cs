using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bronzetti.christian._4h.comuni.Models
{
    class Comuni
    {
        public List<Comune> _elencoComuni = new List<Comune>();
        public Comuni(string path)
        {

            using(StreamReader sr = new StreamReader(path))
            {
                while(true)
                {
                    string letto = sr.ReadLine();
                    
                    if (letto == null)
                        break;

                    string[] sottoStringa = letto.Split(',');
                    _elencoComuni.Add(new Comune(sottoStringa[0], sottoStringa[1]));

                    
                };

                sr.Close();
            }

        }
    }
}
