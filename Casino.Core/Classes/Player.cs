using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Core.Interfaces;
using Casino.Core.Classes.Inventories;
using Casino.Core.Classes.Chips;
using Casino.Core.Classes.Decks;
using Casino.Core.Classes.Decks.Suits;


namespace Casino.Core.Classes
{
    public class Player
    {
        ChipInventory chipInventory;

        public ChipInventory ChipInventory
        {
            get { return chipInventory; }
            set { chipInventory = value; }
        }

        public Player()
        {
            chipInventory = new ChipInventory();
        }
    }
}
