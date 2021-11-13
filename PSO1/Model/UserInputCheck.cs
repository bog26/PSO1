using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PSO1.Model
{
    public class UserInputCheck
    {
        //https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-5.0
        public static bool CheckEmailAddress(string emailAddress)
        {
            bool inputIsCorrect;
            Regex rgx = new Regex(@"^[a-zA-Z0-9]{1,10}@[a-zA-Z]{1,10}.(com|de|org)$");
            inputIsCorrect = rgx.IsMatch(emailAddress);
            return inputIsCorrect;
        }
        public static bool CheckName(string name)
        {
            bool inputIsCorrect;
            Regex rgx = new Regex(@"^[A-Z]{1}[a-z]{1,20}$");
            inputIsCorrect = rgx.IsMatch(name);
            return inputIsCorrect;
        }
        public static bool CheckNumber(string number)
        {
            bool inputIsCorrect;
            Regex rgx = new Regex(@"^[0-9]{1,15}$");
            inputIsCorrect = rgx.IsMatch(number);
            return inputIsCorrect;
        }
        public static bool CheckMultiName(string name)
        {
            bool inputIsCorrect;
            //Regex rgx = new Regex(@"^[A-Z]{1}[a-z]{1,20}(\s[A-Z]{1}[a-z]{1,20}){0,3}(\s[A-Z]{1}[a-z]{1,20}){0,1}$");
            Regex rgx = new Regex(@"^[A-Z]{1}[a-z]{1,20}(\s[A-Z]{1}[a-z]{1,20}){0,3}$");
            inputIsCorrect = rgx.IsMatch(name);
            return inputIsCorrect;

        }

        public static bool CheckCreditInput(string text)
        {
            bool inputIsCorrect;
            //Regex rgx = new Regex(@"^[1-9]{1}[0-9]{1,8}.[0-9]{1,2}$");
            Regex rgx = new Regex(@"^(([1-9]{1}[0-9]{1,8})|([1-9]{1}[0-9]{1,8}.[0-9]{1,2}))$");
            inputIsCorrect = rgx.IsMatch(text);
            return inputIsCorrect;
        }
    }
}
