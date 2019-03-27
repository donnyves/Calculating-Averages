using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A___Calculating_Averages

{
    class CalcAverages
    {
        static void Main(string[] args)
        {
            //  I feel know there a better way to program the test scores.  I'm not sure if it is enumeration
            // or maybe having some sort of array.


            int  test1, test2, test3, test4, test5, test6, test7, test8, test9, test10, grade;
            float avg;

            //I use this string for my introduction and the when they 
            //final result are displayed.
            string FirstName , LastName;
            Console.WriteLine("Enter First Name :");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello " + FirstName + " " + LastName + "! ");

            //I wanted to create a condition where the user can only type in a number
            //between 0.00 and 100.00
            Console.WriteLine("When prompted, type in your 10 grades using a number between 0.00 and 100.00, Press enter now.");
            Console.ReadLine();

            //The ToInt32 allows the user to type in a float for the test results.

            Console.WriteLine("Grade for the 1st test : ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 2nd test : ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 3rd test : ");
            test3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 4th test : ");
            test4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 5th test : ");
            test5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 6th test : ");
            test6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 7th test : ");
            test7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 8th test : ");
            test8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 9th test : ");
            test9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade for the 10th test : ");
            test10 = Convert.ToInt32(Console.ReadLine());

            //To calculate the grade point average , all of the test results are added, and then 
            //divided.  grade displats the total, and avg displays the grade average.  
            grade = test1 + test2 + test3 + test4 + test5 + test6 + test7 + test8 + test9 + test10;
            avg = grade / 10.0f;
            Console.WriteLine("Total : " + grade);
            Console.WriteLine("Percentage : " + avg);

            //  I think I could used switch statment for this part, put I went with if statements.
            // The condition &&, means that both condition need to be true to get the correct 
            //Console.Writeline response.
            if (avg >= 0 && avg < 60)
            {
                Console.WriteLine(FirstName + " " + LastName + " " + "received a grade of an F.");
            }
            if (avg >= 60 && avg < 70)
            {
                Console.WriteLine(FirstName + " " + LastName + " " + "received a grade of a D.");
            }
            if (avg >= 70 && avg <= 80)
            {
                Console.WriteLine(FirstName + " " + LastName + " " + "received a grade of a C.");
            }
            if (avg > 80 && avg <= 90)
            {
                Console.WriteLine(FirstName + " " + LastName + " " + "received a grade of a B!");
            }
            if (avg > 90 && avg <= 100)
            {
                Console.WriteLine(FirstName + " " + LastName + " " + "received a grade of an A");
            }
            Console.ReadLine();
        }
    }
}
