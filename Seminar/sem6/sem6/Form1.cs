using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem6
{
    public partial class Form1 : Form
    {
        Magazie obMag;
        public Form1()
        {
            InitializeComponent();
            obMag = new Magazie() { DenMag = "CSIE" };
            obMag.Ev_Actualizare += ObMag_Ev_Actualizare;//in momentul cand adaug un material/modific se ridica evenimentul
        }

        private void ObMag_Ev_Actualizare(object sender, EventArgs e)
        {
            Mag_Ev_Args evM=e as Mag_Ev_Args;
            //aici sincronizez interfata, trb sa afisez
            Magazie ob=sender as Magazie;//pt ca sender e object
            Tabel.Rows.Clear();
            for (int i = 0; i < ob.NrMat; i++)
            {
               
                Tabel.Rows.Add(ob[i].Cod.ToString(), ob[i].Denumire);
                Tabel.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            Tabel.Rows[evM.Index].Selected = true;

        }

        private void Form1_Load(object sender, EventArgs e) {
            tbMag.Text += obMag.DenMag;
            tbMag.Size=new Size(this.Size.Width, this.Size.Height);
            this.ResizeRedraw = true;

        }

        private void Form1_Resize(object sender, EventArgs e) {
            tbMag.Size = new Size(this.Size.Width, this.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e) {
            Material nou = new Material() { Cod = int.Parse(tCod.Text),Denumire=tDen.Text };//parse pt ca codul e intreg si trb convertit(in textbox e sir de caractere)
            obMag.adaugaMaterial(nou);
            tCod.Text = "0";
            tDen.Text = string.Empty;
            tCod.Focus();
            tCod.SelectAll();

            
        }
    }
}
