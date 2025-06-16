using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Grafic : Control
    {
        List<int> lv;
        Rectangle rc;
        public Grafic()
        {
            ResizeRedraw = true;
        }
        public List<int> Valori
        { get => lv;
          set => lv=value;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            rc = ClientRectangle;
            Graphics g = e.Graphics;
            Rectangle chenar = new Rectangle
            {
                X=rc.X+10,
                Y=rc.Y+10,
                Width = rc.Width-20,
                Height = rc.Height-20
            };
            g.DrawRectangle(Pens.Blue, chenar);
        }
    }
}
