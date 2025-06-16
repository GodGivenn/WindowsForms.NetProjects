using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Magazie obmag;
        Form2 fgr;
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = magazie; Integrated Security = True; Encrypt=False";
        public Form1()
        {
            InitializeComponent();
            obmag= new Magazie() { DenMag="CSIE" };
            obmag.Ev_Actualizare+=Obmag_Ev_Actualizare;
            fgr = new Form2();
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
            fgr.gr.Valori = (from el in obmag.Col_Mat select el.Val).ToArray();
        }

        void incarca_date()
        {
            SqlConnection con = new SqlConnection(cs);
            string ssel = "select * from materiale";
            con.Open();
            SqlCommand cmd = new SqlCommand(ssel,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) 
                obmag.Adauga(new Material { Cod=int.Parse(dr[0].ToString()), Denumire = dr[1].ToString(), Val= int.Parse(dr[2].ToString()) });
            dr.Close();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            incarca_date(); 
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
            if(fgr.IsDisposed) fgr = new Form2(); 
            if(!fgr.Visible)
            {
                fgr.gr.Valori = (from el in obmag.Col_Mat select el.Val).ToArray();
                fgr.Show();
            }
            
            
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t1.Text = gv.CurrentRow.Cells[0].Value.ToString();
            t2.Text = gv.CurrentRow.Cells[1].Value.ToString();
            t3.Text = gv.CurrentRow.Cells[2].Value.ToString();
        }

        void descarca()
        {
            SqlConnection con = new SqlConnection(cs);
            string sdel = "delete from materiale";
            con.Open();
            SqlCommand cmd = new SqlCommand(sdel, con);
            cmd.ExecuteNonQuery();
            foreach (Material mat in obmag.Col_Mat)
            {
                string sins = "insert into materiale values("+mat.Cod.ToString()+",'"+mat.Denumire+"',"+mat.Val.ToString()+")";
                SqlCommand cmd_ins = new SqlCommand(sins, con);
                cmd_ins.ExecuteNonQuery();
            }
            con.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Salvati modificarile?","Intrebare",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                descarca();
            }

        }
    }
}
