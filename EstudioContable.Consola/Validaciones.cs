using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudioContable.Consola.Excepciones;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EstudioContable.Consola
{
    internal static class Validaciones
    {


        internal static void validarEntero(string intString)
        {
            int numericValue;
            if (intString == null)
            {
                throw new ValidacionException("No se ingreso ningun valor");
            }
            if (int.TryParse(intString, out numericValue) == false)
            {
                throw new ValidacionException("No se ingreso un valor numerico");
            }
            if (numericValue < 0)
            {
                throw new ValidacionException("Se debe ingresar un valor mayor a 0");
            }

        }

        internal static void validarMail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                throw new ValidacionException("El email no es valido");
            }
            try
            {
                var addr = new MailAddress(email);
            }
            catch
            {
                throw new ValidacionException("El email no es valido");
            }
        }

        internal static void validarTelfono(string telefono)
        {
            string regex_validar_telefono = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"; 

            if (Regex.IsMatch(telefono, regex_validar_telefono) == false)
            {
                throw new ValidacionException("El telefono no es valido");
            }

        }

        internal static void validarCuil(string cuil)
        {
            string regex_validar_cuil = @"\b(20|23|24|27|30|33|34)(\D)?[0-9]{8}(\D)?[0 - 9]"; 

            if (Regex.IsMatch(cuil, regex_validar_cuil) == false)
            {
                throw new ValidacionException("El Cuil no es valido");

            }
        }

        internal static void validarFecha(string fecha)
        {
            DateTime fechaValidada;
            if(DateTime.TryParseExact(fecha, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fechaValidada)== false)
            {
                throw new ValidacionException("La fecha no es valida, tiene que ser en formato dd/mm/yyyy");
            }
            
         
        }   



    }
}
