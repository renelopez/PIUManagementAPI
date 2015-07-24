using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using PumpManagement.DataLayer;
using PumpManagement.DataLayer.DTOs;
using PumpManagement.DataLayer.QueryCommandObjects;

namespace PumpManagement.API.Controllers
{
    [RoutePrefix("api/songs")]
    public class SongController : ApiController
    {
        public ListSongsQuery ListSongsQuery { get; set; }

        public SongController(ListSongsQuery listSongsQuery)
        {
            ListSongsQuery = listSongsQuery;
        }
        // GET: api/Song
        [Route("")]
        public async Task<List<SongListDTO>> Get()
        {
            return await ListSongsQuery.Execute();
        }

        // GET: api/Song/5
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Song
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Song/5
        [Route("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Song/5
        [Route("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
