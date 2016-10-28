namespace _01_Events.Interfaces
{
    using System;

    public interface IEvent
    {
        DateTime Date { get; }

        string Title { get; }

        string Location { get; }

        int CompareTo(object obj);
    }
}
