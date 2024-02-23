using System.Text.RegularExpressions;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // WriteLine("Before parsing");
        // Write("What is your age?");
        // string? input = ReadLine();
        // try
        // {
        //     int age = int.Parse(input);
        //     WriteLine($"You are {age} years old.");
        // }
        // catch
        // {
        //     // ignored
        // }
        // WriteLine("After parsing");
        
        //alternative with regex without throw exception
        // if (input is null || !Regex.IsMatch(input, @"^\d+$"))
        // //better to handle the situation
        //     WriteLine("You did not enter a value so the app has ended");
        // else
        // {
        //     int age = int.Parse(input!);
        // }

        // if (input is null)
        // {
        //     WriteLine("You did not enter a value so the app has ended");
        //     return;
        // }
        // try
        // {
        //     int age = int.Parse(input);
        //     WriteLine($"You are {age} years old.");
        // }
        // catch 
        // {
        //     // ignored
        // }
        // WriteLine("After parsing");
        
        // if (input is null)
        // {
        //     WriteLine("You did not enter a value so the app has ended");
        //     return;
        // }
        // try
        // {
        //     int age = int.Parse(input);
        //     WriteLine($"You are {age} years old.");
        // }
        // catch (OverflowException)
        // {
        //     WriteLine("Your age is a valid number format but it is either too big or small");
        // }
        // catch (FormatException)
        // {
        //     WriteLine("The age you entered is not a valid number format");
        // }
        // catch (Exception ex)
        // {
        //     WriteLine($"{ex.GetType()} says {ex.Message}");
        // }
        // WriteLine("After parsing");

        
        
        
        
        // catching with filters
        // WriteLine("Enter an amount: ");
        // string amount = ReadLine()!;
        // if (string.IsNullOrEmpty(amount)) return;
        // try
        // {
        //     decimal amountValue = decimal.Parse(amount);
        //     WriteLine($"Amount formatted as currency: {amountValue:C}");
        // }
        // catch (FormatException) when (amount.Contains("$"))
        // {
        //     WriteLine("Amounts cannot use the dollar sign!");
        // }
        // catch (FormatException)
        // {
        //     WriteLine("Amounts must only contain digits!");
        // }
        
        
        
        
        
        //Checking for overflow
        
        
    }
}