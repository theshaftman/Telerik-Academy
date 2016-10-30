namespace _02_Exceptions.Model
{
    using System;
    using Exceptions;

    public class CSharpExam : Exam
    {
        public const int MIN_SCORE = 0;

        public const int MAX_SCORE = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ValueLessThanZeroException();
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.Score < MIN_SCORE || this.Score > MAX_SCORE)
            {
                throw new ValueOutOfRangeException();
            }

            return new ExamResult(
                this.Score,
                MIN_SCORE,
                MAX_SCORE,
                "Exam results calculated by score.");
        }
    }
}
