namespace _02_Human.Model
{
    using System;
    using Enums;

    public class Human
    {
        private const int MIN_AGE_COUNT = 0;

        private const int MAX_AGE_COUNT = 150;

        private string name;

        private Gender gender;

        private int age;

        public Human(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        ExceptionMessages.NULLABLE_OR_EMPTY_NAME);
                }

                this.name = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                this.gender = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < MIN_AGE_COUNT || value > MAX_AGE_COUNT)
                {
                    throw new ArgumentException(
                        string.Format(
                            ExceptionMessages.AGE_OUT_OF_BOUNDS,
                            MIN_AGE_COUNT,
                            MAX_AGE_COUNT));
                }

                this.age = value;
            }
        }
    }
}
