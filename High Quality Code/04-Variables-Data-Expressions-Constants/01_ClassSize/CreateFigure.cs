namespace CountSize
{
    using System;

    public class CreateFigure
    {
        public static void Main()
        {            
            Figure a = new Figure(5, 3);
            a = a.GetRotatedSize(15);

            Console.WriteLine(a.Width);
            Console.WriteLine(a.Height);
        }
    }
}
