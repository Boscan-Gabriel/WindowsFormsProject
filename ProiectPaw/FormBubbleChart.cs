using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace AdmitereFacultate
{
    public partial class FormBubbleChart : Form
    {

        private List<int> nrLocuri = new List<int>();
        private List<string> denumiriFacultati = new List<string>();
        public FormBubbleChart(List<Facultate> list)
        {
            InitializeComponent();
            foreach (Facultate f in list)
            {
                nrLocuri.Add(f.calculNumarLocuriTotal());
                denumiriFacultati.Add(f.Denumire);

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            const float maxRadius = 50;
            const float minRadius = 10;
            const float scale = 0.5f;

            int max = GetMaxValue(nrLocuri);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.White);

            
            Font font = new Font("Arial", 10);
            Pen pen = new Pen(Color.Black);

           
            int axisX = 50;
            int axisY = panel1.Height - 50;
            int axisWidth = panel1.Width - 100;
            int axisHeight = panel1.Height - 100;
            graphics.DrawLine(pen, axisX, axisY, axisX + axisWidth, axisY); 
            graphics.DrawLine(pen, axisX, axisY, axisX, axisY - axisHeight); 


            
            for (int i = 0; i < denumiriFacultati.Count; i++)
            {
                float radius = GetRadius(nrLocuri[i], max, minRadius, maxRadius) * scale;
                float x = 100 + i * 120;
                float y = 150;

                Brush brush = new SolidBrush(GetRandomColor());
                graphics.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
                graphics.DrawEllipse(Pens.Black, x - radius, y - radius, 2 * radius, 2 * radius);
                graphics.DrawString(denumiriFacultati[i]+"->"+nrLocuri[i], font, Brushes.Black, x + radius, y);
            }
        }

        private int GetMaxValue(List<int> values)
        {
            int max = int.MinValue;
            foreach (int value in values)
            {
                if (value > max)
                    max = value;
            }
            return max;
        }

        private float GetRadius(int value, int maxValue, float minRadius, float maxRadius)
        {
            float radius = minRadius + (maxRadius - minRadius) * value / maxValue;
            return radius;
        }

        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            const float maxRadius = 50;
            const float minRadius = 10;
            const float scale = 0.5f;

            int max = GetMaxValue(nrLocuri);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.White);

            
            Font font = new Font("Arial", 10);
            Pen pen = new Pen(Color.Black);

            
            int axisX = 50;
            int axisY = panel1.Height - 50;
            int axisWidth = panel1.Width - 100;
            int axisHeight = panel1.Height - 100;
            graphics.DrawLine(pen, axisX, axisY, axisX + axisWidth, axisY); 
            graphics.DrawLine(pen, axisX, axisY, axisX, axisY - axisHeight); 


            
            for (int i = 0; i < denumiriFacultati.Count; i++)
            {
                float radius = GetRadius(nrLocuri[i], max, minRadius, maxRadius) * scale;
                float x = 100 + i * 120;
                float y = 150;

                Brush brush = new SolidBrush(GetRandomColor());
                graphics.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
                graphics.DrawEllipse(Pens.Black, x - radius, y - radius, 2 * radius, 2 * radius);
                graphics.DrawString(denumiriFacultati[i] + "->" + nrLocuri[i], font, Brushes.Black, x + radius, y);
            }
        }

        private void previzualizeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}

