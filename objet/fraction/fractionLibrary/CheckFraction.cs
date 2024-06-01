using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractionLibrary
{
    public class CheckFraction : Exception
    {
        public CheckFraction()
        {
        }

        public CheckFraction(string? Fraction) : base(String.Format("la fraction : {0} est invalide.",Fraction))
        {
        }
    }
}
