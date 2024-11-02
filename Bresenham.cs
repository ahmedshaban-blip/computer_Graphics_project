 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Bresenham : DDA
    {
        int p, sx, sy, Xend, XS, YS;
        float m;
       public Bresenham(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {

            dx = Math.Abs(dx);
            dy = Math.Abs(dy);
            p = 2 * dy - dx;
            m = dy / dx;
            sx = Math.Sign(x2 - x1);
            sy = Math.Sign(y2 - y1);
            intial();
        }
        void intial()
        {
            if (m < 1)
            {
                if (x1 > x2)
                {
                    XS = x2;
                    YS = y2;
                    Xend = x1;
                }
                else
                {
                    XS = x1;
                    YS = y1;
                    Xend = x2;
                }
            }
            else if (m > 1)
            {
                if (y1 > y2)
                {
                    XS = x2;
                    YS = y2;
                    Xend = y1;
                }
                else
                {
                    XS = x1;
                    YS = y1;
                    Xend = y2;
                }
            }
        }
        public override void Draw()
        {
            #region m < 1
            if (m < 1)
            {
                X.Add(XS); Y.Add(YS);
                while (XS < Xend)
                {
                    XS += sx;
                    if (p < 0)
                    {
                        p += 2 * dy;
                    }
                    else
                    {
                        YS += sy;
                        p += 2 * (dy - dx);
                    }
                    X.Add(XS); Y.Add(YS);

                }
            }
            #endregion
            #region m > 1
            else if (m > 1)
            {
                X.Add(XS); Y.Add(YS);
                while (YS < Xend)
                {
                    YS += sy;
                    if (p < 0)
                    {
                        p += 2 * dx;
                    }
                    else
                    {
                        XS += sx;
                        p += 2 * (dx - dy);
                    }
                    X.Add(XS); Y.Add(YS);
                }
            }
            #endregion
        }
    }
}
