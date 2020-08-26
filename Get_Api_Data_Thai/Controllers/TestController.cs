using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Get_Api_Data_Thai.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Get_Api_Data_Thai.Controllers
{
    public class TestController : Controller
    {

        private IMongoCollection<ModelTest> _collection;
        private IMongoCollection<ModelTest> _test;
        public TestController()
        {
            var dbcilent = new MongoClient("mongodb://admin01:beer8640@cluster0-shard-00-00.suwog.azure.mongodb.net:27017,cluster0-shard-00-01.suwog.azure.mongodb.net:27017,cluster0-shard-00-02.suwog.azure.mongodb.net:27017/test?replicaSet=atlas-13s0sb-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("sample-amphoe");
            _collection = database.GetCollection<ModelTest>("amphoe");
            _test = database.GetCollection<ModelTest>("Myamphoe");
        }
        // GET: TestController1
        public ActionResult Index()
        {
            var result = _collection.Find(it => true).ToList();
            return View(result);
        }
    }
}
