using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Expression
    {
       public Number Calculate(List<Number> numbers, char op)
        {
            var result = new Number();
            result.Value = 0;
            IOperator oper = new Sum();

            foreach(var n in numbers)
            {
                result = oper.Resolve(result, n);
            }

            return result;
        }
    }
}
