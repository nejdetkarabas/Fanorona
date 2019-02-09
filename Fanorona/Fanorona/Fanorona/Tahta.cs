using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Fanorona
{
    class Tahta
    {
        private Graphics gnesne;

        public Tahta(Graphics g)
        {
            gnesne = g;
            Renkler();
        }

        public void Renkler()
        {
            Brush arkaplan = new SolidBrush(Color.WhiteSmoke);
            Pen cizgi = new Pen(Color.Black);

            gnesne.FillRectangle(arkaplan, new Rectangle(0, 0, 1000, 600));

            
            gnesne.DrawLine(cizgi, new Point(0, 0), new Point(1000, 0));
            gnesne.DrawLine(cizgi, new Point(0, 600), new Point(1000, 600));
            gnesne.DrawLine(cizgi, new Point(0, 0), new Point(0, 600));
            gnesne.DrawLine(cizgi, new Point(1000, 0), new Point(1000, 600));


            
            for (int i = 1; i <= 5; i++)
            {
                gnesne.DrawLine(cizgi, new Point(100, 100*i), new Point(900, 100*i));
            }

            
            for (int i = 1; i < 10; i++)
            {
                gnesne.DrawLine(cizgi, new Point(100*i, 100), new Point(100*i, 500));

            }

           
           
            gnesne.DrawLine(cizgi, new Point(100, 300), new Point(300, 500));
            gnesne.DrawLine(cizgi, new Point(100, 100), new Point(500, 500));
            gnesne.DrawLine(cizgi, new Point(300, 100), new Point(700, 500));
            gnesne.DrawLine(cizgi, new Point(500, 100), new Point(900, 500));
            gnesne.DrawLine(cizgi, new Point(700, 100), new Point(900, 300));

            gnesne.DrawLine(cizgi, new Point(900, 300), new Point(700, 500));
            gnesne.DrawLine(cizgi, new Point(900, 100), new Point(500, 500));
            gnesne.DrawLine(cizgi, new Point(700, 100), new Point(300, 500));
            gnesne.DrawLine(cizgi, new Point(500, 100), new Point(100, 500));
            gnesne.DrawLine(cizgi, new Point(300, 100), new Point(100, 300));
            
        }
    }
}
