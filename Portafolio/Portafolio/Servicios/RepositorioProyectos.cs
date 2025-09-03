using Portafolio.Models;
namespace Portafolio.Servicios;



public interface IRepositorioProyectos
{
     List<Proyecto> ObtenerProyectos();
}
public class RepositorioProyectos: IRepositorioProyectos
{

    public List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-commerce realizado en ASP.NET core",
                    Link = "https://amazon.com",
                    ImagenURL = "imagenes/amazon2.png "

                },
                new Proyecto{
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "./imagenes/nyt.jpg"
                },
                new Proyecto{
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "./imagenes/reddit.webp"
                },
                new Proyecto{
                    Titulo = "Steam",
                    Descripcion = "Tienda en lianea para omprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "./imagenes/steam.jpg"
                }

            };

    }

}

