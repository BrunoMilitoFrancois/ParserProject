using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Expression
    {
        Number Calculate(Number a, Number b, char op)
        {
            Number result = new Number();
            IOperator oper;
            switch (op)
            {
                case '+':
                    oper = new Sum();
                    break;
                case '-':
                    oper = new Subtraction();
                    break;
                default:
                    throw new InvalidOperationException();
            }
            result = oper.Resolve(a, b);
            return result;
        }
    }
}
