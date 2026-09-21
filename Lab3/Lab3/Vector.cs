class Vector
{
    public int[] IntArray;
    public int CountElements;
    public string State;

    public Vector()
    {
        Console.WriteLine("vector1");
        IntArray = new int[0];
        CountElements = 0;
        State = "empty vector";
    }

    public Vector(int[] array)
    {
        Console.WriteLine("vector2");
        IntArray = array;
        CountElements = array.Length;
        State = "Created with array";
    }

    public Vector(int size, int initialValue = 0)
    {
        Console.WriteLine("vector3");
        IntArray = new int[size];
        CountElements = size;
        State = "created and initialized";

        for (int i = 0; i < size; i++)
        {
            IntArray[i] = initialValue;
        }
    }




}