using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardDeviationValues
{
    class CalculateStdValues
    {
        private const double standard = .05;
        private const double pressure = .002;
        private readonly double _amountAverageIterator = standard;
        private readonly double _windSpeedAverageIterator = .15;
        private readonly double _pressureAverageIterator = pressure;
        private readonly double _airTempAverageIterator = standard;
        private readonly double _visibilityAverageIterator = standard;
        private readonly double _waterTempAverageIterator = standard;
        private readonly double _4hrAirChangeAverageIterator = standard;
        private readonly double _4hrWaterChangeAverageIterator = standard;
        private readonly double _4hrPressureChangeAverageIterator = pressure;
        private readonly double _8hrAirChangeAverageIterator = standard;
        private readonly double _8hrWaterChangeAverageIterator = standard;
        private readonly double _8hrPressureChangeAverageIterator = pressure;
        private readonly double _24hrAirChangeAverageIterator = standard;
        private readonly double _24hrWaterChangeAverageIterator = standard;
        private readonly double _24hrPressureChangeAverageIterator = pressure;

        public void CalcAll(List<Fish> current)
        {
            CalcFishAmountValue(current);
            CalcWindSpeedAmountValue(current);
            CalcPressureValue(current);
            CalcAirTempValue(current);
            CalcVisibilityValue(current);
            CalcWaterTempValue(current);
            Calc4hrChangeAirTempValue(current);
            Calc4hrWaterChangeTempValue(current);
            Calc4hrPressureChangeValue(current);
            Calc8hrChangeAirTempValue(current);
            Calc8hrWaterChangeTempValue(current);
            Calc8hrPressureChangeValue(current);
            Calc24hrChangeAirTempValue(current);
            Calc24hrWaterChangeTempValue(current);
            Calc24hrPressureChangeValue(current);
        }

        private void Calc24hrPressureChangeValue(List<Fish> current)
        {
            var twentyFourPressureChangeAvg = current.Average(x => double.Parse(x.Pressure24hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.Pressure24hr) - twentyFourPressureChangeAvg);
                var value = (int)(std / (twentyFourPressureChangeAvg * _24hrPressureChangeAverageIterator));
                fish.PressureValue24hr = value;
            }
        }

        private void Calc24hrWaterChangeTempValue(List<Fish> current)
        {
            var twentyFourHourWaterChangeAvg = current.Average(x => double.Parse(x.WaterTemp24hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.WaterTemp24hr) - twentyFourHourWaterChangeAvg);
                var value = (int)(std / (twentyFourHourWaterChangeAvg * _24hrWaterChangeAverageIterator));
                fish.WaterTempValue24hr = value;
            }
        }

        private void Calc24hrChangeAirTempValue(List<Fish> current)
        {
            var twentyFourHourAirChangeAvg = current.Average(x => double.Parse(x.AirTemp24hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.AirTemp24hr) - twentyFourHourAirChangeAvg);
                var value = (int)(std / (twentyFourHourAirChangeAvg * _24hrAirChangeAverageIterator));
                fish.AirTempValue24hr = value;
            }
        }

        private void Calc8hrPressureChangeValue(List<Fish> current)
        {
            var eightHourPressureChangeAvg = current.Average(x => double.Parse(x.Pressure8hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.Pressure8hr) - eightHourPressureChangeAvg);
                var value = (int)(std / (eightHourPressureChangeAvg * _8hrPressureChangeAverageIterator));
                fish.PressureValue8hr = value;
            }
        }

        private void Calc8hrWaterChangeTempValue(List<Fish> current)
        {
            var eightHourWaterChangeAvg = current.Average(x => double.Parse(x.WaterTemp8hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.WaterTemp8hr) - eightHourWaterChangeAvg);
                var value = (int)(std / (eightHourWaterChangeAvg * _8hrWaterChangeAverageIterator));
                fish.WaterTempValue8hr = value;
            }
        }

        private void Calc8hrChangeAirTempValue(List<Fish> current)
        {
            var eightHourAirAvg = current.Average(x => double.Parse(x.AirTemp8hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.AirTemp8hr) - eightHourAirAvg);
                var value = (int)(std / (eightHourAirAvg * _8hrAirChangeAverageIterator));
                fish.AirTempValue8hr = value;
            }
        }

        private void Calc4hrPressureChangeValue(List<Fish> current)
        {
            var fourHourPressureChangeAvg = current.Average(x => double.Parse(x.Pressure4hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.Pressure4hr) - fourHourPressureChangeAvg);
                var value = (int)(std / (fourHourPressureChangeAvg * _4hrPressureChangeAverageIterator));
                fish.PressureValue4hr = value;
            }
        }

        private void Calc4hrWaterChangeTempValue(List<Fish> current)
        {
            var fourHourWaterChangeAvg = current.Average(x => double.Parse(x.WaterTemp4hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.WaterTemp4hr) - fourHourWaterChangeAvg);
                var value = (int)(std / (fourHourWaterChangeAvg * _4hrWaterChangeAverageIterator));
                fish.WaterTempValue4hr = value;
            }
        }

        private void Calc4hrChangeAirTempValue(List<Fish> current)
        {
            var fourHourAirChangeAvg = current.Average(x => double.Parse(x.AirTemp4hr));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.AirTemp4hr) - fourHourAirChangeAvg);
                var value = (int)(std / (fourHourAirChangeAvg * _4hrAirChangeAverageIterator));
                fish.AirTempValue4hr = value;
            }
        }

        private void CalcWaterTempValue(List<Fish> current)
        {
            var waterTempAvg = current.Average(x => int.Parse(x.WaterTemp));

            foreach (var fish in current)
            {
                var std = (int.Parse(fish.WaterTemp) - waterTempAvg);
                var value = (int)(std / (waterTempAvg * _waterTempAverageIterator));
                fish.WaterTempValue = value;
            }
        }

        private void CalcVisibilityValue(List<Fish> current)
        {
            var visibilityAvg = current.Average(x => double.Parse(x.Visibility));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.Visibility) - visibilityAvg);
                var value = (int)(std / (visibilityAvg * _visibilityAverageIterator));
                fish.VisibilityValue = value;
            }
        }

        private void CalcAirTempValue(List<Fish> current)
        {
            var airTempAvg = current.Average(x => int.Parse(x.AirTemp));

            foreach (var fish in current)
            {
                var std = (int.Parse(fish.AirTemp) - airTempAvg);
                var value = (int)(std / (airTempAvg * _airTempAverageIterator));
                fish.AirTempValue = value;
            }
        }

        private void CalcPressureValue(List<Fish> current)
        {
            var pressureAvg = current.Average(x => double.Parse(x.WaterPressure));

            foreach (var fish in current)
            {
                var std = (double.Parse(fish.WaterPressure) - pressureAvg);
                var value = (int)(std / (pressureAvg * _pressureAverageIterator));
                fish.PressureValue = value;
            }
        }

        private void CalcWindSpeedAmountValue(List<Fish> current)
        {
            var windAvg = current.Average(x => int.Parse(x.WindSpeed));

            foreach (var fish in current)
            {
                var std = (int.Parse(fish.WindSpeed) - windAvg);
                var value = (int)(std / (windAvg * _windSpeedAverageIterator));
                fish.WindSpeedValue = value;
            }
        }

        private void CalcFishAmountValue(List<Fish> current)
        {
            var amountAvg = current.Average(x => x.FishAmount);

            foreach (var fish in current)
            {
                var std = (fish.FishAmount - amountAvg);
                var value = (int)(std / (amountAvg * _amountAverageIterator));
                fish.FishAmountValue = value;
            }
        }
    }
}
