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
        int vectorLenght;
        if (v1.IntArray.Length >= v2.IntArray.Length)
        {
            vectorLenght = v1.IntArray.Length;
        }
        else
        {
            vectorLenght = v2.IntArray.Length;
        }
        Vector newVector = new Vector(vectorLenght);

        for (int i = 0; i < vectorLenght; i++)
        {

            // нужно решить проблему с выходом за пределы массива и присвоением 0 через индексатор
            newVector[i] = v1[i] + v2[i];

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
                return IntArray[index];
            }
            else
            {
                State = "Error: Index out of range";
                return 0;
            }
        }
        set 
        {
            if (IntArray != null && index >= 0 && index < CountElements)
            {
                IntArray[index] = value;
                State = "OK";
            }
            else
            {
                State = "Error: Index out of range!";
            }
        }
    }
}