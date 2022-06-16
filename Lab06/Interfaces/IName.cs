using System;

namespace Lab06.Interfaces
{
    public interface IName : IComparable<string>
    {
        new int CompareTo(string? name);
    }
}