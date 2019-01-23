using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("PLease enter your grade between 0 and 100:");
                String input = Console.ReadLine();
                int value = int.Parse(input);
                
                String letter_grade = Get_grade(value);
                Console.WriteLine("Your letter grade is: " + letter_grade);
                               
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("You have an error");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
        } //End of main

        private static String Get_grade(int grade)
        {
            String letter;


            if (grade >= 95)
            {
                letter = "A+";
                
            }
            else if (grade >= 90 && grade < 95)
            {
                letter = "A";
                
            }
            else if (grade >= 87 && grade < 90)
            {
                letter = "A-";
                
            }
            else if (grade >= 84 && grade < 87)
            {
                letter = "B+";
                
            }
            else if (grade >= 80 && grade < 84)
            {
                letter = "B";
                
            }
            else if (grade >= 77 && grade < 80)
            {
                letter = "B-";
                
            }
            else if (grade >= 74 && grade < 77)
            {
                letter = "C+";
                
            }          
            else if (grade >= 70 && grade < 74)
            {
                letter = "C";
                
            }
            else if (grade >= 67 && grade < 70)
            {
                letter = "C-";
                
            }
            else if (grade >= 63 && grade < 67)
            {
                letter = "D+";
                
            }
            else if (grade >= 60 && grade < 63)
            {
                letter = "D";
               
            }
            else
            {
                letter = "F";
             
            }
            return (letter);
        }
    }
    
}
