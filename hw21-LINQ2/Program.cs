using System;
using System.Linq;
namespace hw21_LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write some text:  ");
            char[] input = Console.ReadLine().ToCharArray();
            Console.Write("Result text:  ");
            var answer = new string(input.Select(i => i == 'a' ? '1': i == 'e'? '2' : 
                                                      i == 'i' ? '3': i == 'o'? '4':
                                                      i == 'u' ? '5': i).ToArray());
            Console.Write(answer);
            Console.ReadKey();

        }
    }
    
}
