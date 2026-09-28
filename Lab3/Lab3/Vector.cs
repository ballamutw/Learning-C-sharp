using System.Numerics;

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
        State = "empty vector";
        TotalVectorsCount++;
    }

    //constructor with params
    public Vector(int[] array)
    {
        IntArray = array;
        CountElements = array.Length;
        State = "Created with array";
        TotalVectorsCount++;
    }

    //constructor with default params
    public Vector(int size, int initialValue = 0)
    {
        IntArray = new int[size];
        CountElements = size;
        State = "created and initialized";

        for (int i = 0; i < size; i++)
        {
            IntArray[i] = initialValue;
        }

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

        Vector newVector = new Vector(MaxVectorLenght);

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1.IntArray.Length ? v1[i] : 0;
            int val2 = i < v2.IntArray.Length ? v2[i] : 0;

            newVector[i] = val1 + val2;
        }
        for (int i = 0; i < MaxVectorLenght; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    //private constructor
    //private Vector(int size)
    //{

    //}

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