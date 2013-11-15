using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDBInfrastructure;
using Mongo = MongoDB.Driver.Builders;


namespace MongoDBMVC.Logic.Query
{
    public class AllPIntegrations : MongoDBInfrastructure.Query
    {
        public AllPIntegrations()
        {
            CollectionName = "Integrations";
            MongoQuery = Mongo.Query.Null;
        }
        
    }
}
