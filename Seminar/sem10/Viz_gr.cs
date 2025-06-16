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
        int[] lista_valori;
        int tipGrafic;
        Rectangle rc;
        public Grafic()
        {
            lista_valori = null;
            tipGrafic = 0; 
            ResizeRedraw = true;
        }
        public int[] Valori
        { get => lista_valori;
            set { lista_valori=value; Invalidate();//retraseaza grafic
                  }
        }

        public int Tip_Grafic
        {
            get => tipGrafic;
            set
            {
                tipGrafic=value; Invalidate();//retraseaza grafic
            }

        }

        Rectangle[] get_bars(Rectangle r)
        {
            int no = lista_valori.Length , t=0;
            int db = r.Width/(4*no+1), lb = 3*db;
            return lista_valori.Select(el => new Rectangle
            {
                X = r.X + (t+1)*db + lb*(t++),
                Y = r.Y + (r.Height - (el*r.Height/lista_valori.Max())),
                Width = lb,
                Height = el*r.Height/lista_valori.Max()
            }).ToArray();
        }


        //pt dreptunghi: colt stanga sus, latime, si inaltime
        /*
         *  w = (n+1)db+n*lb -> w = n*db +db+3n*db = (4n+1)db
         *  db = 1/3 lb => lb = 3db; db = w/(4n+1)
         *  
         *  h = xi/Max(xi) * HEIGHT
         */
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
            if(lista_valori != null)
            {
                if(tipGrafic == 0)
                {
                    //BARS
                    g.FillRectangles(Brushes.Red, get_bars(chenar));
                }
                else if(tipGrafic == 1)
                {
                    //PIE
                    g.DrawString("Pie graph",this.Font,Brushes.Green, rc.Width/2, rc.Height/2);
                }
                else
                {
                    //LINE
                    g.DrawString("Line graph",this.Font,Brushes.Purple, rc.Width/2, rc.Height/2);
                }
            }
        }
    }
}
