using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ecommerce_help
{
    public abstract class DataFactory : IDisposable
    {
        private string connectionString = "";
        private string errorMessage = String.Empty;

        protected string ConnectionString
        {
            get { return this.connectionString; }
        }
        public string ErrorMessage
        {
            get { return this.errorMessage; }
            set { this.errorMessage = value; }
        }

        protected DataFactory()
        {
            this.connectionString = BuildConnectionString();
        }

        protected virtual string BuildConnectionString()
        {
            throw new NotImplementedException();
        }

        public abstract void AdParameter(string paramName, ParameterDirection paramDirection, Object paramValue);
        public abstract void AdParameter(string paramName, Object paramValue);

        public bool ExecProcedure(string spDBName, string spName, out DataSet spOutData)
        {
            return this.ExecQuery(spDBName, spName, CommandType.StoredProcedure, out spOutData);
        }

        public bool ExecProcedure(string spDBName, string spName,  out Int32 spOutData)
        {
            return this.ExecNonQuery(spDBName, spName, CommandType.StoredProcedure,  out spOutData);
        }

        public bool ExecProcedure(string spDBName, string spName, out object spOutData)
        {
            return this.ExecuteScalar(spDBName, spName, CommandType.StoredProcedure, out spOutData);
        }

        public bool ExecQuery(string queryDBName, string queryString, out DataSet queryOutData)
        {
            return this.ExecQuery(queryDBName, queryString, CommandType.Text, out queryOutData);
        }

        public bool ExecQuery(string queryDBName, string queryString, out Int32 queryOutData)
        {
            return this.ExecNonQuery(queryDBName, queryString, CommandType.Text, out queryOutData);
        }

        public bool ExecQuery(string queryDBName, string queryString, out object queryOutData)
        {
            return this.ExecuteScalar(queryDBName, queryString, CommandType.Text, out queryOutData);
        }

        public abstract bool ExecQuery(string queryDBName, string queryString, CommandType queryType, out DataSet queryOutData);

        public abstract bool ExecNonQuery(string nonQueryDBName, string nonQueryString, CommandType nonQueryType, out Int32 nonQueryOutData);

        public abstract bool ExecuteScalar(string scalarQueryDBName, string scalarQueryString, CommandType scalarQueryType, out object scalarQueryOutData);


        protected virtual bool Open()
        {
            throw new NotImplementedException();
        }

        protected virtual bool Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }
    }
}
