using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_numar
{
    public delegate void Del_Numar(object obs);
    public class CNumar
    {
        public event Del_Numar Ev_Modificare;
        int a;
        public CNumar() { a = 0; }
        public int Patrat => a* a;

        public int Element
        {
            get => a;
            set
            {
                if(a != value)
                {
                    a = value;
                    if (Ev_Modificare != null) Ev_Modificare(this);
                }
            }
        }
    }
}
