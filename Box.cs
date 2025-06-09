using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }

        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }

        public void setWidtht(int width)
        {
            if (height > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("너비를 자연수로 초기화해주세요!");
            }
        }
        public void setHeight(int height)
        {
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("높이를 자연수로 초기화해주세요!");
            }
        }
        public int Area() { return width * height; }
    }
}