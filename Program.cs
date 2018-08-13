/*
Automorphic Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-25 

If the square of a number ends with the number itself, it is considered to be automorphic. 

For Example: 
25 is an automorphic number, as the square of 25 = 625 (ends with 25). 
Sequence of automorphic numbers: 1, 5, 6, 25, 76, 376, .. 

Tasks: 
(Easy) Write a program to verify whether a given number is automorphic or not. 
(Medium) Write a program to find all the automorphic numbers in a range.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomorphicNumbersEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 25;    // Insert a number to verify whether a given number is automorphic or not

            long square = (long)Math.Pow(number, 2);

            string nu = number.ToString();
            string sq = square.ToString();

            Console.WriteLine($"The number {nu} {((nu == sq.Substring(sq.Length - nu.Length, nu.Length)) ? "is" : "is not")} an Automorphic number ({nu}^2={sq})");
        }
    }
}