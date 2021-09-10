using System;
using System.Data.SqlClient;

namespace Cash
{
	class SqlOperator : IDisposable
	{
		private SqlConnection connection;
		private SqlCommand command;

		public SqlOperator(string dbName, string serverName)
		{
			connection = new SqlConnection(@" Data Source=" + serverName + "; Initial Catalog=" + dbName + "; Integrated Security=SSPI; Persist Security Info=false");
			connection.Open();
		}

		public SqlDataReader ExecuteReader(string command)
		{
			this.command = new SqlCommand(command, connection);
			return this.command.ExecuteReader();
		}

		public void ExecuteNonReader(string command)
		{
			this.command = new SqlCommand(command, connection);
			this.command.ExecuteNonQuery();
		}

		public void Dispose()
		{
			connection.Close();
		}
	}
}
