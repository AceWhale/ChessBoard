using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(Color.Black, 3.0f))
                {
                    int x = 120;
                    int y = 60;
                    bool zigzag = false;
                    SolidBrush brush = new SolidBrush(Color.Black);
                    for (; y < 520; y += 60)
                    {
                        for (; x < 520; x += 120)
                            g.FillRectangle(brush, new Rectangle(x, y, 60, 60));
                        if (zigzag)
                        {
                            x = 120;
                            zigzag = false;
                        }
                        else
                        {
                            x = 60;
                            zigzag = true;
                        }
                    }
                    g.DrawLine(pen, 540, 540, 60, 540);
                    g.DrawLine(pen, 60, 60, 60, 540);
                    g.DrawLine(pen, 60, 60, 540, 60);
                    g.DrawLine(pen, 540, 540, 540, 60);
                }
            }
        }
    }
}
