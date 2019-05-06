using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 49)
                {
                    x = 0;
                }
                else if (value < 0)
                {
                    x = 49;
                }
                else
                {
                    x = value;
                }
            }
        }

        public int Y {
            get
            {
                return y;
            }
            set
            {
                if (value > 24)
                {
                    y = 0;
                } 
                else if (value < 0)
                {
                    y = 24;
                }
                else
                {
                    y = value;
                }
            }
        }
    }
}
