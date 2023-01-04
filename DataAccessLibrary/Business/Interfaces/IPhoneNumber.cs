namespace DataAccessLibrary.Business
{
    public interface IPhoneNumber
    {
        Task Delete(int ID, string Type);
    }
}