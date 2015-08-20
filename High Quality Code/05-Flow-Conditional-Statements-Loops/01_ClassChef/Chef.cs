namespace ChefStuff
{
    using System;
    using _01_ClassChef;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);
            
            bowl.Add(potato);
            bowl.Add(carrot);
            
            Cut(potato);
            Cut(carrot);
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("{0} is cut.", vegetable);
        }

        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("{0} is peeled.", vegetable);
        }
    }
}