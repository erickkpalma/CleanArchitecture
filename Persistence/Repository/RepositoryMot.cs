using Domain.Entities;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using static Persistence.Repository.UserRepository;

namespace Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        public void SalvarUsuario(RodmotDTO rodmot)
        {
            string connectionString = DbCommunicator.GetConnectionString();

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = @"
                            DECLARE @NextCODMOT INT;

                            IF EXISTS (SELECT 1 FROM RODMOT WHERE CODMOT = @CODMOT)
                            BEGIN
                                SELECT @NextCODMOT = ISNULL(MAX(CODMOT), 0) + 1 FROM RODMOT;
                            END
                            ELSE
                            BEGIN
                                SET @NextCODMOT = @CODMOT;
                            END

                            INSERT INTO RODMOT (CODMOT, CODPAD, CODFIL, CODMUN, VEICFIX, DATATU, USUATU, NOMMOT)
                            VALUES (@NextCODMOT, @CODPAD, @CODFIL, @CODMUN, @VEICFIX, @DATATU, @USUATU, @NOMMOT)";

                dbConnection.Open();
                dbConnection.Execute(query, rodmot);
            }
        }

        public interface IUserRepository
        {
            void SalvarUsuario(RodmotDTO rodmot);
        }
    }
}
