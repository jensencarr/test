using System.Text.RegularExpressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv: ");
            string input = Console.ReadLine();
            string konsunanter = "bcdfghjklmnpqrstvwxz";


            string rövarspråket = "";

            foreach (var bokstav in input)
            {
                
                if (konsunanter.Contains(bokstav))
                {
                    rövarspråket += bokstav + "o" + bokstav;
                    
                }
                else
                {
                    rövarspråket += bokstav;
                }
            }
            Console.Write(rövarspråket);

        }
    }
}