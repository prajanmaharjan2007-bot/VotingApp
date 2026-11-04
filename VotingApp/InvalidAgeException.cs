using System;
using System.Collections.Generic;
using System.Text;

namespace VotingApp
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string Message):base(Message)
        {



        }
    }
}
