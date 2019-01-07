using System;

using System.Collections.Generic;



namespace project

{

    static class PreworkProject

    {

        static void Main(string[] args)

        {

            prework_code_challenges.Foo prework = new prework_code_challenges.Foo();

            Console.WriteLine("Welcome to Sean's Prework, my name is Computer and I will be assisting you today.");

            prework.ChallengeList();

        }

    }

}

namespace prework_code_challenges
{

    public class Foo

    {

        public int ChallengeList()

        {

            Console.WriteLine("Here are the Challenges, please enter one to ineract with:\n-Array Multiplier\n-Leap Year\n-Sum of Rows\n-Perfect Sequence");

            string answer = Console.ReadLine();

            switch (answer)

            {

                case ("Array Multiplier"):

                    return ArrayMultiplier();

                case ("Leap Year"):

                    return LeapYear();

                case ("Sum of Rows"):

                    return SumofRows();

                case ("Perfect Sequence"):

                    return PerfectSequence();

                default:

                    return ChallengeList();

            }

        }

        public int ArrayMultiplier()

        {

            string userName;

            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, chosenNum;

            int[] numArray = new int[5] { num1, num2, num3, num4, num5 };

            int multiplier = 0;

            string[] questions = new string[5] { "Your First Number...", "Your Second Number...", "Your Third Number...", "Your Fourth Number...", "Your Fifth Number..." };

            Console.WriteLine("Hello! This is interactive game, so what's your name?");

            userName = Console.ReadLine();

            Console.WriteLine("Well {0} I'm pleased to meet you,\nI am the computer. Salutations!", userName);

            Console.WriteLine("Let's get started shall we. Please enter 5 numbers between 1-10.\nI will prompt you for each one individually.");

            for (int i = 0; i < questions.Length; i++)

            {

                Console.WriteLine(questions[i]);

                Int32.TryParse(Console.ReadLine(), out int num);

                if (num > 10 || num < 1)

                {

                    Console.WriteLine("That Number is not between 1-10, please try again.");

                    i--;

                }

                numArray[i] = num;

            }



            Console.WriteLine("Fantastic! Now choose any one of those Numbers and I will tell you your Score.");

            Int32.TryParse(Console.ReadLine(), out chosenNum);



            foreach (int num in numArray)

            {

                if (num == chosenNum)

                {

                    multiplier += 1;

                }

            }

            int score = chosenNum * multiplier;

            Console.WriteLine("Your Score is {0}! Congratz and Thanks for playing!", score);

            return ChallengeList();

        }

        public int LeapYear()

        {

            Console.WriteLine("Welcome I am your host, Computer. \nI will let you know if a year is a Leap Year");

            void Test()

            {

                bool con1 = true, con2 = true, con3 = true;

                Console.WriteLine("Please enter a year that you wish to know about.");

                Int32.TryParse(Console.ReadLine(), out int year);

                decimal con1Math = Decimal.Divide(year, 4);

                decimal con2Math = Decimal.Divide(year, 100);

                decimal con3Math = Decimal.Divide(year, 400);



                if ((con1Math % 1) > 0)

                {

                    con1 = false;



                }

                if ((con2Math % 1) > 0)

                {

                    con2 = false;

                }

                if ((con3Math % 1) > 0)

                {

                    con3 = false;

                }

                if (con1 & con2 & con3 || con1)

                {

                    Console.WriteLine("Yes, that year is a leap year.");

                }

                else

                {

                    Console.WriteLine("No, that year is not a leap year.");

                }

                Retry();

            }

            void Retry()

            {

                bool retry = false;

                Console.WriteLine("Would you like to try again? Yes or No");

                string answer = Console.ReadLine();

                if (answer == "Yes")

                {

                    retry = true;

                }

                if (answer == "No")

                {

                    Console.WriteLine("Thank you, see you soon!");

                    retry = false;

                }

                if (answer != "Yes" && answer != "No")

                {

                    Console.WriteLine("That is not a valid response.");

                    Retry();

                }

                if (retry == true)

                {

                    Test();

                }

            }

            Test();

            return ChallengeList();

        }

        public int PerfectSequence()

        {



            int sum = 0;

            int product = 1;



            Console.WriteLine("Welcome and Welcome, I am your host, Computer!/nLets figure out if a list of numbers is a perfect sequence!!");

            Console.WriteLine("Please enter a number when I prompt you and type 'Done' when you dont want to enter any more numbers");

            Console.WriteLine("Let's begin.");

            bool done = false;

            List<int> sequence = new List<int>();

            while (!done)

            {

                Console.WriteLine("Please enter a number to add to the sequence.");

                Int32.TryParse(Console.ReadLine(), out int num);

                sequence.Add(num);

                Console.WriteLine("Are you done? If so enter 'Done' otherwise press the ENTER key");

                string doneAnswer = Console.ReadLine();

                if (doneAnswer == "Done")

                {

                    done = true;

                }

            }

            foreach (int num in sequence)

            {

                if (num < 0)

                {

                    Console.WriteLine("Ooops something went wrong!");

                }

                sum += num;

                product *= num;

            }

            if (sum == product)

            {

                Console.WriteLine("This is a perfect sequence!");

            }

            else

            {

                Console.WriteLine("This is not a perfect sequence");

            }

            return ChallengeList();

        }

        public int SumofRows()

        {





            //Define the Matrix



            Console.WriteLine("Okay, lets find the sum of the rows of a 3D Matrix!");

            Console.WriteLine("How many numbers should be in the rows?");

            Int32.TryParse(Console.ReadLine(), out int columns);

            Console.WriteLine("How many rows should there be in the matrix?");

            Int32.TryParse(Console.ReadLine(), out int rows);



            int[,] multiArray = new int[columns, rows];

            int[] solutionArray = new int[rows];



            //Fill the Matrix



            for (int i = 0; i < multiArray.GetLength(0); i++)

            {

                Random random = new Random();

                for (int k = 0; k < multiArray.GetLength(1); k++)

                {

                    multiArray[i, k] = random.Next(10);

                }

            }



            //Compute the Matrix



            for (int i = 0; i < multiArray.GetLength(0); i++)

            {

                int sum = 0;

                for (int k = 0; k < multiArray.GetLength(1); k++)

                {

                    sum += multiArray[i, k];

                }

                solutionArray[i] = sum;

            }

            Console.WriteLine("Sums of the rows are: " + string.Join(",", solutionArray));

            return ChallengeList();

        }

    }

}
