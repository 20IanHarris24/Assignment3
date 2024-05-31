using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string message = "You tried to use a text input in a numeric only field. This fired an error!";
            return message;
        }
    }
}
