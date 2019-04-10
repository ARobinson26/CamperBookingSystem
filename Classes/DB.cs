using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CamperBookingSystem.Classes
{
    class DB
    {
        /// <summary>
        /// Queries database for a single camper with a matching registration.
        /// </summary>
        /// <param name="registration">Registration of the camper to be found in DB</param>
        /// <returns></returns>
        public static DataRow FindCamper(string registration)
        {
            //Creates a SQL Connection
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CamperBookingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                //Opens SQL Connection and sets query/parameter values
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM Camper WHERE registration = @CamperReg", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@reg", registration);

                //SQL Adapter object converts SQL results into C#
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Creates dataset object and fills it with results from data adapter.
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet.Tables[0].Rows[0];
                }
                else
                {
                    return null;
                }
            }

            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

