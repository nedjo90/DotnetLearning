using System;
using System.Threading.Tasks;
namespace DotnetLearning;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 40; i++)
        {
            var value = Random.Shared.Next();
            Console.WriteLine(value);
        }
        
        
    }
}