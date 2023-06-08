using System.Configuration;
using System.Data.SqlClient;

namespace CRUD.SingletonPattern
{
    public class SqlSingleton
    {
        private readonly static SqlConnection _instance = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public static SqlConnection Instance //Creamos el acceso al atributo _instance
        {
            get { return _instance; }
        }

        private SqlSingleton()  //Constructyor private para no se puedan crear objetos de esta clase
        {

        }

    }
}