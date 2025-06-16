using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excabs
{
    interface IMasura
    {
        int Perimetru
        {  get; }
        int Get_Aria();
    }

    abstract class Figura : IMasura
    {
        protected int latura;
        public Figura(int l) {  latura = l; }
        protected abstract int calcul_a();
        protected abstract int calcul_p();
        public int Perimetru => calcul_p();
        public int Get_Aria()   {   return calcul_a();   }
        public override string ToString() => $"Perimetru {Perimetru}  Aria {Get_Aria()}";
        public void Salut() {; }
    }

    class Patrat : Figura
    {
        public Patrat(int l) : base(l) { }

        protected override int calcul_a() => latura*latura;
        protected override int calcul_p() { return 4 * latura; }
    }
    class Dreptunghi : Figura
    {
        int latimea;
        public Dreptunghi(int l, int lat) : base(l) { latimea = lat; }
        protected override int calcul_a() => latura * latimea;
        protected override int calcul_p() { return 2 * latura + 2* latimea; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMasura fg1 = new Patrat(2), fg2 = new Dreptunghi(3, 4);
            Console.WriteLine("Aria P:" + fg1.Get_Aria());
            Console.WriteLine("Aria D:" + fg2.Get_Aria());
            Console.WriteLine(fg1.ToString());
            Console.WriteLine(fg2.ToString());
        }
    }
}
