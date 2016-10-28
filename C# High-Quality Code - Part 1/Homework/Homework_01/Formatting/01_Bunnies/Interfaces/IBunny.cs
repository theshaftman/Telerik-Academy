namespace _01_Bunnies.Interfaces
{
    using Enums;

    public interface IBunny
    {
        string Name { get; }

        int Age { get; }

        FurType FurType { get; }

        void Introduce(IWriter writer);
    }
}
