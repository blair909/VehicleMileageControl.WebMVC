using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model;

namespace VehicleMileageControl.Service
{
    public class MaintenanceService
    {
        private readonly Maintenance _maintenanceDirectory = new Maintenance();
        private readonly Message _messageDirectory = new Message();
        private readonly Guid _maintenanceUserId;
        public MaintenanceService(Guid maintenanceUserId)
        {
            _maintenanceUserId = maintenanceUserId;
        }
        public bool CreateMaintenance(MaintenanceCreate model)
        {
            var entity =
                new Maintenance()
                {
                    MaintenanceOwnerId = _maintenanceUserId,
                    OdomoterMileage = model.OdomoterMileage,
                    MaintenanceId = model.MaintenanceId,
                    PersonalNoteTitle = model.PersonalNoteTitle,
                    PersonalNoteContent = model.PersonalNoteContent,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Maintenances.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<MaintenanceListItem> GetMaintenances()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Maintenances
                        .Where(e => e.MaintenanceOwnerId == _maintenanceUserId)
                        .Select(
                            e =>
                                new MaintenanceListItem
                                {
                                    MaintenanceId = e.MaintenanceId,
                                    OdomoterMileage = e.OdomoterMileage,
                                    PersonalNoteTitle = e.PersonalNoteTitle
                                }
                        );
                return query.ToArray();
            }
        }
        public MaintenanceDetails GetMaintenanceById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Maintenances
                        .Single(e => e.MaintenanceId == id && e.MaintenanceOwnerId == _maintenanceUserId);
                return
                    new MaintenanceDetails
                    {
                        MaintenanceId = entity.MaintenanceId,
                        OdomoterMileage = entity.OdomoterMileage,
                        PersonalNoteTitle = entity.PersonalNoteTitle,
                        PersonalNoteContent = entity.PersonalNoteContent,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateMaintenance(MaintenanceEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Maintenances
                        .Single(e => e.MaintenanceId == model.MaintenanceId && e.MaintenanceOwnerId == _maintenanceUserId);

                entity.MaintenanceId = model.MaintenanceId;
                entity.OdomoterMileage = model.OdomoterMileage;
                entity.PersonalNoteTitle = model.PersonalNoteTitle;
                entity.PersonalNoteContent = model.PersonalNoteContent;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteMaintenance(int MaintenanceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Maintenances
                        .Single(e => e.MaintenanceId == MaintenanceId && e.MaintenanceOwnerId == _maintenanceUserId);

                ctx.Maintenances.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        public string RegularOilAndFilter(int oldMileage, int newMileage)
        {
            oldMileage = _maintenanceDirectory.OdomoterMileage;
            newMileage = _maintenanceDirectory.OdomoterMileage;
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);

            if (mileageDifference >= 3000)
            {
                return message.MessageOne;
            }
            else if (mileageDifference < 3000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string TireRotate(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 6000)
            {
                return message.MessageTwo;
            }
            else if (mileageDifference < 6000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string SyntheticOilAndFilter(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 7000)
            {
                return message.MessageThree;
            }
            else if (mileageDifference < 7000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string TireAlignment(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 9000)
            {
                return message.MessageFour;
            }
            else if (mileageDifference < 9000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string CompleteInspection(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 15000)
            {
                return message.MessageFive;
            }
            else if (mileageDifference < 15000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string EngineAirFilter(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 20000)
            {
                return message.MessageSix;
            }
            else if (mileageDifference < 20000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string CabinAirFilter(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 20000)
            {
                return message.MessageSeven;
            }
            else if (mileageDifference < 20000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string CopperSparkPlugs(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 20000)
            {
                return message.MessageEight;
            }
            else if (mileageDifference < 20000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string FuelFilter(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 30000)
            {
                return message.MessageNine;
            }
            else if (mileageDifference < 30000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string BrakeFluid(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 35000)
            {
                return message.MessageTen;
            }
            else if (mileageDifference < 35000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string TransmissionFluidPanGasketAndFilter(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 40000)
            {
                return message.MessageEleven;
            }
            else if (mileageDifference < 40000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string BrakePads(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 45000)
            {
                return message.MessageTwelve;
            }
            else if (mileageDifference < 45000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string Battery(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 50000)
            {
                return message.MessageThirteen;
            }
            else if (mileageDifference < 50000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string EngineCoolant(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 55000)
            {
                return message.MessageFourteen;
            }
            else if (mileageDifference < 55000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string HVAC(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 60000)
            {
                return message.MessageFifteen;
            }
            else if (mileageDifference < 60000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string SuspensionComponents(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 60000)
            {
                return message.MessageSixteen;
            }
            else if (mileageDifference < 60000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string BrakeRotors(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 60000)
            {
                return message.MessageSeventeen;
            }
            else if (mileageDifference < 60000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string RadiatorHose(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 60000)
            {
                return message.MessageEighteen;
            }
            else if (mileageDifference < 60000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string TimingBelt(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 70000)
            {
                return message.MessageNineteen;
            }
            else if (mileageDifference < 70000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string PowerSteeringFluid(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 70000)
            {
                return message.MessageTwenty;
            }
            else if (mileageDifference < 70000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string PlatinumOrIridiumSparkPlugs(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 80000)
            {
                return message.MessageTwentyone;
            }
            else if (mileageDifference < 80000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string RubberCracks(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 100000)
            {
                return message.MessageTwentytwo;
            }
            else if (mileageDifference < 100000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
        public string Tires(int oldMileage, int newMileage)
        {
            Message message = new Message();
            int mileageDifference = (newMileage - oldMileage);
            if (mileageDifference >= 55000)
            {
                return message.MessageTwentysix;
            }
            else if (mileageDifference < 55000)
            {
                return null;
            }
            else
            {
                return message.MessageTwentyfive;
            }
        }
    }


    //public bool BetweenRanges(int a, int b, int number)
    //{
    //    return (a + 3000 <= number && number <= b + 3000);
    //}

    //* IEnumerable<string> strings =
    //Enumerable.Repeat("I like programming.", x % 3000);

    //foreach (String str in strings)
    //{
    //Console.WriteLine(str);
    //}

    //public decimal FindDifference(decimal nr1, decimal nr2)
    //{
    //return Math.Abs(nr1 - nr2);
    //}
}