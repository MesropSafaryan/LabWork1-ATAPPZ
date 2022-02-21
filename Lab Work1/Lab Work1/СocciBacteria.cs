namespace Lab_Work1
{
    public class CocciBacteria : IBacterium
    {
        private double growthRate = 15;
        private double lifeSpan = 120;
        private string typeOfBactery = "Сocci";
        public double BacterialGrowthRate { get => growthRate; set => growthRate = value; }
        public double LifeSpanOfABacterium { get => lifeSpan; set => lifeSpan = value; }
        public string TypeOfBactery { get => typeOfBactery; }
    }
}
