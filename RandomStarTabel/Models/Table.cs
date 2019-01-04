using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomStarTabel.Models
{
    public class Table
    {
        int row;
        int min;
        int max;
        private int[] a;
        private Random random;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

      
        public Table(int r,int mi,int ma)
        {

            row = r;
            min = mi;
            max = ma;
            random = new Random();
            a = new int[Row];
            for(int i = 0; i < a.Length; i++)
            {
               a[i] = random.Next(Min, Max);
            }
       
        }
        public int[] getValue()
        {
            return a;
        }

        public string createStar(int n)
        {
            var tem = "";
            for (int i = 0; i < n; i++)
            {
                tem += "*";
            }
            return tem;
        }
    }
}









