using Aplication.Shared.Behavior;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;
using static Aplication.Shared.Behavior.UserService;
using static Aplication.Shared.Behavior.ValidationBehavior;
using static Persistence.Repository.UserRepository;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DbCommunicator.Usuario = "usuario";
            DbCommunicator.Senha = "senha";
            DbCommunicator.Database = "db";
            DbCommunicator.Servidor = "servidor";


            var serviceProvider = new ServiceCollection()
                .AddTransient<IUserRepository, UserRepository>() 
                .AddTransient<IUserService, UserService>()      
                .AddTransient<IValidateData, ValidationBehavior>()
                .BuildServiceProvider();

            Application.Run(new Form1(serviceProvider));
        }
    }
}