using System;
using System.Text.RegularExpressions;

namespace poc_CellPhoneValidator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite um numero de celular: ");

            var cellphone = Console.ReadLine();

            Console.WriteLine(CellPhoneValidator(cellphone));
        }

        private static string CellPhoneValidator(string cellphone)
        {
            Regex regex = new Regex(@"^\+[5]{2}[1-9]{2}(9[1-9])[0-9]{3}[0-9]{4}$");

            if (regex.IsMatch(cellphone)) {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}



