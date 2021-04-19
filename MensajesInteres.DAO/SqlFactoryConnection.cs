using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MensajesInteres.DAO
{
	public class SqlFactoryConnection
	{
		public ILogger Logger { get; }

		public SqlFactoryConnection(ILogger logger = null)
		{
			Logger = logger;
		}
	

		private static string Connection_String
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
			}
		}


		public SqlConnection Connection()
		{
			SqlConnection conn = new SqlConnection(Connection_String);
			Logger?.LogInformation("Abriendo conexión de base de datos en modo sincrono");
			conn.Open();
			return conn;
		}
	}
}
