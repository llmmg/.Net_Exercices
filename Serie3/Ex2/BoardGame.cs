using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    public class BoardGame
    {
        private Dictionary<char, bool> table = new Dictionary<char, bool>();
        private int SlotNumber;
        private int PawnNumber;

        public BoardGame()
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            SlotNumber = 26;
            PawnNumber = 6;

            foreach(char c in alphabet)
            {
                table.Add(c,false);
            }

            Random rnd = new Random();
            for(int i=0;i<6;i++)
            {
                int pos = rnd.Next(0, 26);
                char elem=table.Keys.ElementAt(rnd.Next(0,26));

                if (!table[elem])
                {
                    table[elem] = true;
                }
                else
                {
                    i--;
                }
            }
        }

        public int slotNumber
        {
            get { return SlotNumber; }
        }
        public int pawnNumber {
            get {return PawnNumber; }
        }

        //TODO: fill table

       
        public bool this[char letter]
        {
            get
            {
                return table[letter];
            }
        }
        public char this[int pos]
        {
            get
            {
                return table.Keys.ElementAt(pos);
            }
        }
    }
}
