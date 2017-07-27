using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Name: Bradley Sutton
/// Date: July 25, 2017
/// Description: This is the Abstract superclass Card List.  It inherits from the build-in List generic collection and consumes the Card class.
/// Version 0.1 - Created the CardList class
/// </summary>

namespace COMP123_S2017_Lesson11A
{
    public abstract class CardList : List<Card>
    {

        //PRIVATE INSTANCE VARIABLES

        //PRIVATE PROPERTIES

        //CONSTRUCTORS ====================================================================================
        public CardList()
        {
            this._initialize();
        }

        //PRIVATE METHODS
        protected abstract void _initialize();

        //PUBLIC METHODS
    }
}