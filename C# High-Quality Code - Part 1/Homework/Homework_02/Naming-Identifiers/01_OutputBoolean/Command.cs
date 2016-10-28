namespace _01_OutputBoolean
{
    using System;

    internal class Command
    {
        private const int MAX_BOOLEAN_COUNT = 6;

        private int index;
        
        internal Command()
        {
        }

        internal void AddBoolean(bool inputBoolean)
        {
            this.index += 1;

            if (this.index > MAX_BOOLEAN_COUNT)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            OutputWriter.WriteLine(inputBoolean);
        }
    }
}
