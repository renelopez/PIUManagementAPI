using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GenericServices;
using PumpManagement.DataLayer;

namespace PumpManagement.API.Controllers
{
    public class SongController : ApiController
    {
        public IListService Service { get; set; }

        // GET: api/Song
        public IEnumerable<SongListDtoAsync> Get()
        {
            return Service.GetAll<SongListDtoAsync>().ToList();
        }

        // GET: api/Song/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Song
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Song/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Song/5
        public void Delete(int id)
        {
        }
    }
}
