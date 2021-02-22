using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        //OPG A
        //private int side;

        //public Square(int side)
        //{
        //    this.side = side;
        //}

        public int Omkreds()
        {
            int o = 4 * side;
            return o;
        }

        public int Areal()
        {
            int a = side * side;
            return a;
        }

        //OPG B
        private int side;

        public int Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square()
        {


        }
    }
}
