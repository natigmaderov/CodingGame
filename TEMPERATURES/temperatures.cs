using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        int[] inputTempsToAnalyze = new int[n];
		
		if (n > 0)
		{
			inputTempsToAnalyze = temps.Split(' ').Select(s=> int.Parse(s)).ToArray();
		} 
		int lowestTempOutput = 0;
		  
        for(int i = 0; i < n; i++)
        {
            if (i == 0)
			{
				lowestTempOutput = inputTempsToAnalyze[i];
			}
			else if (Math.Abs(inputTempsToAnalyze[i]) < Math.Abs(lowestTempOutput))
			{
				lowestTempOutput = inputTempsToAnalyze[i];						
			}
			else if (Math.Abs(inputTempsToAnalyze[i]) == Math.Abs(lowestTempOutput) && inputTempsToAnalyze[i] > lowestTempOutput)
			{
				lowestTempOutput = inputTempsToAnalyze[i];
			}
			      
        }
		
        Console.WriteLine("{0}", lowestTempOutput);
    }
}
