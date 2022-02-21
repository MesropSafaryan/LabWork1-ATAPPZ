namespace Lab_Work1
{
    public class Spirilla : IBacterium
    {
        private double growthRate = 25;
        private double lifeSpan = 75;
        private string typeOfBactery = "Spirilla";
        public double BacterialGrowthRate { get => growthRate; set => growthRate = value; }
        public double LifeSpanOfABacterium { get => lifeSpan; set => lifeSpan = value; }
        public string TypeOfBactery { get => typeOfBactery; }
    }
}
