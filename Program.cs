namespace CardsEnumAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int suit = random.Next(4);
            int value = random.Next(1, 14);
            Card card = new((Values)value, (Suits)suit);
            Console.WriteLine(card.Name);
        }
    }
}