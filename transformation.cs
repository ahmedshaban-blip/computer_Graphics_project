using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class transformation
    {
       
        int dir = 1, dir2 = -1;
        public  List<int> translate(int x1 , int y1 , int x2 , int y2 , int tx , int ty )
        {
         
            x1 += tx;
            x2 += tx;
            y1 += ty;
            y2 += ty;
            return new List<int>() { x1, y1, x2, y2 };
        }
        public List<int> Rotate(int x1, int y1, int x2, int y2, double angle)
        {
            angle = angle * Math.PI / 180;
            double[,] rotate ={
                      {Math.Cos(angle),Math.Sin(angle)*dir,0},
                      {Math.Sin(angle)*dir2,Math.Cos(angle),0},
                      {0,0,1}
                      };
            //MessageBox.Show(Math.Cos(60).ToString());
            double[,] p1_zer0 = tras_to_zero((x1 + x2) / 2, (y1 + y2) / 2);

            double newddx1 = x1 + p1_zer0[0, 2];
            double newddx2 = x2 + p1_zer0[0, 2];

            double newddy1 = y1 + p1_zer0[1, 2];
            double newddy2 = y2 + p1_zer0[1, 2];

            double[,] come_back = tras_to_zero((x1 + x2) / -2, (y1 + y2) / -2);

            double[,] test = matrix33_X_matrix33(come_back, rotate);
            double[,] res = matrix33_X_matrix33(test, p1_zer0);

            double[] point_1_before = { x1, y1, 1 };
            double[] point_2_before = { x2, y2, 1 };

            double[] point_1_after_rotate = matrix33_X_matrix31(res, point_1_before);
            double[] point_2_after_rotate = matrix33_X_matrix31(res, point_2_before);

            return new List<int>() { (int)point_1_after_rotate[0], (int)point_1_after_rotate[1], (int)point_2_after_rotate[0], (int)point_2_after_rotate[1] };
        }
        double[,] tras_to_zero(double x, double y)
        {
            double[,] trans_to_zero ={
                                 {1,0,-1*x},
                                 {0,1,-1*y},
                                 {0,0,1}
                                  };
            return trans_to_zero;

        }
        double[] matrix33_X_matrix31(double[,] arr1, double[] arr2)
        {
            double[] res = new double[3];

            for (int i = 0; i < 9; i++)
            {
                res[i / 3] += arr1[i / 3, i % 3] * arr2[i % 3];
            }

            return res;
        }
        double[,] matrix33_X_matrix33(double[,] arr1, double[,] arr2)
        {
            double[,] res = new double[3, 3];

            for (int i = 0; i < 9; i++)
            {
                //for (int row = 0; row < 3; row++)
                //{
                for (int col = 0; col < 3; col++)
                {
                    res[i / 3, i % 3] += arr1[i / 3, col] * arr2[col, i % 3];
                }
                //}
            }

            return res;
        }
        public List<int> Scale(int x1, int y1, int x2, int y2, double sx, double sy)
        {
            double[,] scall ={
                      {sx,0,0},
                      {0,sy,0},
                      {0,0,1}
                      };
            //MessageBox.Show(Math.Cos(60).ToString());
            double[,] p1_zer0 = tras_to_zero((x1 + x2) / 2, (y1 + y2) / 2);
            double newddx1 = x1 + p1_zer0[0, 2];
            double newddx2 = x2 + p1_zer0[0, 2];

            double newddy1 = y1 + p1_zer0[1, 2];
            double newddy2 = y2 + p1_zer0[1, 2];

            double[,] come_back = tras_to_zero((x1 + x2) / -2, (y1 + y2) / -2);

            double[,] test = matrix33_X_matrix33(come_back, scall);
            double[,] res = matrix33_X_matrix33(test, p1_zer0);

            double[] point_1_before = { x1, y1, 1 };
            double[] point_2_before = { x2, y2, 1 };

            double[] point_1_after_rotate = matrix33_X_matrix31(res, point_1_before);
            double[] point_2_after_rotate = matrix33_X_matrix31(res, point_2_before);

            return new List<int>() { (int)point_1_after_rotate[0], (int)point_1_after_rotate[1], (int)point_2_after_rotate[0], (int)point_2_after_rotate[1] };
        }

    }
}
