using System.Collections.Generic;

namespace ReportsTestLibrary.Databases
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement,
                               U parameters,
                               string connectionStringName,
                               bool isStoredProcedure = false);
        void SaveData<T>(string sqlStatement,
                         T parameters,
                         string connectionStringName,
                         bool isStoredProcedure = false);
    }
}