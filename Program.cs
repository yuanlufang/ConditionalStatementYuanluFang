using System;

namespace ConditionalStatementYuanluFang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter the score you wish to obtain in this class (out of 100). Please do NOT include '%' sign :)");
            Console.WriteLine("Type below and hit ENTER:");


            int expectedGrade;
            int aPlusLower = 98;
            int aPlusHiger = 100;
            int aLower = 92;
            int aHigher = 97;
            int aMinusLower = 90;
            int aMiusHigher = 91;
            int bPlusLower = 88;
            int bPlusHiger = 89;
            int bLower = 82;
            int bHigher = 87;
            int bMinusLower = 80;
            int bMiusHigher = 81;
            int cPlusLower = 78;
            int cPlusHiger = 79;
            int cLower = 72;
            int cHigher = 77;
            int cMinusLower = 70;
            int cMiusHigher = 71;




            while (int.TryParse(Console.ReadLine(), out expectedGrade))
            {

                if (expectedGrade <= aPlusHiger && expectedGrade >= aPlusLower)
                {
                    Console.WriteLine("Your expected grade letter is A+!");
                }
                else if (expectedGrade <= aHigher && expectedGrade >=aLower)
                {
                    Console.WriteLine("Your expected grade letter is A!");
                }
                else if (expectedGrade <= aMiusHigher && expectedGrade >=aMinusLower)
                {
                    Console.WriteLine("Your expected grade letter is A-!");
                }
                else if (expectedGrade <= bPlusHiger && expectedGrade >=bPlusLower)
                {
                    Console.WriteLine("Your expected grade letter is B+!");
                }
                else if (expectedGrade <= bHigher && expectedGrade >= bLower)
                {
                    Console.WriteLine("Your expected grade letter is B!");
                }
                else if (expectedGrade <= bMiusHigher && expectedGrade >= bMinusLower)
                {
                    Console.WriteLine("Your expected grade letter is B-!");
                }
                else if (expectedGrade <= cPlusHiger && expectedGrade >= cPlusLower)
                {
                    Console.WriteLine("Your expected grade letter is C+!");
                }
                else if (expectedGrade <= cHigher && expectedGrade >= cLower)
                {
                    Console.WriteLine("Your expected grade letter is C!");
                }
                else if (expectedGrade <= cMiusHigher && expectedGrade >= cMinusLower)
                {
                    Console.WriteLine("Your expected grade letter is C-!");
                }
                else if (expectedGrade < cMinusLower)
                {
                    Console.WriteLine("Sorry! You won't graduate :)");
                }
                else if (expectedGrade>aPlusHiger)
                {
                    Console.WriteLine("Please enter a score from 0 to 100!");
                }
            }
                Console.Clear();
                Console.WriteLine("Enter ONLY number!");
            }
        }
    }

