using Microsoft.Extensions.Configuration;

namespace DataAccessLibrary
{
    public interface ISQLDataAccess
    {
        string ConnectionStringName { get; set; }
        string getConnectionString();
        Task DeleteRecord<T>(string sql, T parameters);
        Task<IEnumerable<T>> LoadData<T, U>(string Sql, U parameters);
        Task<List<T>> LoadDataAsList<T, U>(string Sql, U parameters);
        Task<T> LoadSingleRecord<T, U>(string Sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}