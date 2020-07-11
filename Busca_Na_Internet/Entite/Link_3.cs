using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_Na_Internet.Entite
{
    class Link_3
    {
        public int T { get; set; }

        public Link_3()
        {

        }

        public Link_3(int t)
        {
            T = t;
        }

        public int PrimeiroLink()
        {
            return T * 4;
        }
       
    }
}
