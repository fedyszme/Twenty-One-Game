using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player//a class is a design. It is the objects modeled from this that will get the values.
    {   
        public Player( string name) : this(name, 100)//this is a second constructor (constructor chaining) that utilizes the code of the one below. And if no balance is inputed will default to 100
        {
        }
        public Player (string name, int beginningBalance) //constructors go at the top of a class 
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name{ get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount; //this is the same as Balance = Balance - amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)//overloading the operator +. Its taking two operands, a game and a player and returning a game.
        {//...so its taking the game adding a player to it and returning the game.
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)//remember Players is a list which is why you can add and remove.
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
