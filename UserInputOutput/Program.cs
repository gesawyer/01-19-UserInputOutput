using System;

namespace looooooops
{
    class MainClass
    {
        public static void Main(string[] args)

        {

            


            do
            {


                Console.WriteLine("Hello! Please enter the length of the room in feet.");

                string input = Console.ReadLine();
                double Length = double.Parse(input);

                

                Console.WriteLine("Please enter the width in feet.");
                string input2 = Console.ReadLine();
                double Width = double.Parse(input2);
                

                Console.WriteLine("Please enter the height in feet.");
                string input3 = Console.ReadLine();
                double Height = double.Parse(input3);

                double PerimLength = Length * 2;
                

                double PerimWidth = Width * 2;
                


                Console.WriteLine($"The area of the room is " + (Length * Width) + " feet, the perimeter of the room is " + (PerimLength + PerimWidth) +
                    " feet, and the volume of the room is " + (Length * Width * Height)+ " feet.");

                Console.WriteLine();

                Console.WriteLine("Would you like to continue with another room? y/n");



            } while (Console.ReadLine() == "y");




        }

    }


}



        
    

