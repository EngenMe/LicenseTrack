using BusinessLayer.Interfaces;
using System.Data;

namespace BusinessLayer.Classes
{
    public class GetNumberOfRecordFromDtService : IGetNumberOfRecordFromDtService
    {
        public int GetNumberOfRecords(DataTable dataTable)
        {
            return dataTable.Rows.Count;
        }
    }
}
