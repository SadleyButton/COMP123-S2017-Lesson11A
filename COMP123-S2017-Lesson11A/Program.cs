using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Description: Lesson 11 A
/// Version 0.4 - Created a new Hand for the Deal5 method
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            /*
            hand.Add(deck.Deal1()); //Deals one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1()); //Deals one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */

            /* Lab Homework Outline
            
            Use the following to deal five cards into a hand
                hand = deck.Deal5();
            */
            Hand hand = new Hand(); //new empty Hand container (player)
            hand = deck.Deal5();
            Console.WriteLine(hand.ToString());


            /*
            Sort Hand to order by Highest Cards using LINQ
                    from hand in this
                        where ...
            */


        }
    }
}
