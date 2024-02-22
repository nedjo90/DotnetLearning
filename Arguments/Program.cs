using System.Runtime.InteropServices;

namespace Arguments;

class Program
{
    static void Main(string[] args)
    {
        // foreach (string s in args)
        // {
        //     WriteLine(s);
        // }
        // WriteLine($"There are {args.Length} arguments.");
        
        
        // use args to allow user to pick a color for the background and foreground an cursor size of the output window

        if (args.Length < 3)
        {
            WriteLine("You must specify two colors and cursor size, e.g.");
            WriteLine("dotnet run red yellow 50");
            return;
        }
        ForegroundColor = Enum.Parse<ConsoleColor>(args[0], true);
        BackgroundColor = Enum.Parse<ConsoleColor>(args[1], true);
        // try
        // {
        //     CursorSize = int.Parse(args[2]);
        // }
        // catch(Exception e)
        // {
        //     WriteLine("Cursor size can be change only on windows OS");
        // }

        if (OperatingSystem.IsWindows())
        {
            CursorSize = int.Parse(args[2]);
        }
        else
        {
            WriteLine("Cursor size can be change only on windows OS");
        }
    }
}