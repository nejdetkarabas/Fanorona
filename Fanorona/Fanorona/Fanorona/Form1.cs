using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fanorona
{
    public partial class Form1 : Form
    {
        Tahta engine;
        Panel[,] paneller = new Panel[5,9];
        public System.Windows.Forms.ListBox listBox2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2 = new ListBox();
            listBox2.Size = new Size(210, 290);
            listBox2.Location = new System.Drawing.Point(1130, 15);
            this.Controls.Add(listBox2);

            Tas taslar = new Tas(listBox2, panel1, paneller);
            taslar.tasOlustur();
            kontrolPanelOlustur();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new Tahta(toPass);
        }

       

       

        void kontrolPanelOlustur()
        {
            int n = 1;
            int i = 0;
            int j = 0;
            for (int y = 50; y < 550; y = y + 100)
            {
                for (int x = 50; x < 950; x = x + 100)
                {
                    Panel p = new Panel();
                    p.Size = new Size(100, 100);
                    p.Location = new System.Drawing.Point(x, y);
                   
                    p.Name = "panel" + Convert.ToString(n);
                    p.Visible = false;
                    paneller[i, j] = p;
                    panel1.Controls.Add(p);
                    n++;
                    j++;
                }
                i++;
                j = 0;
            }
        }

       

        private void listBoxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
