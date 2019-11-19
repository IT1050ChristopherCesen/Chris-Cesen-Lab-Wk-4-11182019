using System;

namespace CHris_Cesen_Wk_4_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            /*There is the variable which is the name of the code that controlls the rest of the code. 
             * The next part is the variable’s initial value which the code will use as a starting point for the output.  
             * Next is the increment value, which is how the variable will be changed as it is run through the code. 
             * Finally there is the loop-continuation condition which tells the loop when to stop.
 */


            //Question 2
            /*
              Both are used to perform an action when certain conditions are met.  
              For loops are used for specific number or repetitions and while loops are better for an unknown number of repetitions  

             */


            //Question 3
            /*
             A do while loop executes its program at least once.  If I needed to check a line of code, this lets me do that. 
             It then moves on to the next line of code letting the program run more efficiently, 
             rather than completing a statement that might not need to be completed.

             */


            //Question 4
            /*for (int i = 1; i <= 100; i++)
             {
                 Console.WriteLine("{0}", i);
                 // if ((i % 2) == 0;
                 Console.WriteLine{ "It is even" };
             }
             */

            //Question 5
           /* 
            Console.Write("Please enter a temperature     ");
            int  i = Convert.ToInt32(Console.ReadLine());
            if (i < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (i < 20)
            {
                Console.WriteLine("Penguin");
            }

            else if (i < 40)
            {
                Console.WriteLine("Moose");
            }

            else if (i <50)
            {
                Console.WriteLine("Reindeer");
          }

            else if (i < 60)
            {
                Console.WriteLine("Deer");
            }

            else if (i < 70)
            {
                Console.WriteLine("Turtle");
            }

            else if (i < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (i < 90)
            {
                Console.WriteLine("Deer");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            */

            //Question 6
            /*
            int  exhibit;
            Console.Write("Please enter the exhibit number  ");
            exhibit= Convert.ToInt32(Console.ReadLine());


            switch (exhibit)
            {
                case 1:
                    Console.WriteLine("Polor Bear");
                    break;

                case 2:
                    Console.WriteLine("Penguin");
                    break;

                case 3:
                    Console.WriteLine("Moose");
                    break;

                case 4:
                    Console.WriteLine("Reindeer");
                    break;

                case 5:
                    Console.WriteLine("Deer");
                    break;

                case 6:
                    Console.WriteLine("Turtle");
                    break;

                case 7:
                    Console.WriteLine("Lion");
                    break;

                case 8:
                    Console.WriteLine("Fish");
                    break;


                case 9:
                    Console.WriteLine("Bug");
                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    break;




            }
            */


            //Question 7
            /*int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i++);
            }
            

            //Question 8
            /*
            for (int i = 0; i < 101; i++)
                 Console.WriteLine(i);
                 Console.WriteLine("********");
                 */

            //Quetion 9 Extra Credit

            /*int i, j;
            for (i = 0; i < 10; i++) 
            {
                for (j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            int i, j;
            for (i = 10; i > 0; i--)
            {
                Console.WriteLine("**********".Substring(0, i));
            }
            





        }
    }
}
