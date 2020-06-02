using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMileageControl.Data;
using VehicleMileageControl.Model.NoteModel;

namespace VehicleMileageControl.Service
{
    public class NoteService
    {
        private readonly Guid _noteUserId;
        public NoteService(Guid noteUserId)
        {
            _noteUserId = noteUserId;
        }
        public bool CreateNote(NoteCreate model)
        {
            var entity =
                new Note()
                {
                    NoteOwnerId = _noteUserId,
                    NoteId = model.NoteId,
                    NoteTitle = model.NoteTitle,
                    NoteContent = model.NoteContent
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Notes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<NoteListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Notes
                        .Where(e => e.NoteOwnerId == _noteUserId)
                        .Select(
                            e =>
                                new NoteListItem
                                {
                                    NoteId = e.NoteId,
                                    NoteTitle = e.NoteTitle
                                }
                        );
                return query.ToArray();
            }
        }
        public NoteDetails GetNoteById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Notes
                        .Single(e => e.NoteId == id && e.NoteOwnerId == _noteUserId);
                return
                    new NoteDetails
                    {
                        NoteId = entity.NoteId,
                        NoteTitle = entity.NoteTitle,
                        NoteContent = entity.NoteContent
                    };
            }
        }
        public bool UpdateNotes(NoteEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Notes
                        .Single(e => e.NoteId == model.NoteId && e.NoteOwnerId == _noteUserId);

                entity.NoteId = model.NoteId;
                entity.NoteTitle = model.NoteTitle;
                entity.NoteContent = model.NoteContent;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteNote(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Notes
                        .Single(e => e.NoteId == noteId && e.NoteOwnerId == _noteUserId);

                ctx.Notes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
