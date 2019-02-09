using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fanorona
{
    public class Tas
    {
        
        bool hareketetme = false; 
        Point ilkkonum;
        int orX, orY;
        private ListBox listBox2;
        private Panel panel1;
        private Panel[,] paneller;
        private PictureBox[,] taslar = new PictureBox[5, 9];
        private string[,] durumMatrisi = new string[5, 9] {
            {"k", "k", "k", "k", "k", "k", "k", "k", "k",},
            {"k", "k", "k", "k", "k", "k", "k", "k", "k",},
            {"k", "m", "k", "m", "b", "k", "m", "k", "m",},
            {"m", "m", "m", "m", "m", "m", "m", "m", "m",},
            {"m", "m", "m", "m", "m", "m", "m", "m", "m",}
        };


        public Tas(ListBox listBox2, Panel panel1, Panel[,] paneller)
        {
            this.listBox2 = listBox2;
            this.panel1 = panel1;
            this.paneller = paneller;
        }

        public void tasOlustur()
        {
            Image kirmiziImage = Image.FromFile("..//..//Resources//kirmizi_tas.png");
            Image maviImage = Image.FromFile("..//..//Resources//mavi_tas.png");

            int indis1 = 0;
            int indis2 = 0;
            for (int i = 100; i < 300; i = i + 100)
            {
                for (int j = 100; j < 1000; j = j + 100)
                {
                    PictureBox kirmiziTas = new System.Windows.Forms.PictureBox();
                    kirmiziTas.Size = new Size(30, 30);
                    kirmiziTas.Location = new System.Drawing.Point(j - 15, i - 15);
                    kirmiziTas.Name = "k";
                    kirmiziTas.Image = kirmiziImage;
                    kirmiziTas.Tag = indis1 + "" + indis2;

                    kirmiziTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    kirmiziTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    kirmiziTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    kirmiziTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = kirmiziTas;
                    panel1.Controls.Add(kirmiziTas);
                    indis2++;
                }
                indis2 = 0;
                indis1++;
            }
            //----------------------------------------------------------------------------
            indis1 = 2;
            indis2 = 0;
            for (int j = 1; j < 5; j++)
            {
                if ((j % 2) != 0)
                {
                    PictureBox kirmiziTas = new System.Windows.Forms.PictureBox();
                    kirmiziTas.Size = new Size(30, 30);
                    kirmiziTas.Location = new System.Drawing.Point((j * 100) - 15, 300 - 15);
                    kirmiziTas.Name = "k";
                    kirmiziTas.Image = kirmiziImage;
                    kirmiziTas.Tag = indis1 + "" + indis2;

                    kirmiziTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    kirmiziTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    kirmiziTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    kirmiziTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = kirmiziTas;
                    panel1.Controls.Add(kirmiziTas);
                    indis2++;
                }
                else
                {
                    PictureBox maviTas = new System.Windows.Forms.PictureBox();
                    maviTas.Size = new Size(30, 30);
                    maviTas.Location = new System.Drawing.Point((j * 100) - 15, 300 - 15);
                    maviTas.Name = "m";
                    maviTas.Image = maviImage;
                    maviTas.Tag = indis1 + "" + indis2;

                    maviTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    maviTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    maviTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    maviTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = maviTas;
                    panel1.Controls.Add(maviTas);
                    indis2++;
                }
            }

            indis1 = 2;
            indis2 = 5;
            for (int j = 6; j < 10; j++)
            {
                if ((j % 2) == 0)
                {
                    PictureBox kirmiziTas = new System.Windows.Forms.PictureBox();
                    kirmiziTas.Size = new Size(30, 30);
                    kirmiziTas.Location = new System.Drawing.Point((j * 100) - 15, 300 - 15);
                    kirmiziTas.Name = "k";
                    kirmiziTas.Image = kirmiziImage;
                    kirmiziTas.Tag = indis1 + "" + indis2;

                    kirmiziTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    kirmiziTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    kirmiziTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    kirmiziTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = kirmiziTas;
                    panel1.Controls.Add(kirmiziTas);
                    indis2++;
                }
                else
                {
                    PictureBox maviTas = new System.Windows.Forms.PictureBox();
                    maviTas.Size = new Size(30, 30);
                    maviTas.Location = new System.Drawing.Point((j * 100) - 15, 300 - 15);
                    maviTas.Name = "m";
                    maviTas.Image = maviImage;
                    maviTas.Tag = indis1 + "" + indis2;

                    maviTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    maviTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    maviTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    maviTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = maviTas;
                    panel1.Controls.Add(maviTas);
                    indis2++;
                }
            }

            //----------------------------------------------------------------------------
            indis1 = 3;
            indis2 = 0;
            for (int i = 400; i < 600; i = i + 100)
            {
                for (int j = 100; j < 1000; j = j + 100)
                {
                    PictureBox maviTas = new System.Windows.Forms.PictureBox();
                    maviTas.Size = new Size(30, 30);
                    maviTas.Location = new System.Drawing.Point(j - 15, i - 15);
                    maviTas.Name = "m";
                    maviTas.Image = maviImage;
                    maviTas.Tag = indis1 + "" + indis2;

                    maviTas.MouseDown += new MouseEventHandler(tasMouseDown);
                    maviTas.MouseMove += new MouseEventHandler(tasMouseMove);
                    maviTas.MouseUp += new MouseEventHandler(tasMouseUp);
                    maviTas.Click += new EventHandler(tasClick);

                    taslar[indis1, indis2] = maviTas;
                    panel1.Controls.Add(maviTas);
                    indis2++;
                }
                indis2 = 0;
                indis1++;
            }

            taslar[2, 4] = new PictureBox();

        }

        private void tasClick(object sender, EventArgs e)
        {
            PictureBox pTas = (sender as PictureBox);
            listBox2.Items.Add(Convert.ToString(pTas.Location));
            listBox2.Items.Add(Convert.ToString(pTas.Name));
            listBox2.Items.Add(Convert.ToString(pTas.Size));

        }

        private void tasMouseDown(object sender, MouseEventArgs e)
        {
            hareketetme = true;
            PictureBox pYeniTas = (sender as PictureBox);
            pYeniTas.Cursor = Cursors.SizeAll;
            ilkkonum = e.Location;
            orX = pYeniTas.Location.X;
            orY = pYeniTas.Location.Y;
        }

        private void tasMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pYeniTas = (sender as PictureBox);
            if (hareketetme)
            {
                pYeniTas.Left = e.X + pYeniTas.Left - (ilkkonum.X);
                pYeniTas.Top = e.Y + pYeniTas.Top - (ilkkonum.Y);
            }
        }

        private void tasMouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pYeniTas = (sender as PictureBox);
            hareketetme = false;
            pYeniTas.Cursor = Cursors.Default;
            int tasX = pYeniTas.Location.X;
            int tasY = pYeniTas.Location.Y;
            int tagI = Convert.ToInt32(tagAyir(pYeniTas.Tag, 0));
            int tagJ = Convert.ToInt32(tagAyir(pYeniTas.Tag, 1));
            int panelX = 0;
            int panelY = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    panelX = paneller[i, j].Location.X;
                    panelY = paneller[i, j].Location.Y;
                    if (panelX <= tasX && (panelX + 100) >= tasX && panelY <= tasY && (panelY + 100) >= tasY)
                    {
                        if (hucreKontrol(i, j) && atlamaKontrol(i, j, tagI, tagJ))
                        {
                            durumMatrisi[i, j] = pYeniTas.Name;
                            pYeniTas.Tag = i + "" + j;
                            taslar[i, j] = pYeniTas;

                            tasHamle(yonKontrol(panelX, panelY, orX, orY), i, j, pYeniTas.Name);

                            pYeniTas.Left = panelX + 50 - 15;
                            pYeniTas.Top = panelY + 50 - 15;

                            oyunBitisKontrol(pYeniTas.Name);
                        }
                        else
                        {
                            pYeniTas.Left = orX;
                            pYeniTas.Top = orY;
                        }

                    }
                }
            }
        }

        string tagAyir(object obj, int indis)
        {
            if (indis == 0)
                return obj.ToString().Substring(0, 1);
            else
                return obj.ToString().Substring(1, 1);
        }

        bool hucreKontrol(int i, int j)
        {
            if (durumMatrisi[i, j] == "b")
                return true;
            else
                return false;
        }

        void oyunBitisKontrol(string tip)
        {
            int sayacmavi = 0, sayackirmizi = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (taslar[i, j].Name == "m")
                        sayacmavi++;
                    else if (taslar[i, j].Name == "k")
                    {
                        sayackirmizi++;
                    }
                }
            }
            if (sayackirmizi == 0)
                oyunBitti("m");
            else if (sayacmavi == 0)
            {
                oyunBitti("k");
            }
        }

        void oyunBitti(string tip)
        {
            if (tip == "m")
                tip = "Mavi";
            else
                tip = "Kırmızı";
            MessageBox.Show("Oyun bitti. \n Kazanan renk: " + tip);
        }

        bool atlamaKontrol(int pI, int pJ, int tI, int tJ)
        {
            bool durum = false;
            listBox2.Items.Add("atlamaKontrol,pI: " + pI.ToString());
            listBox2.Items.Add("atlamaKontrol,pJ: " + pJ.ToString());
            listBox2.Items.Add("atlamaKontrol,tI: " + tI.ToString());
            listBox2.Items.Add("atlamaKontrol,tJ: " + tJ.ToString());

            if ((pI + 1) == tI)
                durum = true;

            if ((pI - 1) == tI)
                durum = true;

            if ((pJ - 1) == tJ)
                durum = true;

            if ((pJ + 1) == tJ)
                durum = true;

            if ((pI + 1) == tI && (pJ + 1) == tJ)
                durum = true;

            if ((pI + 1) == tI && (pJ - 1) == tJ)
                durum = true;

            if ((pI - 1) == tI && (pJ + 1) == tJ)
                durum = true;

            if ((pI - 1) == tI && (pJ - 1) == tJ)
                durum = true;

            return durum;
        }

        string yonKontrol(int pX, int pY, int tX, int tY)
        {
            string yon = "Hareket yok!";
            if (pX <= tX && (pX + 100) >= tX)
            {
                if (pY <= tY && (pY + 100) <= tY)
                    yon = "K";
                if (pY > tY && (pY + 100) >= tY)
                    yon = "G";
            }
            if (pY <= tY && (pY + 100) >= tY)
            {
                if (pX <= tX && (pX + 100) <= tX)
                    yon = "B";
                if (pX >= tX && (pX + 100) >= tX)
                    yon = "D";
            }
            if (pX <= tX && (pX + 100) <= tX)
            {
                if (pY <= tY && (pY + 100) <= tY)
                    yon = "KB";
            }
            if (pX >= tX && (pX + 100) >= tX)
            {
                if (pY <= tY && (pY + 100) <= tY)
                    yon = "KD";
            }
            if (pX < tX && (pX + 100) <= tX)
            {
                if (pY >= tY && (pY + 100) > tY)
                    yon = "GB";
            }
            if (pX >= tX && (pX + 100) >= tX)
            {
                if (pY >= tY && (pY + 100) >= tY)
                    yon = "GD";
            }
            return yon;

        }

        void tasHamle(string yon, int i, int j, string tip)
        {
            listBox2.Items.Add("Yön Adı: " + yon);
            int tempJ = 0;
            switch (yon)
            {
                case "K":
                    durumMatrisi[(i + 1), j] = "b";
                    taslar[(i + 1), j] = new PictureBox();

                    for (int k = (i - 1); k >= 0; k--)
                    {
                        if (durumMatrisi[k, j] == "b")
                            break;
                        if (durumMatrisi[k, j] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, j]);
                        durumMatrisi[k, j] = "b";
                        taslar[k, j] = new PictureBox();

                    }

                    
                    for (int k = (i + 2); k <= 4; k++)
                    {
                        if (durumMatrisi[k, j] == "b")
                            break;
                        if (durumMatrisi[k, j] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, j]);
                        durumMatrisi[k, j] = "b";
                        taslar[k, j] = new PictureBox();
                    }

                    break;
                case "G":
                    durumMatrisi[(i - 1), j] = "b";
                    taslar[(i - 1), j] = new PictureBox();


                    for (int k = (i + 1); k <= 4; k++)
                    {
                        if (durumMatrisi[k, j] == "b")
                            break;
                        if (durumMatrisi[k, j] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, j]);
                        durumMatrisi[k, j] = "b";
                        taslar[k, j] = new PictureBox();

                    }
                   
                    for (int k = (i - 2); k >= 0; k--)
                    {
                        if (durumMatrisi[k, j] == "b")
                            break;
                        if (durumMatrisi[k, j] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, j]);
                        durumMatrisi[k, j] = "b";
                        taslar[k, j] = new PictureBox();
                    }

                    break;
                case "D":
                    durumMatrisi[i, (j - 1)] = "b";
                    taslar[i, (j - 1)] = new PictureBox();


                    for (int k = (j + 1); k <= 8; k++)
                    {
                        if (durumMatrisi[i, k] == "b")
                            break;
                        if (durumMatrisi[i, k] == tip)
                            break;

                        panel1.Controls.Remove(taslar[i, k]);
                        durumMatrisi[i, k] = "b";
                        taslar[i, k] = new PictureBox();

                    }
                    
                    for (int k = (j - 2); k >= 0 && indisCheck(tempJ); k--)
                    {
                        if (durumMatrisi[i, k] == "b")
                            break;
                        if (durumMatrisi[i, k] == tip)
                            break;
                        panel1.Controls.Remove(taslar[i, k]);
                        durumMatrisi[i, k] = "b";
                        taslar[i, k] = new PictureBox();
                    }
                    break;
                case "B":
                    durumMatrisi[i, (j + 1)] = "b";
                    taslar[i, (j + 1)] = new PictureBox();

                    for (int k = (j - 1); k >= 0; k--)
                    {
                        if (durumMatrisi[i, k] == "b")
                            break;
                        if (durumMatrisi[i, k] == tip)
                            break;

                        panel1.Controls.Remove(taslar[i, k]);
                        durumMatrisi[i, k] = "b";
                        taslar[i, k] = new PictureBox();

                    }
              
                    for (int k = (j + 2); k <= 8; k++)
                    {
                        if (durumMatrisi[i, k] == "b")
                            break;
                        if (durumMatrisi[i, k] == tip)
                            break;
                        panel1.Controls.Remove(taslar[i, k]);
                        durumMatrisi[i, k] = "b";
                        taslar[i, k] = new PictureBox();
                    }
                    break;
                case "KB":
                    durumMatrisi[(i + 1), (j + 1)] = "b";
                    taslar[(i + 1), (j + 1)] = new PictureBox();

                    tempJ = j - 1;
                    for (int k = (i - 1); k >= 0 && indisCheck(tempJ); k--)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ--;
                    }

                    
                    tempJ = j + 2;
                    for (int k = (i + 2); k <= 4 && indisCheck(tempJ); k++)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ++;
                    }
                    break;
                case "KD":
                    durumMatrisi[(i + 1), (j - 1)] = "b";
                    taslar[(i + 1), (j - 1)] = new PictureBox();

                    tempJ = j + 1;
                    for (int k = (i - 1); k >= 0 && indisCheck(tempJ); k--)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ++;
                    }

                    
                    tempJ = j - 2;
                    for (int k = (i + 2); k <= 4 && indisCheck(tempJ); k++)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ--;
                    }
                    break;
                case "GB":
                    durumMatrisi[(i - 1), (j + 1)] = "b";
                    taslar[(i - 1), (j + 1)] = new PictureBox();

                    tempJ = j - 1;
                    for (int k = (i + 1); k <= 4 && indisCheck(tempJ); k++)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ--;
                    }

                    
                    tempJ = j + 2;
                    for (int k = (i - 2); k >= 0 && indisCheck(tempJ); k--)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ++;
                    }
                    break;
                case "GD":
                    durumMatrisi[(i - 1), (j - 1)] = "b";
                    taslar[(i - 1), (j - 1)] = new PictureBox();

                    tempJ = j + 1;
                    for (int k = (i + 1); k <= 4 && indisCheck(tempJ); k++)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;

                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ++;
                    }

                    tempJ = j - 2;
                    for (int k = (i - 2); k >= 0 && indisCheck(tempJ); k--)
                    {
                        if (durumMatrisi[k, tempJ] == "b")
                            break;
                        if (durumMatrisi[k, tempJ] == tip)
                            break;
                        panel1.Controls.Remove(taslar[k, tempJ]);
                        durumMatrisi[k, tempJ] = "b";
                        taslar[k, tempJ] = new PictureBox();
                        tempJ--;
                    }
                    break;
                default:
                    MessageBox.Show("Hata");
                    break;
            }



        }
        bool indisCheck(int tmp)
        {
            if (tmp < 0 || tmp > 8)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
