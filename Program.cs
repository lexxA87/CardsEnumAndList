namespace CardsEnumAndList
{
    internal class Program
    {
        private static readonly Random random = new();
        static void Main(string[] args)
        {
            int suit = random.Next(4);
            int value = random.Next(1, 14);
            Card card = new((Values)value, (Suits)suit);
            Console.WriteLine(card.Name);
        }
    }
}