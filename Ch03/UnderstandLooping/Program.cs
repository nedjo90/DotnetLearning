using System.Collections;

namespace UnderstandLooping;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Adam", "Barry", "Charlie" };
        // foreach (string name in names)
        // {
        //     WriteLine($"{name} has {name.Length} characters.");
        // }

        /*
         * foreach statement will work on any type that follows these rules:
         * -> type must have a method named GetEnumerator that returns an object
         * -> the returned object must have a property named Current and a method named MoveNext
         * -> MoveNext method must change the value of Current and return true if there are more items to enumerate through pr return false if there are no more items
         * IEnumerable and IEnumerable<T> formally define these rules
         */
        
        IEnumerator e = names.GetEnumerator();
        while (e.MoveNext())
        {
            string name = (string)e.Current;
            WriteLine($"{name} has {name.Length} characters");
        }
    }
}