using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Grafic : Control
    {
        int[] lv;
        int tg;
        Rectangle rc;
        public Grafic()
        {
            lv=null;
            tg=0;
            ResizeRedraw = true;
        }
        public int[] Valori
        { get => lv;
          set { lv=value; Invalidate(); }
        }

        public int Tip_Grafic
        {
            get => tg;
            set { tg=value; Invalidate(); }
        }

        Rectangle[] get_bars(Rectangle r)
        {
            int no = lv.Length, t=0;
            int db = r.Width/(4*no+1), lb = 3*db;
            return lv.Select(el => new Rectangle
            {
                X = r.X+(t+1)*db+lb*t++,
                Y=r.Y+(r.Height-(el*r.Height/lv.Max())),
                Width = lb,
                Height=el*r.Height/lv.Max()
            }).ToArray();
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
            if(lv!=null && lv.Length>=2)
            {
                if(tg==0)
                {
                    //Afis bar
                    g.FillRectangles(Brushes.Red, get_bars(chenar));
                }
                else if(tg==1)
                {
                    //Afis Pie
                    g.DrawString("AFISARE PIE", this.Font, Brushes.Green, rc.Width/2, rc.Height/2);

                }
                else
                {
                    //Afis Linie
                    g.DrawString("AFISARE LINIE", this.Font, Brushes.Purple, rc.Width/2, rc.Height/2);
                }
            }
        }
    }
}
