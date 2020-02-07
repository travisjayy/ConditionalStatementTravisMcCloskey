using System;

namespace ConditionalStatementTravisMcCloskey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What score do you anticipate on getting in ISM 4300? Please input a number between 0 and 100.");
            int userGrade = Convert.ToInt16(Console.ReadLine());

            if (userGrade > 100)
            {
                Console.WriteLine("Please input a number that's quantifiable on a grade scale. You know what to do.");
            }
            if (userGrade > 97 && userGrade < 101)
            {
                Console.WriteLine("You'll receive an A+, You're brilliant! :D");
            }
            if (userGrade > 91 && userGrade < 98)
            {
                Console.WriteLine("You'll receive an A, Close to an A+ :D");
            }
            if (userGrade > 89 && userGrade < 92)
            {
                Console.WriteLine("You'll receive an A-, Hey.. It's still an A :D");
            }
            if (userGrade > 87 && userGrade < 90)
            {
                Console.WriteLine("You'll receive an B+");
            }
            if (userGrade > 81 && userGrade < 88)
            {
                Console.WriteLine("You'll receive an B");
            }
            if (userGrade > 79 && userGrade < 82)
            {
                Console.WriteLine("You'll receive an B-");
            }
            if (userGrade > 77 && userGrade < 80)
            {
                Console.WriteLine("You'll receive an C+");
            }
            if (userGrade > 71 && userGrade < 78)
            {
                Console.WriteLine("You'll receive an C");
            }
            if (userGrade > 69 && userGrade < 72)
            {
                Console.WriteLine("You'll receive an C-");
            }
            if (userGrade > 67 && userGrade < 70)
            {
                Console.WriteLine("You'll receive an D+");
            }
            if (userGrade > 61 && userGrade < 68)
            {
                Console.WriteLine("You'll receive an D");
            }
            if (userGrade > 59 && userGrade < 62)
            {
                Console.WriteLine("You'll receive an D-");
            }
            if (userGrade > 60)
            {
                Console.WriteLine("Dude, get it together. You're getting an F.");
            }
        }
    }
}
