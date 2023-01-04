using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Business
{
    public class PhoneNumber : IPhoneNumber
    {
        private readonly ISQLDataAccess _db;

        public PhoneNumber(ISQLDataAccess db) => _db = db;

        public Task Delete(int ID, string Type) => _db.DeleteRecord($"EXECUTE [dbo].[pc_PhoneNumbers_Delete_By_ID] @ID, @Type", new { ID, Type });
    }
}
