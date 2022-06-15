using System;

namespace Lab04.CustomExceptions
{
    public class OutOfArrayException : Exception
    {
        public OutOfArrayException(int index)
            : base($"Product at '{index}' not found")
        {
        }
    }
}