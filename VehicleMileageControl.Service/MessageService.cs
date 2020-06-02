using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.MessageModel;

namespace VehicleMileageControl.Service
{
    public class MessageService
    {
        private readonly Guid _messageUserId;
        public MessageService(Guid messageUserId)
        {
            _messageUserId = messageUserId;
        }
        public bool CreateMessage(MessageCreate model)
        {
            var entity =
                new Message()
                {
                    MessageId = model.MessageId,
                    NewMessage = model.NewMessage
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Messages.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<MessageListItem> GetMessages()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Messages
                        .Where(e => e.MessageOwnerId == _messageUserId)
                        .Select(
                            e =>
                                new MessageListItem
                                {
                                    MessageId = e.MessageId,
                                }
                        );
                return query.ToArray();
            }
        }
        public MessageDetails GetMessageById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Messages
                        .Single(e => e.MessageId == id && e.MessageOwnerId == _messageUserId);
                return
                    new MessageDetails
                    {
                        MessageId = entity.MessageId,
                        MessageOne = entity.MessageOne,
                        MessageTwo = entity.MessageTwo,
                        MessageThree = entity.MessageThree,
                        MessageFour = entity.MessageFour,
                        MessageFive = entity.MessageFive,
                        MessageSix = entity.MessageSix,
                        MessageSeven = entity.MessageSeven,
                        MessageEight = entity.MessageEight,
                        MessageNine = entity.MessageNine,
                        MessageTen = entity.MessageTen,
                        MessageEleven = entity.MessageEleven,
                        MessageTwelve = entity.MessageTwelve,
                        MessageThirteen = entity.MessageThirteen,
                        MessageFourteen = entity.MessageFourteen,
                        MessageFifteen = entity.MessageFifteen,
                        MessageSixteen = entity.MessageSixteen,
                        MessageSeventeen = entity.MessageSeventeen,
                        MessageEighteen = entity.MessageEighteen,
                        MessageNineteen = entity.MessageNineteen,
                        MessageTwenty = entity.MessageTwenty,
                        MessageTwentyone = entity.MessageTwentyone,
                        MessageTwentytwo = entity.MessageTwentytwo,
                        MessageTwentythree = entity.MessageTwentythree,
                        MessageTwentyfour = entity.MessageTwentyfour,
                        MessageTwentyfive = entity.MessageTwentyfive,
                        MessageTwentysix = entity.MessageTwentysix,
                        MessageTwentyseven = entity.MessageTwentyseven
                    };
            }
        }
        public bool UpdateMessage(MessageEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Messages
                        .Single(e => e.MessageId == model.MessageId && e.MessageOwnerId == _messageUserId);

                entity.MessageId = model.MessageId;
                entity.NewMessage = model.NewMessage;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteMessage(int messageId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Messages
                        .Single(e => e.MessageId == messageId && e.MessageOwnerId == _messageUserId);

                ctx.Messages.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}