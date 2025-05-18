using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Super_Market.packages.display
{
    public class Validator
    {
        public static bool IsValidName(string input)
        {
            string pattern = @"^[a-zA-Z ]{3,}$";
            return Regex.IsMatch(input, pattern);
        }
        
        public static bool IsValidProductName(string input)
        {
            string pattern = @"^[a-zA-Z0-9 ]{3,}$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidInteger(string input)
        {
            return input.All(char.IsDigit) && !string.IsNullOrWhiteSpace(input);
        }

        public static bool IsValidEmail(string input)
        {
            string pattern = "^[a-z][a-z0-9._-]*@(gmail|yahoo|outlook|hotmail)\\.(com|org)$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidPhone(string input)
        {
            string pattern = "^01[0125]\\d{8}$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidPassword(string input)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$";
            return Regex.IsMatch(input, pattern);
        }
        
        public static bool IsValidAddress(string input)
        {
            // 13st Tahrir, Dokki, Giza
            string pattern = @"(?i)^\d+(st\.?|Street)\s+[A-Za-z\s]+,\s+[A-Za-z\s]+,\s+[A-Za-z\s]+$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
