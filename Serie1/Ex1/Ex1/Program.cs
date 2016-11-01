using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        Point3D point;
       
        public Program(float x, float y, float z)
        {
            point = new Point3D(x, y, z);
            // Console.WriteLine(x+"sdfsdf "+ y+" "+ z);
            displayPoint(point);
        }

        public static void displayPoint(Point3D pts)
        {
            Console.WriteLine("["+pts.x + "," + pts.y + "," + pts.z+"]");
        }
        public static void swapPoints(ref Point3D pt1, ref Point3D pt2)
        {
            Point3D tmpPoints = pt1;
            pt1 = pt2;
            pt2 = tmpPoints;
        }

        public struct Point3D
        {
            public float x;
            public float y;
            public float z;
            public Point3D(float posX,float posY, float posZ)
            {
                this.x = posX;
                this.y = posY;
                this.z = posZ;
            }
            public float distanceToOrigin()
            {
                return ((float)Math.Sqrt((float)(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2))));
            }
        }
        static void Main(string[] args)
        {
            Point3D pt1 = new Point3D(1, 0, 0);
            Point3D pt2 = new Point3D(2, 2, 2);
            displayPoint(pt1);
            displayPoint(pt2);
            
            Console.WriteLine("dist to 0 pt1:"+pt1.distanceToOrigin());
            Console.WriteLine("dist to 0 pt2:"+pt2.distanceToOrigin());

            Console.WriteLine("Swap points");

            swapPoints(ref pt1, ref pt2);

            displayPoint(pt1);
            displayPoint(pt2);
            
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
