using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Description: This is the Hand Class
/// Version 0.2 - Added the Deal 1 method
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS ==========================================================================================================

        //PRIVATE METHODS

        protected override void _initialize()
        {
            throw new NotImplementedException();
        }

        //PUBLIC METHODS

        /// <summary>
        /// This method clones the top card, removes from top of deck, and return to hand.
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            //Clone the top card of the desk for placement in Hand
            Card firstCard = (Card)this[0].Clone();
            //Remove the Top Card from the CardList - Deck
            this.RemoveAt(0);

            //WriteLine for debugging purposes
            //Console.WriteLine("Deck now contains: " + this.Count + " Cards");

            return firstCard;
        }

        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "The Hand contains:\n";
            outputstring += "===========================================================\n";

            foreach (Card card in this)
            {
                outputstring += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputstring;
        }

    }
}