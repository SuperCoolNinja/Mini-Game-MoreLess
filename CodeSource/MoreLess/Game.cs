using System;
using System.Collections.Generic;
using System.Text;

namespace MoreLess
{
    class Game
    {
        //Converti string to int :
        private bool isNumberValid(string text)
        {
            return int.TryParse(text, out int n);
        }

        public void BeginGame()
        {
            //Player MAX TRY :
            var MAX_TRY = 5;

            //Player try used :
            var try_used = 0;

            //Load a random number between 50-100 :
            var correctNumber = new Random().Next(50, 100);

            //Set a default userNumber :
            var userNumber = "0";

            do
            {
                //Loop link to the player maxtry :
                for (var i = 0; i <= MAX_TRY; i++)
                {
                    try_used += 1;

                    //Ask the number Value : 
                    //Console.Write("Number loaded : {0}.\n", correctNumber);
                    Console.Write("You need to enter the correct number between 50-100\nTry remaining {0}.\n", MAX_TRY);
                    Console.Write("Enter : ");
                    userNumber = Console.ReadLine();

                    //Clear the console :
                    Console.Clear();

                    //Check if the input of the user is a valid number :
                    if (!isNumberValid(userNumber))
                    {
                        Console.WriteLine("Text not allowed");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        //Check if the user number is more than the correct number :
                        if (int.Parse(userNumber) > correctNumber)
                        {
                            Console.WriteLine("It's less !");
                        }

                        //Check if the user number is less than the correct number :
                        else if (int.Parse(userNumber) < correctNumber)
                        {
                            Console.WriteLine("It's more !");
                        }
                        else
                        {
                            Console.WriteLine("Bravo !");
                            break;
                        }
                    }

                    MAX_TRY -= 1;
                }
            }
            while (int.Parse(userNumber) != correctNumber && MAX_TRY != 0);

            Console.WriteLine("YOU END THE GAME WITH {0} TRY", try_used);
            Console.ReadKey();
        }

    }
}
