using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rectangle
    {
        List<int> listX = new List<int>(); 
        List<int> listY = new List<int>();
        public int X0 { get; private set; }
        public int X1 { get; private set; }
        public int Y0 { get; private set; }
        public int Y1 { get; private set; }
        public List<int> ListX { get { return listX; } set { listX = value; } }
        public List<int> ListY { get {return listY; } set { listY = value; } }
         int Xmax ,Xmin,Ymax,Ymin ;

 
        public Rectangle(int Xmin,int Ymin,int Xmax , int Ymax)
        {
            this.Xmax = Xmax;
            this.Xmin = Xmin;
            this.Ymin = Ymin;
            this.Ymax = Ymax;
        }
        public void Draw()
        {
            DDA line1 = new DDA(Xmin,Ymin,Xmax,Ymin);
            line1.Draw();
            fill(line1.X, listX);
            fill(line1.Y, listY);
            DDA line2 = new DDA(Xmin, Ymin, Xmin, Ymax);
            line2.Draw();
            fill(line2.X, listX);
            fill(line2.Y, listY);
            DDA line3 = new DDA(Xmax, Ymax, Xmax, Ymin);
            line3.Draw();
            fill(line3.X, listX);
            fill(line3.Y, listY);
            DDA line4 = new DDA(Xmax, Ymax, Xmin, Ymax);
            line4.Draw();
            fill(line4.X, listX);
            fill(line4.Y, listY);

        }
        void fill(List<int> list,List<int> main)
        {
            foreach (var i in list)
            {
                main.Add(i);
            }
        }






        const string RIGHT = "R";
        const string LEFT = "L";
        const string TOP ="T";
        const string BOTTOM ="B";
       // int X, Y; 
        string ComputeOutCode(double x, double y)
        {
            string code=null;

            if (y > Ymax)
            {
                code = TOP;
            }
            else if (y < Ymin)
            {
                code  = BOTTOM;  
            }
            if (x > Xmax)
            {
                code += RIGHT;
            }
            else if (x < Xmin)
            {
                code += LEFT;
            }
            return code ;
        }
        public void cohen(int x1, int y1, int x2, int y2, int xmin, int ymin, int xmax, int ymax)
        {

            if (ComputeOutCode(x2, y2) == (TOP + RIGHT))
            {
                Y1 = ymax;
                X1 = x1 + (x2 - x1) * (ymax - y1) / (y2 - y1);
            }
            else if (ComputeOutCode(x2, y2) == null)
            {
                Y1 = y2;
                X1 = x2;
            }
            else if (ComputeOutCode(x2, y2) == (TOP + LEFT))
            {
                X1 = xmax;
                Y1 = y1 + (y2 - y1) * (xmax - x1) / (x2 - x1);
            }
            else
            {
                Y1 = y2;
                X1 = x2;

            }

            if (ComputeOutCode(x1, y1) == null)
            {
                X0 = x1;
                Y0 = y1;
            }
            else if (ComputeOutCode(x1, y1) == (BOTTOM + LEFT))
            {
                X0 = x1 + (x2 - x1) * (ymin - y1) / (y2 - y1);
                Y0 = ymin;
            }
            else if (ComputeOutCode(x1, y1) == (BOTTOM + RIGHT))
            {
                X0 = xmin;
                Y0 = y1 + (y2 - y1) * (xmin - x1) / (x2 - x1);
            }
            else
            {
                X0 = x1;
                Y0 = y1;
            }



        }

    }
}
