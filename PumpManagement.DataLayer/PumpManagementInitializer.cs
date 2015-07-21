using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericServices;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class PumpManagementInitializer:DropCreateDatabaseAlways<PumpManagementContext>
    {
        protected override void Seed(PumpManagementContext context)
        {
            var songs=new List<Song>()
            {
                new Song() {Author = "Rene",BPM = 223,Genre = "M",Name = "Que de raro tiene",SongId = 1},
                new Song() {Author = "Rene1",BPM = 223,Genre = "M",Name = "Que de raro tiene",SongId = 1},
                new Song() {Author = "Rene2",BPM = 223,Genre = "M",Name = "Que de raro tiene",SongId = 1},
                new Song() {Author = "Rene3",BPM = 223,Genre = "M",Name = "Que de raro tiene",SongId = 1},
                new Song() {Author = "Rene4",BPM = 223,Genre = "M",Name = "Que de raro tiene",SongId = 1}
            };

            context.Songs.AddRange(songs);
            var status=context.SaveChangesWithCheckingAsync();
        }
    }
}
