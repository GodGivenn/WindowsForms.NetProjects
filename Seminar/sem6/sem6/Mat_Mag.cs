using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace sem6
{
    public class Mag_Ev_Args: EventArgs
    {
        int k;
        public Mag_Ev_Args(int z) { k = z;}
        public int Index => k;
    }
    public class Material 
    {
        public string Denumire {  get; set; }
        public int Cod {  get; set; }
        public override bool Equals(object obj)
        {
            bool rez = true;
            Material ob = obj as Material;/*(Material)obj;*/
            if (Cod != ob.Cod)
                return false;
            if (Denumire != ob.Denumire)
                return false;
            return rez;
        }
    }
    //bogdan a fost aici
    public class Magazie
    {
        List<Material> list_mat;
        public string DenMag {  get; set; }
        public event EventHandler Ev_Actualizare;
        public int NrMat => list_mat.Count;
        public string DenumireMag { get; set; }
        public Magazie()
        {
            list_mat = new List<Material>();
        }
        public void adaugaMaterial(Material m)
        {
            list_mat.Add(m);
            Ev_Actualizare?.Invoke(this, new Mag_Ev_Args(list_mat.Count - 1));//adauga evenimentul ca sa actualizez (comunicare prin ev)
        }
        public Material this[int k] {

            get => k < list_mat.Count ? list_mat[k] : throw new IndexOutOfRangeException();
            set {
                if (k >= list_mat.Count)
                    throw new IndexOutOfRangeException();
                if (!list_mat[k].Equals(value)) {
                    list_mat[k] = value;
                    Ev_Actualizare?.Invoke(this, new Mag_Ev_Args(k));
                }


            }
        }
    }
}
