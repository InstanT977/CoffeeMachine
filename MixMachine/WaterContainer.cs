using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MixMachine
{
    public class WaterContainer
    {
        private const int Volume=1000;
        private const int MaxTemperature = 102;
        private const int MinTemperature = 96;
        

        public double mLiter = Volume;

        public double Temperature = 100;
        private readonly Timer _coolingTimer = new Timer();
        private readonly Timer _heatingTimer = new Timer();

        public bool IsHeating;
        public WaterContainer()
        {
            InitializeHeatingTimer();
            InitializeCoolingTimer();
        }

        public bool CheckWaterContains(double mLiters)
        {
            return mLiter >= mLiters;
        }

        public bool CheckTemperature()
        {
            if (Temperature <= MinTemperature)
            {
                StartHeating();
            }

            if (Temperature >= (MaxTemperature - 2))
            {
                StopHeating();
            }
            if ((Temperature <= (MaxTemperature - 2)) || (Temperature >= MinTemperature))
            {
                return true;
            }
            return false;
        }

        public double Get(double mLiters)
        {
            mLiter -= mLiters;
            if (mLiter <= 0)
            {
                mLiter += mLiters;
                return -1;
            }
            return mLiters;
        }
        public void StartHeating()
        {
            IsHeating = true;
            _heatingTimer.Start();
        }

        public void StopHeating()
        {
            IsHeating = false;
            _heatingTimer.Stop();
        }

        private void InitializeHeatingTimer()
        {
            _heatingTimer.Elapsed += HeatingWater;
            _heatingTimer.Interval = 1000; // 1 seconds
        }

        private void InitializeCoolingTimer()
        {
            _coolingTimer.Elapsed += CoolingWater;
            _coolingTimer.Interval = 60000; // 60 seconds
            _coolingTimer.Start();
        }

        private void HeatingWater(object sender, ElapsedEventArgs e)
        {
            if (Temperature <= MaxTemperature)
            {
                Temperature += 0.2;
            }
        }

        private void CoolingWater(object sender, ElapsedEventArgs e)
        {
            Temperature--;
        }
    }
}
