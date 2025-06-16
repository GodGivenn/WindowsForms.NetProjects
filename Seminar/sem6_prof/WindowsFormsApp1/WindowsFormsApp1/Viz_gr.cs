using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Grafic : Control//Control imi asigura ca voi avea acel canvas pe care sa desenez
    {
        List<int> lista_valori;
        Rectangle rc;
        public Grafic()
        {
            ResizeRedraw = true;
        }

        public List<int> Valori
        { 
            get => lista_valori;
            set => lista_valori = value;
        }
        //override onpa <tab>
        //il fac fac docabil pe toata pagina -> Dock
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            rc = ClientRectangle;
            Graphics g = e.Graphics;//iau contextul grafic al contorului? idk
            Rectangle chenar = new Rectangle
            {
                X= rc.X + 10,
                Y= rc.Y + 10,
                Width= rc.Width - 20,
                Height= rc.Height - 20
            };
            g.DrawRectangle(Pens.ForestGreen, chenar);
        }
    }
}
