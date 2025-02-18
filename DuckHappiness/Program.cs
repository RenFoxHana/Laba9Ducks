namespace DuckHappiness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кличку утки:");
            string duckName = Console.ReadLine();

            PetDuck petDuck = new PetDuck(duckName);
            petDuck.Start();
        }
    }
}
