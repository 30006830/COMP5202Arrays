using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Question 1
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("====================w====================");
            Console.WriteLine("================ Arrays! ================");
            Console.WriteLine("====================w====================");

            string[] medalWinners;
            medalWinners = new string[3];

            Console.WriteLine("Please enter the winner's name of the Gold medal: ");
            medalWinners[0] = Console.ReadLine();
            Console.WriteLine("Please enter the winner's name of the Silver medal: ");
            medalWinners[1] = Console.ReadLine();
            Console.WriteLine("Please enter the winner's name of the Bronze medal: ");
            medalWinners[2] = Console.ReadLine();

            Console.WriteLine("Which medal winner would you like to view?");
            Console.Write("1 - Gold\n2 - Silver\n3 - Bronze\n");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"The medal winner is: {medalWinners[input - 1]}");

            Console.WriteLine("Press enter to continue to the next program..");
            Console.ReadLine();
            Console.Clear();
        
            //Question 2
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("====================w====================");
            Console.WriteLine("============== More Arrays! =============");
            Console.WriteLine("====================w====================");

            string[] names;
            names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Please enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine($"The first name you entered is: {names[0]}\n");
            Console.WriteLine($"The last name you entered was: {names[names.Length -1]}");

            Console.WriteLine("Press enter to continue to the next program..");
            Console.ReadLine();
            Console.Clear();

            //Question 3
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("====================w====================");
            Console.WriteLine("============ Another Array!! ============");
            Console.WriteLine("====================w====================");

            string[] japanese = { "Ohayo", "Konichiwa", "Daisuki" };
            string[] english = { "Morning", "Hello", "Love" };

            for(int i =0; i < japanese.Length; i++)
            {
                Console.WriteLine($"{i+1}. {english[i]}");
            }

            Console.WriteLine("Which of these words would you like to translate? (btw this program translates words!): ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{english[input1 - 1]} translated into Japanese is: {japanese[input1 -1]}");

            Console.WriteLine("Thanks for using this app! Please press enter to continue..");
            Console.ReadLine();
        }
    }
}
