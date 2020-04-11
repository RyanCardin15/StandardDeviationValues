using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardDeviationValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var SetupFish = new PopulateFish();
            var CalcValues = new CalculateStdValues();
            var AllFish = SetupFish.AllFish();
            CalcValues.CalcAll(AllFish);
            Display(AllFish);
        }

        private static void Display(List<Fish> allFish)
        {
            var data = from f in allFish
                       orderby f.FishAmountValue
                       group f by f.FishAmountValue into num
                       select num;

            foreach (var item in data)
            {
                Console.WriteLine(item.Key);
                foreach (var e in item)
                {
                    Console.WriteLine($"{nameof(e.FishAmount)} : {e.FishAmount}");
                    Console.WriteLine($"{nameof(e.WindSpeed)} : {e.WindSpeed} : {e.WindSpeedValue}");
                    Console.WriteLine($"{nameof(e.WaterPressure)} : {e.WaterPressure} : {e.PressureValue}");
                }
                    Console.WriteLine($"Average Water Pressure : {item.Average(x => double.Parse(x.WaterPressure))}");
            }
        }
    }
}
