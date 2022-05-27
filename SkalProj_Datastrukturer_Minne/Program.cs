using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {


            Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
                + "\n+. Add string to List"
                + "\n-. Remove ´first item from List"
                + "\n0. Back to main menu");
            char input = ' '; //Creates the character input to be used with the switch-case below.

            // Loop this method untill the user inputs something to exit to main menue.
            bool keepLooping = true;
            List<string> theList = new List<string>();
            while (keepLooping)
            {
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    
                   
                    case '+':
                        Console.WriteLine("Before adding the string, the capacity of the list is: " + CheckList(theList));
                        Console.WriteLine("Please type in string for Da List");
                        theList.Add(UserInput());
                        Console.WriteLine("After adding the string, the capacity of the list is: " + CheckList(theList));
                        break;
                    case '-':
                        Console.WriteLine("removing the first string of the list");
                        try
                        {
                            Console.WriteLine("Before removing the string, the capacity of the list is: " + CheckList(theList));
                            theList.RemoveAt(0); //Tries to set input to the first char in an input line
                            Console.WriteLine("After removing the string, the capacity of the list is: " + CheckList(theList));
                        }
                        catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                        {
                            Console.Clear();
                            Console.WriteLine("The list seems to be empty, please enter a string to the list");
                            ExamineList();
                        }
                        break;
                    case '0':
                        Main();
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (+, -, 0)");
                        break;
                }

            }
            /* * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

        static string UserInput()
        {
            return Console.ReadLine();
        }

        static int CheckList(List<string> list)
        {
            var capacity = list.Capacity;

            return capacity;
        }

        

    }
}

