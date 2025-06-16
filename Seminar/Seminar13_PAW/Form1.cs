using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar13_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void setNode(int k, TreeNode node)
        {
            node.Text = k.ToString();
            node.Tag = new sup_node();
        }

        void insertNode(int k, TreeNode rad)
        {
            if (rad.Text == "NULL" ) setNode(k, rad);
            else
            {
                if(rad.Nodes.Count == 0 && k != int.Parse(rad.Text))
                {
                    rad.Nodes.Add("NULL");
                    rad.Nodes.Add("NULL");
                }
                if(k < int.Parse(rad.Text)) insertNode(k, rad.Nodes[0]);
                else if(k > int.Parse(rad.Text)) insertNode(k, rad.Nodes[1]);
                else
                {
                    rad.ForeColor = Color.Red;
                    sup_node sn = (sup_node)rad.Tag;
                    sn++;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int k = int.Parse(tb.Text);
            insertNode(k, tv.Nodes[0]);
            tv.ExpandAll();
            tb.Focus();
            tb.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tv.Nodes.Add("NULL");
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tb_fv.Text = e.Node.Text == "NULL" ? String.Empty : "Nodul: " + e.Node.Text 
                + " are frecventa: " + ((sup_node)e.Node.Tag).Frecventa;
        }


        void inordine(TreeNode rad)
        {
            if(rad.Text !="NULL")
            {
                if(rad.Nodes.Count != 0) inordine(rad.Nodes[0]);
                textB.Text += rad.Text + ";";
                if (rad.Nodes.Count != 0) inordine(rad.Nodes[1]);
                     }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textB.Text=String.Empty;
            inordine(tv.Nodes[0]);
        }
    }   


    public class sup_node
    {
        int frecventa;
        public sup_node()
        {
            frecventa = 1;
        }
        public int Frecventa => frecventa;

        public static sup_node operator ++(sup_node node) {
            node.frecventa++;
            return node;
        }
    }
}
