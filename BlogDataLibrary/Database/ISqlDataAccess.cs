﻿using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace BlogDataLibrary.Database
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure);
        void SaveData<T>(string sqlStatement, T parameters, string connectionStringName, bool isStoredProcedure);
    }
}