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
                gv.Rows.Add(ob[i].Cod.ToString(), ob[i].Denumire, ob[i].Val.ToString());
                gv.Rows[i].HeaderCell.Value=(i+1).ToString();
            }
            gv.Rows[evM.index].Selected=true;
            gv.CurrentCell = gv.Rows[evM.index].Cells[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TbMag.Text+=obmag.DenMag;
            TbMag.Size=new Size(this.Size.Width, this.Size.Height);
            this.ResizeRedraw=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            Material nou = new Material { Cod=int.Parse(t1.Text), Denumire=t2.Text, Val= int.Parse(t3.Text) };
            if(bt.Tag.ToString() == "A") obmag.Adauga(nou);
            else if (bt.Tag.ToString() == "M") obmag[gv.CurrentRow.Index] = nou;
            t1.Focus();
            t1.SelectAll();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            TbMag.Size=new Size(this.Size.Width, this.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fgr = new Form2();
            fgr.ShowDialog();
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t1.Text = gv.CurrentRow.Cells[0].Value.ToString();
            t2.Text = gv.CurrentRow.Cells[1].Value.ToString();
            t3.Text = gv.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
