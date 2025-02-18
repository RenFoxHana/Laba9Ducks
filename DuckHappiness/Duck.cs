namespace DuckHappiness
{
    public class Duck
    {
        public string Name { get; set; }
        public int Happiness { get; set; }
        public int Satisfaction { get; set; }
        public string Status { get; set; }

        public Duck(string name)
        {
            Name = name;
            Happiness = 50;
            Satisfaction = 50;
            Status = "жива";
        }

        public void GetDuckInfo()
        {
            Console.WriteLine($"{Name} ({Status}) - Счастье: {Happiness}, Сытость: {Satisfaction}");
        }
    }
}
