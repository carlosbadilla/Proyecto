using Dapper;
using ProyectoFinal.Models;
using Microsoft.Data.SqlClient;
using System.Net.WebSockets;

namespace ProyectoFinal.Servicios
{
    public interface IRepositorioRegistro
    {
        Task Crear(Modelo_Registro modelo_Registro);
    }
    public class RepositorioRegistro : IRepositorioRegistro
    {
        private readonly string connectionString;

        public RepositorioRegistro(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(Modelo_Registro modelo_Registro)
        {
            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO Registro (Usuario, Correo, Contraseña)
                                                    VALUES (@Usuario, @Correo, Contraseña);
                                                    SELECT SCOPE_IDENTITY();", modelo_Registro);
            modelo_Registro.Registro_Id = id;
        }

    }
}
