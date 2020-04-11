using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviationValues
{
    class PopulateFish
    {
        readonly ReturnData ReturnData = new ReturnData();
        readonly List<Fish> AllElements = new List<Fish>();

        public PopulateFish()
        {
            var list = ReturnData.Init();
            Setup(list);
        }

        public List<Fish> AllFish()
        {
            return AllElements;
        }

        public void Setup(List<string> list)
        {
            foreach (var item in list)
            {
                var temp = item.Split(',');
                var thisFish = new Fish();
                Startup(temp, thisFish);
                AllElements.Add(thisFish);
            }
        }

        private void Startup(string[] temp, Fish current)
        {
            current.FishName = temp[0];
            current.FishSize = temp[1];
            current.FishAmount = int.Parse(temp[2]);
            current.FishLocation = temp[3];
            current.WindSpeed = temp[4];
            current.WaterPressure = temp[5];
            current.Month = temp[6];
            current.Moon = temp[7];
            current.Medium = temp[8];
            current.WindDirection = temp[9];
            current.AirTemp = temp[10];
            current.Time = temp[11];
            current.Visibility = temp[12];
            current.WaterTemp = temp[13];
            current.Clarity = temp[14];
            current.Humidity = temp[15];
            current.AirTemp4hr = temp[16];
            current.WaterTemp4hr = temp[17];
            current.Pressure4hr = temp[18];
            current.AirTemp8hr = temp[19];
            current.WaterTemp8hr = temp[20];
            current.Pressure8hr = temp[21];
            current.AirTemp24hr = temp[22];
            current.WaterTemp24hr = temp[23];
            current.Pressure24hr = temp[24];
        }
    }
}

