using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    public class results
    {
        public int[] MakeHist(int rolls)
        {
            // random number generator class
            Random random = new Random();
            int[] diArray = new int[11];//created array for results to be stored

            // loops through the user inputed rolls
            for (int i = 0; i < rolls; i++)
            {
          //simulates the roll of the dice for the number of times user specified
                int die1 = random.Next(1, 7);
                           // max value(7) is not included but min value(1) is
                int die2 = random.Next(1, 7);
                int total = die1 + die2;
             
             //adding results for each roll total to the array
                diArray[total - 2]++;
                // 0-10 in arrays but totals are 2-12 so have to do -2  
            }
            
            return diArray;
          
        }
    }
}
