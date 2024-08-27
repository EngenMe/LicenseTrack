using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class DataServiceFactory : IDataServiceFactory
    {
        public DataAccessLayer.Interfaces.IDataService CreateDataService(
            DataAccessLayer.Interfaces.IDatabaseService databaseService, List<string> allowedTables)
        {
            return new DataAccessLayer.Classes.DataService(databaseService, allowedTables);
        }
    }
}
