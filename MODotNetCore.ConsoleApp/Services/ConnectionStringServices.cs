﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODotNetCore.ConsoleApp.Services;

internal class ConnectionStringServices
{
    public static SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder()
    {
        DataSource = "DESKTOP-QIPPQBI\\SQLEXPRESS",
        InitialCatalog = "DotNetTrainingBatch4",
        UserID = "sa",
        Password = "sasa@123"
    };
}
