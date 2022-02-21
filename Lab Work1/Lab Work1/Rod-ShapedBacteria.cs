namespace Lab_Work1
{
    public class Rod_ShapedBacteria : IBacterium
    {
        private double growthRate = 20;
        private double lifeSpan = 135;
        private string typeOfBactery = "Rod-Shaped";
        public double BacterialGrowthRate { get => growthRate; set => growthRate = value; }
        public double LifeSpanOfABacterium { get => lifeSpan; set => lifeSpan = value; }
        public string TypeOfBactery { get => typeOfBactery; }
    }
}
