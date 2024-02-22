using Spectre.Console;
namespace Ch02Ex03Numbers;

class Program
{
    static void Main(string[] args)
    {
        
        WriteLine(new string('-', count: 127));
        WriteLine("{0, -15}{1,4}{2, 32}{3, 45}", "Type", "Byte(s) of memory", "Min", "Max");
        WriteLine(new string('-', count: 127));
        
        
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "short", sizeof(short), short.MinValue, short.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "int", sizeof(int), int.MinValue, int.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "long", sizeof(long), long.MinValue, long.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        unsafe
        {
            WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
            WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
            WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "Half", sizeof(Half), Half.MinValue, Half.MaxValue);
        }
        
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "float", sizeof(float), float.MinValue, float.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "double", sizeof(double), double.MinValue, double.MaxValue);
        WriteLine("{0, -15}{1, 4}{2, 45}{3, 45}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        
        
        
        
        
        
        
        WriteLine(new string('-', count: 127));
        
    }

    void display(string s)    {
        if (s is null)
            throw new ArgumentNullException(nameof(s));
    }
}