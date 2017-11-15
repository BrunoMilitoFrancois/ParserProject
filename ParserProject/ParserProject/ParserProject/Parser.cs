using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Parser
    {
       public Expression Covert(string formula)
        {
            var numbers = new List<Number>();
            formula = formula.Replace(" ", string.Empty);
            var auxiliary = formula.Replace("+", "*").Replace("-", "*");
            foreach(var c in auxiliary)
            {
                if (c != '*')
                {
                    numbers.Add(new Number() { Value = c, Signal = })
                }
            }
            

        }
    }
}
