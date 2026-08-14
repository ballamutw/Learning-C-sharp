using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            bool mainRunning = true;
            while (mainRunning)
            {
                try
                {
                    char switch_Task;
                    Console.WriteLine("Select a task (1, 2, 3, 4):");
                    switch_Task = Convert.ToChar(Console.ReadLine());

                    switch (switch_Task)
                    {

                        case '1':
                            Task1();

                            break;

                        case '2':
                            Task2();

                            break;

                        case '3':
                            Task3();

                            break;

                        case '4':
                            //Task4();

                            break;

                        default:
                            ReturnToBackForDefault();
                            break;
                    }
                }
                catch (Exception)
                {
                    ReturnToBackForCatch();
                }
            }
        }
                
        static void Task1()
        {
            Console.WriteLine("Types: \n");

            bool taskRunning = true;
            while (taskRunning)
            {
                try
                {
                    char switch_Task;
                    Console.WriteLine("Select a task (a, b, c, d, e, f): \n");
                    switch_Task = Convert.ToChar(Console.ReadLine());

                    switch (switch_Task)
                    {
                        case 'a':
                            string switch_Case_a;

                            Console.WriteLine("Select type:\n" +
                                "1 - bool\n" +
                                "2 - byte\n" +
                                "3 - sbyte\n" +
                                "4 - short\n" +
                                "5 - ushort\n" +
                                "6 - int\n" +
                                "7 - uint\n" +
                                "8 - long\n" +
                                "9 - ulong\n" +
                                "10 - float\n" +
                                "11 - double\n" +
                                "12 - decimal\n" +
                                "13 - char\n" +
                                "14 - nint\n" +
                                "15 - nuint\n");

                            switch_Case_a = Console.ReadLine();
                            switch (switch_Case_a)
                            {
                                case "1":
                                    // System.Boolean
                                    // bool == true, false, 0, 1.

                                    bool alive = true;
                                    bool isDead = false;

                                    Console.WriteLine($"Writing a bool variable before entering a value: alive: {alive}, isDead: {isDead}.");
                                    Console.Write("Enter value alive and is Dead (True or False): \n");

                                    alive = Convert.ToBoolean(Console.ReadLine());
                                    isDead = Convert.ToBoolean(Console.ReadLine());

                                    Console.WriteLine($"Writing a bool variable after entering a value: alive: {alive}, isDead: {isDead}.");

                                    break;

                                case "2":
                                    //System.Byte 1 byte
                                    //byte == [0; 255]

                                    byte bit1 = 1;
                                    byte bit2 = 102;

                                    Console.WriteLine($"Writing a byte variable before entering a value: bit1: {bit1}, bit2: {bit2}.");
                                    Console.Write("Enter value bit1 and bit2 ([0; 255]): \n");

                                    bit1 = Convert.ToByte(Console.ReadLine());
                                    bit2 = Convert.ToByte(Console.ReadLine());

                                    Console.WriteLine($"Writing a byte variable after entering a value: bit1: {bit1}, bit2: {bit2}.");

                                    break;

                                case "3":
                                    //System.SByte 1 byte
                                    //sbyte == [-128; 127]

                                    sbyte sbit1 = -10;
                                    sbyte sbit2 = 122;

                                    Console.WriteLine($"Writing a sbyte variable before entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");
                                    Console.Write("Enter value sbit1 and sbit2 ([-128; 127]): \n");

                                    sbit1 = Convert.ToSByte(Console.ReadLine());
                                    sbit2 = Convert.ToSByte(Console.ReadLine());

                                    Console.WriteLine($"Writing a sbyte variable after entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");

                                    break;

                                case "4":
                                    //System.Int16 2 byte
                                    //short == [-32768; 32767]

                                    short short1 = 1;
                                    short short2 = 102;

                                    Console.WriteLine($"Writing a short variable before entering a value: short1: {short1}, short2: {short2}.");
                                    Console.Write("Enter value short1 and short2 ([-32768; 32767]): \n");

                                    short1 = Convert.ToInt16(Console.ReadLine());
                                    short2 = Convert.ToInt16(Console.ReadLine());

                                    Console.WriteLine($"Writing a short variable after entering a value: short1: {short1}, short2: {short2}.");

                                    break;

                                case "5":
                                    //System.UInt16 2 byte
                                    //ushort == [0;655350]

                                    ushort ushort1 = 111;
                                    ushort ushort2 = 1012;

                                    Console.WriteLine($"Writing a ushort variable before entering a value: ushort1: {ushort1}, ushort2: {ushort2}.");
                                    Console.Write("Enter value ushort1 and ushort2 ([0;655350]): \n");

                                    ushort1 = Convert.ToUInt16(Console.ReadLine());
                                    ushort2 = Convert.ToUInt16(Console.ReadLine());

                                    Console.WriteLine($"Writing a ushort variable after entering a value: ushort1: {ushort1}, ushort2: {ushort2}.");

                                    break;

                                case "6":
                                    //System.Int32 4 byte
                                    //int == [-2147483648;2147483647]

                                    int inta = 10;
                                    int intb = 0b101;
                                    int intc = 0xFF;

                                    Console.WriteLine($"Writing a int variable before entering a value: inta: {inta}, intb: {intb}, intc: {intc}.");
                                    Console.Write("Enter value inta in decimal form, intb in binary form and intc in hexadecimal form [-2147483648;2147483647] \n" +
                                                    "decimal form - 123, 4123, 124213 \n" +
                                                    "binary form - 0b101: \n" +
                                                    "hexadecimal form - 0xFF \n");

                                    inta = Convert.ToInt32(Console.ReadLine());
                                    intb = Convert.ToInt32(Console.ReadLine(), 2);
                                    intc = Convert.ToInt32(Console.ReadLine(), 16);

                                    Console.WriteLine($"Writing a int variable after entering a value: inta: {inta}, intb: {intb}, intc: {intc}.");

                                    break;

                                case "7":
                                    //System.UInt32 4 byte
                                    //uint == [0;4294967295]

                                    uint uinta = 10;
                                    uint uintb = 0b101;
                                    uint uintc = 0xFF;

                                    Console.WriteLine($"Writing a uint variable before entering a value: uinta: {uinta}, uintb: {uintb}, uintc: {uintc}.");
                                    Console.Write("Enter value uinta in decimal form, uinta in binary form and uinta in hexadecimal form [0;4294967295] \n" +
                                                    "decimal form - 123, 4123, 124213 \n" +
                                                    "binary form - 101: \n" +
                                                    "hexadecimal form - 0xFF \n");

                                    uinta = Convert.ToUInt32(Console.ReadLine());
                                    uintb = Convert.ToUInt32(Console.ReadLine(), 2);
                                    uintc = Convert.ToUInt32(Console.ReadLine(), 16);

                                    Console.WriteLine($"Writing a uint variable after entering a value: uinta: {uinta}, uintb: {uintb}, uintc: {uintc}.");

                                    break;

                                case "8":
                                    //System.Int64 8 byte
                                    //long == [–9 223 372 036 854 775 808; 9 223 372 036 854 775 807]

                                    long la = -10;
                                    long lb = 0b101;
                                    long lc = 0xFF;

                                    Console.WriteLine($"Writing a long variable before entering a value: la: {la}, lb: {lb}, lc: {lc}.");
                                    Console.Write("Enter value la in decimal form, lb in binary form and lc in hexadecimal form [–9 223 372 036 854 775 808; 9 223 372 036 854 775 807] \n" +
                                                    "decimal form - 123, 4123, 124213 \n" +
                                                    "binary form - 101: \n" +
                                                    "hexadecimal form - 0xFF \n");

                                    la = Convert.ToInt64(Console.ReadLine());
                                    lb = Convert.ToInt64(Console.ReadLine(), 2);
                                    lc = Convert.ToInt64(Console.ReadLine(), 16);

                                    Console.WriteLine($"Writing a long variable after entering a value: long la: {la}, long lb: {lb}, long lc: {lc}.");

                                    break;

                                case "9":
                                    //System.UInt64 8 byte
                                    //ulong == [0; 18 446 744 073 709 551 615]

                                    ulong ula = 10;
                                    ulong ulb = 0b101;
                                    ulong ulc = 0xFF;

                                    Console.WriteLine($"Writing a ulong variable before entering a value: ula: {ula}, ulb: {ulb}, ulc: {ulc}.");
                                    Console.Write("Enter value ula in decimal form, ulb in binary form and ulc in hexadecimal form [0; 18 446 744 073 709 551 615] \n" +
                                                    "decimal form - 123, 4123, 124213 \n" +
                                                    "binary form - 101: \n" +
                                                    "hexadecimal form - 0xFF \n");

                                    ula = Convert.ToUInt64(Console.ReadLine());
                                    ulb = Convert.ToUInt64(Console.ReadLine(), 2);
                                    ulc = Convert.ToUInt64(Console.ReadLine(), 16);

                                    Console.WriteLine($"Writing a ulong variable after entering a value: ula: {ula}, ulb: {ulb}, ulc: {ulc}.");

                                    break;

                                case "10":
                                    //System.Single 4 byte
                                    //float == [-3.4*10^38; 3.4*10^38]

                                    float floata = 10;

                                    Console.WriteLine($"Writing a float variable before entering a value: floata: {floata}.");
                                    Console.Write("Enter value floata [-3,4*10^38; 3,4*10^38]: \n");

                                    floata = Convert.ToSingle(Console.ReadLine());

                                    Console.WriteLine($"Writing a float variable after entering a value: floata: {floata}.");

                                    break;

                                case "11":
                                    //System.Double 8 byte
                                    //double == [±5,0*10^-324; ±1,7*10^308]

                                    double doublea = 10;

                                    Console.WriteLine($"Writing a double variable before entering a value: doublea: {doublea}.");
                                    Console.Write("Enter value doublea [±5,0*10^-324; ±1,7*10^308]: \n");

                                    doublea = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine($"Writing a double variable after entering a value: doublea: {doublea}.");

                                    break;

                                case "12":
                                    //System.Decimal 16 byte
                                    //decimal == [±1.0*10^-28; ±7.9228*10^28]

                                    decimal decimala = 10;

                                    Console.WriteLine($"Writing a decimal variable before entering a value: decimala: {decimala}.");
                                    Console.Write("Enter value decimala [±1.0*10^-28; ±7.9228*10^28]: \n");

                                    decimala = Convert.ToDecimal(Console.ReadLine());

                                    Console.WriteLine($"Writing a decimal variable after entering a value: decimala: {decimala}.");

                                    break;

                                case "13":
                                    //System.Char 2 byte
                                    //char == 1 symbol

                                    char chara = 'A';
                                    char charb = '\x5A';
                                    char charc = '\u0420';

                                    Console.WriteLine($"Writing a char variable before entering a value: chara: {chara}, charb: {charb}, charc: {charc}");
                                    Console.Write("Enter value char ('A', '\x5A', '\u0420'): \n");

                                    chara = Convert.ToChar(Console.ReadLine());
                                    charb = Convert.ToChar(Console.ReadLine());
                                    charc = Convert.ToChar(Console.ReadLine());

                                    Console.WriteLine($"Writing a char variable after entering a value: chara: {chara}, charb: {charb}, charc: {charc}");

                                    break;

                                case "14":
                                    //System.IntPtr
                                    //output when run in a 64-bit process == 8 byte
                                    //nint.MinValue = -9223372036854775808
                                    //nint.MaxValue = 9223372036854775807

                                    //output when run in a 32-bit process == 4 byte
                                    //nint.MinValue = -2147483648
                                    //nint.MaxValue = 2147483647

                                    nint ninta = 0;

                                    Console.WriteLine($"Writing a ninta variable before entering a value: ninta: {ninta}.");
                                    Console.Write("Enter value ninta \n" +
                                                    "x64 - [-9223372036854775808; 9223372036854775807]\n" +
                                                    "x86 - [-2147483648; 2147483647]:\n");

                                    ninta = nint.Parse(Console.ReadLine());

                                    Console.WriteLine($"Writing a ninta variable after entering a value: ninta: {ninta}.");

                                    break;

                                case "15":
                                    //System.UIntPtr
                                    //output when run in a 64-bit process == 8 byte
                                    //nuint.MinValue = 0
                                    //nuint.MaxValue = 18446744073709551615

                                    //output when run in a 32-bit process == 4 byte
                                    //nuint.MinValue = 0
                                    //nuint.MaxValue = 4294967295
                                    nuint nuinta = 0;


                                    Console.WriteLine($"Writing a nuint variable before entering a value: nuinta: {nuinta}.");
                                    Console.Write("Enter value nuinta \n" +
                                                    "x64 - [-0; 18446744073709551615]\n" +
                                                    "x86 - [-0; 4294967295]:\n");

                                    ninta = nint.Parse(Console.ReadLine());


                                    Console.WriteLine($"Writing a nuint variable after entering a value: nuinta: {nuinta}.");

                                    break;

                                default:
                                    ReturnToBackForDefault();
                                    break;
                            }

                            break;

                        case 'b':
                            char switch_Case_b;

                            Console.WriteLine("Select Conversions:\n" +
                                                "1 - Implicit Conversion\n" +
                                                "2 - Explicit Conversion\n");

                            switch_Case_b = Convert.ToChar(Console.ReadLine());
                            switch (switch_Case_b)
                            {
                                case '1':

                                    //Implicit Conversions

                                    //Safe Widening

                                    int smallNumber = 42;
                                    Console.WriteLine("Implicit Conversions:\n" +
                                                        "Safe Widening:\n" +
                                                        $"int smallNumber = {smallNumber}\n" +
                                                        $"smallNumber {smallNumber} = {smallNumber.GetType()}");

                                    long bigNumber = smallNumber;
                                    Console.WriteLine($"long bigNumber = smallNumber;\n" +
                                                        $"smallNumber {smallNumber} = {smallNumber.GetType()}\n" +
                                                        $"bigNumber {bigNumber} = {bigNumber.GetType()}\n" +
                                                        $"_______________________________________________");

                                    //Upcasting

                                    string text = "Hi!";
                                    Console.WriteLine("Upcasting:\n" +
                                                        $"string text = {text}\n" +
                                                        $"text {text} = {text.GetType()}");

                                    object obj = text;
                                    Console.WriteLine("object obj = text\n" +
                                                        $"string text = {text}\n" +
                                                        $"obj {obj} = {obj.GetType()}\n" +
                                                        $"_______________________________________________");

                                    //Literal Conversions

                                    byte safeByte = 150;
                                    Console.WriteLine("Literal Conversions:\n" +
                                                        $"byte safeByte = {safeByte};\n" +
                                                        $"safeByte: {safeByte.GetType()}\n" +
                                                        $"_______________________________________________");

                                    //Nullable Conversions
                                    int normalValue = 42;

                                    Console.WriteLine("Nullable Conversions:\n" +
                                                        $"int normalValue = {normalValue};\n" +
                                                        $"normalValue: {normalValue.GetType()}\n");

                                    int? nullableValue = null;
                                    Console.WriteLine("int? nullableValue = normalValue\n" +
                                                        $"normalValue = {normalValue.GetType()}\n" +
                                                        $"nullableValue = {nullableValue.HasValue}\n" +
                                                        $"_______________________________________________");

                                    //Tuple  Conversions

                                    (int id, string name) user = (1, "Иван");
                                    (double id, object name) looseUser = user;
                                    Console.WriteLine("Tuple  Conversions:\n" +
                                                        $"(int id, string name) user = (1, \"Иван\");\n" +
                                                        $"(double id, object name) looseUser = user;\n" +
                                                        $"(user.id: {user.id.GetType()}, user.name: {user.name.GetType()}\n" +
                                                        $"(looseUser.id: {looseUser.id.GetType()}, looseUser.name: {looseUser.name.GetType()}\n" +
                                                        $"_______________________________________________");

                                    break;

                                case '2':

                                    //Explicit Conversion

                                    //Numeric Conversions

                                    long bigValue = 300;
                                    Console.WriteLine($"Numeric Conversions:" +
                                                        $"convert long to byte\n" +
                                                        $"long bigValue = 300;\n" +
                                                        $"bigValue: {bigValue}, Type {bigValue.GetType()}\n");

                                    byte smallValue = (byte)bigValue;
                                    Console.WriteLine($"byte smallValue = (byte)bigValue;\n" +
                                                        $"smallValue: {smallValue}, Type {smallValue.GetType()}\n");


                                    double pi = 3.14159;
                                    Console.WriteLine($"convert double to int\n" +
                                                        $"double pi = 3.14159;\n" +
                                                        $"pi: {pi}, Type {pi.GetType()}\n");

                                    int integerPi = (int)pi;
                                    Console.WriteLine($"int integerPi = (int)pi;\n" +
                                                        $"integerPi: {integerPi}, Type {integerPi.GetType()}\n" +
                                                        $"_______________________________________________");

                                    //Nullable Conversions

                                    int? nullableScore = 99;
                                    int regularScore = (int)nullableScore;

                                    int? nullValue = null;
                                    //int brokenScore = (int)nullValue; 
                                    Console.WriteLine($"int? nullableScore = 99;\n" +
                                                        $"int regularScore = (int)nullableScore\n" +
                                                        $"its works because there is a number inside\n" +
                                                        $"int? nullValue = null;\n" +
                                                        $"int brokenScore = (int)nullValue;\n" +
                                                        $"if the variable was indeed null, an explicit cast will throw an InvalidOperationException.\n" +
                                                        $"_______________________________________________");

                                    //Tuple Conversions

                                    (double x, double y) coordinates = (10.5, 20.9);
                                    (int x, int y) intCoordinates = ((int)coordinates.x, (int)coordinates.y);

                                    Console.WriteLine("Tuple  Conversions:\n" +
                                                        $"(double x, double y) coordinates = (10.5, 20.9);\n" +
                                                        $"(int x, int y) intCoordinates = ((int)coordinates.x, (int)coordinates.y);\n" +
                                                        $"(coordinates.x: {coordinates.x.GetType()}, (coordinates.y: {coordinates.y.GetType()}\n" +
                                                        $"(intCoordinates.x: {intCoordinates.x.GetType()}, (intCoordinates.y: {intCoordinates.y.GetType()}\n" +
                                                        $"_______________________________________________");

                                    break;

                                default:
                                    ReturnToBackForDefault();
                                    break;
                            }

                            break;

                        case 'c':

                            //boxing and unboxing
                            Console.WriteLine("boxing and unboxing:");

                            int number = 42;
                            object boxed = number;
                            Console.WriteLine("boxing:\n" +
                                                "int number = 42;\n" +
                                                "object boxed = number;\n");

                            int unboxed = (int)boxed;

                            Console.WriteLine("unboxing:\n" +
                                                "int unboxed = (int)boxed;\n");

                            break;

                        case 'd':

                            //implicitly typed variable
                            var age = 25;
                            var name = "Алексей";
                            var varPi = 3.14159;
                            Console.WriteLine($"var age = 25;\n" +
                                                $"var name = \"Алексей\";\n" +
                                                $"var varPi = 3.14159;\n" +
                                                $"age: {age}, Type: {age.GetType()}\n" +
                                                $"name: {name}, Type: {name.GetType()}\n" +
                                                $"varPi: {varPi}, Type: {varPi.GetType()}");

                            break;

                        case 'e':

                            //work with Nullable variable

                            int? val = null;
                            Console.WriteLine("work with Nullable variable\n" +
                                                "int? val = null;\n" +
                                                $"IsNull(val);");
                            IsNull(val);
                            val = 22;
                            Console.WriteLine("IsNull(val);");
                            IsNull(val);

                            void IsNull(int? obj)
                            {
                                if (obj == null) Console.WriteLine("null");
                                else Console.WriteLine(obj);
                            }

                            break;

                        case 'f':

                            //redefining an implicitly variable

                            var integerVariable = 1;
                            //integerVariable = "qw";
                            Console.WriteLine("var integerVariable = 1;\r\n" +
                                                "integerVariable = \"qw\";\n" +
                                                "var determines the type at the first initialization, so reassigning " +
                                                "a value of a different type to such a variable will cause an error.");

                            break;

                        default:
                            ReturnToBackForDefault();
                            break;
                    }
                }
                catch (Exception)
                {
                    ReturnToBackForCatch();
                }
            }
        }

        static void Task2()
        {
            Console.WriteLine("Strings: \n");

            bool taskRunning = true;
            while (taskRunning)
            {
                try
                {
                    char switch_Task;
                    Console.WriteLine("Select a task (a, b, c, d): \n");
                    switch_Task = Convert.ToChar(Console.ReadLine());

                    switch (switch_Task)
                    {
                        case 'a':
                            //System.String
                            //string == (Type Handle == 8 byte + Sync Block Index == 8 byte + Length == 4 byte + symbols == (2 * N)byte(s) + \0 == 2 byte)

                            string hello = "Hello";
                            string hello1 = "Hello";
                            string word = "world";

                            Console.WriteLine("string hello = \"Hello\";\n" +
                                                "string hello1 = \"Hello\";\n" +
                                                "string word = \"world\";\n" +
                                                $"hello == hello1: {hello == hello1}\n" +
                                                $"hello == word: {hello == word}\n" +
                                                $"hello == hello1: {hello == hello1}");

                            break;

                        case 'b':

                            string str1 = "Hello1";
                            string str2 = "Hello2";
                            string str3 = "Hello3";

                            string Concate = str1 + str2;

                            string original = "text";
                            string copy = original;
                            string deepCopy = (string)original.Clone();

                            string sentence = "C# its a cool language";
                            string[] words = sentence.Split(' ');


                            Console.WriteLine("string str1 = \"Hello1\";\n" +
                                                "string str2 = \"Hello2\";\n" +
                                                "string str3 = \"Hello3\";\n" +
                                                "_______________________________________________\n" +
                                                $"Concatenation:\n" +
                                                $"Concate = string.Concat(str1, str2): " +
                                                $"{Concate = string.Concat(str1, str2)}\n" +
                                                $"string Concate = str1 + str2;\n" +
                                                $"str1 + str2 = {Concate}\n" +
                                                "_______________________________________________\n" +
                                                $"Copy:\n" +
                                                $"string original = \"text\";\n" +
                                                $"{original}\n" +
                                                $"{copy.AsMemory()}\n" +
                                                $"string copy = original; (copy link)\n" +
                                                $"string deepCopy = (string)original.Clone(); (create duplicate object)\n" +
                                                "_______________________________________________\n" +
                                                $"Split:\n" +
                                                $"string sentence = \"C# its a cool language\";\n" +
                                                $"string[] words = sentence.Split(' ');\n");

                            for (int i = 0; i < words.Length; i++)
                            {
                                Console.Write($"{words[i]}");
                            }

                            string baseText = "I lern";
                            string updated = baseText.Insert(6, " C#");

                            string source = "dad is dead";
                            string clean1 = source.Remove(7, 4);

                            Console.WriteLine("_______________________________________________\n" +
                                                "Insert:\n" +
                                                $"string baseText = \"I lern\";\n" +
                                                $"string updated = baseText.Insert(6, \" C#\");\n" +
                                                $"{updated}\n" +
                                                "_______________________________________________\n" +
                                                $"Remove:\n" +
                                                $"string source = \"dad is dead\";\n" +
                                                $"{source}\n" +
                                                $"string clean1 = source.Remove(10, 6);\n" +
                                                $"{clean1}\n");

                            break;

                        case 'c':

                            string nullStr = null;
                            string notNullStr = "not null";
                            string voidStr = "";
                            Console.WriteLine($"IsNullOrEmpty\n" +
                                                $"string nullStr = null;\n" +
                                                $"string notNullStr = \"not null\";\n" +
                                                $"string voidStr = \"\";");

                            bool result;
                            result = string.IsNullOrEmpty(nullStr);
                            Console.WriteLine($"nullStr: {result}");
                            result = string.IsNullOrEmpty(notNullStr);
                            Console.WriteLine($"notNullStr: {result}");
                            result = string.IsNullOrEmpty(voidStr);
                            Console.WriteLine($"voidStr: {result}");

                            break;

                        case 'd':
                            //StringBuilder == System.Text.StringBuilder

                            StringBuilder sb = new StringBuilder("Hello");

                            sb.Append(" World");
                            Console.WriteLine(sb);
                            sb.Remove(0, 6);
                            Console.WriteLine(sb);
                            sb.Insert(0, "Good Bye ");
                            Console.WriteLine(sb);

                            break;

                        default:
                            ReturnToBackForDefault();
                            break;

                    }
                }
                catch (Exception)
                {
                    ReturnToBackForCatch();
                }
            }
        }

        static void Task3()
        {
            Console.WriteLine("Arrays: \n");

            bool taskRunning = true;
            while (taskRunning)
            {
                try
                {
                    char switch_Task;
                    Console.WriteLine("Select a task (a, b, c, d): \n");
                    switch_Task = Convert.ToChar(Console.ReadLine());

                    switch (switch_Task)
                    {
                        case 'a':

                            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
                            int rows = nums2.GetUpperBound(0) + 1;
                            int columns = nums2.Length / rows;

                            Console.WriteLine($"Rows: {rows}, Columns: {columns}");

                            for (int i = 0; i < rows; i++)
                            {
                                for (int j = 0; j < columns; j++)
                                {
                                    Console.Write($"{nums2[i, j]} ");
                                }
                                Console.WriteLine();    
                            }

                            break;

                        case 'b':

                            string[] stringArr = { "123", "32" } ;

                            for (int i = 0; i < stringArr.Length; i++)
                            {
                                Console.Write($"{stringArr[i]} ");
                            }

                            Console.WriteLine($"\nArray lenght: {stringArr.Length}");

                            int elementOfArray;

                            bool flagOfTrueLenght = true;
                            while (flagOfTrueLenght)
                            {
                                Console.WriteLine("Select element of array for update:");
                                elementOfArray = Convert.ToInt16(Console.ReadLine());
                                if (stringArr.Length < elementOfArray)
                                {
                                    Console.WriteLine("Your position incorrect, try again");
                                }
                                else
                                {
                                    Console.WriteLine("Write value element of array for update:");
                                    string elementOfValue = Console.ReadLine();

                                    for (int i = 0; i < stringArr.Length; i++)
                                    {
                                        if (i == elementOfArray - 1)
                                        {
                                            stringArr[i] = elementOfValue;
                                        }
                                    }

                                    Console.WriteLine("Array after update:\n");
                                    for (int i = 0; i < stringArr.Length; i++)
                                    {
                                        Console.Write($"{stringArr[i]} ");
                                    }
                                    Console.WriteLine();

                                    flagOfTrueLenght = false;
                                }
                            }

                            break;
                        case 'c':



                            break;
                        case 'd':



                            break;

                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    ReturnToBackForCatch();
                }
            }
        }

        static void Task4()
        {
            Console.WriteLine("Typles: \n");

            bool taskRunning = true;
            while (taskRunning)
            {
                try
                {
                    char switch_Task;
                    Console.WriteLine("Select a task (a, b, c, d): \n");
                    switch_Task = Convert.ToChar(Console.ReadLine());

                    switch (switch_Task)
                    {
                        case 'a':



                            break;
                        case 'b':



                            break;
                        case 'c':



                            break;
                        case 'd':



                            break;

                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    ReturnToBackForCatch();
                }
            }
        }

        static void ReturnToBackForCatch()
        {
            Console.WriteLine("Incorrect value!\n" +
                                "\"Press any key for continue\"");
            Console.ReadLine();
        }

        static void ReturnToBackForDefault()
        {
            Console.WriteLine("Incorrect value!\n" +
                                "\"Press any key for continue\"");
            Console.ReadLine();
        }
    }
}

