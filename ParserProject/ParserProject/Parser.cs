using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserProject
{
    public class Parser
    {
       public List<Number> Covert(string formula)
        {
            var i = 0;
            var numbers = new List<Number>();
            formula = formula.Replace(" ", string.Empty);
            var auxiliary = formula.Replace("+", "*+").Replace("-", "*-");
            var formulaNumbers = auxiliary.Split('*');
            foreach(var c in formulaNumbers)
            {
                if (c != "")
                {
                    numbers.Add(new Number() { Value = Convert.ToInt32(c) });
                }
                
            }
            return numbers;
        }
    }
}
