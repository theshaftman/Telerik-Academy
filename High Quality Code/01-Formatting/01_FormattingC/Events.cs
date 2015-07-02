namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; set; }
        
        public string Title { get; set; }

        public string Location { get; set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byTheDate = this.date.CompareTo(other.date);
            int byTheTitle = this.title.CompareTo(other.title);
            int byTheLocation = this.location.CompareTo(other.location);

            if (byTheDate == 0)
            {
                if (byTheTitle == 0)
                {
                    return byTheLocation;
                }
                else
                {
                    return byTheTitle;
                }
            }
            else
            {
                return byTheDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}