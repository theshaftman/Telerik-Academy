namespace _04_MineSweeper.Model
{
    internal class Highscore
    {
        private string name;

        private int points;

        internal Highscore()
        {
        }

        internal Highscore(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        internal string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        internal int Points
        {
            get
            {
                return this.points;
            }

            private set
            {
                this.points = value;
            }
        }
    }
}
