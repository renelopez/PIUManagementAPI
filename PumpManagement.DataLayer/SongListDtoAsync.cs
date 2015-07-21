using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericServices.Core;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class SongListDtoAsync : EfGenericDtoAsync<Song, SongListDtoAsync>
    {



        protected override CrudFunctions SupportedFunctions {get{return CrudFunctions.AllCrud;}}
    }
}