using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Part3
{
    class Card
    {
        // Instance Varaible
        private string _face;
        private string _suit;


        // Properties
        public string Face
        {
            get
            {
                return this._face; //Read only
            }
        }

        public string Suit
        {
            get
            {
                return this._suit; //Read only
            }
        }

        // Constructor
        public Card(string face, string suit)
        {
            this._face = face;
            this._suit = suit;
        }

        //Public Methods
        public void Show()
        {
            Console.WriteLine("{0} of {1}", this._face, this._suit);
        }
    }
}
