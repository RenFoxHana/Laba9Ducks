namespace DuckHappiness
{
    public class Item
    {
        public string Name { get; set; }
        public int HappinessChange { get; set; }
        public int SatisfactionChange { get; set; }

        public Item(string name, int happinessChange, int satisfactionChange)
        {
            Name = name;
            HappinessChange = happinessChange;
            SatisfactionChange = satisfactionChange;
        }
    }
}

