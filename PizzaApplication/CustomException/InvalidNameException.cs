using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.CustomException
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        { 

        }

    }
}
