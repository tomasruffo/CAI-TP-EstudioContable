using EstudioContable.Entidades;
using EstudioContable.Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Consolas
{
    public class Program
    {
        static void Main(string[] args)
        {      
           
            try
                
            {

                EmpleadoNegocio empleados = new EmpleadoNegocio();
                EmpresaNegocio empresas = new EmpresaNegocio();
                LiquidacionNegocio liquidaciones = new LiquidacionNegocio();
                CategoriaNegocio categorias = new CategoriasNegocio();


                bool consolaActiva = true;
                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionElegida = Console.ReadLine();
                    Switch (opcionElegida)
                    {
                        case "1":
                            TraerEmpleados(empleados);
                            break;
                        case "2":
                            AltaEmpleado(empleados);
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        case "9":
                            break;
                        case "10":
                            break;
                        case "X":
                            break;
                    }
                }

            }
            catch
            {

            }
                 

           

            static void TraerEmpleados(EmpleadoNegocio empleadoNegocio)
            {
                Console.WriteLine("Ingrese Legajo del empleado: ");
                int legajo;
                string legajo_str= Console.ReadLine();
                if (!int.TryParse(legajo_str, out legajo))
                {
                    Console.WriteLine("Ingrese un numero de legajo valido ");
                    return;
                }
                Empleado e1 = empleadoNegocio.GetByLegajo(legajo.toInt);
                Console.WriteLine("Se encontro el siguiente empleado:");
                Console.WriteLine(e1.ToString());



            }

            static void AltaEmpleado(EmpleadoNegocio empleadoNegocio)
            {
                Console.WriteLine("Ingrese el Id Empleado: ");
                string id = Console.ReadLine();
                Console.WriteLine("Ingrese el Id empresa: ");
                string idEmpresa = Console.ReadLine();
                Console.WriteLine("Ingrese el id Categoria: ");
                string idCategoria = Console.ReadLine();
                Console.WriteLine("Ingrese el id fecha nacimiento: ");
                string fechaNacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el direccion: ");
                string direccion = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine("Ingrese el mail: ");
                string mail = Console.ReadLine();

                Empleado e1 = empleadoNegocio.AltaEmpleado(idEmpresa, idCategoria, fechaNacimiento, id,  nombre, apellido, direccion, telefono, mail);


            }


            static void DesplegarOpcionesMenu()
            {
                Console.WriteLine(" 1 - Consultar empelado con legajo");
                Console.WriteLine(" 2 - Alta empleado");
                Console.WriteLine(" 3 - Consultar empresa con codigo de mepleado");
                Console.WriteLine(" 4 - Alta empresa");
                Console.WriteLine(" 5 - Consultar liquidaciones con codigo empleado");
                Console.WriteLine(" 6 - Alta liquidacion");
                Console.WriteLine(" 7 - Consultar categorias con codigo empleado");
                Console.WriteLine(" 8 - Alta categoria");
                Console.WriteLine(" 9 - Reporte Empleados por empresa");
                Console.WriteLine(" 10 - Reporte Liquidaciones por categoria");
                Console.WriteLine(" X - Salir del programa");


            }




        }

    }
}
