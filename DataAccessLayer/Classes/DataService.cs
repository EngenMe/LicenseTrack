using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.Classes
{
    public class DataService : IDataService
    {
        private readonly IDatabaseService _databaseService;
        private readonly List<string> _allowedTables;

        public DataService(IDatabaseService databaseService, List<string> allowedTables)
        {
            _databaseService = databaseService;
            _allowedTables = allowedTables;
        }

        public DataTable GetDataTable(string tabName)
        {
            if (!_allowedTables.Contains(tabName))
                throw new ArgumentException("Invalid view name specified.");

            string query = $"SELECT * FROM {tabName}";

            return _databaseService.ExecuteQuery(query);
        }
    }
}
