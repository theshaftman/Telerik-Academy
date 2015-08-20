namespace CountSize
{
    using System;

    public class Figure
    {
        public double Width { get; set; }

        public double Height { get; set; }
        
        public Figure(double sizeWidth, double sizeHeight)
        {
            this.Width = sizeWidth;
            this.Height = sizeHeight;
        }

        public Figure GetRotatedSize(double angleOfFigureRotation)
        {
            double angleCos = Math.Cos(angleOfFigureRotation);
            double angleSin = Math.Sin(angleOfFigureRotation);

            double resultSizeWidth = (Math.Abs(angleCos) * this.Width) + (Math.Abs(angleSin) * this.Height);
            double resultSizeHeight = (Math.Abs(angleSin) * this.Width) + (Math.Abs(angleCos) * this.Height);

            Figure result = new Figure(resultSizeWidth, resultSizeHeight);

            return result;
        }
    }
}