﻿using Assignment18Day15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18Day15
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        private bool isConnected;
        private int batteryLevel;
        private string displayInfo;

        public Smartphone()
        {

            isConnected = false;
            batteryLevel = 0;
            displayInfo = "Smartphone display information...It's working well";
        }

        public bool Connect()
        {
            isConnected = true;
            return isConnected;
        }
        public void Charge(int minutes)
        {
            batteryLevel += minutes;
        }

        public string Display()
        {
            return displayInfo;
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }
        }
    }
}