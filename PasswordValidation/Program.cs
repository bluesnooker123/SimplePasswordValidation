using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_str;
            input_str = Console.ReadLine();
            if (Is_Valid(input_str))
                Console.WriteLine("valid password");
            else
                Console.WriteLine("invalid password");
        }
        static public bool Is_Valid(string input_str)
        {
            int digits = 0;
            foreach (char c in input_str)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                    return false;
                if (char.IsDigit(c))
                    digits++;
            }
            if (digits >= 2)
                return true;
            else
                return false;
        }
    }
}
