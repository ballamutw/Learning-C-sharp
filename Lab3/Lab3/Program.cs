using System.Runtime.InteropServices;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vector vector1 = new Vector();

            //Vector vector2 = new Vector(new int[] { 1, 2, 3 });

            //Vector vector3 = new Vector(10, 4);

            //Vector v1 = new Vector(new int[] { 1, 2, 3 });
            //Vector v2 = new Vector(new int[] { 1, 2 });

            //Vector.Summ(v1, v2);
            //Vector.Summ(v1, 2);
            //Vector.Mult(v1, v2);
            //Vector.Mult(v1, 2);
            Vector v = new Vector(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

            Vector.TakeElement(ref v, 5, out int outElement);
            Vector.PrintClassInfo();
        }
    }
}
