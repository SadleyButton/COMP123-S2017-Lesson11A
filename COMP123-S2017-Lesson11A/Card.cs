using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the card class
/// Version 0.1 - This is the card class to be used in the card shuffling and dealing simulation
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public class Card
    {
        //PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERTIES
        public Face Face { get { return this._face; }  set { this._face = value; } }

        public Suit Suit { get { return this._suit; } set { this._suit = value; } }

        //CONSTRUCTORS -------------------------------------------------------------------------
        /// <summary>
        /// This is the main constructor for the card class.
        /// It takes two arguments; face (face) and suit (suit).
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}