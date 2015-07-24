using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class PumpManagementInitializer:DropCreateDatabaseAlways<PumpManagementContext>
    {
        protected override void Seed(PumpManagementContext context)
        {
            var pumpers = new List<Pumper>()
            {
                new Pumper()
                {
                    Id = 1,
                    Name = "Rene",
                    LastName = "Lopez",
                    NickName = "Renex",
                    Email = "rene.cano@hotmail.com",
                    Phone = "36052916",
                    BirthDate = Convert.ToDateTime("24/04/1988"),
                    CaloriesBurned = 20,
                    DebutDate = Convert.ToDateTime("12/12/2006"),
                    PhotoUrl = "http://www.gravatar.com/avatar/0cf15665a9146ba852bf042b0652780a?s=200",
                    Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            AddressId = 1,
                            City = "Guadalajara",
                            Colony = "Jardines de San Francisco",
                            ExternalNumber = 23123,
                            InternalNumber = 982,
                            Name = "Pablo Valdez",
                            PostalCode = 44760,
                            State = "Jalisco",
                        }
                    },
                    Locals = new List<Local>()
                    {
                        new Local()
                        {
                            LocalId = 1,
                            Name="Rockoparty"
                        }
                    }
                }
            };
        }
    }
}
