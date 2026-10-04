partial class Vector
{
    public static void Summ(Vector v1, Vector v2)
    {
        int MaxVectorLenght = (v1._intArray.Length >= v2._intArray.Length) ? v1._intArray.Length : v2._intArray.Length;
        int SmallVectorLenght = (v1._intArray.Length <= v2._intArray.Length) ? v1._intArray.Length : v2._intArray.Length;
        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1._intArray.Length ? v1[i] : 0;
            int val2 = i < v2._intArray.Length ? v2[i] : 0;
            tempArray[i] = val1 + val2;
        }

        Vector newVector = new Vector(tempArray, true);

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    public static void Summ(Vector v1, int value)
    {
        int[] tempArray = new int[v1._intArray.Length];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = v1[i] + value;
        }

        Vector newVector = new Vector(tempArray, true);

        for (int i = 0; i < tempArray.Length; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    public static void Mult(Vector v1, Vector v2)
    {
        int MaxVectorLenght = (v1._intArray.Length >= v2._intArray.Length) ? v1._intArray.Length : v2._intArray.Length;
        int SmallVectorLenght = (v1._intArray.Length <= v2._intArray.Length) ? v1._intArray.Length : v2._intArray.Length;
        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1._intArray.Length ? v1[i] : 0;
            int val2 = i < v2._intArray.Length ? v2[i] : 0;
            tempArray[i] = val1 * val2;
        }

        Vector newVector = new Vector(tempArray, true);

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    public static void Mult(Vector v1, int value)
    {
        int[] tempArray = new int[v1._intArray.Length];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = v1[i] * value;
        }

        Vector newVector = new Vector(tempArray, true);

        for (int i = 0; i < tempArray.Length; i++)
        {
            Console.WriteLine(newVector[i]);
        }
    }

    //TryTake
    public static void TakeElement(ref Vector v, int element, out int outElement)
    {
        outElement = 0;

        if (v._intArray == null || v._intArray.Length <= element || element < 0)
        {
            _state = "TryTake Error: null or out of range";
            return;
        }

        outElement = v._intArray[element];

        int[] tempArray = new int[v._intArray.Length - 1];


        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = (i < element) ? v._intArray[i] : v._intArray[i + 1];
            Console.WriteLine(tempArray[i]);
        }

        v = new Vector(tempArray, true);

        _state = "TryTake - OK";
        Console.WriteLine(_state);
    }

    public static void PrintClassInfo()
    {
        Console.WriteLine($"______________________________________________\n" +
                          $"Info about class Vector\n" +
                          $"Total vectors count: {_totalVectorsCount}\n" +
                          $"Сurrent state of the class: {_state}\n" +
                          $"______________________________________________");
    }

    //indexator
    public int this[int index]
    {
        get
        {
            if (_intArray != null && index >= 0 && index < _intArray.Length)
            {
                _state = "Get OK";
                Console.WriteLine(_state);
                return _intArray[index];
            }
            else
            {
                _state = "Get Error: Index out of range";
                Console.WriteLine(_state);
                return 0;
            }
        }
        set
        {
            if (_intArray != null && index >= 0 && index < _intArray.Length)
            {
                _intArray[index] = value;
                _state = "Set OK";
                Console.WriteLine(_state);
            }
            else
            {
                _state = "Set Error: Index out of range!";
                Console.WriteLine(_state);
            }
        }
    }
}