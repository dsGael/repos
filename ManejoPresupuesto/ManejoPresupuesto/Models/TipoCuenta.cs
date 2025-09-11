using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

       // [StringLength(maximumLength:50, MinimumLength=3, ErrorMessage ="La longitud del campo {0} debe estar entre {2} y {1}")]
        //[Display(Name ="Nombre del tipo cuenta")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        [SoloPrimeraMayuscula]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }

        public int Orden { get; set; }

       // [Required(ErrorMessage = "El campo {0} es requerido")]
        //[EmailAddress(ErrorMessage ="El campo debe ser un email valido")]
        public string Email { get; set; }

     //   [Range(minimum:18,maximum:100,ErrorMessage ="El valor debe esr entre {1} y {2}")]
        public int Edad { get; set; }

       // [Url(ErrorMessage ="El campo debe ser ua URL valida")]
        public string URL { get; set; }

       // [CreditCard(ErrorMessage ="La tarjeta de credito no es valida")]
        public string TarjetaDeCredito { get; set; }



    }
}
