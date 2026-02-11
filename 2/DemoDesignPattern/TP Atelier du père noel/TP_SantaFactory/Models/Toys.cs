using System;
using System.Collections.Generic;
using System.Text;

namespace TP_SantaFactory.Models
{
    internal class Toys
    {
        public class Doll : IToy
        {
            public string GetDescription()
            {
                return "Une poupée";
            }
        }

        public class Train : IToy
        {
            public string GetDescription()
            {
                return "Un Train";
            }
        }
    }
}
