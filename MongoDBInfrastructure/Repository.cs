using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBInfrastructure
{
    public class Repository
    {
        private MongoDatabase database;

        public Repository()
        {
            database = GetMongoDatabase();
        }

        public void Add(Entity entity){}
        public void Delete(Entity entity){}
        public RawBsonDocument GetById(Entity entity) {
            return database.GetCollection<RawBsonDocument>(entity.CollectionName).FindOneById(new ObjectId(entity.Id));
        }
        public void Update(Entity entity) { }

        public List<RawBsonDocument> Query(Query query)
        {
            var result = database.GetCollection<RawBsonDocument>(query.CollectionName).Find(query.MongoQuery);
            return result.ToList<RawBsonDocument>();
        }

        private MongoDatabase GetMongoDatabase()
        {
            const string ConnectionString = "mongodb://localhost";
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");
            return database;
        }
    }
}
