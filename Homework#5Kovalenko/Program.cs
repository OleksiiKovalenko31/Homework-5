// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


// Я Вважаю що код пожна поліпшити тому я її перездам пвзніше . Сорі через роботу бракує часу

Console.Write("Введіть число: "); 
string inNumber = Console.ReadLine();

try
{
    // decimal 

    decimal isNumberCon = decimal.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат decimal {1}", isNumberCon, inNumber);
}
catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }

// int
try
    {
    int isNumberCon = int.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат int {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }

    // sbyte          
    try
    {
    sbyte isNumberCon = sbyte.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат sbyte {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }

    // byte
    try
    {
    byte isNumberCon = byte.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат byte {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }


    try // float
    {
    float isNumberCon = float.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат float {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    try // double
    {
    double isNumberCon = double.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат double {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    // ushort
    try
    {
    ushort isNumberCon = ushort.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат ushort {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    // short
    try
    {
    short isNumberCon = short.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат short {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    // uint
    try
    {
    uint isNumberCon = uint.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат uint {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    // long
    try
    {
    long isNumberCon = long.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат long {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
    // ulong
    try
    {
    ulong
    isNumberCon = ulong.Parse(inNumber);
    Console.WriteLine("\n Число {0} переконвертовано у формат ulong {1}", isNumberCon, inNumber);
    }
    catch (Exception ex) { Console.WriteLine("\nНе можна переконвертувати {0}", ex.Message); }
