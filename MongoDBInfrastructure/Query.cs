using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBInfrastructure
{
    public class Query
    {
        public string CollectionName { get; set; }
        public IMongoQuery MongoQuery { get; set; }
    }
}
