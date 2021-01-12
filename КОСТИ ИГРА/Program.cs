using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace КОСТИ_ИГРА
{
    class Program
    {
        static Random ran = new Random();
        static int Rand_gi(int a) 
        {
            int output=0;
            int temporary = ran.Next(1, 7);
            if (a == 1) 
            {
                output = ran.Next(1, 7);
            }
            else if(a==2)
            {

                if (temporary == 1)
                {
                    output = ran.Next(1, 3);
                }
                else if (temporary == 2||temporary==3)
                {
                    output = ran.Next(3, 5);
                }
                else
                {
                    output = ran.Next(5, 7);
                }
            }
            else if (a == 3)
            {
                if (temporary > 2)
                {
                    output = ran.Next(5, 7);
                }
                else
                {
                    output = ran.Next(1, 5);
                }
            }return output;
    
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of bots: ");
            int m = int.Parse(Console.ReadLine());
            int[] arr = new int[m];

            do
            {
                Console.WriteLine("Roll a dice for you, guys?");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    int user1 = ran.Next(1, 7);
                    int user2 = ran.Next(1, 7);
                    Console.WriteLine("Вы набрали {0} и {1}. В сумме вы получили {2}", user1, user2, user1 + user2);
                    user1 = user1 + user2;

                    int max = 0;
                    for (int i = 0; i < m; i++)
                    {
                        int bot1 = Rand_gi(1);
                        int bot2 = Rand_gi(2);
                        arr[i] = bot1 + bot2;
                        Console.WriteLine("Бот {0} набрал {1} и {2}. В сумме он получил {3}", i + 1, bot1, bot2, bot1 + bot2);
                        if (max < arr[i]) //максимальное значение из набранных очков ботов
                            max = arr[i];
                    }
                    if (user1 == max) 
                    {
                        Console.WriteLine("Никто не выиграл!");
                    }
                    else
                    {
                        if (user1 > max)
                            Console.Write("Вы ");
                        else
                        {
                            for (int i = 0; i < m; i++)
                            {
                                if (max == arr[i]) //узнаю какие боты набрали максимальное значение
                                    Console.Write("Бот {0} ", i + 1);
                            }

                        }
                        Console.WriteLine(" победил(и)");
                    }
                }

            } while (true);
        }        
    }
}
