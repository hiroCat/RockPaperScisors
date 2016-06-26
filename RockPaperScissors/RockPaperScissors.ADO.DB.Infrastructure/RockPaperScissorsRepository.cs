using RockPaperScissors.Contract.ServiceLibrary.Entities;
using RockPaperScissors.Impl.ServiceLibrary.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;

namespace RockPaperScissors.ADO.DB.Infrastructure
{
    public class RockPaperScissorsRepository : IRockPaperScissorsRepository
    {
        private string connectionString = "Data Source=HIRO-X303\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";


        public UserEntity GetUserEntityById(long id)
        {
            UserEntity returnDto = null;
            using (var sqlconnection = new SqlConnection(connectionString))
            {
                sqlconnection.Open();
                var sqlcommand = new SqlCommand()
                {
                    Connection = sqlconnection,
                    CommandText = "SELECT Id,createdUser,playsOfUser " +
                                  "FROM User " +
                                  "WHERE id=@id",
                    CommandTimeout = 600,
                    CommandType = CommandType.Text
                };
                sqlcommand.Parameters.AddWithValue("@id", id);
                using (var reader = sqlcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        returnDto = new UserEntity()
                        {
                            id = id,
                            createdUser = Convert.ToDateTime(reader["createdUser"]),
                            playsOfUser = 
                        };
                    }
                }
            }
            return returnDto;
        }

        public TrainingDTO GetDTOByAirportCode(string AirportCode)
        {
            TrainingDTO returnDto = null;
            using (var sqlconnection = new SqlConnection(_infrastructureConfiguration.ConnectionString))
            {
                sqlconnection.Open();
                var sqlcommand = new SqlCommand()
                {
                    Connection = sqlconnection,
                    CommandText = "SELECT IP,City,AirportCode " +
                                  "FROM Localitzation " +
                                  "WHERE AirportCode=@AirportCode",
                    CommandTimeout = _infrastructureConfiguration.DatabaseTimeout,
                    CommandType = CommandType.Text
                };
                sqlcommand.Parameters.AddWithValue("@AirportCode", AirportCode);
                using (var reader = sqlcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        returnDto = new TrainingDTO()
                        {
                            Ip = Convert.ToString(reader["IP"]),
                            City = Convert.ToString(reader["City"]),
                            AirportCode = AirportCode,
                        };
                    }
                }
            }
            return returnDto;
        }

        public void SaveAirportCity(TrainingDTO dto)
        {
            using (var sqlconnection = new SqlConnection(_infrastructureConfiguration.ConnectionString))
            {
                sqlconnection.Open();
                var sqlcommand = new SqlCommand()
                {
                    Connection = sqlconnection,
                    CommandText = "INSERT INTO Localitzation (IP,City,AirportCode)" +
                                  "VALUES (@IP,@City,@AirportCode)",
                    CommandTimeout = _infrastructureConfiguration.DatabaseTimeout,
                    CommandType = CommandType.Text
                };
                sqlcommand.Parameters.AddWithValue("@IP", dto.Ip);
                sqlcommand.Parameters.AddWithValue("@City", dto.City);
                sqlcommand.Parameters.AddWithValue("@AirportCode", dto.AirportCode);

                sqlcommand.ExecuteReader();
            }
        }
    }
}
