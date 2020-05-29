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

        // int mileageDifference = (newMileage - oldMileage);

        // When this method returns MessageOne, stop it and start it again.
        // Is mileageDifference counting from initial odomoter mileage, when the differene between any given odomoter mileage is 3000 or greater for any given other, or counting at all?
        // Once method returns MessageOne, does it automatically stop and start again or will the message appear for every odomoter entry in the future?
        public string MessagePopulateForMileage(int mileage)
        {
            Message message = new Message();
            // Regular Oil and Filter
            for (int x = 1; x < 330; x++)
            {
                int z = (3000 * x) + 500;
                int y = (3000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageOne;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Tire Rotation
            for (int x = 1; x < 165; x++)
            {
                int z = (6000 * x) + 750;
                int y = (6000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTwo;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Synthetic Oil and Filter
            for (int x = 1; x < 140; x++)
            {
                int z = (7000 * x) + 1000;
                int y = (7000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageThree;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Tire Alignment
            for (int x = 1; x < 110; x++)
            {
                int z = (9000 * x) + 1000;
                int y = (9000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageFour;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Complete Vehicle Inspection
            for (int x = 1; x < 65; x++)
            {
                int z = (15000 * x) + 1000;
                int y = (15000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageFive;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Engine Air Filter, Cabin Air Filter, and Copper Spark Plugs
            for (int x = 1; x < 45; x++)
            {
                int z = (20000 * x) + 1000;
                int y = (20000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageSix + message.MessageSeven + message.MessageEight;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Fuel Filter
            for (int x = 1; x < 32; x++)
            {
                int z = (30000 * x) + 1000;
                int y = (30000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageNine;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Brake Fluid
            for (int x = 1; x < 28; x++)
            {
                int z = (35000 * x) + 1000;
                int y = (35000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTen;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Transmission Fluid, Pan Gasket, Filter, and Front Tires (FWD) or Rear Tires (RWD)
            for (int x = 1; x < 24; x++)
            {
                int z = (40000 * x) + 1000;
                int y = (40000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageEleven + message.MessageTwentythree;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Brake Pads
            for (int x = 1; x < 22; x++)
            {
                int z = (45000 * x) + 1000;
                int y = (45000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTwelve;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Battery and Tires (AWD)
            for (int x = 1; x < 19; x++)
            {
                int z = (50000 * x) + 1000;
                int y = (50000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageThirteen + message.MessageTwentyseven;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Engine Coolant
            for (int x = 1; x < 18; x++)
            {
                int z = (55000 * x) + 1000;
                int y = (55000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageFourteen;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // HVAC, Suspension Components, Brake Rotors, Radiator Hoses, and Front Tires (RWD) or Rear Tires (FWD)
            for (int x = 1; x < 16; x++)
            {
                int z = (60000 * x) + 1000;
                int y = (60000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageFifteen + message.MessageSixteen + message.MessageSeventeen + message.MessageEighteen + message.MessageTwentyfour;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Timing Belt and Power Steering Fluid
            for (int x = 1; x < 14; x++)
            {
                int z = (70000 * x) + 1000;
                int y = (70000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageNineteen + message.MessageTwenty;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Platinum or Iridium Spark Plugs
            for (int x = 1; x < 12; x++)
            {
                int z = (80000 * x) + 1000;
                int y = (80000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTwentyone;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Rubber Cracks
            for (int x = 1; x < 10; x++)
            {
                int z = (100000 * x) + 1000;
                int y = (100000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTwentytwo;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
            // Alternator
            for (int x = 1; x < 8; x++)
            {
                int z = (125000 * x) + 1000;
                int y = (125000 * x);
                if (y <= mileage && mileage <= z)
                {
                    return message.MessageTwentysix;
                }
                else if (y > mileage && mileage > z)
                {
                    return null;
                }
                else
                {
                    return message.MessageTwentyfive;
                }
            }
        }
    }
}
//public string RegularOilAndFilter(int id, int newMileage)
//{
//    var maintenance = GetMaintenanceById(id);
//    int mileageDifference = (newMileage - maintenance.OdomoterMileage);

//    Message message = new Message();

//    if (mileageDifference >= 3000)
//    {
//        return message.MessageOne;
//    }
//    else if (mileageDifference < 3000)
//    {
//        return null;
//    }
//    else
//    {
//        return message.MessageTwentyfive;
//    }
//}

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