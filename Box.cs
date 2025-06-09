using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace PropExample
{
    class Box
{
    // C#에서는 속성(Property)
    private int width;
    public int Width
    {
        get { return width; }
        set
        {
            if (value > 0)
            {
                width = value;
            }
            else
            {
                Console.WriteLine("너비를 자연수로 초기화해주세요!");
            }
        }
    }
    private int height;
    public int Heigth
    {
        get { return height; }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                Console.WriteLine("높이를 자연수로 초기화해주세요!");
            }
        }
    }
    public int Area
    {
        get { return Width * Heigth; }
    }

    public Box(int width, int height)
    {
        Width = width;
        Heigth = height;
    }

    }
}