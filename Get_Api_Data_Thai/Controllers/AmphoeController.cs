using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Get_Api_Data_Thai.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Get_Api_Data_Thai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmphoeController : ControllerBase
    {
        private IMongoCollection<ModelTest> _collection;
        private IMongoCollection<ModelTest> _test;
        public AmphoeController()
        {
            var dbcilent = new MongoClient("mongodb://admin01:beer8640@cluster0-shard-00-00.suwog.azure.mongodb.net:27017,cluster0-shard-00-01.suwog.azure.mongodb.net:27017,cluster0-shard-00-02.suwog.azure.mongodb.net:27017/test?replicaSet=atlas-13s0sb-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("sample-amphoe");
            _collection = database.GetCollection<ModelTest>("amphoe");
            _test = database.GetCollection<ModelTest>("Myamphoe");
        }

        // GET: api/<AmphoeController>
        [HttpGet]
        public IEnumerable<ModelTest> Get()
        {
            var result = _collection.Find(it => true).ToList();
            return (result);
        }

        // GET api/<AmphoeController>/5
        [HttpGet("{district}")]
        public IEnumerable<ModelTest> Get(string district)
        {
            var item = _collection.Find(it => it.district == district).ToList();
            return (item);
        }

        // POST api/<AmphoeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AmphoeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AmphoeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
