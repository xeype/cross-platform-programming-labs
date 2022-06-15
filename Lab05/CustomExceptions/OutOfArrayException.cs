using System;

namespace Lab05.CustomExceptions
{
    public class OutOfArrayException : Exception
    {
        public OutOfArrayException(int index)
            : base($"Product at '{index}' not found")
        {
        }
    }
}