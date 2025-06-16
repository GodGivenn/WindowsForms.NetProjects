using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarul_3
{
    class ExArgument0 : Exception
    {
        public ExArgument0() : base("ERR coeficient X2 ZERO!") { }
    }
    
    class ExDelta_negativa : Exception 
    {
        int d;
        public ExDelta_negativa(int fd) : base("ERR Delta < 0: " + fd + "!!") { d = fd; }
        public int Val_Delta => d;
    }
    
    public class Ecutatie2
    {
        int coefx2, coefx, t1, delta;
        float rad1, rad2;

        public Ecutatie2()
        {
            coefx2 = 1;
            coefx = t1 = 0;

        }

        public int C_Xp
        {
            get => coefx2;
            set 
            {
                if (value == 0) throw new ExArgument0();
                else coefx2 = value; 
            }
        }

        public int C_X
        {
            get => coefx;
            set => coefx = value;
        }

        public int Termen_L
        {
            get => t1; 
            set => t1 = value;
        }

        public double Rad1
        {
            get 
            {
                calculDelta();
                return (-coefx + Math.Sqrt((double)delta)) / (2F * coefx2);
            }
        }

        public double Rad2
        {
            get 
            {
                calculDelta();
                return (-coefx - Math.Sqrt((double)delta)) / (2F * coefx2);
            }
        }

        void calculDelta()
        {
            delta = coefx * coefx - 4 * coefx2 * t1;
            if (delta < 0) throw new ExDelta_negativa(delta);

        }

        public override string ToString() => (coefx2 == 1 ? string.Empty : coefx2.ToString()) + "X^2"
            + (coefx == 0 ? string.Empty : coefx.ToString("+#;-#") + "X") 
            + (t1 == 0 ? string.Empty : t1.ToString("+#;-#") + "=0");




    }
}
