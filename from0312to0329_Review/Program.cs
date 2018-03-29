using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from0312to0329_Review
{
    class Program
    {
        /// <summary>
        /// 建立一個 struct Book 儲存三種資料
        /// </summary>
        public struct Book
        {
            public string Title;
            public int Price;
            public int Amount;
        }
        static void Main(string[] args)
        {
            bool KeepRead = true;
            string menuchoose = "0";
            while (KeepRead)
            {
                Console.WriteLine("There is a menu.");
                Console.WriteLine("There are some codes I think it can be achievement from 3/12 to 3/29.\n");
                MenuPrint(menuchoose);
                menuchoose = Console.ReadLine();
                StringTrim(ref menuchoose);
                if (menuchoose == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Hellow World");
                    Console.Write("Hello");
                    Console.Write(" World");
                    Console.Write("\n");
                    Console.WriteLine("Hello\tWorld");
                    Pause(menuchoose);
                }
                if (menuchoose == "2")
                {
                    Console.Clear();
                    int OutputA = 0;
                    OutputA = Number_Complement(OutputA);
                    Console.WriteLine(OutputA);
                    Pause(menuchoose);
                }
                if (menuchoose == "3")
                {
                    Console.Clear();
                    int x = 0;
                    Customized_multiplication_table(x);
                    Pause(menuchoose);
                }
                if (menuchoose == "4")
                {
                    Console.Clear();
                    int x = 0;
                    Prime_Finder(x);
                    Pause(menuchoose);
                }
                if (menuchoose == "5")
                {
                    Console.Clear();
                    Find_Disappeared_Num(5);
                    Pause(menuchoose);
                }
                if (menuchoose == "6")
                {
                    Console.Clear();
                    Five_Zero_Guess(6);
                    Pause(menuchoose);
                }
                if (menuchoose == "7")
                {
                    Console.Clear();
                    Lotto_Awards(7);
                    Pause(menuchoose);
                }
                if (menuchoose == "8")
                {
                    Console.Clear();
                    Html_Table_BookLIST(8);
                    Pause(menuchoose);
                }
                if (menuchoose == "-1")
                {
                    KeepRead = false;
                }
            }
            Pause(menuchoose);
        }



        private static int CheckInt(string v)
        {
            int num;
            while (!int.TryParse(v, out num) || num < 0)
            {
                Console.WriteLine("Type Error!! Please type positive integer");
                v = Console.ReadLine();
            }
            return num;
        }

        private static void Pause(string menuchoose)
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void StringTrim(ref string menuchoose)
        {
            menuchoose = menuchoose.Trim();
        }
        public static void MenuPrint(string x)
        {
            Console.WriteLine("'Hellow world', I first know how to print the string.");
            Console.WriteLine("Want to use can type 1\n");
            Console.WriteLine("'Number complement'");
            Console.WriteLine("It's a Leetcode question No.476, I know how to change the num from decimal to binary.");
            Console.WriteLine("Want to use can type 2\n");
            Console.WriteLine("'Customized_multiplication_table' use more than one loop to calculate number.");
            Console.WriteLine("Want to use can type 3\n");
            Console.WriteLine("'Prime_finder' use loop to search prime below the max I input.");
            Console.WriteLine("Want to use can type 4\n");
            Console.WriteLine("'Find_disappered_number'");
            Console.WriteLine("It's a Leetcode question No.448");
            Console.WriteLine("I think a solution it just use one loop and Array.IndexOf to find it.");
            Console.WriteLine("Want to see can type 5\n");
            Console.WriteLine("'Five_Zero_guess', it's a intersting game");
            Console.WriteLine("Want to use can type 6\n");
            Console.WriteLine("'Lotto awards',you can guess number, I will tell you how many you guess right.");
            Console.WriteLine("Want to use can type 7\n");
            Console.WriteLine("'Html table booklist',You can input the title, price, amount of the books,I can make them to be a html.");
            Console.WriteLine("Want to use can type 8\n");
            Console.WriteLine("Want to leave can type -1");
        }

        public static int Number_Complement(int x)
        {
            int OutputA, counter;
            Console.WriteLine("Type a positive integer :");
            x = CheckInt(Console.ReadLine());
            OutputA = 0;
            counter = 2;
            bool isOK = false;
            while (!isOK)
            {
                OutputA += (1 - x % counter / (counter / 2)) * counter / 2;
                if (counter >= x || counter < 0)
                {
                    break;
                }
                counter *= 2;
            }
            return OutputA;
        }
        public static void Customized_multiplication_table(int x)
        {
            int i, j, x_;
            x = 0;
            i = 1;
            j = 1;
            x_ = 0;
            Console.WriteLine("Type the min num_i you want:");
            int minI = CheckInt(Console.ReadLine());
            i = minI;
            Console.WriteLine("Type the max num_i you want:");
            int inputMAX = CheckInt(Console.ReadLine());
            Console.WriteLine("Type the min num_j you want:");
            int minJ = CheckInt(Console.ReadLine());
            Console.WriteLine("Type the max num_j you want:");
            int maxJ = CheckInt(Console.ReadLine());
            Console.WriteLine("Type how many column you want:");
            int inputX = CheckInt(Console.ReadLine());
            Console.WriteLine();
            int inputY = inputMAX / inputX;
            int inputY_ = inputMAX % inputX;
            while (i <= inputY * inputX)
            {
                i += x;
                if (i > inputX * inputY)
                {
                    break;
                }
                j = minJ;
                while (j <= maxJ)
                {
                    x = 0;
                    while (x < inputX)
                    {
                        Console.Write($"{i + x} * {j} = {(i + x) * j}\t");
                        x++;
                    }
                    Console.WriteLine("");
                    j++;
                }
                Console.WriteLine("\n");
            }
            i = inputMAX - (inputMAX - inputX * inputY);
            while (i < inputMAX)
            {
                j = minJ;
                while (j <= maxJ)
                {
                    x_ = 1;
                    while (x_ <= inputY_)
                    {
                        Console.Write($"{i + x_} * {j} = {(i + x_) * j}\t");
                        x_++;
                    }
                    Console.WriteLine("");
                    j++;
                }
                Console.WriteLine("\n");
                i += inputY_;
            }
        }

        public static void Prime_Finder(int x)
        {
            int[] Prime = new int[] { 2 };
            Console.WriteLine("Type a number I can give you all of the prime less than:");
            int inputNumber = CheckInt(Console.ReadLine());
            for (int input = 3; input <= inputNumber; input++)
            {
                bool isPrime = true;
                int num = 0;
                for (; num < Prime.Length; num++)
                {
                    if (input % Prime[num] == 0 && input > Prime[num])
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    for (int prime = Prime[num - 1] + 1; prime < Math.Ceiling(Math.Sqrt(input)); prime++)
                    {
                        if (input % prime == 0 && input > prime)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    Array.Resize(ref Prime, num + 1);
                    Prime[num] = input;
                }
            }
            Console.WriteLine();
            Console.WriteLine("這些是質數:");
            for (int i = 0; i < Prime.Length; i++)
            {
                Console.WriteLine(Prime[i]);
            }
        }

        public static void Find_Disappeared_Num(int x)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine("int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 }");
            int[] calc = new int[nums.Length];
            List<int> dsnums = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                calc[i] = i + 1;
            }
            for (int i = 0; i < calc.Length; i++)
            {
                if (Array.IndexOf(nums, calc[i]) >= 0)
                {
                    continue;
                }
                else if (Array.IndexOf(nums, calc[i]) == -1)
                {
                    dsnums.Add(calc[i]);
                }
            }
            Console.Write("disappeared numbers: ");
            for (int i = 0; i < dsnums.Count; i++)
            {
                Console.Write($"{dsnums[i]} ");
            }
            Console.WriteLine();
        }

        public static bool CheckIntFiveOrZero(string[] x, int y)
        {
            int z;
            if (!int.TryParse(x[y], out z))
            {
                return false;
            }
            if (z != 5 && z != 0)
            {
                return false;
            }
            return true;
        }
        public static void Five_Zero_Guess(int x)
        {
            //宣告亂數產生
            Random rnd1 = new Random();
            //持續玩的迴圈建立
            bool keepPlay = true;
            while (keepPlay)
            {
                //產生隨機先後，0是玩家先，1是電腦先
                int order = rnd1.Next(0, 2);
                //決定勝負的迴圈建立
                bool isWin = false;
                while (!isWin)
                {
                    //判斷是電腦還是玩家可以猜拳數
                    int CP = 0;
                    //判斷共贏了幾次
                    int count = 0;
                    //看現在是誰的回合
                    if (order == 0)
                    {
                        Console.WriteLine("Player your turn, we can only raise 0 or 5 fingers each hand.");
                        CP = 1;
                    }
                    else if (order == 1)
                    {
                        Console.WriteLine("Player is my turn, we can only raise 0 or 5 fingers each hand.");
                        CP = 2;
                    }
                    //建立玩家陣列來儲存使用者輸入
                    string[] inputP = new string[2];
                    //防呆迴圈
                    bool isRight = false;
                    while (!isRight)
                    {
                        Console.WriteLine("How many fingers you want to raise by your right hand:");
                        //讀取玩家輸入
                        inputP[0] = Convert.ToString(Console.ReadLine());
                        //判斷輸入值是否只有0, 5
                        if (CheckIntFiveOrZero(inputP, 0))
                        {
                            //跳脫迴圈
                            isRight = true;
                        }
                        else
                        {
                            //提醒輸入錯誤
                            Console.WriteLine("Type error, plese type 0 or 5.");
                        }
                    }
                    //布林值重設
                    isRight = false;
                    //防呆迴圈
                    while (!isRight)
                    {
                        Console.WriteLine("How many fingers you want to raise by your left hand:");
                        //讀取玩家輸入
                        inputP[1] = Convert.ToString(Console.ReadLine());
                        //判斷輸入值是否只有0, 5
                        if (CheckIntFiveOrZero(inputP, 1))
                        {
                            //跳脫迴圈
                            isRight = true;
                        }
                        else
                        {
                            //提醒輸入錯誤
                            Console.WriteLine("Type error, plese type 0 or 5.");
                        }
                    }
                    //建立陣列來儲存電腦輸入
                    string[] inputC = new string[2];
                    //使用迴圈快速存入隨機的 0 或 5
                    for (int i = 0; i < 2; i++)
                    {
                        inputC[i] = Convert.ToString((rnd1.Next(0, 2)) * 5);
                    }
                    //若是玩家猜拳數的回合
                    if (order == 0)
                    {
                        //增加陣列的空間
                        Array.Resize(ref inputP, 3);
                        //防呆迴圈
                        isRight = false;
                        while (!isRight)
                        {
                            Console.WriteLine("Now guess the total fingers we raise:");
                            //讀取玩家輸入
                            inputP[2] = Convert.ToString(Console.ReadLine());
                            //判斷輸入值是否僅為 0, 5, 10, 15, 20.
                            switch (CheckTotal(inputP[2]))
                            {
                                case 0:
                                    isRight = true;
                                    break;
                                case 5:
                                    isRight = true;
                                    break;
                                case 10:
                                    isRight = true;
                                    break;
                                case 15:
                                    isRight = true;
                                    break;
                                case 20:
                                    isRight = true;
                                    break;
                                default:
                                    //提醒輸入錯誤
                                    Console.WriteLine("Type error, plese type 0, 5, 10, 15,or 20.");
                                    break;
                            }
                        }
                    }
                    //若是電腦猜拳數的回合
                    else if (order == 1)
                    {
                        //增加陣列儲存空間
                        Array.Resize(ref inputC, 3);
                        //讓電腦會以自已出拳數為基礎進行隨機的猜測
                        inputC[2] = Convert.ToString(rnd1.Next(0, 3) * 5 + int.Parse(inputC[0]) + int.Parse(inputC[1]));
                    }
                    //因為出拳數總和很常使用，令一個變數來儲存
                    int total = int.Parse(inputP[0]) + int.Parse(inputP[1]) + int.Parse(inputC[0]) + int.Parse(inputC[1]);
                    //列印雙方出拳的拳數及猜拳數，再列印出拳總數
                    Console.Write("玩家: ");
                    for (int i = 0; i < inputP.Length; i++)
                    {
                        Console.Write($"{inputP[i]} ");
                    }
                    Console.Write("\n");
                    Console.Write("電腦: ");
                    for (int i = 0; i < inputC.Length; i++)
                    {
                        Console.Write($"{inputC[i]} ");
                    }
                    Console.Write("\n");
                    Console.WriteLine($"總數 {total}");
                    //判斷是玩家的回合
                    if (order == 0 && CP == 1)
                    {
                        //判斷玩家是否猜對拳數且不是連續猜對
                        if (total == int.Parse(inputP[2]) && count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("你聽牌了");
                            count++;
                        }
                        //判斷玩家是否猜對拳數且是連續猜對
                        else if (total == int.Parse(inputP[2]) && count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You won.");
                            //更改布林值狀態，以停留在續玩迴圈中
                            isWin = true;
                        }
                        //判斷玩家是否猜錯，換成是電腦的回合
                        else
                        {
                            order = 1;
                        }
                    }
                    //判斷是電腦的回合
                    if (order == 1 && CP == 2)
                    {
                        //判斷電腦是否猜對拳數且不是連續猜對
                        if (total == int.Parse(inputC[2]) && count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("電腦聽牌");
                            count++;
                        }
                        //判斷電腦是否猜對拳數且是連續猜對
                        else if (total == int.Parse(inputC[2]) && count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Computer is won.");
                            //更改布林值狀態，以停留在續玩迴圈中
                            isWin = true;
                        }
                        //判斷電腦是否猜錯，換成是玩家的回合
                        else
                        {
                            order = 0;
                        }
                    }
                }
                //是否繼續玩的迴圈，(因為已有人勝利，可以進到迴圈)
                while (isWin)
                {
                    Console.WriteLine("Do you want to play again? Yes: 1/ No: 2.");
                    //讀取玩家輸入
                    int answer = CheckInt(Console.ReadLine());
                    //要再玩
                    if (answer == 1)
                    {
                        //清空版面，再開始
                        Console.Clear();
                        break;
                    }
                    else if (answer == 2)
                    {
                        //更改布林值狀態以跳出最大迴圈
                        keepPlay = false;
                        break;
                    }
                    else
                    {
                        //提醒輸入錯誤
                        Console.WriteLine("Type error, plese type 1 or 2.");
                    }
                }
            }
        }

        private static int CheckTotal(string v)
        {
            int num = 0;
            while (!int.TryParse(v, out num))
            {
                Console.WriteLine("Type error, plese type numer.");
                v = Console.ReadLine();
            }
            return num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int CheckHowManyRightNum(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    return 0;
                }
            }
            return x.Length;
        }
        /// <summary>
        /// Generate the Lotto six number
        /// </summary>
        /// <param name="output">Lotto int[]</param>
        public static void GenerateLotto(ref int[] output)
        {
            Random rnd1 = new Random();
            output = new int[6];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = rnd1.Next(1, 50);
                while (Array.IndexOf(output, output[i]) != Array.LastIndexOf(output, output[i]))
                {
                    output[i] = rnd1.Next(1, 50);
                }
            }
        }

        /// <summary>
        /// Check input is 6 numbers,and non duplicate,and not overflow
        /// </summary>
        /// <param name="x">input string</param>
        /// <param name="lotto">儲存6個數字</param>
        /// <returns>輸入是否正確</returns>
        public static bool CheckArrayNum(string x, ref int[] lotto)
        {
            if (!String.IsNullOrEmpty(x))
            {
                string[] temp = x.Split(',');
                if (temp.Length == 6)
                {
                    lotto = new int[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (Array.IndexOf(temp, temp[i]) != Array.LastIndexOf(temp, temp[i]))
                        {
                            return false;
                        }
                        temp[i] = temp[i].Trim();
                        lotto[i] = CheckIntAnother(temp[i]);
                        if (lotto[i] > 49 || lotto[i] < 1)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Check string is number. 
        /// </summary>
        /// <param name="x">input(string)</param>
        /// <returns>number or -1(not number)</returns>
        public static int CheckIntAnother(string x)
        {
            int num;
            if (int.TryParse(x, out num))
            {
                return num;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Calculate how many right number
        /// </summary>
        /// <param name="x">Player guess</param>
        /// <param name="y">Computer generate Lotto</param>
        /// <param name="z">Guess right number</param>
        public static void CheckRightNum(int[] x, int[] y, ref int[] z)
        {
            int count = 1;
            for (int i = 0; i < x.Length; i++)
            {
                if (Array.IndexOf(y, x[i]) >= 0)
                {
                    Array.Resize(ref z, count);
                    z[count - 1] = x[i];
                    count++;
                }
            }
        }
        /// <summary>
        /// 讓 int[]array 組合成 string，以","連接
        /// </summary>
        /// <param name="array">輸入的 int 陣列</param>
        /// <returns>一行文字</returns>
        public static string IntArrayToString(int[] array)
        {
            string a = "";
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
                if (i == array.Length - 1)
                {
                    break;
                }
                a += ",";
            }
            return a;
        }

        public static void Lotto_Awards(int x)
        {
            bool KeepPlay = true;
            while (KeepPlay)
            {
                bool isOK = false;
                int[] lotto = new int[3];
                while (!isOK)
                {
                    Console.WriteLine("請輸入六個數字(1~49)，我幫你看看你中了幾個(請以逗點隔開數字):");
                    string input = Console.ReadLine();
                    isOK = CheckArrayNum(input, ref lotto);
                    if (!isOK)
                    {
                        Console.WriteLine("輸入錯誤。");
                    }
                }
                Console.WriteLine("============================");
                Console.WriteLine($"玩家輸入:{IntArrayToString(lotto)}");
                int[] Lotto = new int[1];
                GenerateLotto(ref Lotto);
                Console.WriteLine("============================");
                Console.WriteLine($"大樂透:{IntArrayToString(Lotto)}");
                int[] guessRight = new int[1];
                CheckRightNum(lotto, Lotto, ref guessRight);
                int nums = CheckHowManyRightNum(guessRight);
                Console.WriteLine("============================");
                Console.WriteLine($"猜對的數字有{nums}個");
                if (nums > 0)
                {
                    Console.WriteLine($"猜對的數字是{IntArrayToString(guessRight)}");
                }
                else
                {
                    Console.WriteLine($"沒猜對任何數字");
                }
                while (KeepPlay)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("要不要繼續玩? YES / 1,  NO / 2");
                    string want = Console.ReadLine();
                    want = want.Trim();
                    if (want == "1")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (want == "2")
                    {
                        KeepPlay = false;
                    }
                    else
                    {
                        Console.WriteLine("輸入錯誤。");
                    }
                }
            }
        }

        private static void Html_Table_BookLIST(int v)
        {
            //設定有幾筆資料
            int max = 0;
            //防呆迴圈
            bool isOK = false;
            while (!isOK)
            {
                //詢問資料數目
                Console.WriteLine("How many books you want to build a list.");
                isOK = CheckMax(Console.ReadLine(), ref max);
            }
            int count = 0;
            //建立陣列儲存使用者輸入資料
            Book[] book_list = new Book[max];
            //建立迴圈直到輸入資料筆數足夠
            while (count < max)
            {
                //初始化book
                Book book;
                book.Title = "";
                book.Price = 0;
                book.Amount = 0;
                string isRight = "1";
                //防呆，詢問book標題
                while (isRight != "0")
                {
                    Console.WriteLine($"Type the title of the book.第{count + 1}筆");
                    isRight = CheckTitle(Console.ReadLine(), ref book.Title);
                }
                //防呆，詢問book價錢
                while (isRight != "1")
                {
                    Console.WriteLine($"Type the price of the book.第{count + 1}筆");
                    isRight = CheckPrice(Console.ReadLine(), ref book.Price);
                }
                //防呆，詢問book數量
                while (isRight != "2")
                {
                    Console.WriteLine($"Type the amount of the book.第{count + 1}筆");
                    isRight = CheckAmount(Console.ReadLine(), ref book.Amount);
                }
                //將資料寫入陣列中
                book_list[count++] = book;
            }
            //HTML要建立的檔名
            string path = $"book_list{DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss")}.html";
            //大字串，儲存要輸出的檔案
            StringBuilder content = new StringBuilder();
            //用function建立HTML文字檔
            CreateHtml(ref content, book_list);
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //建立檔案，將字串的內容完全輸出
                File.WriteAllText(path, content.ToString(), Encoding.UTF8);
                Console.WriteLine();
                //通知使用者已建立檔案
                Console.WriteLine("File has been created.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// 將字串組合，形成html
        /// </summary>
        /// <param name="content">要輸出的html大字串</param>
        /// <param name="book_list">使用者輸入的資料</param>
        public static void CreateHtml(ref StringBuilder content, Book[] book_list)
        {
            //從外面引入的txt檔的路徑
            string path_head = "html_head.txt";
            try
            {
                //用陣列儲存從外面讀取的string
                string[] html_head;
                if (File.Exists(path_head))
                {
                    html_head = File.ReadAllLines(path_head);
                    //將陣列輸入大字串中
                    for (int i = 0; i < html_head.Length; i++)
                    {
                        content.AppendLine(html_head[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            //將使用者輸入的檔案寫入大字串中
            for (int i = 0; i < book_list.Length; i++)
            {
                content.AppendLine($"<tr>");
                content.AppendLine($"<td>{book_list[i].Title}</td>");
                content.AppendLine($"<td>{book_list[i].Price}</td>");
                content.AppendLine($"<td>{book_list[i].Amount}</td>");
                content.AppendLine($"</tr>");
            }
            //從外面引入的txt檔的路徑
            string path_footer = "html_footer.txt";
            try
            {
                //用陣列儲存從外面讀取的string
                string[] html_footer;
                if (File.Exists(path_footer))
                {
                    html_footer = File.ReadAllLines(path_footer);
                    //將陣列輸入大字串中
                    for (int i = 0; i < html_footer.Length; i++)
                    {
                        content.AppendLine(html_footer[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// 確認輸入的是不是數字，且要大於等於 0
        /// </summary>
        /// <param name="v">輸入的字串</param>
        /// <param name="amount">儲存到 Book 的屬性中(Amount)</param>
        /// <returns>要不要重新輸入</returns>
        public static string CheckAmount(string v, ref int amount)
        {
            if (int.TryParse(v, out amount))
            {
                if (amount >= 0)
                {
                    return "2";
                }
                Console.WriteLine("Type Error!! Please type number by positive integer");
                return "3";
            }
            Console.WriteLine("Type error!! Please type by number.");
            return "3";
        }
        /// <summary>
        /// 確認輸入的是不是數字，且要大於等於 0
        /// </summary>
        /// <param name="v">輸入的字串</param>
        /// <param name="price">儲存到 Book 的屬性中(Price)</param>
        /// <returns>要不要重新輸入</returns>
        public static string CheckPrice(string v, ref int price)
        {
            if (int.TryParse(v, out price))
            {
                if (price >= 0)
                {
                    return "1";
                }
                Console.WriteLine("Type Error!! Please type number by positive integer");
                return "2";
            }
            Console.WriteLine("Type error!! Please type by number.");
            return "2";
        }
        /// <summary>
        /// 確認輸出的不是空字串，並幫他把前後空白刪減掉
        /// </summary>
        /// <param name="v">輸入的字串</param>
        /// <param name="title">儲存到 Book 的屬性中(Title)</param>
        /// <returns>要不要重新輸入</returns>
        public static string CheckTitle(string v, ref string title)
        {
            if (!String.IsNullOrEmpty(v))
            {
                title = v.Trim();
                return "0";
            }
            Console.WriteLine("Type error!! Please type some string.");
            return "1";
        }
        /// <summary>
        /// 確定輸入的是數字且至少3筆
        /// </summary>
        /// <param name="v">input</param>
        /// <param name="max">有幾筆要輸出</param>
        /// <returns>要不要重新輸入</returns>
        public static bool CheckMax(string v, ref int max)
        {
            if (int.TryParse(v, out max))
            {
                if (max >= 3)
                {
                    return true;
                }
                Console.WriteLine("type too little.");
                return false;
            }
            Console.WriteLine("Type error!! Please type number.");
            return false;
        }
    }
}
