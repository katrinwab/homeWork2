namespace HomeWork2.Drink
{
    class Drink: ISubject
    {
        public Drink(int cost, int count, string name)
        {
            Name = name;
            Count = count;
            Cost = cost;
        }

        public int Cost { get; private set; }
        public int Count { get; private set; }
        public string Name { get; private set; }
    }
}
