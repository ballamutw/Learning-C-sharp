class Vector
{
    private static int _totalVectorsCount = 0;
    private static string _state = "OK";
    private readonly int _id;
    private int[] _intArray;
    public const int MaxVectorSize = 10000;

    public static int TotalVectorsCount
    {
        get { return _totalVectorsCount; }
        private set { _totalVectorsCount = value; }
    }
    public static string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public int Id
    {
        get { return _id; }
    }
    public int[] IntArray
    {
        get { return _intArray; }
        set { _intArray = value; }
    }

    //static constructor
    static Vector()
    {
        _totalVectorsCount = 0;
        _state = "OK";
    }

    //constructor no params
    public Vector()
    {
        _intArray = new int[0];
        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        _state = "No params constructor - OK";
    }

    //constructor with params
    public Vector(int[] array)
    {
        if (array.Length > MaxVectorSize)
        {
            _intArray = new int[MaxVectorSize];
            Array.Copy(array, _intArray, MaxVectorSize);
        }
        else
        {
            _intArray = array;
        }

        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        _state = "Constructor with params - OK";
    }

    //constructor with default params
    public Vector(int size, int initialValue = 0)
    {
        if (size <= MaxVectorSize)
        {
            _intArray = new int[size];
            _state = "Constructor with default params - OK";
        }
        else 
        {
            _intArray = new int[MaxVectorSize];
            _state = "Constructor with default params - Not OK (Out of range, Clamped)";
        }

        for (int i = 0; i < _intArray.Length; i++)
        {
            _intArray[i] = initialValue;
        }

        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
    }

    //private constructor
    private Vector(int[] readyArray, int size)
    {
        _intArray = readyArray;
        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        _state = "Private constructor - OK";
    }

    public static void Summ(Vector v1, Vector v2)
    {
        int MaxVectorLenght;
        int SmallVectorLenght;

        if (v1._intArray.Length >= v2._intArray.Length)
        {
            MaxVectorLenght = v1._intArray.Length;
            SmallVectorLenght = v2._intArray.Length;
        }
        else
        {
            MaxVectorLenght = v2._intArray.Length;
            SmallVectorLenght = v1._intArray.Length;
        }

        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1._intArray.Length ? v1[i] : 0;
            int val2 = i < v2._intArray.Length ? v2[i] : 0;

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

        if (v1._intArray.Length >= v2._intArray.Length)
        {
            MaxVectorLenght = v1._intArray.Length;
            SmallVectorLenght = v2._intArray.Length;
        }
        else
        {
            MaxVectorLenght = v2._intArray.Length;
            SmallVectorLenght = v1._intArray.Length;
        }

        int[] tempArray = new int[MaxVectorLenght];

        for (int i = 0; i < MaxVectorLenght; i++)
        {
            int val1 = i < v1._intArray.Length ? v1[i] : 0;
            int val2 = i < v2._intArray.Length ? v2[i] : 0;

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