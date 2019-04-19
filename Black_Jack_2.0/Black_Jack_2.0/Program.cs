using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class basics
    {
        public bool player = true, hitt = true;
        public int draw = 0, count, dealerstotal, playerstotal;
        public string card_Name, response, Play_Again;
        public static Random r = new Random();
        public int loopCounter = 1;
        public int Card()
        {
            draw = r.Next(2, 15);
            return draw;
        }
        public int Total()
        {
            if (draw < 14)
            {
                count = 10;
                if (draw <= 9)
                {
                    count = draw;
                }
            }
            else //this isnt working 
            {
                if (count + 11 > 21)
                {
                    count = 1;
                }
                else
                {
                    count = 11;
                }
            }
            return count;
        }
        public string Card_Name()
        {
            switch (draw)
            {
                case 2:
                    card_Name = "2";
                    break;
                case 3:
                    card_Name = "3";
                    break;
                case 4:
                    card_Name = "4";
                    break;
                case 5:
                    card_Name = "5";
                    break;
                case 6:
                    card_Name = "6";
                    break;
                case 7:
                    card_Name = "7";
                    break;
                case 8:
                    card_Name = "8";
                    break;
                case 9:
                    card_Name = "9";
                    break;
                case 10:
                    card_Name = "10";
                    break;
                case 11:
                    card_Name = "Jack";
                    break;
                case 12:
                    card_Name = "Queen";
                    break;
                case 13:
                    card_Name = "King";
                    break;
                case 14:
                    card_Name = "Ace";
                    break;
            }
            return card_Name;
        }
        public void Display()
        {
            player = true;
            Console.WriteLine("\nWelcome to BlackJack\n You have " + playerstotal);
        }
        public void Decision()
        {
            Console.WriteLine("\n Hit or Stay?\n");

            response = (Console.ReadLine().ToLower());
        }
    }
    class Game
    {
        public static void Main(string[] args)
        {
            bool retry = true;
            while (retry == true)
            {
            basics b = new basics();
           
                while (b.loopCounter <= 4)
                {
                    b.Card();
                    b.Total();
                    if (b.loopCounter > 2)
                    {
                        b.player = false;
                    }

                    if (b.player == true)
                    {
                        b.playerstotal += b.count;
                    }
                    else { b.dealerstotal += b.count; }
                    b.loopCounter += 1;
                }
                //need a boolen 
                b.Display();
                while (b.hitt == true)
                {
                    b.Decision();
                    if (b.response == "hit" & b.playerstotal <= 21)
                    {
                        b.player = true;
                        b.Card();
                        b.Total();
                        b.Card_Name();
                        b.playerstotal += b.count;
                        if (b.playerstotal > 21)
                        {

                            b.hitt = false;
                        }
                        else
                        {
                            Console.WriteLine("You drew a " + b.card_Name + "\n You now have " + b.playerstotal);
                        }
                    }
                    else if (b.response == "stay")
                    {
                        b.hitt = false;
                        b.player = false;
                    }
                    while (b.player == false)
                    {
                        if (b.dealerstotal >= 17)
                        {
                            b.player = true;
                            break;
                        }
                        b.Card();
                        b.Total();
                        b.Card_Name();
                        b.dealerstotal += b.count;

                     
                    }
                }
                if (b.dealerstotal <= 21)
                {
                    if (b.playerstotal <= 21)
                    {
                        if (b.playerstotal > b.dealerstotal)
                        {
                            Console.WriteLine("Computer: " + b.dealerstotal + "\nYou: " + b.playerstotal + "\nYOU ARE A Winner!!!");
                        }
                        else if (b.dealerstotal > b.playerstotal)
                        {
                            Console.WriteLine("Computer: " + b.dealerstotal + "\nYou: " + b.playerstotal + "\nYOU ARE A LOOSER");
                        }
                        else
                        {
                            Console.WriteLine("Computer: " + b.dealerstotal + "\nYou: " + b.playerstotal + "\nTIE!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You went Bust! " +  "\nYou drew a " + b.card_Name + "\nDealers Total: " + b.dealerstotal + "\nPlayers Total: " + b.playerstotal + "\nYou're a LOOSER!!");
                    }
                }
                else
                {
                    Console.WriteLine("Dealer went Bust! " +  "\nDealers Total: " + b.dealerstotal + "\nPlayers Total: " + b.playerstotal + "\nYou WON!!");
                }
                Console.WriteLine("\n\nPlay Agin?\nY or N?");

                b.Play_Again = (Console.ReadLine().ToLower().Substring(0, 1));
                if (b.Play_Again == "y")
                {
                    retry = true;
                }
                else
                {
                    retry = false;

                } 
        }
            Console.WriteLine("Thanks For Playing!!");
                  Console.Read();
            }
    }
}
