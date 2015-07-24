using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using PumpManagement.DataLayer;
using PumpManagement.DataLayer.DTOs;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class DataLayerMapping
    {
        public static void AutoMapperStart()
        {
            AutoMapper.Mapper.CreateMap<Song, SongListDTO>();
        }
    }
}
