using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleInformation;
using VehicleMileageControl.Model.VehicleInformationModel;

namespace VehicleMileageControl.Service
{
    public class VehicleInformationService
    {
        private readonly Guid _vehicleInformationUserId;
        public VehicleInformationService(Guid vehicleInformationUserId)
        {
            _vehicleInformationUserId = vehicleInformationUserId;
        }
        public bool CreateVehicleInformation(VehicleInformationCreate model)
        {
            var entity =
                new VehicleInformation()
                {
                    VehicleInformationId = model.VehicleInformationId,
                    NewVehicleInformation = model.NewVehicleInformation
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.VehicleInformations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
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
        public bool UpdateVehicleInformation(VehicleInformationEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleInformations
                        .Single(e => e.VehicleInformationId == model.VehicleInformationId && e.VehicleInformationOwnerId == _vehicleInformationUserId);

                entity.VehicleInformationId = model.VehicleInformationId;
                entity.NewVehicleInformation = model.NewVehicleInformation;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteVehicleInformation(int vehicleInformationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleInformations
                        .Single(e => e.VehicleInformationId == vehicleInformationId && e.VehicleInformationOwnerId == _vehicleInformationUserId);

                ctx.VehicleInformations.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}