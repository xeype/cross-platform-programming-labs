using System;

namespace Lab06.CustomExceptions
{
    public class OutOfArrayException : Exception
    {
        public OutOfArrayException(int index)
            : base($"Product at '{index}' not found")
        {
        }
    }
}