namespace CardsEnumAndList
{
    internal class Card
    {
        public Card(Values value, Suits suit)
        {
            Value = value.ToString();
            Suit = suit.ToString();
        }
        public string Suit { get; private set; }
        public string Value { get; private set; }

        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }
    }
}
