using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        if(n % 2 != 0 || (n>=6 && n<=20))
            {
            Console.WriteLine("Weird");
        }
        else if((n %2 == 0 && n>=2 && n<=5) || (n%2==0 && n>20) )
            {
             Console.WriteLine("Not Weird");
        }
    }
}
