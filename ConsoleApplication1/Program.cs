using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ages = new List<int>();
            ages.Add(10);
            ages.Add(20);
            ages.Add(30);
            ages.Add(40);
            ages.Add(50);
            
            IEnumerable<int> age_IEnumerable = (IEnumerable<int>)ages;
            

            IEnumerator<int> age_IEnumerator = ages.GetEnumerator();

            

            
        }
        
        

    }
}
