using System;
using Assign2;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Time for the Dice Throwing Simulator!");
        Console.WriteLine("How many dice rolls would you like to do?");
        
        //what is this and why does it work? another chat thing
        int.TryParse(Console.ReadLine(), out int rolls);
            //console.readLine() treats it as a string
            //int.TryParse(..) method to string--> int
            //out int rolls declares output named rolls
        
        //taking userinput and sending to result class
        results Results = new results();
        int[] diArray = Results.MakeHist(rolls);

        Console.WriteLine("Rolling " + rolls + " times complete");
        //print histogram that shows % each number was rolled
        // Each * represents 1% of total rolls
        
        //send array and rolls to the function
        PrintHist(diArray, rolls);

        Console.WriteLine("Sayonara suckers!");
    }
    static void PrintHist(int[] diArray, int rolls)
    {
        for (int i = 0; i < diArray.Length; i++) 
        {
            // frequency of each number
            int percent = diArray[i]* 100 / rolls;
            
            // creates string which does * for value stored 
            string histogram = new string('*', percent);
            // new string() uses the string constructor
            // * is character to be repeated percent variable amount of times

            //alt way- for loop to do number given from percent print 1 *
            
            // print '*' proportional to percent
            Console.WriteLine($"{i + 2}: {histogram} ({percent}%)");
            
        }
    }
}