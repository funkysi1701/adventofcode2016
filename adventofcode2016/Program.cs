using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using adventofcode2016;

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
            daythree();
            Console.ReadKey();
            //daythreepart2();
            dayfour();
            Console.ReadKey();
            dayfive();
            Console.ReadKey();
            daysix();
            Console.ReadKey();
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

        public static void daythree()
        {
            string filepath = "C:\\Projects\\adventofcode2016\\adventofcode2016\\day3.txt";
            int possible = 0;
            int a;
            int b;
            int c;
            string[] input3 = File.ReadAllLines(filepath);
            for (int i = 0; i < input3.Length; i++)
            {
                input3[i] = input3[i].Trim();
                input3[i] = input3[i].Replace("  ", ",");
                string[] sides = input3[i].Split(',');
                Int32.TryParse(sides[0], out a);
                Int32.TryParse(sides[1], out b);
                Int32.TryParse(sides[2], out c);

                    if ((b + c > a) && (a + c > b) && (b + a > c)) possible++;
            
            }
            
            Console.WriteLine(possible);
            
        }

        public static void dayfour()
        {
            int total = 0;
            string filepath = "C:\\Projects\\adventofcode2016\\adventofcode2016\\day4.txt";
            //string input = "aaaaa-bbb-z-y-x-4123[abxyz]";
            //string input = "a-b-c-d-e-f-g-h-987[abcde]";
            //string input = "not-a-real-room-404[oarel]";
            string[] input4 = File.ReadAllLines(filepath);
            for (int i = 0; i < input4.Length; i++)
            {
                string[] inputsplit = input4[i].Split('[');
                string origstring = inputsplit[0];
                string sectorIDstring = Regex.Replace(inputsplit[0], @"[^0-9]+", "");
                inputsplit[0] = string.Concat(inputsplit[0].OrderBy(c => c));
                inputsplit[0] = inputsplit[0].Replace('-', ' ');
                inputsplit[0] = inputsplit[0].Trim();

                int sectorID;
                Int32.TryParse(sectorIDstring, out sectorID);
                inputsplit[0] = Regex.Replace(inputsplit[0], @"^[\d-]*\s*", "", RegexOptions.Multiline);
                inputsplit[1] = inputsplit[1].Replace(']', ' ');
                inputsplit[1] = inputsplit[1].TrimEnd();
                var result = inputsplit[0].GroupBy(c => c).Select(c => new { charName = c.Key, charCount = c.Count() });
                string ans = "";

                foreach (var c in result.OrderByDescending(c => c.charCount))
                {
                    ans += c.charName;
                }
                if (ans.Substring(0, 5) == inputsplit[1]) {
                    total += sectorID;
                    string final = Caesar(origstring, sectorID);
                    if (final.Contains("northpole"))
                    {
                        Console.WriteLine(final);
                        Console.WriteLine(sectorID);
                    }

                }
            }
            Console.WriteLine(total);

        }

        public static void dayfive()
        {
            string input = "abbhdwsy";
            
            string char1 = calcHash(input);
            Console.WriteLine(char1.Substring(5,1));
            string char2 = calcHash(input);
            Console.WriteLine(char2.Substring(5, 1));
            string char3 = calcHash(input);
            Console.WriteLine(char3.Substring(5, 1));
            string char4 = calcHash(input);
            Console.WriteLine(char4.Substring(5, 1));
            string char5 = calcHash(input);
            Console.WriteLine(char5.Substring(5, 1));
            string char6 = calcHash(input);
            Console.WriteLine(char6.Substring(5, 1));
            string char7 = calcHash(input);
            Console.WriteLine(char7.Substring(5, 1));
            string char8 = calcHash(input);
            Console.WriteLine(char8.Substring(5, 1));
            List<string> part2index = new List<string>();
            List<string> part2value = new List<string>();
            string temp = calcHash(input);
            string ans = "";
            start = 1;
            for (int i = 0; i < 50; i++)
            {
                temp = calcHash(input);
                part2index.Add(temp.Substring(5, 1));
                part2value.Add(temp.Substring(6, 1));
            }
            int first = part2index.IndexOf("0");
            ans = ans + part2value[first];
            first = part2index.IndexOf("1");
            ans = ans + part2value[first];
            first = part2index.IndexOf("2");
            ans = ans + part2value[first];
            first = part2index.IndexOf("3");
            ans = ans + part2value[first];
            first = part2index.IndexOf("4");
            ans = ans + part2value[first];
            first = part2index.IndexOf("5");
            ans = ans + part2value[first];
            first = part2index.IndexOf("6");
            ans = ans + part2value[first];
            first = part2index.IndexOf("7");
            ans = ans + part2value[first];
            Console.WriteLine(ans);
        }
        public static int start = 1;

        public static void daysix()
        {
            string filepath = "C:\\Projects\\adventofcode2016\\adventofcode2016\\day6.txt";
            string[] input = File.ReadAllLines(filepath);
            List<string> char1 = new List<string>();
            List<string> char2 = new List<string>();
            List<string> char3 = new List<string>();
            List<string> char4 = new List<string>();
            List<string> char5 = new List<string>();
            List<string> char6 = new List<string>();
            List<string> char7 = new List<string>();
            List<string> char8 = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                char1.Add(input[i].Substring(0, 1));
                char2.Add(input[i].Substring(1, 1));
                char3.Add(input[i].Substring(2, 1));
                char4.Add(input[i].Substring(3, 1));
                char5.Add(input[i].Substring(4, 1));
                char6.Add(input[i].Substring(5, 1));
                char7.Add(input[i].Substring(6, 1));
                char8.Add(input[i].Substring(7, 1));
            }
            var most1 = (from i in char1
                        group i by i into grp
                        orderby grp.Count() descending
                        select grp.Key).First();
            var most2 = (from i in char2
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most3 = (from i in char3
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most4 = (from i in char4
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most5 = (from i in char5
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most6 = (from i in char6
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most7 = (from i in char7
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            var most8 = (from i in char8
                         group i by i into grp
                         orderby grp.Count() descending
                         select grp.Key).First();
            string ans = most1 + most2 + most3 + most4 + most5 + most6 + most7 + most8;
            Console.WriteLine(ans);
            var least1 = (from i in char1
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least2 = (from i in char2
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least3 = (from i in char3
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least4 = (from i in char4
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least5 = (from i in char5
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least6 = (from i in char6
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least7 = (from i in char7
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            var least8 = (from i in char8
                         group i by i into grp
                         orderby grp.Count() ascending
                         select grp.Key).First();
            ans = least1 + least2 + least3 + least4 + least5 + least6 + least7 + least8;
            Console.WriteLine(ans);
        }
 
        private static string calcHash(string input)
        {
            for (int i = start; i < 132319300; i++)
            {
                start++;
                string teststring = input + i.ToString().PadLeft(6, '0');
                string hash = GetMd5Hash(MD5.Create(), teststring);
                if (hash.StartsWith("00000")) { return hash; }
            }

            return "";
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            int rem = shift % 26;
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                if (letter == (char)'-')
                {
                    letter = ' ';
                } else letter = (char)(letter + rem);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                
                if (letter > 'z' && letter != (char)' ')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a' && letter != (char)' ')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
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
