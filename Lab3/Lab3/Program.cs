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

            Vector v1 = new Vector(new int[] { 1, 2, 3 });
            Vector v2 = new Vector(new int[] { 1, 2 });

            Vector.Summ(v1, v2);
            Vector.Mult(v1, v2);

        }
    }
}
