namespace _02_Human.Model
{
    using System.Collections.Generic;
    using Enums;

    public class Command
    {
        private List<Human> humanList;

        public Command()
        {
            this.humanList = new List<Human>();
        }

        public Human[] HumanList
        {
            get
            {
                return this.humanList.ToArray();
            }
        }

        public void AddHuman(int humanAge)
        {
            Human human;

            if (humanAge % 2 == 0)
            {
                human = new Human("Батката", Gender.Man, humanAge);
            }
            else
            {
                human = new Human("Мацето", Gender.Women, humanAge);
            }

            this.humanList.Add(human);
        }
    }
}
