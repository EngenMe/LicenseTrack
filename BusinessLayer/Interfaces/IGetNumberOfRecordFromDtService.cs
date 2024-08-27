using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IGetNumberOfRecordFromDtService
    {
        int GetNumberOfRecords(DataTable dataTable);
    }
}
