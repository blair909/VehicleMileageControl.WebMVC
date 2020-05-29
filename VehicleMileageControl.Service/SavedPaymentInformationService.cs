using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model;

namespace VehicleMileageControl.Service
{
    public class SavedPaymentInformationService
    {
        //change paymentId to user
        private readonly Guid _userId;
        public SavedPaymentInformationService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePayment(SavedPaymentInformationCreate model)
        {
            var entity =
                new SavedPaymentInformation()
                {
                    SavedPaymentInformationId = model.SavedPaymentInformationId,
                    OwnerId = _userId,
                    CardNumber = model.CardNumber,
                    FullName = model.FullName,
                    ExpirationDate = model.ExpirationDate,
                    CVV = model.CVV
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.SavedPaymentInformations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<SavedPaymentInformationListItem> GetPayment()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SavedPaymentInformations
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new SavedPaymentInformationListItem
                        {
                            SavedPaymentInformationId = e.SavedPaymentInformationId,
                            CardNumber = e.CardNumber,
                            FullName = e.FullName
                        }
                        );
                return query.ToArray();
            }
        }
        public SavedPaymentInformationDetails GetSavedPaymentInformationById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .SavedPaymentInformations
                        .Single(e => e.SavedPaymentInformationId == id && e.OwnerId == _userId);
                return
                    new SavedPaymentInformationDetails
                    {
                        SavedPaymentInformationId = entity.SavedPaymentInformationId,
                        CardNumber = entity.CardNumber,
                        FullName = entity.FullName,
                        ExpirationDate = entity.ExpirationDate,
                        CVV = entity.CVV
                    };
            }
        }

        public bool UpdatePaymentInformation(SavedPaymentInformationEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.SavedPaymentInformations.Single(e => e.SavedPaymentInformationId == model.SavedPaymentInformationId && e.OwnerId == _userId);
                entity.CardNumber = model.CardNumber;
                entity.FullName = model.FullName;
                entity.ExpirationDate = model.ExpirationDate;
                entity.CVV = model.CVV;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePaymentInformation(int payId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.SavedPaymentInformations.Single(e => e.SavedPaymentInformationId == payId && e.OwnerId == _userId);
                ctx.SavedPaymentInformations.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
