using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_2_Soccer_
{
    /// <summary>
    /// Class about matrix of goals of all teams
    /// </summary>
    class Matrix
    {
        public readonly int max = 20;
        private int[,] scoreTable;
        public int R { get; set; }
        public int C { get; set; }
        public Matrix() 
        {
            scoreTable = new int[max, max]; 
            R = 0; 
            C = 0; 
        }
        public int this[int i,int j]
        {
            get
            {
                return scoreTable[i,j];
            }
            set
            {
                scoreTable[i, j] = value;
            }
        }
    }
}
