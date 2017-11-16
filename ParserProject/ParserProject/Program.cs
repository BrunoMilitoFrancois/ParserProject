using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            Console.WriteLine("Enter the expression to be calculated: ");
            string expression = Console.ReadLine();
            List<Number> numbers = parser.Covert(expression);
            var result = new Expression().Calculate(numbers, '+');
            Console.WriteLine($"Answer = {result.Value}");
            Console.ReadLine();
        }
    }
}
