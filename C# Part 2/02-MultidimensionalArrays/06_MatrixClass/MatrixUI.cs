namespace _06_MatrixClass
{
    using System;

    class MatrixUI
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[1, 0] = 2;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 2;
            matrix2[0, 1] = 3;

            Matrix sum = matrix1 + matrix2;
            Console.WriteLine(sum.ToString());

            sum = matrix1 - matrix2;
            Console.WriteLine(sum.ToString());

            sum = matrix1 * matrix2;
            Console.WriteLine(sum.ToString());
        }
    }
}
