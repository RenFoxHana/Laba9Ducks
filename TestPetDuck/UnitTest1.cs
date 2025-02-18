using DuckHappiness;
namespace TestPetDuck
{
    public class ItemManagerTests
    {
        private readonly ItemManager itemManager;
        private readonly Duck duck;

        public ItemManagerTests()
        {
            itemManager = new ItemManager();
            duck = new Duck("�������� ����");
        }

        [Fact]
        public void UsingHappyItem()
        {
            var itemName = "���������� ������";
            var itemHappinessChange = itemManager.Items.FirstOrDefault(x => x.Name == itemName).HappinessChange;
            var initialHappiness = duck.Happiness;

            itemManager.UseItem(duck, itemName);

            Assert.Equal(initialHappiness + itemHappinessChange, duck.Happiness);
        }

        [Fact]
        public void UsingUnhappyItem()
        {
            var itemName = "������";
            var itemHappinessChange = itemManager.Items.FirstOrDefault(x => x.Name == itemName).HappinessChange;
            var initialHappiness = duck.Happiness;

            itemManager.UseItem(duck, itemName);

            Assert.Equal(initialHappiness + itemHappinessChange, duck.Happiness);
        }

        [Fact]
        public void DuckDiesFromSadness()
        {
            duck.Happiness = 1;
            var itemName = "������ �����";

            itemManager.UseItem(duck, itemName);

            Assert.Equal("������", duck.Status);
        }

        [Fact]
        public void SatisfactionNotAbove100()
        {
            duck.Satisfaction = 95;
            var itemName = "���� ��� ����";

            itemManager.UseItem(duck, itemName);

            Assert.Equal(100, duck.Satisfaction);
        }

        [Fact]
        public void SatisfactionNotBelow0()
        {
            duck.Satisfaction = 5;
            var itemName = "������ �����";

            itemManager.UseItem(duck, itemName);

            Assert.Equal(0, duck.Satisfaction);
        }
    }
}