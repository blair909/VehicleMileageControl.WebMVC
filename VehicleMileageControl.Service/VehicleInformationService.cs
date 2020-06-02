using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleInformation;

namespace VehicleMileageControl.Service
{
    public class VehicleInformationService
    {
        private readonly Guid _vehicleInformationUserId;
        public VehicleInformationService(Guid vehicleInformationUserId)
        {
            _vehicleInformationUserId = vehicleInformationUserId;
        }
        public IEnumerable<VehicleInformationListItem> GetVehicleInformations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .VehicleInformations
                        .Where(e => e.VehicleInformationOwnerId == _vehicleInformationUserId)
                        .Select(
                            e =>
                                new VehicleInformationListItem
                                {
                                    VehicleInformationId = e.VehicleInformationId
                                }
                        );
                return query.ToArray();
            }
        }
        public VehicleInformationDetails GetVehicleInformationById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleInformations
                        .Single(e => e.VehicleInformationId == id && e.VehicleInformationOwnerId == _vehicleInformationUserId);
                return
                    new VehicleInformationDetails
                    {
                        VehicleInformationId = entity.VehicleInformationId,
                        OilAndFilterChange = entity.OilAndFilterChange,
                        TireRotation = entity.TireRotation,
                        TireAlignment = entity.TireAlignment,
                        EngineAirFilterChange = entity.EngineAirFilterChange,
                        CabinAirFilterChange = entity.CabinAirFilterChange,
                        FuelFilterChange = entity.FuelFilterChange,
                        BrakeFluidChange = entity.BrakeFluidChange,
                        TransmissionFluidAndFilterChange = entity.TransmissionFluidAndFilterChange,
                        TransmissionSystemsInspection = entity.TransmissionSystemsInspection,
                        BrakePadChange = entity.BrakePadChange,
                        BatteryChange = entity.BatteryChange,
                        EngineCoolingSystemInspection = entity.EngineCoolingSystemInspection,
                        EngineCoolantChange = entity.EngineCoolantChange,
                        StrutCheck = entity.StrutCheck,
                        SteeringRackCheck = entity.SteeringRackCheck,
                        BrakeRotorChange = entity.BrakeRotorChange,
                        RadiatorHoseChange = entity.RadiatorHoseChange,
                        TimingBeltChange = entity.TimingBeltChange,
                        FuelTankPressureSensorCheck = entity.FuelTankPressureSensorCheck,
                        FuelSystemsInspection = entity.FuelSystemsInspection,
                        PowerSteeringPumpInspection = entity.PowerSteeringPumpInspection,
                        SparkPlugChange = entity.SparkPlugChange,
                        DriveTrainInspection = entity.DriveTrainInspection,
                        AlternatorChange = entity.AlternatorChange,
                        CatalyticConverterCheck = entity.CatalyticConverterCheck
                    };
            }
        }
    }
}