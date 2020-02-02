using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Password generator [x = exit]");
                string input = Console.ReadLine();
                if (input == "x")
                {
                    break;
                }
                int length = Convert.ToInt32(input);
                Console.WriteLine(PasswordGenerate(length));

            }
        }

        static string PasswordGenerate(int length)
        {
            string password = "";
            Random gen = new Random();
            while (password.Length != length)
            {
                int unicodeNumbers = gen.Next(48, 58);  // generate numbers asciicode
                int unicodeCapital = gen.Next(65, 91);  // generate capital letters asciicode
                int unicodeLetters = gen.Next(97, 123); // generate letters asciicode
                int chance = gen.Next(0, 3);

                switch (chance)
                {
                    case 0:
                        password += Convert.ToChar(unicodeNumbers);
                        break;
                    case 1:
                        password += Convert.ToChar(unicodeCapital);
                        break;
                    case 2:
                        password += Convert.ToChar(unicodeLetters);
                        break;
                    default:
                        break;
                }
            }
            return password;
        }
    }
}
