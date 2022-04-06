using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestRecords.Manager;
using RestRecords.Models;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        public readonly RecordsManager _recordsManager = new RecordsManager();
        // GET: api/<RecordsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<RecordsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public Record GetById(int id)
        {
            return _recordsManager.GetById(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetByNameOrTitle()
        {


        }


        // Get Api/<RecordsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetAll()
        {
            IEnumerable<Record> record = null;
            record = _recordsManager.GetAll();

            if (!record.Any())
            {
                return NotFound("Not Found");
            }

            return Ok(record);

        }

        // PUT api/<RecordsController>/5
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPut("{id}")]
        public Record Put(int id, [FromBody] Record value)
        {
            return _recordsManager.Add(value);
        }

        // DELETE api/<RecordsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public Record Delete(int id)
        {
            return _recordsManager.Delete(id); 
        }
    }
}
