using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class NumericInputTooBig : UserError
    {
        public override string UEMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string message = "You entered a numeric input that is too large a number for the field type. This fired an error!";
            return message;
        }
    }

}
