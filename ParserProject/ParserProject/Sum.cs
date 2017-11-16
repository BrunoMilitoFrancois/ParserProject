using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    class Sum : IOperator
    {
        public Number Resolve(Number a, Number b)
        {
            var number = new Number();
            number.Value = a.Value + b.Value;

            return number;
        }
    }
}
