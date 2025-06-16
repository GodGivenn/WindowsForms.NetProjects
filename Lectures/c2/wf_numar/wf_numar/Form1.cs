using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_numar
{
    public partial class Form1 : Form
    {
        CNumar obn;
        public Form1()
        {
            InitializeComponent();
            obn = new CNumar();
            obn.Ev_Modificare += Obn_Ev_Modificare;
        }

        private void Obn_Ev_Modificare(object obs)
        {
            tbpn.Text = ((CNumar) obs).Patrat.ToString();
            ListViewItem rc= lv.Items.Add((lv.Items.Count+1).ToString());
            rc.SubItems.Add(((CNumar)obs).Element.ToString());
            rc.SubItems.Add(((CNumar)obs).Patrat.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbn_Validating(tbn, new CancelEventArgs());
        }

        private void tbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                tbn_Validating(sender, new CancelEventArgs());
            }
        }

        private void tbn_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                obn.Element = int.Parse(tb.Text);
                err.SetError((Control)sender, string.Empty);
            }
            catch (FormatException ex)
            {
                //MessageBox.Show(ex.Message,"ERR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError((Control)sender, ex.Message);
                e.Cancel = true;
            }
            finally
            {
                tb.Focus();
                tb.SelectAll();
            }
        }
    }
}
