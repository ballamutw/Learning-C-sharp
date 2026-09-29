using System.Runtime.InteropServices;

class Vector
{
    public static int TotalVectorsCount;
    public int[] IntArray;
    public int CountElements;
    public string State;
    
    //static constructor
    static Vector()
    {
        TotalVectorsCount = 0;
    }

    //constructor no params
    public Vector()
    {
        IntArray = new int[0];
        CountElements = 0;
        TotalVectorsCount++;
    }

    //constructor with params
    public Vector(int[] array)
    {
        IntArray = array;
        CountElements = array.Length;
        TotalVectorsCount++;
    }

    //constructor with default params
    public Vector(int size, int initialValue = 0)
    {
        IntArray = new int[size];
        CountElements = size;

        for (int i = 0; i < size; i++)
        {
            IntArray[i] = initialValue;
        }

        TotalVectorsCount++;
    }

    //private constructor
    private Vector(int[] readyArray, int size)
    {
        IntArray = readyArray;
        CountElements = size;
        TotalVectorsCount++;
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
            if (IntArray != null && index >= 0 && index < CountElements)
            {
                State = "OK";
                Console.WriteLine(State);
                return IntArray[index];
            }
            else
            {
                State = "Error: Index out of range";
                Console.WriteLine(State);
                return 0;
            }
        }
        set 
        {
            if (IntArray != null && index >= 0 && index < CountElements)
            {
                IntArray[index] = value;
                State = "OK";
                Console.WriteLine(State);
            }
            else
            {
                State = "Error: Index out of range!";
                Console.WriteLine(State);
            }
        }
    }
}