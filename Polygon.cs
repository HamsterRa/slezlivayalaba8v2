﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba_8_oaip.Form1;


namespace laba_8_oaip
{
    internal class Polygon:Figure
    {
        public List<int> pointsx = new List<int>();
        public List<int> pointsy = new List<int>();
        public int CountOfPoints;
        public bool mg = true;
        private bool p;

        public Polygon() { }
        public Polygon(int Count, List<int> pointsx, List<int> pointsy)
        {
            this.pointsx = pointsx;
            this.pointsy = pointsy;
            CountOfPoints = Count;
            this.x = pointsx.Min();
            this.y = pointsy.Min();
            this.width = pointsx.Max() - x;
            this.height = pointsx.Max() - y;
            mg = true;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            Point[] mas_point = new Point[CountOfPoints];
            for (int i = 0; i < mas_point.Length; i++)
            {
                mas_point[i] = new Point(pointsx[i], pointsy[i]);
            }
            g.DrawPolygon(Init.pen, mas_point);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void Selection()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            Point[] mas_point = new Point[CountOfPoints];
            for (int i = 0; i < mas_point.Length; i++)
            {
                mas_point[i] = new Point(pointsx[i], pointsy[i]);

            }
            g.DrawPolygon(new Pen(Color.White, 5), mas_point);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            this.Selection();
            Graphics g = Graphics.FromImage(Init.bitmap);
            Point[] mas_point = new Point[CountOfPoints];
            List<int> lx = pointsx;
            List<int> ly = pointsy;
            for (int i = 0; i < mas_point.Length; i++)
            {
                if (lx[i] + x >= Init.bitmap.Width || lx[i] + x < 0 || ly[i] + y >= Init.bitmap.Height || ly[i] + y < 0)
                {
                    MessageBox.Show("Невозможно передвинуть фигуру");
                    return;
                }

                lx[i] = pointsx[i] + x;
                ly[i] = pointsy[i] + y;
                mas_point[i] = new Point(lx[i], ly[i]);
            }
            g.DrawPolygon(Init.pen, mas_point);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
