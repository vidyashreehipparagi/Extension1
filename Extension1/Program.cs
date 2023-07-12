using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation cal=new Calculation();
            
            int result = cal.Sub(1,2);
            Console.WriteLine(result);
            int result1=cal.Mul(1,2);
            Console.WriteLine(result1);




        }  
       
    }
  
}
