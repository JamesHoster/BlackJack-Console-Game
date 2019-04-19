using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int UserCard1 = rnd.Next(1, 10);
            int UserCard2 = rnd.Next(1, 10);
            int DealerCard1 = rnd.Next(1, 10);
            int DealerCard2 = rnd.Next(1, 10);
            int HitCard1 = rnd.Next(1, 10);
            int HitCard2 = rnd.Next(1, 10);
            int UserSum1, DealerSum1;
            int UserPot = 0;
            int DealerPot = 0;
            string _wager;
            int wager;
            string PlayAgain;

            //System.Threading.Thread.sleep(20);
            try
            {
                do
                {
                    System.Console.WriteLine("How much would you like to wager?");
                    _wager = System.Console.ReadLine();
                   
                    wager = Int32.Parse(_wager);
                    System.Console.WriteLine($"{wager} Wagered");

                    UserSum1 = UserCard1 + UserCard2;



                    System.Console.WriteLine($"Your Card Count: {UserSum1}");
                    DealerSum1 = DealerCard1 + DealerCard2;
                    System.Console.WriteLine($"The Dealers Card Count: {DealerSum1}");

                    System.Threading.Thread.Sleep(20);

                    /*do
                        {
                            DealerSum1 = DealerSum1 + HitCard1;
                            System.Console.WriteLine($"Dealer Card Count: {DealerSum1}");
                        } while (DealerSum1 <= 17);*/

                    System.Console.WriteLine("Hit?  (Y/N)");
                    string hit = System.Console.ReadLine();
                    if (hit.ToUpper() == "Y")
                    {
                        UserSum1 = UserSum1 + HitCard1;
                        System.Console.WriteLine($"Your Card Count: {UserSum1}");
                        if (DealerSum1 <= 17)
                            DealerSum1 = DealerSum1 + HitCard2;
                        //do
                        //{
                        //    DealerSum1 = DealerSum1 + HitCard2;
                        //} while (DealerSum1 <= 17);
                        System.Console.WriteLine($"Dealer Card Count: {DealerSum1}");

                        if ((DealerSum1 > UserSum1) && (DealerSum1 <= 21))
                        {
                            DealerPot = wager + DealerPot;
                        }
                        else
                        {
                            UserPot = wager + UserPot;
                        }
                        //System.Console.WriteLine($"Current User Pot: {UserPot}   Current Dealer Pot: {DealerPot}");
                    }
                    if (hit.ToUpper() == "N")
                    {
                        System.Console.WriteLine($"Your Card Count: {UserSum1}");
                        if (DealerSum1 <= 17)
                            DealerSum1 = DealerSum1 + HitCard2;
                        //do
                        //{
                        //    DealerSum1 = DealerSum1 + HitCard2;
                        //} while (DealerSum1 <= 17);
                        System.Console.WriteLine($"Dealer Card Count: {DealerSum1}");

                        if ((DealerSum1 > UserSum1) && (DealerSum1 <= 21))
                        {
                            DealerPot = wager + DealerPot;
                        }
                        else
                        {
                            UserPot = wager + UserPot;
                        }
                    }
                    System.Console.WriteLine($"Current User Pot: {UserPot}   Current Dealer Pot: {DealerPot}");

                    System.Console.WriteLine($"Would you like to play again?  (Y/N)");
                    PlayAgain = System.Console.ReadLine();


                } while (PlayAgain.ToUpper() == "Y");

            }
            catch
            {
                

            }
            
        }
    }
}
