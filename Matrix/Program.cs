using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int input;

            float radians;
            Matrix22 matrixA = new Matrix22();
            Matrix22 matrixB = new Matrix22();



            Console.WriteLine("Enter Values For Matrix A: ");
            matrixA.elements[0, 0] = float.Parse(Console.ReadLine());
            matrixA.elements[0, 1] = float.Parse(Console.ReadLine());
            matrixA.elements[1, 0] = float.Parse(Console.ReadLine());
            matrixA.elements[1, 1] = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Values For Matrix B: ");
            matrixB.elements[0, 0] = float.Parse(Console.ReadLine());
            matrixB.elements[0, 1] = float.Parse(Console.ReadLine());
            matrixB.elements[1, 0] = float.Parse(Console.ReadLine());
            matrixB.elements[1, 1] = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1. Add\n2. Multiply\n3. Rotation");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Matrix22 matrixC = matrixA.Add(matrixB);
                Draw2x2Matrix(matrixC.elements);
            }
            if (input == 2)
            {
                Matrix22 matrixC = matrixA.Muliply(matrixB);
                Draw2x2Matrix(matrixC.elements);
            }
            if (input == 3)
            {
                Console.WriteLine("Enter Radian: ");
                radians = float.Parse(Console.ReadLine());
                Matrix22 matrixC = Matrix22.CreateRotation(radians);
                Draw2x2Matrix(matrixC.elements);

                MatrixChecker.CheckRotationMatrix(radians, matrixC.elements[0, 0], matrixC.elements[0, 1], matrixC.elements[1, 0], matrixC.elements[1, 1]);

            }
            Console.ReadKey();

        }
    }
}
