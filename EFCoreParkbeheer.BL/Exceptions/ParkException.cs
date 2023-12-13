using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Exceptions
{
    public class ParkException : Exception
    {
        public ParkException(string message) : base(message)
        {
        }

        public ParkException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
