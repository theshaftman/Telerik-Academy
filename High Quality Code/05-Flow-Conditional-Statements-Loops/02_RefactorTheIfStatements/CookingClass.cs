namespace _02_RefactorTheIfStatements
{
    using System;

    public class CookingClass
    {
        public CookingClass()
        {

        }

        Potato potato = new Potato();

        public void Cook(Potato potato)
        {
            Console.WriteLine("Potato is being cooked.");
        }

        public void Cooking()
        {
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
                else
                {
                    Console.WriteLine("I REFUSE to cook rotten potatoes!!!");
                }
            }
        }
    }
}
