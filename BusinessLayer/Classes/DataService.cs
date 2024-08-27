using BusinessLayer.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer.Classes
{
    public class DataService : IDataService
    {
        private readonly DataAccessLayer.Interfaces.IDataService _dataService;
        private readonly DataAccessLayer.Interfaces.IDatabaseService _dataBaseService;

        public DataService(string connectionString, List<string> allowedTables,
            IDatabaseServiceFactory databaseServiceFactory, IDataServiceFactory dataServiceFactory)
        {
            _dataBaseService = databaseServiceFactory.CreateDatabaseService(connectionString);
            _dataService = dataServiceFactory.CreateDataService(_dataBaseService, allowedTables);
        }

        public DataTable GetDataTable(string tabName)
        {
            return _dataService.GetDataTable(tabName);
        }
    }
}
