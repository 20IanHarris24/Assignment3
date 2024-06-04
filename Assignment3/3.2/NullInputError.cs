using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string message = "You entered a 'null' in a text only field. This fired an error!";
            return message;
        }
    }
}
