using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Consola.Excepciones
{
    public class ValidacionException: Exception
    {

        public ValidacionException()
        {
        }

        public ValidacionException(string message)
            : base(message)
        {
        }

    }
}
