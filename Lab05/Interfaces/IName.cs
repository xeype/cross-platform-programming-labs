using System;

namespace Lab05.Interfaces
{
    public interface IName : IComparable<string>
    {
        new int CompareTo(string? name);
    }
}