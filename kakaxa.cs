using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba_8_oaip.Form1;

namespace laba_8_oaip
{
    internal class kakaxa : Figure
    {
        public Figure[] shape = new Figure[5];
        public int poinx, poiny;
        public int widht = 1;
        public int height = 1;


        public kakaxa( int x, int y, int w, int h)
        {
            poinx = x;
            poiny = y;
            widht = w;
            height = h;

        }
        public override void Draw()
        {
            
            // два элипса

            Elips elipsFormy1 = new Elips(poinx+ widht*2/10, poiny+ height*4/10, widht*3/5, height*3/5);
            elipsFormy1.Draw();
            shape[0] = (elipsFormy1);

            Elips elipsFormy2 = new Elips(poinx+(widht*5/20), poiny+(height*9/20), widht*5/10, height*5/10);
            elipsFormy2.Draw();
            shape[1] = (elipsFormy2);
            

            // треугольник 

            List<int> pointsx = new List<int>();
            List<int> pointsy = new List<int>();
            pointsx.Add((poinx) + widht*1/2);
            pointsx.Add(poinx);
            pointsx.Add((poinx) + widht);
            pointsy.Add((poiny));
            pointsy.Add((poiny) + height);
            pointsy.Add((poiny) + height);
            Tringular triFormy = new Tringular(3, pointsx, pointsy);
            triFormy.Draw();
            shape[2] = (triFormy);
          
        }
        public override void Selection()
        {
            for(int i=0; i < 3; i++)
            {
                shape[i].Selection();
            }
        }
        public override void MoveTo(int x, int y)
        {
            this.Selection();

            if (poinx + x + widht >= Init.bitmap.Width || poinx + x < 0 || poiny + y + height>= Init.bitmap.Height || poiny + y < 0)
            {
                MessageBox.Show("Невозможно передвинуть фигуру");

                return;
            }

            
            this.poinx += x;
            this.poiny += y;
            this.Draw();
        }
    }
}
