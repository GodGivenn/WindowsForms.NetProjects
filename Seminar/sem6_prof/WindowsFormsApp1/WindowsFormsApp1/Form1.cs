using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
  
    public partial class Form1 : Form
    {
        Magazie obmag;
        public Form1()
        {
            InitializeComponent();
            obmag= new Magazie() { DenMag="CSIE" };
            obmag.Ev_Actualizare+=Obmag_Ev_Actualizare;

        }

        private void Obmag_Ev_Actualizare(object sender, EventArgs e)
        {
            Mag_Ev_Args evM = e as Mag_Ev_Args;
            Magazie ob = sender as Magazie;
            gv.Rows.Clear();
            for(int i=0;i<ob.nrMat;i++)
            {
                gv.Rows.Add(ob[i].Cod.ToString(), ob[i].Denumire);
                gv.Rows[i].HeaderCell.Value=(i+1).ToString();
            }
            gv.Rows[evM.index].Selected=true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TbMag.Text+=obmag.DenMag;
            TbMag.Size=new Size(this.Size.Width, this.Size.Height);
            this.ResizeRedraw=true;
        }

        //Aduaga
        private void button2_Click(object sender, EventArgs e)
        {
            Material nou = new Material { Cod=int.Parse(t1.Text), Denumire=t2.Text };
            obmag.Adauga(nou);
            //t1.Text="0";
            //t2.Text=string.Empty;
            //t1.Focus();
            //t1.SelectAll();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            TbMag.Size=new Size(this.Size.Width, this.Size.Height);
        }

        private void gv_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Schimbare element!");
            //DataGridView obgv = sender as DataGridView;
            //gv.CurrentRow.Index
            //if(gv.CurrentRow.Index != -1) {
                //t1.Text = gv.SelectedRows[0].Cells[0].Value.ToString();
                t1.Text = gv.Rows[gv.CurrentRow.Index].Cells[0].Value.ToString();
                t2.Text = gv.Rows[gv.CurrentRow.Index].Cells[1].Value.ToString();

            //}

        }

        //Modifica
        private void button3_Click(object sender, EventArgs e)
        {
            Material nou = new Material { Cod=int.Parse(t1.Text), Denumire=t2.Text };
            obmag[gv.CurrentRow.Index] = nou;
            //ca pe equals intra daca nu sunt egale, iar aici sunt cred?
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fgr = new Form2();
            fgr.ShowDialog();
        }

        //Sterge - curs
    }
}
