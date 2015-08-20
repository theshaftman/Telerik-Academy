namespace _02_NamingIdentifiers
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;
            if (age % 2 == 0)
            {
                this.Name = "John";
                this.Gender = GenderValue.Male;
            }
            else
            {
                this.Name = "Mary";
                this.Gender = GenderValue.Female;
            }
        }

        public enum GenderValue
        {
            Male,
            Female
        }

        public GenderValue Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
