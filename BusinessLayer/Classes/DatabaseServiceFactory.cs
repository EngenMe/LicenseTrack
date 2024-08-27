using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class DatabaseServiceFactory : IDatabaseServiceFactory
    {
        public DataAccessLayer.Interfaces.IDatabaseService CreateDatabaseService(string connectionString)
        {
            return new DataAccessLayer.Classes.DataBaseService(connectionString);
        }
    }
}
