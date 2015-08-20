namespace _02_RefactorTheIfStatements
{
    public class Potato
    {
        private bool isRotten = true;
        private bool isPeeled = true;

        public Potato()
        {

        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }
        }
        
        public bool IsPeeled 
        {
            get
            {
                return this.isPeeled;
            }
        }

    }
}
