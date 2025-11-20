using Dapper;
using Microsoft.Data.SqlClient;
using Portafolio.Models;
namespace Portafolio.Servicios;



public interface IRepositorioProyectos
{
     Task<IEnumerable<Proyecto>> ObtenerProyectos();
     
}



public class RepositorioProyectos: IRepositorioProyectos
{
    private readonly string connectionString;

    public RepositorioProyectos(IConfiguration configuration)
    {
        connectionString= configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<IEnumerable<Proyecto>> ObtenerProyectos()
    {
        using var connection= new SqlConnection(connectionString);
        return await connection.QueryAsync<Proyecto>("SELECT * FROM Proyectos");
    }

}

