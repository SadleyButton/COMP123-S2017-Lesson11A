using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 27, 2017
/// Description: This is the Hand Class
/// Version 0.4 - Fixed bug with the non-implimented _initalize method
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