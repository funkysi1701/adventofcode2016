using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2016
{
    class Program
    {
        public static string inputday1 = "L1, L3, L5, L3, R1, L4, L5, R1, R3, L5, R1, L3, L2, L3, R2, R2, L3, L3, R1, L2, R1, L3, L2, R4, R2, L5, R4, L5, R4, L2, R3, L2, R4, R1, L5, L4, R1, L2, R3, R1, R2, L4, R1, L2, R3, L2, L3, R5, L192, R4, L5, R4, L1, R4, L4, R2, L5, R45, L2, L5, R4, R5, L3, R5, R77, R2, R5, L5, R1, R4, L4, L4, R2, L4, L1, R191, R1, L1, L2, L2, L4, L3, R1, L3, R1, R5, R3, L1, L4, L2, L3, L1, L1, R5, L4, R1, L3, R1, L2, R1, R4, R5, L4, L2, R4, R5, L1, L2, R3, L4, R2, R2, R3, L2, L3, L5, R3, R1, L4, L3, R4, R2, R2, R2, R1, L4, R4, R1, R2, R1, L2, L2, R4, L1, L2, R3, L3, L5, L4, R4, L3, L1, L5, L3, L5, R5, L5, L4, L2, R1, L2, L4, L2, L4, L1, R4, R4, R5, R1, L4, R2, L4, L2, L4, R2, L4, L1, L2, R1, R4, R3, R2, R2, R5, L1, L2";

        public static string inputday2 = "RLRDDRLLDLRLUDDULLDRUUULDDLRLUDDDLDRRDUDDDLLURDDDLDDDRDURUDRDRRULUUDUDDRRRLRRRRRLRULRLLRULDRUUDRLRRURDDRLRULDLDULLLRULURRUULLRLLDDDDLLDURRUDLDLURDRDRDLUUUDDRDUUDDULLUURRDRLDDULURRRUDLLULULDLLURURUDRRRRUDRLRDLRRLDDRDDLULDLLLURURDUDRRRRUULURLRDULDRLUDRRUDDUULDURUDLDDURRRDLULLUUDRLLDUUDLDRUDDRLLLLLLDUDUDDLRDLRRDRUDDRRRLLRRDLLRLDDURUURRRDDLDUULLDLDLRURDLLLDDRUUDRUDDDDULRLLDUULRUULLLULURRRLLULDLDUDLDLURUDUDULLDLLUUDRRDRLUURURURURDLURUUDLDRLUDDUUDULDULULLLDLDDULLULLDULRRDRULLURRRULLDDDULULURLRDURLLURUDDULLRUDLRURURRDRDUULDRUUDURDURDDLRDUUULDUUDRDURURDRRRURLLDDLLLURURULULUDLRDLDRDRURLRLULRDLU,UDLDURRULDRDDLDUULUDLDUULUURDDRUDRURRRUDRURLLDDRURLDLRDUUURDLLULURDDUDDDRRRURLLDLDLULRDULRLULDLUUDLLRLDLRUUULDDUURDLDDRRDLURLDUDDRURDRRURDURRRLUULURDDLRDLDRRRLDUDRLRLLRLDDUULDURUUULLLRRRRRRRDRRRDRLUULDLDDLULDRDUDLLUDRRUDRUUDULRLUURDDDDRRUUDLURULLLURDULUURDRDDURULRUDRRDLRDUUUUUDDDRDRDDRUDRDDDRLRUUDRDRDDDLUDRDRLDRDDRULURDRLDRUDUDRUULRLLUDRDRLLLLDUDRRLLURDLLLDRRUDDUDRLRLDUDRLURRUUULURDDRUURRLDRLRRRUUDLULDDDRDLDUUURLLUULDDRRUDLDDRUDUDUURURDDRDULLLLLULRRRDLRRRDDDLURDDDDLUULLLRDDURRRRLURRLDDLRUULULRDRDDDDLDUUUUUUDRRULUUUDD,UURDRRUDLURRDDDLUDLRDURUDURDLLLLRDLRLRDDRDRDUUULRDLLDLULULRDUDDRRUUDURULDLUDLRDRUDLDDULLLDDRDLLDULLLURLLRDDLDRDULRRDDULRDURLLRUDRLRRLUDURLDRDLDLRLLLURLRRURDLDURDLUDULRDULLLDRDDRDLDRDULUULURDRRRLDRRUULULLDDRRLDLRUURLRUURLURRLLULUUULRLLDDUDDLRLDUURURUDLRDLURRLLURUDLDLLUDDUULUUUDDDURDLRRDDDLDRUDRLRURUUDULDDLUUDDULLDDRRDDRRRUDUDUDLDLURLDRDLLLLDURDURLRLLLUUDLRRRRUDUDDLDLRUURRLRRLUURRLUDUDRRRRRRRLDUDDRUDDLUDLRDDDRLDUULDRDRRDLDRURDLDRULRLRLUDRDLRRUURUUUUDLDUUULLLRRRRRDLRRURDDLLLLUULDLLRULLUDLLDLLUDLRLRRLRURDDRRL,URDRDLLRDDDLLLDDLURLRURUURRRLUURURDURRLLUDURRLRLDLUURDLULRRDRUDDLULDLDRLDLRLRRLLLDDDUDDDLRURURRLLDRRRURUDLRDDLLDULDDLDRLUUUDRRRULDUULRDDDLRRLLURDDURLULRDUDURRLLDLLRLDUDDRRDDLRLLLDUDRLUURRLLDULRLDLUUUUUDULUDLULUDDUURRURLDLDRRLDLRRUDUDRRDLDUDDLULLDLLRDRURDRDRRLDDDDRDDRLLDDDLLUDRURLURDRRRRRUDDDUDUDDRDUUDRRUDUDRLULDDURULUURUUUURDRULRLRULLDDRRRUULRRRRURUDLDLRDLLDRLURLRUULLURDUDULRRURLRLLRRLLLURULRRRLDDUULLUUULRRDRULUUUUDRDRRDLRURLRLLRLRRRDRDRLDLUURUURULLDLULRRLRRDRULRRLLLDDURULLDLDLDLUUURDLDLUUDULRLLUDDRRDLLDLDLDURLUURRDDRRURDRLUDRLUUUDLDULDLUDRLDUDDLLRUDULLLLLDRRLLUULLUUURRDDUURDLLRDDLRLLU,LDUDRRDLUUDDRLLUUULURLDUDLUDLRLDRURLULRLLDDLRRUUUDDDDRDULDDUUDLRUULDRULLRDRUDDURLDUUURRUDUDRDRDURRDLURRRDRLDLRRRLLLRLURUURRDLLRDLDDLLRDUDDRDUULRULRRURLUDDUDDDUULLUURDULDULLLLRUUUDDRRRLDDDLDLRRDRDRDLUULRLULDRULDLRDRRUDULUDLLUDUULRDLRRUUDDLLDUDDRULURRLULDLDRRULDDRUUDDLURDLRDRLULRRLURRULDUURDLUDLLDRLDULLULDLLRDRDLLLUDLRULLRLDRDDDLDDDLRULDLULLRUUURRLLDUURRLRLDUUULDUURDURRULULRUUURULLLRULLURDDLDRLLRDULLUDLDRRRLLLLDUULRRLDURDURDULULDUURLDUDRLRURRDLUUULURRUDRUUUDRUR";
        public static bool sw = false;
        public static int X = 0;
        public static int Y = 0;
        private static Coord myPosition = new Coord(0, 0);

        private static List<Coord> locations = new List<Coord>();

        private struct Coord
        {
            public int x, y;

            public Coord(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }


        static void Main(string[] args)
        {
            dayone();

            Console.ReadKey();
            daytwo();
            Console.ReadKey();
            daytwoparttwo();
            Console.ReadKey();
        }

        private static void dayone()
        {
            int move = 0;
            int direction = 0;//define which direction we are facing 0 = N, 1 = E, 2 = S, 3 = W
            locations.Add(myPosition);
            string[] inputArray = inputday1.Split(',');

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Substring(0, 1) == "L")
                {
                    direction++;
                    if (direction == 4) direction = 0;
                }
                if (inputArray[i].Substring(0, 1) == "R")
                {
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
        }

        public static void daytwoparttwo()
        {
            X = 0;
            Y = 2;
            string ans = "";
            string[] inputday2string = inputday2.Split(',');
            char[] word1 = inputday2string[0].ToCharArray();
            char[] word2 = inputday2string[1].ToCharArray();
            char[] word3 = inputday2string[2].ToCharArray();
            char[] word4 = inputday2string[3].ToCharArray();
            char[] word5 = inputday2string[4].ToCharArray();
            ans = ans + checkdirection(word1, ans);
            ans = checkdirection(word2, ans);
            ans = checkdirection(word3, ans);
            ans = checkdirection(word4, ans);
            ans = checkdirection(word5, ans);
            Console.WriteLine(ans);
        }

        private static string checkdirection(char[] char1, string ans)
        {
            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] == 'U')
                {
                    Y = Y - 1;
                    if (!isvalidmove(X, Y)) { Y = Y + 1; }
                }
                if (char1[i] == 'D')
                {
                    Y = Y + 1;
                    if (!isvalidmove(X, Y)) { Y = Y - 1; }
                }
                if (char1[i] == 'L')
                {
                    X = X - 1;
                    if (!isvalidmove(X, Y)) { X = X + 1; }
                }
                if (char1[i] == 'R')
                {
                    X = X + 1;
                    if (!isvalidmove(X, Y)) { X = X - 1; }
                }
            }
            ans = ans + getkey(X, Y);
            return ans;
        }

        private static string getkey(int x, int y)
        {
            if (x == 0 && y == 0) { return "Er"; }
            if (x == 1 && y == 0) { return "Er"; }
            if (x == 2 && y == 0) { return "1"; }
            if (x == 3 && y == 0) { return "Er"; }
            if (x == 4 && y == 0) { return "Er"; }

            if (x == 0 && y == 1) { return "Er"; }
            if (x == 1 && y == 1) { return "2"; }
            if (x == 2 && y == 1) { return "3"; }
            if (x == 3 && y == 1) { return "4"; }
            if (x == 4 && y == 1) { return "Er"; }

            if (x == 0 && y == 2) { return "5"; }
            if (x == 1 && y == 2) { return "6"; }
            if (x == 2 && y == 2) { return "7"; }
            if (x == 3 && y == 2) { return "8"; }
            if (x == 4 && y == 2) { return "9"; }

            if (x == 0 && y == 3) { return "Er"; }
            if (x == 1 && y == 3) { return "A"; }
            if (x == 2 && y == 3) { return "B"; }
            if (x == 3 && y == 3) { return "C"; }
            if (x == 4 && y == 3) { return "Er"; }

            if (x == 0 && y == 4) { return "Er"; }
            if (x == 1 && y == 4) { return "Er"; }
            if (x == 2 && y == 4) { return "D"; }
            if (x == 3 && y == 4) { return "Er"; }
            if (x == 4 && y == 4) { return "Er"; }
            else return "Er";
        }

        private static bool isvalidmove(int x, int y)
        {
            if (x == 0 && y == 0) { return false; }
            if (x == 0 && y == 1) { return false; }
            if (x == 1 && y == 0) { return false; }

            if (x == 4 && y == 0) { return false; }
            if (x == 3 && y == 0) { return false; }
            if (x == 4 && y == 1) { return false; }

            if (x == 4 && y == 4) { return false; }
            if (x == 3 && y == 4) { return false; }
            if (x == 4 && y == 3) { return false; }

            if (x == 0 && y == 4) { return false; }
            if (x == 0 && y == 3) { return false; }
            if (x == 1 && y == 4) { return false; }
            if (x < 0 || x > 4) { return false; }
            if (y < 0 || y > 4) { return false; }
            return true;
        }

        public static void daytwo()
        {
            X = 1;
            Y = 1;
            string ans = "";
            string[] d2i = inputday2.Split(',');
            char[] char1 = d2i[0].ToCharArray();
            char[] char2 = d2i[1].ToCharArray();
            char[] char3 = d2i[2].ToCharArray();
            char[] char4 = d2i[3].ToCharArray();
            char[] char5 = d2i[4].ToCharArray();
            ans = ans + getkeypad(char1, ans);
            ans = getkeypad(char2, ans);
            ans = getkeypad(char3, ans);
            ans = getkeypad(char4, ans);
            ans = getkeypad(char5, ans);

            Console.WriteLine(ans);
        }

        private static string getkeypad(char[] char1, string ans)
        {
            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] == 'U')
                {
                    Y = Y - 1;
                    if (Y == -1)
                    {
                        Y = 0;

                    }
                }
                if (char1[i] == 'D')
                {
                    Y = Y + 1;
                    if (Y == 3)
                    {
                        Y = 2;

                    }
                }
                if (char1[i] == 'L')
                {
                    X = X - 1;
                    if (X == -1)
                    {
                        X = 0;

                    }
                }
                if (char1[i] == 'R')
                {
                    X = X + 1;
                    if (X == 3)
                    {
                        X = 2;

                    }
                }
            }
            ans = ans + getnum(X, Y);
            return ans;
        }

        private static string getnum(int x, int y)
        {
            if (x == 0 && y == 0) { return "1"; }
            if (x == 1 && y == 0) { return "2"; }
            if (x == 2 && y == 0) { return "3"; }
            if (x == 0 && y == 1) { return "4"; }
            if (x == 1 && y == 1) { return "5"; }
            if (x == 2 && y == 1) { return "6"; }
            if (x == 0 && y == 2) { return "7"; }
            if (x == 1 && y == 2) { return "8"; }
            if (x == 2 && y == 2) { return "9"; }
            else return "0";
        }

        private static void movealong(int move, int direction)
        {
            switch (direction)
            {
                case 0:

                    if (move == 1)
                    {
                        Y = Y + 1;
                        myPosition = new Coord(X, Y);
                        checkpos();
                        locations.Add(new Coord(X, Y));

                    }
                    if (move > 1)
                    {
                        for (int i = 1; i < move + 1; i++)
                        {
                            Y = Y + 1;
                            myPosition = new Coord(X, Y);
                            checkpos();
                            locations.Add(new Coord(X, Y));

                        }
                    }
                    break;
                case 1:

                    if (move == 1)
                    {
                        X = X + 1;
                        myPosition = new Coord(X, Y);
                        checkpos();
                        locations.Add(new Coord(X, Y));

                    }
                    if (move > 1)
                    {
                        for (int i = 1; i < move + 1; i++)
                        {
                            X = X + 1;
                            myPosition = new Coord(X, Y);
                            checkpos();
                            locations.Add(new Coord(X, Y));

                        }
                    }
                    break;
                case 2:

                    if (move == 1)
                    {
                        Y = Y - 1;
                        myPosition = new Coord(X, Y);
                        checkpos();
                        locations.Add(new Coord(X, Y));

                    }
                    if (move > 1)
                    {
                        for (int i = 1; i < move + 1; i++)
                        {
                            Y = Y - 1;
                            myPosition = new Coord(X, Y);
                            checkpos();
                            locations.Add(new Coord(X, Y));

                        }
                    }
                    break;
                case 3:

                    if (move == 1)
                    {
                        X = X - 1;
                        myPosition = new Coord(X, Y);
                        checkpos();
                        locations.Add(new Coord(X, Y));

                    }
                    if (move > 1)
                    {
                        for (int i = 1; i < move + 1; i++)
                        {
                            X = X - 1;
                            myPosition = new Coord(X, Y);
                            checkpos();
                            locations.Add(new Coord(X, Y));

                        }
                    }
                    break;
                default:
                    break;
            }
            myPosition = new Coord(X, Y);

        }

        private static void checkpos()
        {
            if (locations.Contains(myPosition) && !sw)
            {
                int Total = Math.Abs(X) + Math.Abs(Y);
                Console.WriteLine("X " + X + " Y " + Y);
                Console.WriteLine("Total Part 2 " + Total);
                sw = true;
            }
        }
    }
}
