namespace CardsEnumAndList
{
    internal class Card
    {
        public Card(Values value, Suits suit)
        {
            Value = value.ToString();
            Suit = suit.ToString();
        }
        public string Suit { get; set; }
        public string Value { get; set; }

        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }
    }
}
