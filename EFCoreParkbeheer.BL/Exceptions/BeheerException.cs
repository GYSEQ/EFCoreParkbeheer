using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Exceptions
{
    public class BeheerderException : Exception
    {
        public BeheerderException(string message) : base(message)
        {
        }

        public BeheerderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
