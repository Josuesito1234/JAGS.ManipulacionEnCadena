using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGS.ManipulacionEnCadena
{
    public class Manipulator
    {
        public string ReverseString(string input)
        {
            if (input == null) return null;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            if (input == null) return null;
            return input.Replace(" ", string.Empty);
        }
    }
}
