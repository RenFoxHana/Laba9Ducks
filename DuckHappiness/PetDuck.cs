namespace DuckHappiness
{
    public class PetDuck
    {
        private ItemManager itemManager;
        private Duck duck;

        public PetDuck(string duckName)
        {
            duck = new Duck(duckName);
            itemManager = new ItemManager();
        }

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Дать предмет утке");
                Console.WriteLine("2. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ItemMenu();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        private void ItemMenu()
        {
            while (true)
            {
                Console.Clear();
                duck.GetDuckInfo();
                Console.WriteLine("Доступные предметы:");
                var items = itemManager.GetItems();

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].Name} (Счастье: {items[i].HappinessChange}, Сытость: {items[i].SatisfactionChange})");
                }

                Console.WriteLine();
                Console.WriteLine("Введите номер предмета из списка (или 0 для возврата):");
                string input = Console.ReadLine();

                if (input == "0")
                    return;

                if (int.TryParse(input, out int itemIndex) && itemIndex > 0 && itemIndex <= items.Count)
                {
                    var selectedItem = items[itemIndex - 1];
                    itemManager.UseItem(duck, selectedItem.Name);
                }
                else
                {
                    Console.WriteLine("Неверный номер предмета. Попробуйте снова.");
                }
                Console.ReadKey();
            }
        }
    }
}
