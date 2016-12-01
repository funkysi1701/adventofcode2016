using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2016
{
    class Program
    {
        public static string input = "L1, L3, L5, L3, R1, L4, L5, R1, R3, L5, R1, L3, L2, L3, R2, R2, L3, L3, R1, L2, R1, L3, L2, R4, R2, L5, R4, L5, R4, L2, R3, L2, R4, R1, L5, L4, R1, L2, R3, R1, R2, L4, R1, L2, R3, L2, L3, R5, L192, R4, L5, R4, L1, R4, L4, R2, L5, R45, L2, L5, R4, R5, L3, R5, R77, R2, R5, L5, R1, R4, L4, L4, R2, L4, L1, R191, R1, L1, L2, L2, L4, L3, R1, L3, R1, R5, R3, L1, L4, L2, L3, L1, L1, R5, L4, R1, L3, R1, L2, R1, R4, R5, L4, L2, R4, R5, L1, L2, R3, L4, R2, R2, R3, L2, L3, L5, R3, R1, L4, L3, R4, R2, R2, R2, R1, L4, R4, R1, R2, R1, L2, L2, R4, L1, L2, R3, L3, L5, L4, R4, L3, L1, L5, L3, L5, R5, L5, L4, L2, R1, L2, L4, L2, L4, L1, R4, R4, R5, R1, L4, R2, L4, L2, L4, R2, L4, L1, L2, R1, R4, R3, R2, R2, R5, L1, L2";

        public static int X = 0;
        public static int Y = 0;
        static void Main(string[] args)
        {
            int move = 0;
            int direction = 0;//define which direction we are facing 0 = N, 1 = E, 2 = S, 3 = W

            string[] inputArray = input.Split(',');

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Substring(0, 1) == "L") {
                    direction++;
                    if (direction == 4) direction = 0;
                }
                if (inputArray[i].Substring(0, 1) == "R") {
                    direction--;
                    if (direction == -1) direction = 3;
                }
                if (inputArray[i].Substring(0, 1) == " ")
                {
                    if (inputArray[i].Substring(1, 1) == "L")
                    {
                        direction++;
                        if (direction == 4) direction = 0;
                    }
                    if (inputArray[i].Substring(1, 1) == "R")
                    {
                        direction--;
                        if (direction == -1) direction = 3;
                    }
                }
                if (inputArray[i].Substring(0, 1) == " ")
                {
                    Int32.TryParse(inputArray[i].Substring(2), out move);
                }
                else
                {
                    Int32.TryParse(inputArray[i].Substring(1), out move);
                }


                movealong(move, direction);

                
            }
            int Total = Math.Abs(X) + Math.Abs(Y);
            Console.WriteLine("X " + X + " Y " + Y);
            Console.WriteLine("Total " + Total);
            Console.ReadKey();
        }

        private static void movealong(int move, int direction)
        {
            switch (direction)
            {
                case 0:
                    Y = Y + move;
                    break;
                case 1:
                    X = X + move;
                    break;
                case 2:
                    Y = Y - move;
                    break;
                case 3:
                    X = X - move;
                    break;
                default:
                    break;
            }
        }
    }
}
