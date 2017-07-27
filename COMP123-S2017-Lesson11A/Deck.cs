using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Deck Class
/// Version 0.5 - Refactored Desk class to inherit from CardList
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

        /// <summary>
        /// This is the public method used to shuffle the deck of cards.
        /// </summary>
        public void Shuffle()
        {
            int firstCard, secondCard;
            Card tempCard;

            firstCard = this.Random.Next(0,52);
            secondCard = this.Random.Next(0, 52);
            tempCard = (Card)this[secondCard].Clone();

            for (int i = 0; i < this.Count; i++)
            {
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = this[secondCard].Face;
                this[firstCard].Suit = this[secondCard].Suit;
            }

        }
    }
}