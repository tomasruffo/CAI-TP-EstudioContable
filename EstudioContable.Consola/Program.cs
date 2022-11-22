using EstudioContable.Entidades;
using EstudioContable.Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Consolas
{
    public class Program
    {
        static void Main(string[] args)
        {


           

            EmpleadoNegocio empleados = new EmpleadoNegocio();
            EmpresaNegocio empresas = new EmpresaNegocio();
            LiquidacionNegocio liquidaciones = new LiquidacionNegocio();
            CategoriaNegocio categorias = new CategoriaNegocio();


            bool consolaActiva = true;
            while (consolaActiva)
            {
                DesplegarOpcionesMenu();
                string opcionElegida = Console.ReadLine();
                
                switch (opcionElegida)
                {
                    case "1":
                        TraerEmpleados(empleados);
                        break;
                    case "2":
                        AltaEmpleado(empleados);
                        break;
                    case "3":
                        TraerEmpresas(empresas);
                        break;
                    case "4":
                        AltaEmpresa(empresas);
                        break;
                    case "5":
                        TraerLiquidaciones(liquidaciones);
                        break;
                    case "6":
                        AltaLiquidacion(liquidaciones);
                        break;
                    case "7":
                        TraerCategorias(categorias);
                        break;
                    case "8":
                        AltaCategoria(categorias);
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

        static void TraerEmpleados(EmpleadoNegocio empleadoNegocio)
        {   
            Console.WriteLine("Ingrese Legajo del empleado: ");
            int legajo;
            string legajo_str = Console.ReadLine();
            if (!int.TryParse(legajo_str, out legajo))
            {
                Console.WriteLine("Ingrese un numero de legajo valido ");
             
                try
                {
                    Empleado e1 = empleadoNegocio.GetByLegajo(legajo);
                    Console.WriteLine("Se encontro el siguiente empleado:");
                    Console.WriteLine(e1.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                



            }
        }

        static void AltaEmpleado(EmpleadoNegocio empleadoNegocio)
        {
            Console.WriteLine("Ingrese el Id Empleado: ");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese el Id empresa: ");
            string idEmpresa = Console.ReadLine();
            Console.WriteLine("Ingrese el id Categoria: ");
            string idCategoria = Console.ReadLine();
            Console.WriteLine("Ingrese el cuil: ");
            string cuil = Console.ReadLine();
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
            try
            {
                empleadoNegocio.AltaEmpleado(int.Parse(idEmpresa), int.Parse(idCategoria), int.Parse(cuil), DateTime.Parse(fechaNacimiento), int.Parse(id), nombre, apellido, direccion, long.Parse(telefono), mail);

            }
            catch
            {
                throw new Exception(" Inputs invalidos");
            }


        }
        static void TraerEmpresas(EmpresaNegocio empresaNegocio)
        {
            Console.WriteLine("Ingrese ID del empelado: ");
            int id;
            string id_str = Console.ReadLine();
            if (!int.TryParse(id_str, out id))
            {
                Console.WriteLine("Ingrese un id valido ");
                return;
            }
            try
            {
                Empresa e1 = empresaNegocio.GetByIdEmpleado(id);
                Console.WriteLine("El empelado corresponde a la empresa: ");
                Console.WriteLine(e1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        

        }

        static void AltaEmpresa(EmpresaNegocio empresaNegocio)
        {
            Console.WriteLine("Ingrese el Id : ");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese la razon social: ");
            string razonSocial = Console.ReadLine();
            Console.WriteLine("Ingrese el cuit: ");
            string cuit = Console.ReadLine();
            Console.WriteLine("Ingrese el domicilio: ");
            string domicilio = Console.ReadLine();

            try
            {
                empresaNegocio.AltaEmpresa(int.Parse(id), razonSocial, long.Parse(cuit), domicilio);

            }
            catch
            {
                throw new Exception(" Inputs invalidos");
            }

        }

        static void TraerCategorias(CategoriaNegocio categoriaNegocio)
        {
            Console.WriteLine("Ingrese ID del empleado: ");
            int id;
            string id_str = Console.ReadLine();
            if (!int.TryParse(id_str, out id))
            {
                Console.WriteLine("Ingrese un id valido ");
                return;
            }
            Categoria e1 = categoriaNegocio.GetByIdEmpleado(id);
            Console.WriteLine("Pertenece a la siguente cateogria:");
            Console.WriteLine(e1.ToString());



        }


        static void AltaCategoria(CategoriaNegocio categoriaNegocio)
        {
            Console.WriteLine("Ingrese el Id : ");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la categoria: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el convenio: ");
            string convenio = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo basico: ");
            string sueldoBasico = Console.ReadLine();
            try
            {
                categoriaNegocio.AltaCategoria(int.Parse(id), nombre, convenio, double.Parse(sueldoBasico));

            }
            catch
            {
                throw new Exception(" Inputs invalidos");
            }

        }


        static void TraerLiquidaciones(LiquidacionNegocio liquidacionNegocio)
        {
            Console.WriteLine("Ingrese ID empleado: ");
            int id;
            string id_str = Console.ReadLine();
            if (!int.TryParse(id_str, out id))
            {
                Console.WriteLine("Ingrese un id valido ");
                return;
            }
            List<Liquidacion> listaLiquidaciones = liquidacionNegocio.GetById(id);
            Console.WriteLine("El id ingresdo posee las sigueintes liquidaciones:");
            foreach (var item in listaLiquidaciones)
            {
                Console.WriteLine(item.ToString());
            }

        }


        static void AltaLiquidacion(LiquidacionNegocio liquidacionNegocio)
        {
            Console.WriteLine("Ingrese el id de la liquidacion : ");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese el idEmpleado : ");
            string idEmpleado = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de transferencia: ");
            string codigoTransferencia = Console.ReadLine();
            Console.WriteLine("Ingrese el periodo: ");
            string periodo = Console.ReadLine();
            Console.WriteLine("Ingrese el bruto: ");
            string bruto = Console.ReadLine();
            Console.WriteLine("Ingrese el descuento : ");
            string descuentos = Console.ReadLine();
            try
            {
                liquidacionNegocio.AltaLiquidacion(int.Parse(id), int.Parse(idEmpleado), int.Parse(codigoTransferencia), int.Parse(periodo), double.Parse(bruto), double.Parse(descuentos));

            }
            catch
            {
                throw new Exception(" Inputs invalidos");
            }

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