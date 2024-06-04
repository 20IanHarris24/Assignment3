using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string message = "You tried to use a numeric input in a text only field. This fired an error!";
            return message;
        }
    }

}
