using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz4
{
    public class FizzBuzz
    {
        public String doFizzBuzz(int upperBound)
        {
            var value = "";

            for(int i=0; i <= upperBound; i++)
            {
                if (i %5==0 && i%3==0 && i != 0)
                {
                    value += "FizzBuzz";
                }
                else if(i%5==0 && i != 0)
                {
                    value += "Buzz";
                }
                else if (i%3==0 && i != 0)
                {
                    value += "Fizz";
                }
                else
                {
                    value += i.ToString();
                }
            }
            
            return value;



        }
    }
}
