using System.Runtime.InteropServices;

class Vector
{
    public static int TotalVectorsCount;
    public static string State;
    public readonly int Id;
    public const int MaxVectorSize = 10000;
    public int[] IntArray;
    
    //static constructor
    static Vector()
    {
        State = "OK";
        TotalVectorsCount = 0;
    }

    //constructor no params
    public Vector()
    {
        IntArray = new int[0];
        TotalVectorsCount++;
        Id = TotalVectorsCount.GetHashCode();
    }

    //constructor with params
    public Vector(int[] array)
    {
        IntArray = array;
        TotalVectorsCount++;
        Id = TotalVectorsCount.GetHashCode();
    }

    //constructor with default params
    public Vector(int size, int initialValue = 0)
    {
        IntArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            IntArray[i] = initialValue;
        }

        TotalVectorsCount++;
        Id = TotalVectorsCount.GetHashCode();
    }

    //private constructor
    private Vector(int[] readyArray, int size)
    {
        IntArray = readyArray;
        TotalVectorsCount++;
        Id = TotalVectorsCount.GetHashCode();
    }

    public static void Summ(Vector v1, Vector v2)
    {
        int MaxVectorLenght;
        int SmallVectorLenght;

        if (v1.IntArray.Length >= v2.IntArray.Length)
        {
            MaxVectorLenght = v1.IntArray.Length;
            SmallVectorLenght = v2.IntArray.Length;
        }
        else
        {
            MaxVectorLenght = v2.IntArray.Length;
            SmallVectorLenght = v1.IntArray.Length;
        }

        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1.IntArray.Length ? v1[i] : 0;
            int val2 = i < v2.IntArray.Length ? v2[i] : 0;

            tempArray[i] = val1 + val2;
        }

        Vector newVector = new Vector(tempArray, MaxVectorLenght);

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    public static void Mult(Vector v1, Vector v2)
    {
        int MaxVectorLenght;
        int SmallVectorLenght;

        if (v1.IntArray.Length >= v2.IntArray.Length)
        {
            MaxVectorLenght = v1.IntArray.Length;
            SmallVectorLenght = v2.IntArray.Length;
        }
        else
        {
            MaxVectorLenght = v2.IntArray.Length;
            SmallVectorLenght = v1.IntArray.Length;
        }

        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1.IntArray.Length ? v1[i] : 0;
            int val2 = i < v2.IntArray.Length ? v2[i] : 0;

            tempArray[i] = val1 * val2;
        }

        Vector newVector = new Vector(tempArray, MaxVectorLenght);

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    //indexator
    public int this[int index]
    {
        get 
        {
            if (IntArray != null && index >= 0 && index < IntArray.Length)
            {
                State = "Get OK";
                Console.WriteLine(State);
                return IntArray[index];
            }
            else
            {
                State = "Get Error: Index out of range";
                Console.WriteLine(State);
                return 0;
            }
        }
        set 
        {
            if (IntArray != null && index >= 0 && index < IntArray.Length)
            {
                IntArray[index] = value;
                State = "Set OK";
                Console.WriteLine(State);
            }
            else
            {
                State = "Set Error: Index out of range!";
                Console.WriteLine(State);
            }
        }
    }
}