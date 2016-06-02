using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
            {
            var line = Console.ReadLine();
            for(int j =0; j<line.Length; j++)
                {
                if(j==0 || j % 2 == 0)
                    {
                    Console.Write(line[j]);
                }
            }
             Console.Write(" ");
            for(int j =0; j<line.Length; j++)
                {
                if(j % 2 != 0)
                    {
                    Console.Write(line[j]);
                }
            }
            Console.WriteLine();
        }
    }
}