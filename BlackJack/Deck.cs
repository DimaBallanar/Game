using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private readonly List<Card> cards = new();
        public Deck() => GenerateCards();
       
        public Card GetCard()
        {
            if (IsEmpty) return null;
            var card = cards[new Random().Next(cards.Count)];
            cards.Remove(card);

            return card;
        }
        public bool IsEmpty => !cards.Any();
        public int Count => cards.Count;

        private void GenerateCards()
        {
            foreach (var type in Enum.GetValues<CardTypes>())
            {
                if (type is CardTypes.Number)
                {
                    for (int i = 2; i <= 9; i++)
                    {
                        cards.AddRange(CreateCardsByType(type, i));
                    }
                }
                else
                {
                    cards.AddRange(CreateCardsByType(type));
                }
            }
        }
        private IEnumerable<Card> CreateCardsByType(CardTypes type, int value = 0)
        {
            List<Card> result = new();

            for (int i = 0; i < 4; i++)
            {
                Card card = type switch
                {
                    CardTypes.Number => new($"{value}", value, type),
                    CardTypes.Jack => new($"Валет", 10, type),
                    CardTypes.Queen => new($"Дама", 10, type),
                    CardTypes.King => new($"Король", 10, type),
                    CardTypes.Ace => new($"Туз", 11, type),
                };
                result.Add(card);
            }

            return result;
        }
    }
}
