using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Negocio.Excepciones
{
    public class errorDeInserccionException: Exception
    { 
        public errorDeInserccionException()
        {
        }

        public errorDeInserccionException(string message)
            : base(message)
        {
        }
    }
}
