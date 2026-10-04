partial class Vector
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
        Console.WriteLine(_state);
        Console.WriteLine($"_totalVectorsCount: {_totalVectorsCount}");
    }

    //constructor no params
    public Vector()
    {
        _intArray = new int[0];
        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        _state = "No params constructor - OK";
        Console.WriteLine(_state);
        Console.WriteLine($"_totalVectorsCount: {_totalVectorsCount}");
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
        Console.WriteLine(_state);
        Console.WriteLine($"_totalVectorsCount: {_totalVectorsCount}");
    }

    //constructor with default params
    public Vector(int size, int initialValue = 0)
    {
        if (size <= MaxVectorSize)
        {
            _intArray = new int[size];
            _state = "Constructor with default params - OK";
            Console.WriteLine(_state);
        }
        else 
        {
            _intArray = new int[MaxVectorSize];
            _state = "Constructor with default params - Not OK (Out of range, Clamped)";
            Console.WriteLine(_state);
        }

        for (int i = 0; i < _intArray.Length; i++)
        {
            _intArray[i] = initialValue;
        }

        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        Console.WriteLine($"_totalVectorsCount: {_totalVectorsCount}");
    }

    //private constructor
    private Vector(int[] Array, bool IsPrivate)
    {
        _intArray = Array;
        _totalVectorsCount++;
        _id = _totalVectorsCount.GetHashCode();
        _state = "Private constructor - OK";
        Console.WriteLine(_state);
        Console.WriteLine($"_totalVectorsCount: {_totalVectorsCount}");
    }
}