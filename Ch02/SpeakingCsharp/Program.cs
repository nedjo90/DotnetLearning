using System.Data;
using System.Reflection; // To use Assembly, Type-Name, and so on
namespace SpeakingCsharp;

class Program
{
    static void Main(string[] args)
    {
        // #region Three variables that store the number 2 million.
        // int decimalNotation = 2_000_000;
        // int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; 
        // int hexadecimalNotation = 0x_001E_8480;
        // #endregion
        //
        // // WriteLine(decimalNotation);
        // // WriteLine(binaryNotation);
        // // WriteLine(hexadecimalNotation);
        // WriteLine($"computer named {Env.MachineName} says \"No.\"");
        //

        // Assembly? myApp = Assembly.GetEntryAssembly();
        //
        // if (myApp is null) return;
        //
        // foreach (AssemblyName name in myApp.GetReferencedAssemblies())
        // {
        //     Assembly a = Assembly.Load(name);
        //
        //     int methodCount = 0;
        //
        //     foreach (TypeInfo t in a.DefinedTypes)
        //     {
        //         methodCount += t.GetMethods().Length;
        //     }
        //     WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        //         arg0: a.DefinedTypes.Count(),
        //         arg1: methodCount,
        //         arg2: name.Name);
        // }
        // //Declare some unused variables using types in additional assemblies to make them load too.
        // System.Data.DataSet ds = new DataSet();
        // HttpClient client = new HttpClient();
        
        
        //Let the heightInMetres variable become equal to the value 1.88

        // double heightInMetres = 1.88;
        // WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}");
        
        //Storing text

        // char letter = 'A';
        // char digit = '1';
        // char symbol = '$';
        // //char userChoice = GetChar(); //Assigning from a fictitious function
        //
        // string firstName = "Bob";
        // string lastName = "Smith";
        // string phoneNumber = "(215) 55-4256";
        // string horizontalLine = new('-', count: 74);
        // WriteLine(horizontalLine);
        // //string address = GetAddressFromDatabase(id: 563); //Assigning from a fictitious function
        // OutputEncoding = System.Text.Encoding.UTF8;
        // string grinningEmoji = char.ConvertFromUtf32(0x1F600);
        // WriteLine(grinningEmoji);

        // int testNumber = 132131;    
        // string xml = $"""
        //              <person age="50">
        //                 <first_name>Mark{testNumber}</first_name>
        //              </person>
        //             """;
        // WriteLine(xml);

        // var person = new { FirstName = "Alice", Age = 56 };
        // string json = $$"""
        //                 {
        //                     "first_name": "{{person.FirstName}}",
        //                     "age": {{person.Age}},
        //                     "calculation": "{{{ 1 + 2}}}"
        //                 }
        //                 """;
        // WriteLine(json);
        
        // Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}."); 
        // Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}."); 
        // Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
        
        // unsafe
        // {
        //     WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}."); 
        //     WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
        // }
        
        //Storing any type of object
        // object height = 1.88;
        // object name = "amir";
        // WriteLine($"{name} is {height} metres tall.");
        
        
        // dynamic something;
        //         // Storing an array of int values in a dynamic object.
        // // An array of any type has a Length property.
        //        something = new[] { 3, 5, 7 };
        // // Storing an int in a dynamic object.
        // // int does not have a Length property.
        //  //   something = 12;
        // // Storing a string in a dynamic object.
        // // string has a Length property.
        //     something = "Ahmed";
        // // This compiles but might throw an exception at run-time.
        //     Console.WriteLine($"The length of {nameof(something)} is {something.Length}");
        // // Output the type of the something variable.
        //     Console.WriteLine($"{nameof(something)} is a {something.GetType()}");
        
        // WriteLine($"default(int) = {default(int)}"); 
        // WriteLine($"default(bool) = {default(bool)}"); 
        // WriteLine($"default(DateTime) = {default(DateTime)}"); 
        // WriteLine($"default(string) = {default(string)}");
        // WriteLine($"default(object) = {default(object)}");
        // WriteLine($"default(char) = {default(char)}");
        
        // string formattedString = string.Format($"{30:D5}");
        // Console.WriteLine(formattedString);
        // WriteLine("""
        //                   Syntaxe of string format item is:
        //                   { index [, alignment ] [ : formatString] }
        //                   """);

        // ConsoleKeyInfo key = ReadKey();
        // Console.WriteLine($"key: {key.Key}, char : {key.KeyChar}, modifier : {key.Modifiers}");

        

    }
}
