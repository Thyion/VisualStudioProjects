using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class InvalidStringSizeException : Exception
    {
        public InvalidStringSizeException(string message)
            : base("Invalid String Size: " + message) { }
    }
}
