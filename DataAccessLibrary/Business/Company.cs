using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Business
{
    public class Company : ICompany
    {
        private readonly ISQLDataAccess _db;

        public Company(ISQLDataAccess db) => _db = db;

        public Task Insert(Data.Company company)
        {
            string sql = "[dbo].[pc_Companies_Insert] @Name, @PhoneNumber, @EmailAddress, @AddressLine1, @AddressLine2, @AddressLine3, @Town, @County, @Postcode, @Active, @CreatedBy";

            return _db.SaveData(sql, company);
        }

        public Task Update(Data.Company company)
        {

            string sql = "[dbo].[pc_Companies_Update] @ID, @Name, @PhoneNumber, @EmailAddress, @AddressLine1, @AddressLine2, @AddressLine3, @Town, @County, @Postcode, @Active, @UpdatedBy";

            return _db.SaveData(sql, company);
        }


        public Task<Data.Company> RetrieveByID(int CompanyID) => _db.LoadSingleRecord<Data.Company, dynamic>("pc_Companies_Retrieve_By_ID @CompanyID", new { CompanyID });


        public Task Delete(int CompanyID) => _db.DeleteRecord($"EXECUTE [dbo].[pc_Companies_Delete_By_ID] @CompanyID", new { CompanyID });

        public Task<IEnumerable<Data.Company>> RetrieveCompanyNames() => _db.LoadData<Data.Company, dynamic>("EXECUTE [dbo].[pc_Companies_Retrieve_Company_Names]", new { });

        public Task<IEnumerable<Data.Company>> RetrieveAll() => _db.LoadData<Data.Company, dynamic>("EXECUTE [dbo].[pc_Companies_Retrieve_All]", new { });

        public async Task UpdateMainEmailAddress(int CompanyID, int EmailAddressID) => await _db.SaveData($"EXECUTE[dbo].[pc_Companies_Update_Main_Email_Address_ID] @CompanyID, @EmailAddressID", new { CompanyID, EmailAddressID });

        public async Task UpdateMainPhoneNumber(int CompanyID, int PhoneNumberID) => await _db.SaveData($"EXECUTE[dbo].[pc_Companies_Update_Main_Phone_Number_ID] @CompanyID, @PhoneNumberID", new { CompanyID, PhoneNumberID });

        public async Task UpdateMainContact(int CompanyID, int ContactID) => await _db.SaveData($"EXECUTE[dbo].[pc_Companies_Update_Main_Contact_ID] @CompanyID, @ContactID", new { CompanyID, ContactID });
    }
}
