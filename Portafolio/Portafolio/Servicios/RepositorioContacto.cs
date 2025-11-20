using Dapper;
using Microsoft.Data.SqlClient;
using Portafolio.Models;
namespace Portafolio.Servicios;



public interface IRepositorioContacto
{
    Task CrearContacto(ContactoViewModel contacto);     


}



public class RepositorioContacto: IRepositorioContacto
{
    private readonly string connectionString;

    public RepositorioContacto(IConfiguration configuration)
    {
        connectionString= configuration.GetConnectionString("DefaultConnection");
    }

    
    public async Task CrearContacto(ContactoViewModel contacto)
    {
        using var connection= new SqlConnection(connectionString);
        var id= await connection.QuerySingleAsync<int>(@"INSERT INTO Contacto (Nombre, Email, Mensaje) 
        VALUES (@Nombre, @Email, @Mensaje);
        SELECT SCOPE_IDENTITY();", contacto);
        contacto.Id= id;
    }

}

