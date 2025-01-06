using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.learn;

namespace ConsoleApp1
{
    class Program    //类
    {
        static void Main(string[] args)  //功能
        {
            //char a='A';
            //Console.WriteLine((int)a);

            int a = 1, i = 0, b = 0;
            while (b < 1010100)
            {
                a *= 2;
                b = b + a;
                i++;
                Console.WriteLine($"{a},{b},{i}");
            }



















            /**类*/
            //DataType dataType = new DataType();
            //dataType.Pi = float.Parse(Console.ReadLine());
            //dataType.r = float.Parse(Console.ReadLine());
            //Console.WriteLine(dataType.Yzl());
            //Console.WriteLine($"{dataType.yzl()}");


            ForSentence sentence = new ForSentence();
            var arr = sentence.Fcc(12, 58, "+");
            Console.WriteLine($"{arr[0]}和{arr[1]}进行{arr[2]}运算：{arr[3]}");
            //Console.WriteLine($"12和55进行运算：{sentence.Jjcc(12, 55, "-")}");
            //Console.WriteLine($"44和33进行运算：{sentence.Jjcc(44, 33, "*")}");
            //Console.WriteLine($"22和33进行运算：{sentence.Jjcc(22, 33, "/")}");
































            /*List<int> list = new List<int>();//动态数组
            list.Add(1);//索引为0，依次
            list.Add(3);
            list.Add(4);
            list.Add(2);
            list.Remove(1);
            list.Insert(1, 2);//在索引为1的前面插入！插入！插入！不是赋值
            list[0] = 3;//  重新赋值
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }*/
            /*while (true)
            {
                Console.WriteLine();
                Console.WriteLine("请输入想要运行的的程序代号\n"); 
                Console.WriteLine("1:1,1,2,3,5......后25位的和\n");
                Console.WriteLine("2:10的阶乘\n");
                Console.WriteLine("3:100以内偶数之和(for)\n");
                Console.WriteLine("4:100以内偶数之和(while)\n");
                Console.WriteLine("5:输入两个数求和\n");
                Console.WriteLine("6:100个1~1000的随机数\n");
                Console.WriteLine("7:九九乘法表\n");
                Console.WriteLine("8:定义一个数组为100为1~100，foreach遍历,输出所有偶数\n");
                Console.WriteLine("9:定义一个数组为100个1~100的随机数，大于60合格，小于60不合格\n");
                Console.WriteLine("10:定义一个数组为10个1~100的随机数，从大到小排序\n");
                Console.WriteLine("11:身份证验证\n");
                Console.WriteLine("12:现在时间的星期几用中文输出\n");
                Console.WriteLine("13:定义一个数组为10个1~100的随机数，从大到小排序并去重\n");
                Console.WriteLine("14:加密/解码a-->f A-->F 1-->1....\n");
                Console.WriteLine("请输入想要运行的的程序代号");
                Console.WriteLine("想要退出请输入 0");
                String x = Console.ReadLine();
                if (x == "1") aaa(0);//1,1,2,3,5......后25位的和
                else if (x == "2") bbb(0);//10阶乘
                else if (x == "3") ccc(0);//100以内偶数之和(for)
                else if (x == "4") ddd(0);//100以内偶数之和(while)
                else if (x == "5") eee(0);//输入两个数求和
                else if (x == "6") fff(0);//100个1~1000的随机数
                else if (x == "7") ggg(0);//九九乘法表
                else if (x == "8") hhh(0);//定义一个数组为100为1~100，foreach遍历,输出所有偶数
                else if (x == "9") iii(0);//定义一个数组为100个1~100的随机数，大于60合格，小于60不合格
                else if (x == "10") jjj(0);//定义一个数组为10个1~100的随机数，从大到小排序
                else if (x == "11") kkk(0);//身份证验证
                else if (x == "12") lll(0);//现在时间的星期几用中文输出
                else if (x == "13") mmm(0);//定义一个数组为10个1~100的随机数，从大到小排序并去重
                else if (x == "14") nnn(0);//加密/解码a-->f A-->F 1-->1....
                else if (x == "0") break;
                else 
                {
                    Console.WriteLine("错误，没有该程序代号，重来");
                    continue;
                }

            }




            /*String b = Console.ReadLine();
            for (int i = 0; i < b.Length; i++)
            {
                char f = char.Parse(b[i].ToString());
                if (f >= 'a' && f <= 'u'|| f >= 'A' && f <= 'U')
                {
                    f = (char)(f + 5);
                }
                else if(f >= 'v' && f <= 'z'||f >= 'V' && f <= 'Z')
                {
                    f = (char)(f - 21);
                }

                Console.Write(f);
                
            }
            
            
            //char d = Console.ReadKey(true).KeyChar;
            */






            /**知识点         
              *       1/ String x = Console.ReadLine();//输入
              *       int a = int.Parse(x);   //将string（字符串类型）转化为int（整型）并赋值
              *       2/int.TryParse( Console.ReadLine(),out a);   //输入(输出为输入的数);
              *       3/Console.ReadLine()为输出为ASCII码值
              *       4/String returnString = Console.ReadLine();//reStr驼峰 ReStr帕斯卡，输入一个字符串
              *       5/Console.WriteLine("{0}",a+b);   //a+b：若为整型则是相加，若为字符串则是拼接
              *       5/Console.WriteLine("{0}",a+b);   //a+b：若为整型则是相加，若为字符串则是拼接
              *       6/Console.ReadKey();//停顿                       
              *       7/int[] a = new int[3];//动态
              *       int[] b = { 2, 13, 4, 22 };
              *       8/string[] c = { "2", "13", "4", "22" };//静态
              *       9/Array.Sort(b);//排序
              *       10/Array.Reverse(b);//反过来
              *       11/Array.IndexOf(b, 22);//显示数组中指定的数的索引（下标0，1，2，3.....）
              *       12/foreach (int str in b)//循环语句{ Console.WriteLine(str); }
              *       13/浮点型decimal  double  float a = 1.11f;
              *       14/var a;如果不知道a是什么型可以用var
              *       15/有符与无符（有符：1001==-1   0001== +1）
              *       16/位运算符：&  |  ^  ~  <<  >>    1<<4:0001-->0100   2进制数前加0b：0b0000 0001==1
              *           Console.WriteLine(Convert.ToString(1<<4, 10));//0000 0001 --> 0001 0000
              *           赋值运算符：= += /= *= %= <<= >>= &= |= ^=
              *       17/Console.WriteLine(Convert.ToString(x,2));显示x的2进制数
              */






        }
        static void aaa( int d)
        {
            int a = 0, b = 1, c = 0;//前面补两个数为：0，1，1，2......
            for (int i = 1; i <= 25; i++)
            {
                c = a;
                a = b;
                b = c + b;
                Console.WriteLine($"第{i}个数是{b}");
                Console.ReadKey();
            }
        }
        static void bbb(int b)
        {
            int i = 1,j = 1;
            while (i <= 10)
            {
                j *= i;
                Console.WriteLine($"{i}的阶乘是{j}");
                i++;
            }
            Console.ReadKey();
        }
        static void ccc(int b)
        {
            int a = 0;        //(for)100以内所有偶数的和
            Console.WriteLine("100以内所有偶数是:");
            for (int i = 0; i <= 100; i += 2)
            {
                a += i;
                Console.Write($"  {i}");
            }
            Console.WriteLine();
            Console.WriteLine($"它们的和是{a}");
            Console.ReadKey();
        }
        static void ddd(int b)
        {
            int i = 0, j = 0;  //(while)100以内所有偶数的和
            Console.WriteLine("100以内所有偶数是:");
            while (i <= 100)
            {
                Console.Write($"  {i}");
                j += i;
                i += 2;
            }
            Console.WriteLine();
            Console.WriteLine($"它们的和是{j}");
            Console.ReadKey();
        }
        static void fff(int b)
        {
            String a = "zhgsb";
            Console.WriteLine("100个1000以内的随机数是:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Random sjs = new Random();//创建随机数
            //Console.Write(sjs.Next(1,100));
            int[] s = new int[100];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = sjs.Next(1, 1000);
                Console.Write($"     { s[i]}");
            }
            Console.ReadKey();
        }
        static void eee(int x)
        {
            while (true)
            {
                int a = 0;
                int  b;
                /*Console.WriteLine("请输入第一个数");
                string str = Console.ReadLine();

                if (int.TryParse(str,out a))
                {
                    a = int.Parse(str);
                }
                else
                {
                    Console.WriteLine("完蛋辣，重开吧孩子！\n");
                    continue;
                }
                Console.WriteLine("请输入第二个数");
                string str2 = Console.ReadLine();
                if (int.TryParse(str2, out b))
                {
                    b = int.Parse(str2);
                }
                else
                {
                    Console.WriteLine("完蛋辣，重开吧孩子！\n");
                    continue;
                }
                Console.WriteLine("两个数的和是 {0}\n",a + b);*/
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("请输入第{0}个数", i);
                    string str = Console.ReadLine();
                    if (int.TryParse(str, out b))
                    {
                        b = int.Parse(str);
                    }
                    else
                    {
                        Console.WriteLine("完蛋辣，重开吧孩子！\n");
                        break;
                    }
                    a = a + b;
                    if (i == 2)
                        Console.WriteLine(a);
                }
                Console.WriteLine("是否进入下一次运算,请输入  1（是）/0（否）");
                string e = Console.ReadLine();
                if (e == "1")
                {
                    continue;
                }
                else if (e == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("这都能输错？默认重来");
                    continue;
                }
            }
            Console.ReadKey();

        }
        static void ggg(int v)
        {
            int b = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    b = i * j;
                    Console.Write("{0}*{1}={2}\t", j, i, b);
                } 
            }
            Console.WriteLine();
        }
        static void hhh(int b)
        {
            int[] str1 = new int[100];
            for (int i = 0; i < str1.Length; i++)
            {
                str1[i] = i + 1;
                //Console.WriteLine(str1[i]);
            }
            foreach (int x in str1)
            {
                if (x % 2 == 0)
                {
                    Console.Write($"  {x}");
                }
            }
            Console.ReadKey();
        }
        static void iii(int b)
        {
            int[] ran = new int[100];
            Random sjs = new Random();//创建随机数
            for (int i = 0; i < ran.Length; i++)
            {
                ran[i] = sjs.Next(0, 101);
            }

            //Console.Write(sjs.Next(1,100));
            foreach (int t in ran)
            {
                if (t > 60)
                {
                    if (t < 70) 
                    {
                        Console.WriteLine($"{t}你真666");
                    }
                    else
                    {
                        if (t < 80)
                        {
                            Console.WriteLine($"{t}你真6");
                        }
                        else
                        {  
                            if (t < 90)
                            {
                                Console.WriteLine($"{t}你真qiang");
                            }
                            else
                            {                               
                                 Console.WriteLine($"{t}你真nb");   
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{t}你真cha");
                }
                /*if (t == 100)
                {
                    Console.WriteLine($"{t}你真nb");
                }
                else if(t>90&&t<100)
                {
                    Console.WriteLine($"{t}你真棒");
                }
                else if (t > 80 && t < 90)
                {
                    Console.WriteLine($"{t}你不错");
                }
                else if (t > 70 && t < 80)
                {
                    Console.WriteLine($"{t}你还好");
                }
                else if (t > 60 && t < 70)
                {
                    Console.WriteLine($"{t}看得过去及格了");
                }
                else if (t > 50 && t < 60)
                {
                    Console.WriteLine($"{t}你差了");
                }
                else if (t > 30 && t < 50)
                {
                    Console.WriteLine($"{t}太差了");
                }
                else if (t > 10 && t < 30)
                {
                    Console.WriteLine($"{t}重开吧");
                }
                else if (t > 0 && t < 10)
                {
                    Console.WriteLine($"{t}人才");
                }
                else if (t == 0)
                {
                    Console.WriteLine($"{t}你真是“天才”");
                }*/
            }
            Console.ReadKey();
        }
        static void jjj(int b)
        {
            int[] ran = new int[10];
            int min = 0;
            Random sjs = new Random();//创建随机数
            for (int i = 0; i < ran.Length; i++)
            {
                ran[i] = sjs.Next(0, 101);
                Console.WriteLine($"ran[{ i}]={ ran[i]}");
            }
            for (int i = 0; i < ran.Length; i++)
            {
                for (int j = 0; j < ran.Length - 1 - i; j++)
                {
                    if (ran[j] < ran[j + 1])
                    {

                        min = ran[j + 1];
                        ran[j + 1] = ran[j];
                        ran[j] = min;
                    }
 
                }
            }
            
            Console.Write("从大到小排序后为:");
            for (int i = 0; i < ran.Length; i++)
            {
                Console.Write($"  {ran[i]}");
            }
            Console.ReadKey();
        }
        static void kkk(int p)
        {
            int sum = 0;
            string[] a = new string[18];
            string id=Console.ReadLine();
            Console.WriteLine("请输入身份证");
            for (int s = 0; s < a.Length; s++)
            {
                a[s] = id[s].ToString();
            }
            Console.WriteLine();
            int[] b = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string[] c = { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
            int[] f = new int[17];
            for (int i = 0; i < b.Length; i++)
            {
                f[i] = int.Parse(a[i]);  
                //Console.Write($"f[{i}]={f[i]}");
                sum = (f[i] * b[i]) + sum;
            }
            Console.WriteLine($"sum={sum}\n");
            int d = 0;
            d = sum % 11;
            Console.WriteLine($"d={d}\n");
            Console.WriteLine($"c[d]={c[d]}\n");
            if (c[d] == a[17])
            {
                Console.WriteLine("验证对");
            }
            else
            {
                Console.WriteLine("验证不对");
            }
            Console.ReadKey();
        }
        static void lll(int p)
        {
            DateTime dateTime = DateTime.Now;
            //dateTime = dateTime.AddDays(6);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.DayOfWeek);
            string[] Day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] zh_Day = { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日" };
            string x = dateTime.DayOfWeek.ToString();//法一for循环

            for (int i = 0; i <= 6; i++)
            {
                if (x == Day[i])
                {
                    Console.WriteLine(zh_Day[i]);
                }
            }
            /*int pe=(int)dateTime.DayOfWeek;;//法二switch
            switch (pe)
            {
                case 1:
                    Console.WriteLine("星期一");
                break;
                case 2:
                    Console.WriteLine("星期二");
                break;
                case 3:
                    Console.WriteLine("星期三");
                break;
                case 4:
                    Console.WriteLine("星期四");
                break;
                case 5:
                    Console.WriteLine("星期五");
                break;
                case 6:
                    Console.WriteLine("星期六");
                break;
                default:
                    Console.WriteLine("星期日");
                break;
            }*/
            /*if (dateTime.DayOfWeek.ToString() == "Monday")//法三if与else if
            {
                Console.WriteLine("星期一");
            }
            else if (dateTime.DayOfWeek.ToString() == "Tuesday")
            {
                Console.WriteLine("星期二");
            }
            else if (dateTime.DayOfWeek.ToString() == "Wednesday")
            {
                Console.WriteLine("星期三");
            }
            else if (dateTime.DayOfWeek.ToString() == "Thursday")
            {
                Console.WriteLine("星期四");
            }
            else if(dateTime.DayOfWeek.ToString() == "Friday")
            {
                Console.WriteLine("星期五");
            }
            else if (dateTime.DayOfWeek.ToString() == "Saturday")
            {
                Console.WriteLine("星期六");
            }
            else if (dateTime.DayOfWeek.ToString() == "Sunday")
            {
                Console.WriteLine("星期日");
            }*/
            Console.ReadKey ();

            //Tuesday Wednesday Thursday Friday Saturday Sunday
        }
        static void mmm(int p)
        {
            List<int> list = new List<int>();
            Random sjs = new Random();//创建随机数
            for (int i = 0; i < 10; i++)
            {
                list.Add(sjs.Next(0, 101));
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            int min = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - 1 - i; j++)
                {

                    if (list[j] < list[j + 1])
                    {

                        min = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = min;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {

                    if (list[j] == list[j + 1])
                    {
                        list.Remove(list[j]);
                    }

                }
            }
            foreach (int i in list)
            {
                Console.Write($"   {i}");
            }
        }
        static void nnn(int p)
        {
            Console.WriteLine("加密请输入：0     解码请输入：1");
            String v = Console.ReadLine();
            if (v == "0")
            {
                String b = Console.ReadLine();
                Console.Write("加密为：");
                for (int i = 0; i < b.Length; i++)
                {
                    char f = char.Parse(b[i].ToString());
                    if (f >= 'a' && f <= 'u'|| f >= 'A' && f <= 'U')
                    {
                        f = (char)(f + 5);
                    }
                    else if(f >= 'v' && f <= 'z'||f >= 'V' && f <= 'Z')
                    {
                        f = (char)(f - 21);
                    }
    
                    Console.Write(f);
                    
                }
                Console.ReadKey();
            }
            
            else if (v == "1")
            {

                String b = Console.ReadLine();
                Console.Write("解码为：");
                for (int i = 0; i < b.Length; i++)
                {
                    char f = char.Parse(b[i].ToString());
                    if (f >= 'a' && f <= 'e' || f >= 'A' && f <= 'E')
                    {
                        f = (char)(f + 21);
                    }
                    else if (f >= 'f' && f <= 'z' || f >= 'F' && f <= 'Z')
                    {
                        f = (char)(f - 5);
                    }

                    Console.Write(f);

                }
                Console.ReadKey();
            }
        }
    }   
}
   