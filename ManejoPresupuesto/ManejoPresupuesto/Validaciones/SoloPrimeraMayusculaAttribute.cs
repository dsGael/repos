using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    public class SoloPrimeraMayusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var palabra = value.ToString();

            for (int i = 1; i < palabra.Length; i++)
            {
                if (palabra[i].ToString() == palabra[i].ToString().ToUpper())
                {
                    return new ValidationResult("Solo la primera letra debe ser mayuscula");
                }
            }

            return ValidationResult.Success;
        }
    }
}
