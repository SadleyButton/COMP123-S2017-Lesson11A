using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: Lesson 11 A
/// Version 0.2 - Added syntax to shuffle deck and display the shuffled results
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
        }
    }
}
