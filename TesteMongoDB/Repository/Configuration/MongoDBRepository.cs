using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDB.Repository.Configuration
{
    public class MongoDBRepository : IDisposable
    {
        public string DataBaseName { get; set; }
        private IMongoClient _client { get; set; }
        private IMongoDatabase _dataBase { get; set; }

        public MongoDBRepository() : this("dbmongo")
        {

        }

        public MongoDBRepository(string databaseName)
        {
            DataBaseName = databaseName;
            _client = new MongoClient("mongodb://localhost:27017");
            _dataBase = _client.GetDatabase(DataBaseName);
        }

        public IMongoDatabase Database
        {
            get { return _dataBase; }
        }

        public void Dispose()
        {
            _client = null;
            _dataBase = null;
        }
    }
}
