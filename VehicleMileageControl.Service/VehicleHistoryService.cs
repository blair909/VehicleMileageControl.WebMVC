using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.VehicleHistoryModel;

namespace VehicleMileageControl.Service
{
    public class VehicleHistoryService
    {
        private readonly Guid _vehicleHistoryUserId;
        public VehicleHistoryService(Guid vehicleHistoryUserId)
        {
            _vehicleHistoryUserId = vehicleHistoryUserId;
        }
        public bool CreateVehicleHistory(VehicleHistoryCreate model)
        {
            var entity =
                new VehicleHistory()
                {
                    VehicleHistoryId = model.VehicleHistoryId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    FullName = model.FullName,
                    VehicleMake = model.VehicleMake,
                    VehicleModel = model.VehicleModel,
                    VehicleYear = model.VehicleYear,
                    LicenseNo = model.LicenseNo,
                    VinNo = model.VinNo,
                    ServiceDate = model.ServiceDate,
                    OdometerMileage = model.OdometerMileage,
                    ServiceOne = model.ServiceOne,
                    ServiceTwo = model.ServiceTwo,
                    ServiceThree = model.ServiceThree,
                    ServiceFour = model.ServiceFour,
                    ServiceFive = model.ServiceFive,
                    ServiceOneCost = model.ServiceOneCost,
                    ServiceTwoCost = model.ServiceTwoCost,
                    ServiceThreeCost = model.ServiceThreeCost,
                    ServiceFourCost = model.ServiceFourCost,
                    ServiceFiveCost = model.ServiceFiveCost
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.VehicleHistorys.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<VehicleHistoryListItem> GetVehicleHistorys()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .VehicleHistorys
                        .Where(e => e.VehicleHistoryOwnerId == _vehicleHistoryUserId)
                        .Select(
                            e =>
                                new VehicleHistoryListItem
                                {
                                    VehicleHistoryId = e.VehicleHistoryId,
                                    LastName = e.LastName,
                                    VehicleMake = e.VehicleMake,
                                    VehicleYear = e.VehicleYear,
                                    ServiceDate = e.ServiceDate,
                                    OdometerMileage = e.OdometerMileage
                                }
                        );
                return query.ToArray();
            }
        }
        public VehicleHistoryDetails GetVehicleHistoryById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleHistorys
                        .Single(e => e.VehicleHistoryId == id && e.VehicleHistoryOwnerId == _vehicleHistoryUserId);
                return
                    new VehicleHistoryDetails
                    {
                        VehicleHistoryId = entity.VehicleHistoryId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        FullName = entity.FullName,
                        VehicleMake = entity.VehicleMake,
                        VehicleModel = entity.VehicleModel,
                        VehicleYear = entity.VehicleYear,
                        LicenseNo = entity.LicenseNo,
                        VinNo = entity.VinNo,
                        ServiceDate = entity.ServiceDate,
                        OdometerMileage = entity.OdometerMileage,
                        ServiceOne = entity.ServiceOne,
                        ServiceTwo = entity.ServiceTwo,
                        ServiceThree = entity.ServiceThree,
                        ServiceFour = entity.ServiceFour,
                        ServiceFive = entity.ServiceFive,
                        ServiceOneCost = entity.ServiceOneCost,
                        ServiceTwoCost = entity.ServiceTwoCost,
                        ServiceThreeCost = entity.ServiceThreeCost,
                        ServiceFourCost = entity.ServiceFourCost,
                        ServiceFiveCost = entity.ServiceFiveCost
                    };
            }
        }
        public bool UpdateVehicleHistory(VehicleHistoryEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleHistorys
                        .Single(e => e.VehicleHistoryId == model.VehicleHistoryId && e.VehicleHistoryOwnerId == _vehicleHistoryUserId);

                entity.VehicleHistoryId = model.VehicleHistoryId;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.FullName = model.FullName;
                entity.VehicleMake = model.VehicleMake;
                entity.VehicleModel = model.VehicleModel;
                entity.VehicleYear = model.VehicleYear;
                entity.LicenseNo = model.LicenseNo;
                entity.VinNo = model.VinNo;
                entity.ServiceDate = model.ServiceDate;
                entity.OdometerMileage = model.OdometerMileage;
                entity.ServiceOne = model.ServiceOne;
                entity.ServiceTwo = model.ServiceTwo;
                entity.ServiceThree = model.ServiceThree;
                entity.ServiceFour = model.ServiceFour;
                entity.ServiceFive = model.ServiceFive;
                entity.ServiceOneCost = model.ServiceOneCost;
                entity.ServiceTwoCost = model.ServiceTwoCost;
                entity.ServiceThreeCost = model.ServiceThreeCost;
                entity.ServiceFourCost = model.ServiceFourCost;
                entity.ServiceFiveCost = model.ServiceFiveCost;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteVehicleHistory(int vehicleHistoryId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .VehicleHistorys
                        .Single(e => e.VehicleHistoryId == vehicleHistoryId && e.VehicleHistoryOwnerId == _vehicleHistoryUserId);

                ctx.VehicleHistorys.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
