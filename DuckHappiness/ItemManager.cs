namespace DuckHappiness
{
    public class ItemManager
    {
        public List<Item> Items { get; private set; }

        public ItemManager()
        {
            Items = new List<Item>
            {
                new Item("Хлеб", 10, 20),
                new Item("Корм для уток", 15, 30),
                new Item("Гравий", -20, 5),
                new Item("Морковь", 5, 10),
                new Item("Счастливый камень", 30, 0),
                new Item("Пустая банка", -10, -10)
            };
        }

        public void UseItem(Duck duck, string itemName)
        {
            var item = Items.Find(i => i.Name.Equals(itemName, System.StringComparison.OrdinalIgnoreCase));

            if (duck.Status == "мертва")
            {
                Console.WriteLine($"Утка {duck.Name} больше не может пользоваться предметами.");
                return;
            }

            if (duck.Satisfaction >= 100)
            {
                Console.WriteLine($"Утка {duck.Name} слишком сытая!");
                return;
            }

            duck.Happiness += item.HappinessChange;
            duck.Satisfaction += item.SatisfactionChange;

            Console.WriteLine($"Утка {duck.Name} использовала {item.Name}. (Счастье: {duck.Happiness}, Сытость: {duck.Satisfaction})");

            if (duck.Happiness > 100) duck.Happiness = 100;
            if (duck.Happiness < 0) duck.Happiness = 0;
            if (duck.Satisfaction > 100) duck.Satisfaction = 100;
            if (duck.Satisfaction < 0) duck.Satisfaction = 0;

            if (duck.Happiness <= 0 || duck.Satisfaction <= 0)
            {
                Console.WriteLine($"Утка {duck.Name} умерла :(");
                duck.Status = "мертва";
            }
        }

        public List<Item> GetItems()
        {
            return Items;
        }
    }
}
