using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        double mealCost = double.Parse(Console.ReadLine());
        double tipPercent = double.Parse(Console.ReadLine());
        double taxPercent = double.Parse(Console.ReadLine());
        
        double tip = mealCost*tipPercent/100.0;
        double tax = mealCost*taxPercent/100.0;
        double totalCost = mealCost + tip + tax;
        
        Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));
    }
}