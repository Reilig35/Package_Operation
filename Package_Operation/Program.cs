using System;

namespace Package_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting message
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.");
            
            //Getting package weight
            Console.WriteLine("Please enter the package weight:\n");
            int Pack_Weight = Convert.ToInt32(Console.ReadLine());

            //Branch 1 if package meets weight requirment
            if (Pack_Weight <= 50)
            {
                Console.WriteLine("What is the width of the package:");
                int Pack_Width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of the package");
                int Pack_Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of the package");
                int Pack_Length = Convert.ToInt32(Console.ReadLine());

                int Total_Size_ADD = (Pack_Width + Pack_Length + Pack_Height);
                
                //Branch 1-A if package size meets standard
                if (Total_Size_ADD <= 50)
                {
                    float Total_Cost = (((Pack_Height * Pack_Length) * Pack_Width) * Pack_Weight) / 100;
                    Console.WriteLine($"Your estiamted cost for shipping is:\n£{Total_Cost}.00\nThank You :)");

                }

                //Branch 1-B if package fails to meet standard 
                else if (Total_Size_ADD >= 51)
                {
                    Console.WriteLine("Sorry your package is too big to ship with us :(");
                }
                
            }
            //Branch 2 if package does not meet weight requirment
            else if (Pack_Weight >= 51)
            {
                Console.WriteLine("Sorry your package is to heavy to ship with us :(");
            }

        }

           
    }
}
