using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dpdpdp
{
    static class regExpr
    {

        public static bool ValidNameAndMidName(string value)
        {
            string pattern = @"^([А-ЯЁ]{1}[а-яё]*){1}([-\s]{1}[А-ЯЁ]{1}[а-яё]*)*$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(value);
        }

        public static bool ValidationSurname(string surname)
        {
            string pattern = @"^([А-ЯЁ]{1}[а-яё]*){1}(-{1}[А-ЯЁ]{1}[а-яё]*)*$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(surname);
        }

        public static bool ValidationPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{6,12}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(password);
        }


    }
}
