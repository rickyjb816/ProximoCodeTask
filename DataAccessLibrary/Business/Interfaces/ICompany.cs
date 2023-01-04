namespace DataAccessLibrary.Business
{
    public interface ICompany
    {
        Task Delete(int CompanyID);
        void Insert(Data.Company company);
        Task<IEnumerable<Data.Company>> RetrieveAll();
        Task<Data.Company> RetrieveByID(int CompanyID);
        Task<IEnumerable<Data.Company>> RetrieveCompanyNames();
        void Update(Data.Company company);
        Task UpdateMainEmailAddress(int CompanyID, int EmailAddressID);
        Task UpdateMainPhoneNumber(int CompanyID, int PhoneNumberID);
        Task UpdateMainContact(int CompanyID, int ContactID);
    }
}