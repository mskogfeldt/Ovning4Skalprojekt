using System;
/*frågor:
1.​​​​​​​​​​​​​​​​Hur ​​fungerar​​​ stacken ​​​och​​​ heapen​?​​Förklara ​​gärna​​ med​​ exempel ​​eller ​​skiss​​ på​​dess grundläggande​​ funktion

stacken slänger bort saker som den använt. Heapen sparar saker. jag antar att om du deklarerar en int på en class så sparas den på heapen. Det är den skillnad jag förstår mig på. Jag tror även att saker som sparas på heapen måste sparas i en textfil eller liknande för att programet ska fungera om datorn startas om eller programet stängs av.

2.​​​​​​​​​​​​​​​​Vad​​ är​​​ Value​​Types​​​ repsektive ​​​Reference​​Types ​​​och​​ vad​​ skiljer​​ dem​​ åt?
Valuytypes sparas på stacken. Reference​​Types sparas på heapen och pekar på ett object.skillnaden utöver det som getts i exempel i elaerning och denna övning är jag osäker på om jag förstår

3.Följande​​ metoder​​(​se​​ bild​​ nedan​) ​​genererar​​ olika​​ svar.​​Den ​​första​​ returnerar​​ 3,​​den andra​​ returnerar ​​4,​​varför?

Efterssom den första bara är ett värde men den andra är ett object. Så samma object har två referencer som pekar på samma object.*/


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
                    case '5':
                        CheckParanthesis();
                        break;
                    case '6':
                        CheckFibonacciItterative();
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
            // Loop this method untill the user inputs something to exit to main menue.
            bool keepLooping = true;
            List<string> theList = new List<string>();
            while (keepLooping)
            {
                Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
                    + "\n+. Add string to List"
                    + "\n-. Remove ´first item from List"
                    + "\n0. Back to main menu");
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


                    case '+':
                        Console.WriteLine("Before adding the string, the capacity of the list is: " + CheckList(theList));
                        Console.WriteLine("List count is. " + theList.Count());
                        Console.WriteLine("Please type in string for Da List");
                        theList.Add(UserInput());
                        Console.WriteLine("After adding the string, the capacity of the list is: " + CheckList(theList));
                        Console.WriteLine("List count is. " + theList.Count());
                        break;
                    case '-':

                        Console.WriteLine("removing the first string of the list");
                        try
                        {
                            Console.WriteLine("Before removing the string, the capacity of the list is: " + CheckList(theList));
                            Console.WriteLine("List count is. " + theList.Count());
                            theList.RemoveAt(0); //Tries to set input to the first char in an input line
                            Console.WriteLine("After removing the string, the capacity of the list is: " + CheckList(theList));
                            Console.WriteLine("List count is. " + theList.Count());
                        }
                        catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
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
            /*
            2.​​​​​​​​​​​​​​​​När​​ ökar​​ listans​​kapacitet? ​​(Alltså ​​den ​​underliggande ​​arrayens​​storlek) : Var fjärde index ökar den 4a start på första.
            3.​​​​​​​​​​​​​​​​Med​​ hur​​ mycket ​​ökar ​​kapaciteten? 4
            4.​​​​​​​​​​​​​​​​Varför ​​ökar ​​inte ​​listans ​​kapacitet ​​i​​ samma​​ takt​​ som ​​element ​​läggs ​​till? För att det är extra grejer på en array, så att den har några extra.
            5.​​​​​​​​​​​​​​​​Minskar​​ kapaciteten ​​när ​​element​​ tas​​ bort​​ ur​​ listan? Nej.
            6.​​​​​​​​​​​​​​​​När ​​är det ​​då fördelaktigt ​​att​​ använda​​ en​​ egendefinierad ​​​array​​​ istället​​ för​​ en​​ lista? När man vet storleken.
             */
        }


        static void ExamineQueue()
        {
            Queue<string> theQueue = new Queue<string>();
            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
                    + "\n+. Add customer to Hemmköp Cue"
                    + "\n-. Remove customer from Hemmköp cue"
                    + "\n0. Back to main menu");
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
                    case '+':
                        Console.WriteLine("Before adding the customer, the Queue looks like this ");
                        PrintTheCue(theQueue);
                        Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                        Console.WriteLine("enter the customers name.");
                        theQueue.Enqueue(UserInput());

                        Console.WriteLine("After adding the customer, the Queue looks like this ");
                        PrintTheCue(theQueue);
                        Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                        break;

                    case '-':
                        Console.WriteLine("removing the first string of the list");
                        try
                        {
                            Console.WriteLine("Before removing the customer, the Queue looks like this ");
                            PrintTheCue(theQueue);
                            Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                            theQueue.Dequeue();
                            Console.WriteLine("After removing the customer, the Queue looks like this ");
                            PrintTheCue(theQueue);
                            Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                        }
                        catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
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
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {

            // Loop this method until the user inputs something to exit to main menue.
            Stack<string> theStack = new Stack<string>();

            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
                    + "\n+. Add customer to Ica Queue"
                    + "\n-. Remove customer from Ica Queue"
                    + "\n0. Back to main menu");
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
                    case '+':
                        Console.WriteLine("Before adding the customer, the Queue looks like this ");
                        // PrintTheCue(theStack);
                        Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                        Console.WriteLine("enter the customers name.");
                        theStack.Push(UserInput());

                        Console.WriteLine("After adding the customer, the Queue looks like this ");
                        //PrintTheCue(theStack);
                        Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                        break;

                    case '-':
                        Console.WriteLine("removing the first string of the list");
                        try
                        {
                            Console.WriteLine("Before removing the customer, the Queue looks like this ");
                            // PrintTheCue(theStack);
                            Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                            theStack.Pop();
                            Console.WriteLine("After removing the customer, the Queue looks like this ");
                            //PrintTheCue(theStack);
                            Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                        }
                        catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
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

                        /* 1.​​​​​​​​​​​​​​​​Simulera ​​ännu​​ en​​ gång​​ ICA - kön ​​på​​ papper.​​Denna​​gång ​​med​​en​​​ stack​.​​Varför​​är ​​det inte​​ så​​ smart​​ att​​ använda ​​en​​​ stack​​​ i​​ det ​​här​​ fallet ?
                         För att första kunden inte får lämna kön om han inte är ensam*/

                        /*
                         
                         2.​​​​​​​​​​​​​​​​Implementera​​en ​​ReverseText-metod​​ som ​​läser ​​in ​​en ​​sträng ​​från ​​användaren​​ och med ​​hjälp​​ av​​ en ​​stack​​ vänder ​​ordning ​​på​​ teckenföljden ​​för​​ att ​​sedan ​​skriva​​ ut​​ 
                        den omvända​​strängen ​​till​​ användaren. ::: rad 324
                         */

                        // 2.​​​​​​​​​​​​​​​​Implementera ​​funktionaliteten ​​i​​ metoden ​​​Check Parantheses​.​​Låt​​
                        // programmet ​​läsa in ​​en ​​​sträng ​​​från ​​användaren ​​och ​​returnera​​ ett​​ svar​​ som​​ reflekterar ​​huruvida strängen ​​är​​ väl formad ​​eller ​​ej.
                }
            }

            /* Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            string toBetested;

            // Loop this method until the user inputs something to exit to main menue.
            Stack<string> theStack = new Stack<string>();

            bool keepLooping = true;

            while (keepLooping)
            {
                Console.WriteLine("Please navigate through the menu by inputting a character \n(+, 0) of your choice"
                    + "\n+. Add string to be tested"
                    + "\n0. Back to main menu");
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
                    case '+':
                        Console.WriteLine("write your text, w ");
                        toBetested = Console.ReadLine();
                        if (TestStringParanthesesTheMotherShip(toBetested)) Console.WriteLine("Test sucess!");
                        else Console.WriteLine("Test failed!");
                        break;
                    case '0':
                        Main();
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (+, -, 0)");
                        break;

                }
            }

            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

        static void CheckFibonacciItterative()
        {

            bool keepLooping = true;
            string fibonacci = "";
            int fibonacciInt = 0;

            while (keepLooping)
            {
                Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
                    + "\n+. Type a number in the Fibonacci sequence:"

                    + "\n0. Back to main menu");
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
                    case '+':
                        Console.WriteLine("Type the number now ");
                        fibonacci = UserInput();
                        try
                        {
                            fibonacciInt = Int32.Parse(fibonacci);
                            fibonacciInt = ItteraticeFibonacciSequence(fibonacciInt);
                            Console.WriteLine("The number you are looking for is: " + fibonacciInt);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Unable to parse '{input}'");
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

        static void PrintTheCue(Queue<string> cueue)
        {
            foreach (var item in cueue)
            {
                Console.WriteLine(item);
            }
        }

        static void FippWord(string input)
        {
            Stack<char> stack = new Stack<char>();
            string output = "";
            foreach (char c in input)
            {
                stack.Push(c);
            }
            foreach (char c in stack)
            {
                output += c;
            }
            Console.WriteLine(output);
        }


        static bool TestStringParanthesesTheMotherShip(string toBeTested)
        {
            //making a sting of all Parantheses
            string actualParentesis = MakeListOfParantheses(toBeTested);
            string updatedWord;
            // if (toBeTested.Length > 1)
            //{
            for (int i = actualParentesis.Length; i >= 0; i--)
            {
                //seeing so that the last char is a closing Parantheses
                if (actualParentesis.Length > 0 && CheckClosingParantheses(actualParentesis[i - 1]))
                {
                    //seeing where the closest opening Parantheses or returning -1 if it finds non
                    int openingParanthesesIndex = IndexOfOpeningParantheses(actualParentesis);
                    if (openingParanthesesIndex == -1) return false;
                    else
                    {
                        //removing the the last char, ie a closing Parantheses, and the opening Parantheses
                        updatedWord = RemoveClosedParantheses(actualParentesis, openingParanthesesIndex);
                        //calling this metod again
                        TestStringParanthesesTheMotherShip(updatedWord);
                    }
                }
            }
            //}
            return true;
        }

        static string MakeListOfParantheses(string text)
        {
            List<char> Parentesis = new List<char>() { '(', '[', '{', '<', ')', ']', '}', '>' };
            string actualParentesis = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (Parentesis.Contains(text[i])) actualParentesis += text[i];
            }
            return actualParentesis;

        }

        static bool CheckClosingParantheses(char lastChar)
        {
            List<char> negativeChars = new List<char>() { ')', ']', '}', '>' };
            if (negativeChars.Contains(lastChar)) return true;
            return false;
        }

        static int IndexOfOpeningParantheses(string toBeTested)
        {
            char openingParantheses = FindOpeningParantheses(toBeTested[toBeTested.Length - 1]);
            for (int i = toBeTested.Length - 1; i >= 0; i--)
            {
                if (toBeTested[i] == openingParantheses) return i;
            }
            return -1;
        }

        static char FindOpeningParantheses(char closer)
        {
            if (closer == ')') return '(';
            else if (closer == ']') return '[';
            else if (closer == '}') return '{';
            else return '<';
        }

        static int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (RecursiveEven(n - 1) + 2);
        }

        static int RecursiveFibonacciSequence(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (RecursiveFibonacciSequence(n - 2) + 1);
            }
        }

        static int ItterativeEven(int n)
        {
            return n * 2;
        }

        static int ItteraticeFibonacciSequence(int n)
        {
            // int damnHowMuchEasierIteerativeIsThanRecursive = 0;
            List<int> damnHowMuchEasierIteerativeIsThanRecursive = new List<int>() { };
            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0) damnHowMuchEasierIteerativeIsThanRecursive.Add(i);
                else if (i == 1) damnHowMuchEasierIteerativeIsThanRecursive.Add(i);
                else damnHowMuchEasierIteerativeIsThanRecursive.Add(i + damnHowMuchEasierIteerativeIsThanRecursive[i - 2]);
            }
            return damnHowMuchEasierIteerativeIsThanRecursive[n + 1];
        }

        static string RemoveClosedParantheses(string toBeedited, int openingParantheses)
        {
            string editedSting = "";
            for (int i = 0; i < toBeedited.Length - 1; i++)
            {
                if (i != openingParantheses) editedSting += toBeedited[i];
            }
            return editedSting;
        }


    }


}
