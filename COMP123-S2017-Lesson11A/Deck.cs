using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Deck Class
/// Version 0.3 - Fixed bug in the _initalize method
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public class Deck:List<Card>
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC VARIABLES

        //CONSTRUCTORS --------------------------------------------------------------------------
        /// <summary>
        /// This is the main constructor for the Deck Class
        /// Takes no arguments
        /// </summary>
        public Deck()
        {
            this._initialize();
        }

        //PRIVATE METHODS
        /// <summary>
        /// This private method (_initalize) that loads a deck with 52 cards
        /// </summary>
        private void _initialize()
        {
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }            
        }

        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the public ToString method and outputs the current Deck contents.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputstring = "";

            foreach (Card card in this)
            {
                outputstring += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputstring;
        }
    }
}