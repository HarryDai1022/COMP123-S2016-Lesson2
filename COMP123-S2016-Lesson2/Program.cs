using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Author: Harry Dai
 * Date: 2016-05-17
 * Date modified: 2016-05-17
 * Description: Advanced Methods Demo for Lesson 2
 * Version: 0.0.3 - Added addXandY method and associated test
 */


namespace COMP123_S2016_Lesson2
{

/*
 * Main driver class for Lesson 2
 * 
 * @class: Program
 */

    public class Program
    {

        /*
         * Main method for the drive classes
         * 
         * @constructor Main
         * @param (string[]) args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
        }

        /*
         * Simple method to  
         */

        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        } 
    }
}
