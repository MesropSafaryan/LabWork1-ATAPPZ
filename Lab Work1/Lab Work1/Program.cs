using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_Work1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;//змінюємо кодування консолі
            Console.InputEncoding = Encoding.Unicode;
            int time = 0;
            string livingConditions = "normal";
            int spirillaNumber = 0, rodNumber = 0, cocciNumber = 0;
            Spirilla spirilla = new Spirilla();
            Rod_ShapedBacteria rod = new Rod_ShapedBacteria();
            CocciBacteria cocci = new CocciBacteria();
            for (int i = 0; i < 1; )
            {
                Console.Clear();
                Console.WriteLine("Коротко про розмноження бактерій: розмноження у бактерій проходить шляхом прямого бінарного ділення." +
                "\nУ різних типів бактерій різний час за який проходить ділення (розмноження). " +
                "\nУ програмі усі показники розмноження і тривалості життя приблизні;\n");
                Console.WriteLine("Виберіть операцію:\n1. Створити популяцію бактерій;\n2. Переглянути дані про види бактерій; " +
                    "\n3. Вийти;");
                string ch1 = Console.ReadLine();
                if (ch1 == "1")
                {
                    for (int j = 0; j < 1;)
                    {
                        Console.WriteLine("Оберіть параметр який хочете задати: \n1. Вказати тривалість експерименту;" +
                        "\n2. Вказати рівень умов для проживання бактерій; \n3. Задати кількість спірил; " +
                        "\n4. Задати кількість палочковидних бактерій; \n5. Задати кількість бактерій-коків" +
                        "\n6. Обчислити резльтат; \n7. Вихід");
                        string ch2 = Console.ReadLine();
                        if (ch2 == "1")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("\nВведіть бажаний час тривалості спостереження");
                                    time = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                                }
                            }
                        }
                        else if (ch2 == "2")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("\nВведіть бажані умови проживання бактерій (ideal, good, normal or bad)");
                                    livingConditions = Console.ReadLine();
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                                }
                            }
                        }
                        else if (ch2 == "3")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("\nВведіть кількість спірил");
                                    spirillaNumber = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                                }
                            }
                        }
                        else if (ch2 == "4")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("\nВведіть кількість палочковидних бактерій");
                                    rodNumber = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                                }
                            }
                        }
                        else if (ch2 == "5")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("\nВведіть кількість бактерій-коків");
                                    cocciNumber = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                                }
                            }
                        }
                        else if (ch2 == "6")
                        {
                            PopulationCalculation psp = new PopulationCalculation(spirilla, spirillaNumber, time, livingConditions);
                            PopulationCalculation pr = new PopulationCalculation(rod, rodNumber, time, livingConditions);
                            PopulationCalculation pco = new PopulationCalculation(cocci, cocciNumber, time, livingConditions);
                            Console.WriteLine("Результат експерименту: \nСпірили:");
                            Console.WriteLine(psp.Population);
                            Console.WriteLine("Палочковидні: ");
                            Console.WriteLine(pr.Population);
                            Console.WriteLine("Бактерії-коки: ");
                            Console.WriteLine(pco.Population);
                            Console.WriteLine("Загалом: ");
                            Console.WriteLine((psp.Population + pr.Population + pco.Population));
                            Console.ReadLine();
                        }
                        else if (ch2 == "7")
                        {
                            j++;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                        }
                    }
                }
                else if (ch1 == "2")
                {
                    Console.WriteLine("Тривалість життя спірил: 75 хв \nЧас необхідний для розмноження: 25 хв\n\n" +
                        "Тривалість життя палочковидних бактерій: 135 хв \nЧас необхідний для розмноження: 20 хв\n\n" +
                        "Тривалість життя бактерій-коків: 120 хв \nЧас необхідний для розмноження: 15 хв\n\n" +
                        "Натисніть будь-яку клавішу для продовження...");
                    Console.ReadKey();
                }
                else if (ch1 == "3")
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Неправильній ввід! Спробуйте ще раз");
                }
            }
        }
    }
}
