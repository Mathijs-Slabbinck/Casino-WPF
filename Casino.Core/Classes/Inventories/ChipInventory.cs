using System.Collections.Generic;
using Casino.Core.Classes.Chips;
using Casino.Core.Interfaces;

namespace Casino.Core.Classes.Inventories
{
    public class ChipInventory
    {
        // i stands for inventory
        private Chip1 iChip1 = new Chip1();
        private Chip5 iChip5 = new Chip5();
        private Chip10 iChip10 = new Chip10();
        private Chip20 iChip20 = new Chip20();
        private Chip50 iChip50 = new Chip50();
        private Chip100 iChip100 = new Chip100();
        private Chip500 iChip500 = new Chip500();
        private Chip1000 iChip1000 = new Chip1000();
        private Chip5000 iChip5000 = new Chip5000();

        public Chip1 IChip1
        {
            get { return iChip1; }
            set { iChip1 = value; }
        }

        public Chip5 IChip5
        {
            get { return iChip5; }
            set { iChip5 = value; }
        }

        public Chip10 IChip10
        {
            get { return iChip10; }
            set { iChip10 = value; }
        }

        public Chip20 IChip20
        {
            get { return iChip20; }
            set { iChip20 = value; }
        }

        public Chip50 IChip50
        {
            get { return iChip50; }
            set { iChip50 = value; }
        }

        public Chip100 IChip100
        {
            get { return iChip100; }
            set { iChip100 = value; }
        }

        public Chip500 IChip500
        {
            get { return iChip500; }
            set { iChip500 = value; }
        }

        public Chip1000 IChip1000
        {
            get { return iChip1000; }
            set { iChip1000 = value; }
        }

        public Chip5000 IChip5000
        {
            get { return iChip5000; }
            set { iChip5000 = value; }
        }

        // if we don't pass anything, we create a standard inventory
        // if a list of chips is passed, we create an inventory with those chips
        public ChipInventory(List<IChip>? chips = null)
        {
            if (chips == null)
            {
                IChip1.Amount = 50;
                IChip5.Amount = 30;
                IChip10.Amount = 25;
                IChip20.Amount = 20;
                IChip50.Amount = 15;
                IChip100.Amount = 10;
                IChip500.Amount = 4;
                IChip1000.Amount = 1;
                IChip5000.Amount = 0;
            }
            else
            {
                if (chips.Count != 9)
                {
                    throw new ArgumentOutOfRangeException("You need to pass 9 chips (1 of each) to create a chip inventory!");
                }

                var seenValues = new HashSet<int>();

                for (int i = 0; i < chips.Count; i++)
                {
                    IChip chip = chips[i];

                    if (i == 0 && chip.Value == iChip1.Value)
                    {
                        IChip1.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The first chip in the list has to be Chip1");
                    }

                    if (i == 1 && chip.Value == IChip5.Value)
                    {
                        IChip5.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The second chip in the list has to be Chip5");
                    }

                    if (i == 2 && chip.Value == IChip10.Value)
                    {
                        IChip10.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The third chip in the list has to be Chip10");
                    }

                    if (i == 3 && chip.Value == IChip20.Value)
                    {
                        IChip20.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The fourth chip in the list has to be Chip20");
                    }

                    if (i == 4 && chip.Value == IChip50.Value)
                    {
                        IChip50.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The fifth chip in the list has to be Chip50");
                    }

                    if (i == 5 && chip.Value == IChip100.Value)
                    {
                        IChip100.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The sixth chip in the list has to be Chip100");
                    }

                    if (i == 6 && chip.Value == IChip500.Value)
                    {
                        IChip500.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The seventh chip in the list has to be Chip500");
                    }

                    if (i == 7 && chip.Value == IChip1000.Value)
                    {
                        IChip1000.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The eighth chip in the list has to be Chip1000");
                    }

                    if (i == 8 && chip.Value == IChip5000.Value)
                    {
                        IChip5000.Amount = chip.Amount;
                    }
                    else
                    {
                        throw new ArgumentException("The ninth chip in the list has to be Chip5000");
                    }

                }

                foreach (IChip chip in chips)
                {
                    if (!seenValues.Add(chip.Value))
                    {
                        throw new ArgumentException("You need to pass 9 chips (1 of each) to create a chip inventory!");
                    }
                }


            }
        }

        public int ReturnTotalValue()
        {
            int totalValue = 0;
            totalValue += (IChip1.Value * IChip1.Amount);
            totalValue += (IChip5.Value * IChip5.Amount);
            totalValue += (IChip10.Value * IChip10.Amount);
            totalValue += (IChip20.Value * IChip20.Amount);
            totalValue += (IChip50.Value * IChip50.Amount);
            totalValue += (IChip100.Value * IChip100.Amount);
            totalValue += (IChip500.Value * IChip500.Amount);
            totalValue += (IChip1000.Value * IChip1000.Amount);
            totalValue += (IChip5000.Value * IChip5000.Amount);
            return totalValue;
        }

        public void UpdateChips(ChipInventory newInventory)
        {
            iChip1.Amount = newInventory.IChip1.Amount;
            iChip5.Amount = newInventory.IChip5.Amount;
            iChip10.Amount = newInventory.IChip10.Amount;
            iChip20.Amount = newInventory.IChip20.Amount;
            iChip50.Amount = newInventory.IChip50.Amount;
            iChip100.Amount = newInventory.IChip100.Amount;
            iChip500.Amount = newInventory.IChip500.Amount;
            iChip1000.Amount = newInventory.IChip1000.Amount;
            iChip5000.Amount = newInventory.IChip5000.Amount;
        }
    }
}
