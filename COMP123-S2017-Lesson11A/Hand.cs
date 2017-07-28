using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Description: This is the Hand Class
/// Version 0.5 - Created the HighestCards method
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS ==========================================================================================================

        //PRIVATE METHODS

        /// <summary>
        /// This method initalizes the class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            //This method is currently empty
        }

        //PUBLIC METHODS

        public void HighestCards(Hand hand)
        {
            var sortCards =
                from cards in this
                orderby cards.Face descending
                select cards;
            
            Console.WriteLine("Hand of Cards in Order\n" +
                              "========================");
            
            foreach (var card in sortCards)
            {
                Console.WriteLine("The {0} of {1}", card.Face, card.Suit);
            }
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