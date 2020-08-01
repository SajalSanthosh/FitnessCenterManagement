using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicketReservationSystem.Utils
{
    class Validator
    {


        public static bool ValidateText(String name)
        {
            return Regex.IsMatch(name, @"^[\p{L} \.'\-]+$");
        }

        public static bool ValidateEmail(String email)
        {
            return Regex.IsMatch(email, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
        }

        public static bool ValidateNumber(String num)
        {
            return Regex.IsMatch(num, @"^[0-9]*$");
        }



    }
}

