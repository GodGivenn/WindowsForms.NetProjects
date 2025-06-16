using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace wf_cons
{
    class Forma_mea : Form
    {
        Button bt;
        public Forma_mea() 
        {
            this.Text = "App Forma!!";
            bt = new Button();
            bt.Size = new Size(100, 50);
            bt.Location = new Point(10, 30);
            bt.Text = "Apasa!!";
            this.Controls.Add(bt);
            bt.Click += (object sender, EventArgs e)=>
            {
                Button aux = (Button)sender;
                MessageBox.Show("Ai apasat butonul " + aux.Text+"  !!!");
            };
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Forma_mea());

        }
    }
}
