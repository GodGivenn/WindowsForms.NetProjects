using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminarul_3
{
    public partial class Form1 : Form
    {
        Ecutatie2 ec;
        public Form1()
        {
            InitializeComponent();
            ec = new Ecutatie2();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            bool vb = false;
            try 
            { 
                ec.C_Xp = int.Parse(textBox1.Text);
                ec.C_X = int.Parse(textBox2.Text);
                ec.Termen_L = int.Parse(textBox3.Text);
                textBox5.Text = ec.Rad1.ToString();
                textBox6.Text = ec.Rad1.ToString();
                
            }
            
            catch(FormatException ex) 
            {
                MessageBox.Show(ex.Message);
                vb = true;
            }

            catch (ExArgument0 ex) {
                MessageBox.Show(ex.Message);
                vb = true;
            }

            catch (ExDelta_negativa ex) {
                MessageBox.Show(ex.Message);
                vb = true;
            }
            
            finally 
            {
                if (vb == false) textBox4.Text = ec.ToString();
                else textBox4.Text = string.Empty;
            }

        }

        
    }
}
