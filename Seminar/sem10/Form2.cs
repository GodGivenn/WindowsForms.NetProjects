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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbg.SelectedIndex = 0;
        }

        private void cbg_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr.Tip_Grafic = cbg.SelectedIndex;
        }
    }
}
