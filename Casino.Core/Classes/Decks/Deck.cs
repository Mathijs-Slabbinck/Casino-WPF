using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Core.Classes.Decks.Suits.Cards;
using Casino.Core.Classes.Decks.Suits;
using Casino.Core.interfaces;

namespace Casino.Core.Classes.Decks
{
    public class Deck
    {
        private readonly bool hasJokers;
        private List<ICard> cards = new List<ICard>();

        public List<ICard> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        // if we call this method while passing a list of which cards it wants, we will add those cards to the deck
        // if we call this method without passing a list, we will create a new deck with the default cards, but with the extra option to add jokers or decide the ace values
        public Deck(List<ICard>? lCards = null, bool lHasJokers = false, int aceValue = 1)
        {
            if(lCards == null)
            {
                AddBasicDeck(lHasJokers, aceValue);
            }
            else
            {
                foreach (ICard card in lCards)
                {
                    Cards.Add(card);
                }
            }
        }

        private void AddBasicDeck(bool lHasJokers, int aceValue)
        {
            AceOfClubs aceOfClubs = new AceOfClubs(aceValue);
            AceOfDiamonds aceOfDiamonds = new AceOfDiamonds(aceValue);
            AceOfHearts aceOfHearts = new AceOfHearts(aceValue);
            AceOfSpades aceOfSpades = new AceOfSpades(aceValue);
            Cards.Add(aceOfClubs);
            Cards.Add(aceOfDiamonds);
            Cards.Add(aceOfHearts);
            Cards.Add(aceOfSpades);

            TwoOfClubs twoOfClubs = new TwoOfClubs();
            TwoOfDiamonds twoOfDiamonds = new TwoOfDiamonds();
            TwoOfHearts twoOfHearts = new TwoOfHearts();
            TwoOfSpades twoOfSpades = new TwoOfSpades();
            Cards.Add(twoOfClubs);
            Cards.Add(twoOfDiamonds);
            Cards.Add(twoOfHearts);
            Cards.Add(twoOfSpades);

            ThreeOfClubs threeOfClubs = new ThreeOfClubs();
            ThreeOfDiamonds threeOfDiamonds = new ThreeOfDiamonds();
            ThreeOfHearts threeOfHearts = new ThreeOfHearts();
            ThreeOfSpades threeOfSpades = new ThreeOfSpades();
            Cards.Add(threeOfClubs);
            Cards.Add(threeOfDiamonds);
            Cards.Add(threeOfHearts);
            Cards.Add(threeOfSpades);

            FourOfClubs fourOfClubs = new FourOfClubs();
            FourOfDiamonds fourOfDiamonds = new FourOfDiamonds();
            FourOfHearts fourOfHearts = new FourOfHearts();
            FourOfSpades fourOfSpades = new FourOfSpades();
            Cards.Add(fourOfClubs);
            Cards.Add(fourOfDiamonds);
            Cards.Add(fourOfHearts);
            Cards.Add(fourOfSpades);

            FiveOfClubs fiveOfClubs = new FiveOfClubs();
            FiveOfDiamonds fiveOfDiamonds = new FiveOfDiamonds();
            FiveOfHearts fiveOfHearts = new FiveOfHearts();
            FiveOfSpades fiveOfSpades = new FiveOfSpades();
            Cards.Add(fiveOfClubs);
            Cards.Add(fiveOfDiamonds);
            Cards.Add(fiveOfHearts);
            Cards.Add(fiveOfSpades);

            SixOfClubs sixOfClubs = new SixOfClubs();
            SixOfDiamonds sixOfDiamonds = new SixOfDiamonds();
            SixOfHearts sixOfHearts = new SixOfHearts();
            SixOfSpades sixOfSpades = new SixOfSpades();
            Cards.Add(sixOfClubs);
            Cards.Add(sixOfDiamonds);
            Cards.Add(sixOfHearts);
            Cards.Add(sixOfSpades);

            SevenOfClubs sevenOfClubs = new SevenOfClubs();
            SevenOfDiamonds sevenOfDiamonds = new SevenOfDiamonds();
            SevenOfHearts sevenOfHearts = new SevenOfHearts();
            SevenOfSpades sevenOfSpades = new SevenOfSpades();
            Cards.Add(sevenOfClubs);
            Cards.Add(sevenOfDiamonds);
            Cards.Add(sevenOfHearts);
            Cards.Add(sevenOfSpades);

            EightOfClubs eightOfClubs = new EightOfClubs();
            EightOfDiamonds eightOfDiamonds = new EightOfDiamonds();
            EightOfHearts eightOfHearts = new EightOfHearts();
            EightOfSpades eightOfSpades = new EightOfSpades();
            Cards.Add(eightOfClubs);
            Cards.Add(eightOfDiamonds);
            Cards.Add(eightOfHearts);
            Cards.Add(eightOfSpades);

            NineOfClubs nineOfClubs = new NineOfClubs();
            NineOfDiamonds nineOfDiamonds = new NineOfDiamonds();
            NineOfHearts nineOfHearts = new NineOfHearts();
            NineOfSpades nineOfSpades = new NineOfSpades();
            Cards.Add(nineOfClubs);
            Cards.Add(nineOfDiamonds);
            Cards.Add(nineOfHearts);
            Cards.Add(nineOfSpades);

            TenOfClubs tenOfClubs = new TenOfClubs();
            TenOfDiamonds tenOfDiamonds = new TenOfDiamonds();
            TenOfHearts tenOfHearts = new TenOfHearts();
            TenOfSpades tenOfSpades = new TenOfSpades();
            Cards.Add(tenOfClubs);
            Cards.Add(tenOfDiamonds);
            Cards.Add(tenOfHearts);
            Cards.Add(tenOfSpades);

            JackOfClubs jackOfClubs = new JackOfClubs();
            JackOfDiamonds jackOfDiamonds = new JackOfDiamonds();
            JackOfHearts jackOfHearts = new JackOfHearts();
            JackOfSpades jackOfSpades = new JackOfSpades();
            Cards.Add(jackOfClubs);
            Cards.Add(jackOfDiamonds);
            Cards.Add(jackOfHearts);
            Cards.Add(jackOfSpades);

            QueenOfClubs queenOfClubs = new QueenOfClubs();
            QueenOfDiamonds queenOfDiamonds = new QueenOfDiamonds();
            QueenOfHearts queenOfHearts = new QueenOfHearts();
            QueenOfSpades queenOfSpades = new QueenOfSpades();
            Cards.Add(queenOfClubs);
            Cards.Add(queenOfDiamonds);
            Cards.Add(queenOfHearts);
            Cards.Add(queenOfSpades);

            KingOfClubs kingOfClubs = new KingOfClubs();
            KingOfDiamonds kingOfDiamonds = new KingOfDiamonds();
            KingOfHearts kingOfHearts = new KingOfHearts();
            KingOfSpades kingOfSpades = new KingOfSpades();
            Cards.Add(kingOfClubs);
            Cards.Add(kingOfDiamonds);
            Cards.Add(kingOfHearts);
            Cards.Add(kingOfSpades);


            if (lHasJokers)
            {
                RedJoker redJoker = new RedJoker();
                BlackJoker blackJoker = new BlackJoker();
                Cards.Add(redJoker);
                Cards.Add(blackJoker);
            }
        }

        public void RemoveCard(ICard card)
        {
            Cards.Remove(card);
        }

        public void AddCard(ICard card)
        {
            Cards.Add(card);
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                ICard temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
    }
}
