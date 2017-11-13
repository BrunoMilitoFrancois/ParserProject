using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Subtraction : IOperator
    {
        public int Calculate(Number a, Number b)
        {
            return a.Value - b.Value;
        }
    }
}
