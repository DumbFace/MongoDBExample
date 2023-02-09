using System;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoDBConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

            var dbList = dbClient.ListDatabases().ToList();

            var database = dbClient.GetDatabase("TestDB");
            var collection = database.GetCollection<BsonDocument>("FirstCollection");

            // var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();

            var document = collection.Find(new BsonDocument());

            foreach (var item in document.ToList())
            {
                Console.WriteLine(item.ToString());
            }



        }
    }
}
