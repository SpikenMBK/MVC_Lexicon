using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lexicon.Models
{
    public class FeverModel
    {
        public static string Check(int temp)
        {
            string message;

            if (temp > 37)
            {
                message = "Din temp är " + temp + " grader, och visar att du har feber";
            }
            else
                message = "Du har ingen feber";
            return message;
        }
    }
}
