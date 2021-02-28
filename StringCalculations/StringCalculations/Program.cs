using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Caluculation("1 + 2 - 3");
            Console.WriteLine(result);
        }

        static int Caluculation(string numsOp)
        {
            char [] operations = numsOp.ToCharArray();
            List<int> _operations = new List<int>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations [i] == '+')
                {
                    //int sum = charToInt + operations[i];
                    _operations.Add(operations[i]);
                }
                
                // Check element is an integer or not
                else if (Int32.TryParse(operations[i].ToString(),out int results))
                {
                    numbers.Add(results);
                }
            }
            return numbers[0] + numbers[1];
          
        }
    }
}
