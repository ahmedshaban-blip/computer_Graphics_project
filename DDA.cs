using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DDA
    {
        
        protected int x1, y1, x2, y2, dx, dy, staps;
      
        float Xinc, Yinc;
        protected float  XP, YP ;
        
        protected List<int> x = new List<int>();
        protected  List<int> y = new List<int>();
        public  List<int> X
        {
            get { return x; }
            set { x= value; }
        }
        public  List<int> Y
        {
            get { return y; }
            set { y = value; }
        }

        #region Constractor
        /// <summary>
        /// Constractor for DDA 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public DDA(int x1 , int y1 , int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            dx = x2 - x1;
            dy = y2 - y1;
            staps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            Xinc = dx / (float)staps;
            Yinc = dy / (float)staps; 
            
        }
        #endregion
        #region methods
        public virtual void Draw()
        {
            XP=x1; YP=y1;
            X.Add((int)Math.Round(XP)); Y.Add((int)Math.Round(YP));
            for (int i = 1; i <= staps; i++)
            {
                XP += Xinc;
                YP += Yinc; 
                X.Add((int)Math.Round(XP)); Y.Add((int)Math.Round(YP));
            }
        }
        #endregion
    }
}
