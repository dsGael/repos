namespace Portafolio.Models
{
    public class Persona
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }

        public DateTime fecha = DateTime.Now;

        public string ToUpperCase(string valor)
        {
            return valor.ToUpper() + "   Funcion aplicada";
        }


     
    }
}
