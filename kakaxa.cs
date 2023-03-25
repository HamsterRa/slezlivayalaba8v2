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

            Elips elipsFormy1 = new Elips(poinx, poiny+(height*6/9), widht, height * 3/3);
            elipsFormy1.Draw();
            shape[0] = (elipsFormy1);

            Elips elipsFormy2 = new Elips(poinx+(widht*5/20), poiny+(height*9/10), widht*5/10, height*5/10);
            elipsFormy2.Draw();
            shape[1] = (elipsFormy2);
            

            // треугольник 

            List<int> pointsx = new List<int>();
            List<int> pointsy = new List<int>();
            pointsx.Add((poinx) + widht*2/4 );
            pointsx.Add((poinx) + widht*6/4 );
            pointsx.Add((poinx) + widht*-5/10 );
            pointsy.Add((poiny) + height*2/10);
            pointsy.Add((poiny) + height*17/10);
            pointsy.Add((poiny) + height*17/10);
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
            this.poinx += x;
            this.poiny += y;
            this.Draw();
        }
        public void Koef(int W, int H)
        {
            height = W;
            widht = H;
        }
    }
}
