namespace CardsEnumAndList
{
    internal class Card
    {
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
