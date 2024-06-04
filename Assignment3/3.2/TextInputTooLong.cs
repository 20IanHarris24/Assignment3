using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class TextInputTooLong : UserError
    {
        public override string UEMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string message = "You enter a text string that was too long for the input field. This fired an error!";
            return message;
        }
    }
}
