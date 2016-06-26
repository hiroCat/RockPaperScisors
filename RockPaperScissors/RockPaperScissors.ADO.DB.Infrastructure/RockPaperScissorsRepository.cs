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
                        };
                    }
                }
            }
            return returnDto;
        }


        public MoveEntity getMove(long id)
        {
            throw new NotImplementedException();
        }

        public void saveMove(MoveEntity moveEntity)
        {
            throw new NotImplementedException();
        }
    }
}
