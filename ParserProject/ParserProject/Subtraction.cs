using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Subtraction : IOperator
    {
        public Number Resolve(Number a, Number b)
        {
            Number number = new Number();
            number.Value = a.Value - b.Value;
            return number;
        }
    }
}
