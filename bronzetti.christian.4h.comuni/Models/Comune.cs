using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bronzetti.christian._4h.comuni.Models
{
    class Comune
    {
        string _codiceCatastale;
        string _nome; public string Nome => _nome;
        
        public Comune (string codice, string comune)
        {
            (_codiceCatastale, _nome) = (codice, comune);
        }

        public override string ToString()
        {
            return _nome;
        }
    }
}
