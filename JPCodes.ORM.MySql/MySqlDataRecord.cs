using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace JPCodes.ORM.MySql
{
    public class MySqlTablettribute : TableAttribute
    {
        public MySqlTablettribute() : base() { }
        public MySqlTablettribute(string tableName) : base(tableName) { }

        public override string ParameterPrefix => "?";
        public override string EncloseObject(string item) => $"`{item}`";
        public override DbParameter CreateParameter(string name, object value) => new MySqlParameter(name, value);
    }
}
