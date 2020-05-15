using System;
using System.Linq;
namespace hw21_LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Problem-1---");
            Console.Write("Write some text:  ");
            char[] input = Console.ReadLine().ToCharArray();
            Console.Write("Result text:  ");
            var answer = new string(input.Select(i => i == 'a' ? '1': i == 'e'? '2' : 
                                                      i == 'i' ? '3': i == 'o'? '4':
                                                      i == 'u' ? '5': i).ToArray());
            Console.Write(answer);
       
            Console.WriteLine("---Problem-2---");
            Console.Write("Write some text:  ");
            input = Console.ReadLine().ToCharArray();
            Console.Write("Result text:  ");
            answer = new string(input.Select(i => i == '1' ? 'a' : i == '2' ? 'e' :
                                                  i == '3' ? 'i' : i == '4' ? 'o' :
                                                  i == '5' ? 'u' : i).ToArray());
            Console.Write(answer);
        
            Console.WriteLine("---Problem-3---");
            Console.Write("Write some text:  ");
            input = Console.ReadLine().ToCharArray();
            var num1 = new string(input.TakeWhile(i => i != '+' && i != '-' && i != '*' && i != '/').
                                      Where(i => (int)i >= 48 && (int)i <= 57).ToArray());
            var num2 = new string(input.SkipWhile(i => i != '+' && i != '-' && i != '*' && i != '/').
                                      Where(i => (int)i >= 48 && (int)i <= 57).ToArray());
            var oper = input.First(i => i == '+' || i == '-' || i == '*' || i == '/');
            double ans;
            switch (oper)
            {
                case '+':
                    ans = int.Parse(num1) + int.Parse(num2);
                    break;
                case '-':
                    ans = int.Parse(num1) - int.Parse(num2);
                    break;
                case '*':
                    ans = int.Parse(num1) * int.Parse(num2);
                    break;
                case '/':
                    ans = Math.Round(int.Parse(num1) / int.Parse(num2));
                    break;

            }

            Console.Write($"{num1} {oper} {num2}");
            Console.ReadKey();
        }
    }
    
}
