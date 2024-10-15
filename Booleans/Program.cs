using System.ComponentModel.Design;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCSharp = true;
            bool isMono = false;
            Console.WriteLine(isCSharp);
            Console.WriteLine(isMono);

            int x = 10;
            int y = 5;
            Console.WriteLine(x > y);
            Console.WriteLine(y > x);
            Console.WriteLine((x == 10));
            Console.WriteLine(x == y);

            int myAge = 27;
            int votingAge = 18;
            if (myAge >= votingAge)
            {
                Console.WriteLine("Elegible for vote.");
            }
            else
            {
                Console.WriteLine("Not elegible for vote.");
            }
        }
    }
}
