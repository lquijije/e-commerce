using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ecommerce_help
{
    public class SqlFactory : DataFactory
    {
        private SqlConnection cnn = null;
        private List<SqlParameter> parameters = null;

        public SqlFactory():base()
        {
            cnn = new SqlConnection();
            parameters = new List<SqlParameter>();
        }

        protected override string BuildConnectionString()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.DataSource = "130.1.40.237" + "," + "1433";
            cs.InitialCatalog = "PODBPOS";
            cs.Password = "moni";
            cs.UserID = "monitran";
            return cs.ConnectionString;
        }

        protected override bool Open()
        {
            try
            {
                if(cnn.State == ConnectionState.Open)
                {
                    this.Close();
                }
                cnn.ConnectionString = this.ConnectionString;
                cnn.Open();
                return true;
            }
            catch (Exception e)
            {
                this.ErrorMessage = e.Message;
                return false;
            }
        }

        protected override bool Close()
        {
            try
            {
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                this.ErrorMessage = e.Message;
                return false;
            }
        }

        
        public override bool ExecNonQuery(string nonQueryDBName, string nonQueryString, CommandType nonQueryType, out int nonQueryOutData)
        {
            bool result = false;
            SqlCommand cmd = null;

            try
            {
                this.Open();
                
                cnn.ChangeDatabase(nonQueryDBName);
                cmd = new SqlCommand(nonQueryString, cnn);
                cmd.CommandType = nonQueryType;
                cmd.CommandTimeout = 300;

                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                nonQueryOutData = cmd.ExecuteNonQuery();

                result = true;
            }
            catch (SqlException ex)
            {
                this.ErrorMessage = ex.Message;
                nonQueryOutData = -1;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
                nonQueryOutData = -1;
            }
            finally
            {
                cnn.Close();
                if (cmd != null)
                    cmd.Dispose();
                cmd = null;
                if (parameters != null)
                    parameters.Clear();
                parameters = null;
            }

            return result;
        }

        public override bool ExecQuery(string queryDBName, string queryString, CommandType queryType, out DataSet queryOutData)
        {
            bool result = false;
            SqlCommand cmd;
            SqlDataAdapter adap;
            queryOutData = new DataSet();

            try
            {
                
                this.Open();
                cnn.ChangeDatabase(queryDBName);
                cmd = new SqlCommand(queryString, cnn);
                cmd.CommandType = queryType;
                cmd.CommandTimeout = 300;
                
                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                adap = new SqlDataAdapter(cmd);
                adap.Fill(queryOutData);

                cnn.Close();
                if (cmd != null)
                    cmd.Dispose();
                cmd = null;
                if (adap != null)
                    adap.Dispose();
                adap = null;
                if (parameters != null)
                    parameters.Clear();
                parameters = null;

                result = true;
            }
            catch (SqlException ex)
            {
                this.ErrorMessage=ex.Message;
                queryOutData = null;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
                queryOutData = null;
            }

            return result;
        }

        public override bool ExecuteScalar(string scalarQueryDBName, string scalarQueryString, CommandType scalarQueryType, out object scalarQueryOutData)
        {
            bool result = false;
            SqlCommand cmd;
            try
            {
                this.Open();
                cnn.ChangeDatabase(scalarQueryDBName);
                cmd = new SqlCommand(scalarQueryString, cnn);
                cmd.CommandType = scalarQueryType;
                cmd.CommandTimeout = 300;

                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                scalarQueryOutData = cmd.ExecuteScalar();

                cnn.Close();
                if (cmd != null)
                    cmd.Dispose();
                cmd = null;
                if (parameters != null)
                    parameters.Clear();
                parameters = null;

                result = true;
            }
            catch (SqlException ex)
            {
                this.ErrorMessage=ex.Message;
                scalarQueryOutData = null;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
                scalarQueryOutData = null;
            }

            return result;
        }

        public override void AdParameter(string paramName, object paramValue)
        {
            AdParameter(paramName, ParameterDirection.Input, paramValue);
        }
        public override void AdParameter(string paramName, ParameterDirection paramDirection, object paramValue)
        {
            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = paramName;
            parameter.Value = paramValue;
            //parametro.MySqlDbType=MySqlDbType.VarChar

            if (ParameterDirection.Output == paramDirection)
                parameter.Direction = ParameterDirection.Output;

            parameters.Add(parameter);
        }

        public new void Dispose()
        {
            try
            {
                if (this.cnn != null)
                    this.cnn.Close();
            }catch
            {}

            try
            {
                if (this.cnn != null)
                    this.cnn.Dispose();
            }catch
            {}

            this.cnn = null;
        }
    }
}
