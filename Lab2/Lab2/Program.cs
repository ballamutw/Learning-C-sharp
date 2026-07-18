namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            void Task1()
            {
                // System.Boolean
                // bool == true, false, 0, 1.

                bool alive = true;
                bool isDead = false;

                Console.WriteLine($"Writing a bool variable before entering a value: alive: {alive}, isDead: {isDead}.");
                Console.Write("Enter value alive and is Dead (True or False): \n");

                alive = Convert.ToBoolean(Console.ReadLine());
                isDead = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"Writing a bool variable after entering a value: alive: {alive}, isDead: {isDead}.");

                //System.Byte 1 byte
                //byte == [0; 255]

                byte bit1 = 1;
                byte bit2 = 102;

                Console.WriteLine($"Writing a byte variable before entering a value: bit1: {bit1}, bit2: {bit2}.");
                Console.Write("Enter value bit1 and bit2 ([0; 255]): \n");

                bit1 = Convert.ToByte(Console.ReadLine());
                bit2 = Convert.ToByte(Console.ReadLine());

                Console.WriteLine($"Writing a byte variable after entering a value: bit1: {bit1}, bit2: {bit2}.");

                //System.SByte 1 byte
                //sbyte == [-128; 127]

                sbyte sbit1 = -10;
                sbyte sbit2 = 122;

                Console.WriteLine($"Writing a sbyte variable before entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");
                Console.Write("Enter value sbit1 and sbit2 ([-128; 127]): \n");

                sbit1 = Convert.ToSByte(Console.ReadLine());
                sbit2 = Convert.ToSByte(Console.ReadLine());

                Console.WriteLine($"Writing a sbyte variable after entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");

                //System.Int16 2 byte
                //short == [-32768; 32767]

                short short1 = 1;
                short short2 = 102;

                Console.WriteLine($"Writing a short variable before entering a value: short1: {short1}, short2: {short2}.");
                Console.Write("Enter value short1 and short2 ([-32768; 32767]): \n");

                short1 = Convert.ToInt16(Console.ReadLine());
                short2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"Writing a short variable after entering a value: short1: {short1}, short2: {short2}.");

                //System.UInt16 2 byte
                //ushort == [0;655350]

                ushort ushort1 = 111;
                ushort ushort2 = 1012;

                Console.WriteLine($"Writing a ushort variable before entering a value: ushort1: {ushort1}, ushort2: {ushort2}.");
                Console.Write("Enter value ushort1 and ushort2 ([0;655350]): \n");

                ushort1 = Convert.ToUInt16(Console.ReadLine());
                ushort2 = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine($"Writing a ushort variable after entering a value: ushort1: {ushort1}, ushort2: {ushort2}.");

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

                //System.Single 4 byte
                //float == [-3.4*10^38; 3.4*10^38]

                float floata = 10;

                Console.WriteLine($"Writing a float variable before entering a value: floata: {floata}.");
                Console.Write("Enter value floata [-3,4*10^38; 3,4*10^38]: \n");

                floata = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"Writing a float variable after entering a value: floata: {floata}.");

                //System.Double 8 byte
                //double == [±5,0*10^-324; ±1,7*10^308]

                double doublea = 10;

                Console.WriteLine($"Writing a double variable before entering a value: doublea: {doublea}.");
                Console.Write("Enter value doublea [±5,0*10^-324; ±1,7*10^308]: \n");

                doublea = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Writing a double variable after entering a value: doublea: {doublea}.");

                //System.Decimal 16 byte
                //decimal == [±1.0*10^-28; ±7.9228*10^28]

                decimal decimala = 10;

                Console.WriteLine($"Writing a decimal variable before entering a value: decimala: {decimala}.");
                Console.Write("Enter value decimala [±1.0*10^-28; ±7.9228*10^28]: \n");

                decimala = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine($"Writing a decimal variable after entering a value: decimala: {decimala}.");

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

                //System.String
                //string == (Type Handle == 8 byte + Sync Block Index == 8 byte + Length == 4 byte + symbols == (2 * N)byte(s) + \0 == 2 byte)

                string hello = "Hello";
                string word = "world";

                Console.WriteLine($"Writing a string variable before entering a value: hello: {hello}, word: {word}.");
                Console.WriteLine($"{hello} {word}.");
                Console.Write("Enter value string ('qwertyuioplkjhgfdsa1234455'): \n");

                hello = Console.ReadLine();
                word = Console.ReadLine();

                Console.WriteLine($"Writing a string variable after entering a value: hello: {hello}, word: {word}.");


                //System.Object
                //object === any type and it takes 4 bytes on a 32-bit platform and 8 bytes on a 64-bit platform

                object objecta = 22;
                object objectb = 3.14;
                object objectc = "hello code";

                Console.WriteLine($"Writing a object variable before entering a value: objecta: {objecta}, objectb: {objectb}, objectc: {objectc}.");
                Console.Write("Enter value object ('qwertyuioplkjhgfdsa1234455', 123, 3,3214): \n");

                objecta = Console.ReadLine();
                objectb = Console.ReadLine();
                objectc = Console.ReadLine();

                Console.WriteLine($"Writing a object variable after entering a value: objecta: {objecta}, objectb: {objectb}, objectc: {objectc}.");
            }
        }
    }
}

