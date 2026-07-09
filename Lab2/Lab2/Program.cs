// System.Boolean
// bool == true, false, 0, 1.

bool alive = true;
bool isDead = false;

Console.WriteLine($"Writing a bool variable before entering a value: alive: {alive}, isDead: {isDead}.");
Console.Write("Enter value alive and is Dead (True or False): \n");

alive = Convert.ToBoolean(Console.ReadLine());
isDead = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Writing a bool variable after entering a value: alive: {alive}, isDead: {isDead}.");

//System.Byte
//byte == [0; 255]

byte bit1 = 1;
byte bit2 = 102;

Console.WriteLine($"Writing a byte variable before entering a value: bit1: {bit1}, bit2: {bit2}.");
Console.Write("Enter value bit1 and bit2 ([0; 255]): \n");

bit1 = Convert.ToByte(Console.ReadLine());
bit2 = Convert.ToByte(Console.ReadLine());

Console.WriteLine($"Writing a byte variable after entering a value: bit1: {bit1}, bit2: {bit2}.");

//System.SByte
//sbyte == [-128; 127]

sbyte sbit1 = -10;
sbyte sbit2 = 122;

Console.WriteLine($"Writing a sbyte variable before entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");
Console.Write("Enter value sbit1 and sbit2 ([-128; 127]): \n");

sbit1 = Convert.ToSByte(Console.ReadLine());
sbit2 = Convert.ToSByte(Console.ReadLine());

Console.WriteLine($"Writing a sbyte variable after entering a value: sbit1: {sbit1}, sbit2: {sbit2}.");

//System.Int16 (short)
//short == [-32768; 32767]

short short1 = 1;
short short2 = 102;

Console.WriteLine($"Writing a short variable before entering a value: short1: {short1}, short2: {short2}.");
Console.Write("Enter value short1 and short2 ([-32768; 32767]): \n");

short1 = Convert.ToInt16(Console.ReadLine());
short2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Writing a short variable after entering a value: short1: {short1}, short2: {short2}.");

