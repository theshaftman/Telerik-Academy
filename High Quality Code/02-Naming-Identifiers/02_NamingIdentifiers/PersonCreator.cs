namespace _02_NamingIdentifiers
{
    using System;

    public class PersonCreator
    {
        public static void Main()
        {
            Person firstPerson = new Person(2);
            Person secondPerson = new Person(3);

            Console.WriteLine("Name: {0}, age: {1}, gender {2}", 
                firstPerson.Name, firstPerson.Age, firstPerson.Gender);
            Console.WriteLine("Name: {0}, age: {1}, gender {2}", 
                secondPerson.Name, secondPerson.Age, secondPerson.Gender);
        }
    }
}
