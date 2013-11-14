using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDBInfrastructure
{
    public class Entity
    {
        private string id;
        public string Id
        {
            get
            {
                if (Document != null)
                {
                    return Document["_id"].AsObjectId.ToString();
                }
                else
                {
                    return id;
                }
            }
            set
            {
                if (Document == null)
                {
                    id = value;
                }
            }
        }
        public string CollectionName { get; set; }
        public RawBsonDocument Document { get; set; }
    }
}
