using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1
{
    class Program
    {

        static void Main(string[] args)
        {
            int i, n,sum = 0,actual_sum = 0,len = 0;
            Console.WriteLine("Enter Number :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+(n-1)+" numbers from 1 to "+n+" :");
            String[] a = Console.ReadLine().Split(' ');
            len = a.Length;
            int[] b= new int[10] ;
            for (i = 0; i < len; i++){
                b[i] = Int32.Parse(a[i]);
                actual_sum += b[i];
            }
            sum = (len+1)*(len+2)/ 2;
            Console.WriteLine("missing number  : {0}", sum - actual_sum); 
            Console.ReadKey();
        }
    }
}

    
