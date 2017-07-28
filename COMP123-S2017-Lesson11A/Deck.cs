using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Description: This is the Deck Class. It inherits from the CardList class.
/// Version 0.7 - Refactored Desk class to add the Deal5 method.
///             - FIXED: the shuffle by placing the randomizer into the loop
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public class Deck : CardList
    {
        //PRIVATE INSTANCE VARIABLES
        private Random _random;

        //PRIVATE PROPERTIES
        public Random Random { get { return this._random; } }

        //PUBLIC VARIABLES

        //CONSTRUCTORS --------------------------------------------------------------------------

        //PRIVATE METHODS
        /// <summary>
        /// This private method (_initalize) that loads a deck with 52 cards.
        /// This method also initalizes the random private variable.
        /// </summary>
        protected override void _initialize()
        {
            // initalize the random object
            this._random = new Random();

            // load the list with cards
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
        /// This method will deal a hand, using the Deal1 method and return cards to the Driver Class hand
        /// </summary>
        /// <returns></returns>
        public Hand Deal5()
        {
            Hand fiveCards = new Hand();  //Creates a hand (container) to hold cards until complete

            for (int cardNo = 0; cardNo < 5; cardNo++)
            {
                fiveCards.Add(Deal1());
            }

            return fiveCards;
        }

        /// <summary>
        /// This method overrides the public ToString method and outputs the current Deck contents.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "The Deck contains:\n";
            outputstring += "===========================================================\n";

            foreach (Card card in this)
            {
                outputstring += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputstring;
        }

        /// <summary>
        /// This is the public method used to shuffle the deck of cards.
        /// </summary>
        public void Shuffle()
        {
            int firstCard, secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = this[secondCard].Face;
                this[firstCard].Suit = this[secondCard].Suit;
            }

        }
    }
}