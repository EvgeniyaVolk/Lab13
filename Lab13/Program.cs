using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulding bulding = new Bulding("адрес", 1, 2, 3);
            MultiBulding multiBulding = new MultiBulding("адрес", 1, 2, 3, 4);
            Console.ReadKey();

        }
    }
    class Bulding
    {
        public string address { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Bulding(string a, float l, float w, float h)
        {
            address = a;
            length = l;
            width = w;
            height = h;
        }
        public virtual void Print()
        {
            Console.WriteLine("Длина= {0}, ширина= {1}, высота= {2}", length, width, height);
        }
    }
    sealed class MultiBulding : Bulding
    {
        public float floor { get; set; }
        public MultiBulding(string a, float l, float w, float h, float f)
            :base(a,l,w,h)
        {
            floor = f;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Этажность= {0}", floor);
        }


    }
}


