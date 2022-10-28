using System;

namespace GrunderOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkle cirkel1=new Cirkle();
            cirkel1.radius = 5;
            cirkel1.getArea();

            Cirkle cirkel2 = new Cirkle();
            cirkel2.radius = 6;
            cirkel2.getArea();
        }
    }
    public class Cirkle
    {
        public float pi = 3.141f;
        public int radius;
        
        public Cirkle()
        {
        }
        public Cirkle(int _radius)
        {
            this.radius = _radius;
        }

        public void getArea()
        {
            float Area = radius * radius * pi;
            Console.WriteLine($"Din cirkel har arean {Area:F3}.");
        }
    }
}
