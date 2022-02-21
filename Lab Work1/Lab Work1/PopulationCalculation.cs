namespace Lab_Work1
{
    public class PopulationCalculation
    {
        int population, wasBorned = 0;
        double growthRate, lifeSpan;
        double chanceCoeff;
        public int Population { get => population; }
        public int WasBorned { get => wasBorned; }
        public PopulationCalculation(IBacterium bacterium, int number, int minutes, string livingСonditions)
        {
            Calculate(bacterium, number, minutes, livingСonditions);
        }
        int Calculate(IBacterium bacterium, int number, int minutes, string livingСonditions)
        {
            if(number < 0 || minutes < 0)
            {
                throw new Exception("Wrong time or amount!");
            }
            population = 1;
            if (livingСonditions == "ideal")
            {
                chanceCoeff = 1;
            }
            else if (livingСonditions == "good")
            {
                chanceCoeff = 0.7;
            }
            else if (livingСonditions == "normal")
            {
                chanceCoeff = 0.5;
            }
            else if (livingСonditions == "bad")
            {
                chanceCoeff = 0.25;
            }
            else
            {
                throw new Exception("Wrong living conditions!");
            }
            bacterium.BacterialGrowthRate = bacterium.BacterialGrowthRate / chanceCoeff;
            bacterium.LifeSpanOfABacterium = bacterium.LifeSpanOfABacterium * chanceCoeff;
            growthRate = bacterium.BacterialGrowthRate;
            lifeSpan = bacterium.LifeSpanOfABacterium;
            double step = 0.01;
            for (double i = 0; i < minutes; i = i + step)
            {
                growthRate = growthRate - step;
                lifeSpan = lifeSpan - step;
                if ((lifeSpan > 0) && (growthRate <= 0))
                {
                    wasBorned = wasBorned + population * 2 - population;
                    population = population * 2;
                    growthRate = bacterium.BacterialGrowthRate;
                    lifeSpan = bacterium.LifeSpanOfABacterium;
                }
                if(lifeSpan <= 0)
                {
                   population--;  
                   if(population > 0)
                    {
                        lifeSpan = bacterium.LifeSpanOfABacterium;
                        growthRate = bacterium.BacterialGrowthRate;
                    }
                   else
                    {
                        break;
                    }
                }
            }
            population = population * number;
            return population;
        }       
    }
}
