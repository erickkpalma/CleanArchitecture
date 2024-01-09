using Xunit;
using Persistence.Repository;
using Domain.Entities;

namespace Tests
{
    public class UserRepositoryTests
    {
        [Fact]
        public void TestSalvarUsuario()
        {
            // Arrange
            var userRepository = new UserRepository();

            var rodmot = new RodmotDTO
            {
                CODMOT = 1,
                CODPAD = 2,
                CODFIL = 3,
                CODMUN = 4,
                VEICFIX = "ABC123",
                DATATU = DateTime.Now,
                USUATU = "TestUser"
            };

            // Act
            userRepository.SalvarUsuario(rodmot);

        }
    }
}
