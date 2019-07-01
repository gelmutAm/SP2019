using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Library.DAL
{
    public static class BaseDao
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=library;Integrated Security=True";

        public static void Add<T>(string storedProcedureName, T obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlCommandBuilder.DeriveParameters(command);

                PropertyInfo[] props = obj.GetType().GetProperties();

                for (int i = 1; i < command.Parameters.Count - 1; i++)
                {
                    command.Parameters[command.Parameters[i + 1].ParameterName].Value = props[i].GetValue(obj);
                }

                command.Parameters[command.Parameters[1].ParameterName].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
            }
        }

        public static void DeleteById(string storedProcedureName, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlCommandBuilder.DeriveParameters(command);

                command.Parameters[command.Parameters[1].ParameterName].Value = id;

                command.ExecuteNonQuery();
            }
        }

        public static IEnumerable<T> GetAll<T>(string request) where T : new()
        {
            List<T> temp = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(request, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        List<object> tempValues = new List<object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            tempValues.Add(reader.GetValue(i));
                        }

                        object[] constructorParameters = new object[1];
                        constructorParameters[0] = tempValues;

                        T tempValue = new T();

                        Type[] types = new Type[1];
                        types[0] = tempValues.GetType();

                        ConstructorInfo constructor = tempValue.GetType().GetConstructor(types);
                        tempValue = (T)constructor.Invoke(constructorParameters);

                        temp.Add(tempValue);
                    }
                }
            };

            return temp;
        }
    }
}
