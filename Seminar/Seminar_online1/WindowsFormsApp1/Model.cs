using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Mag_Ev_Args:EventArgs
    {
        int k;
        public Mag_Ev_Args(int z) { k=z; }
        public int index => k;
    }
    public  class Material
    {
        public int Cod { get; set; }
        public string Denumire { get; set; }
        public int Val { get; set; }

        public override bool Equals(object obj)
        {
            Material ob= obj as Material;
            if (Cod!=ob.Cod) return false;
            if (Denumire!=ob.Denumire) return false;
            if (Val!=ob.Val) return false;
            return true;
        }
    }

    public class Magazie
    {
        List<Material> list_mat;
        public string DenMag { get; set; }
        
        public event EventHandler Ev_Actualizare;
        public string DenumireMag { get; set; }
        public int nrMat => list_mat.Count;
        
        public Magazie() 
        {
            list_mat = new List<Material>();
        }

        public void Adauga(Material mat)
        {
            list_mat.Add(mat);
            Ev_Actualizare?.Invoke(this, new Mag_Ev_Args(list_mat.Count-1));
        }

        public Material  this[int k] {

            get=>k<list_mat.Count ? list_mat[k] :throw new IndexOutOfRangeException() ;
            set 
            {
                if(k>=list_mat.Count)   throw new IndexOutOfRangeException();
                if (!list_mat[k].Equals(value)) 
                {
                    list_mat[k] = value;
                    Ev_Actualizare?.Invoke(this, new Mag_Ev_Args(k));
                }
            }
        }
    }
}
