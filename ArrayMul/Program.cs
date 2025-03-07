using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {

            float a11 = float.Parse(args[0]);
            float a12 = float.Parse(args[1]);
            float a21 = float.Parse(args[2]);
            float a22 = float.Parse(args[3]);
            float b1 = float.Parse(args[4]);
            float b2 = float.Parse(args[5]);

            //Matriz 2x2
            float[,] A = new float [2 , 2] {{a11 , a12} , {a21 , a22}};

            //Matriz 2x1
            float[] B = new float [] {b1 , b2};

            //Result
            float [] resultM = new float[2];

            //Multiplication
            for (int x = 0;x < 2; x++)
            {
                resultM[x] = 0;
                for (int y = 0; y < 2; y++)
                {
                    resultM[x] += A[x , y] * B[y];
                }
            }

            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine($"|{resultM[x],7:F2}|");
            }
        }
    }
}
