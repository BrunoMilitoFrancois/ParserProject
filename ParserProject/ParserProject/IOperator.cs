using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public interface IOperator
    {
        int Calculate(Number a, Number b);
    }
}
