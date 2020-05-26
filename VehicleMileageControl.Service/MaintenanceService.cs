using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;

namespace VehicleMileageControl.Service
{
    public class MaintenanceService
    {
        private readonly Guid _maintenanceUserId;
        public MaintenanceService(Guid maintenanceUserId)
        {
            _maintenanceUserId = maintenanceUserId;
        }
        private readonly Maintenance _maintenanceDirectory = new Maintenance();
        public bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
        public int FindDifference(int a, int b)
        {
            return Math.Abs(a - b);
        }
        public int Message(Maintenance maintenanceMessage)
        {
            if (FindDifference(3000,(_maintenanceDirectory.OdomoterMileage))
        }
    }
}
