using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string expression)
        {
            if (expression.Length > 0)
            {
                if (expression.Contains(","))
                {
                    string[] digits = expression.Split(',');
                    return int.Parse(digits[0]) + int.Parse(digits[1]);
                }
                else
                {
                    return int.Parse(expression);
                }
            }
            return 0;
        }
    }
}
