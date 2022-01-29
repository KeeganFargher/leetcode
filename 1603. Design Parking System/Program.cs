using System;

namespace _1603._Design_Parking_System
{
    public class ParkingSystem
    {
        private readonly int[] _parking;

        public ParkingSystem(int big, int medium, int small)
        {
            _parking = new[] { big, medium, small };
        }

        public bool AddCar(int carType)
        {
            if (_parking[carType - 1] <= 0)
            {
                return false;
            }

            _parking[carType - 1]--;
            return true;
        }
    }
}
