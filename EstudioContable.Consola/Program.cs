using EstudioContable.Consola;
using EstudioContable.Consola.Excepciones;
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
                        ReporteEmpleadosEmpresa(empleados);

                        break;
                    case "10":
                        ReporteLiquidacionesCategoria(liquidaciones);
                        break;
                    case "X":
                        break;
                }
               
            }
           
        }

        static void TraerEmpleados(EmpleadoNegocio empleadoNegocio)
        {   
            Console.WriteLine("Ingrese Legajo del empleado: ");
            string legajo = Console.ReadLine();

            try
            {
                Validaciones.validarEntero(legajo);
                Empleado e1 = empleadoNegocio.GetByLegajo(int.Parse(legajo));
                if( e1 is null)
                {
                    Console.WriteLine("No se encontro un empelado con ese legajo");
                }
                else
                {
                    Console.WriteLine("Se encontro el siguiente empleado:");
                    Console.WriteLine(e1.ToString());
                }
                
            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                



            
        }

        static void AltaEmpleado(EmpleadoNegocio empleadoNegocio)
        {
           
            try
            {
                Console.WriteLine("Ingrese el Id Empleado: ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                Console.WriteLine("Ingrese el Id empresa: ");
                string idEmpresa = Console.ReadLine();
                Validaciones.validarEntero(idEmpresa);
                Console.WriteLine("Ingrese el id Categoria: ");
                string idCategoria = Console.ReadLine();
                Validaciones.validarEntero(idCategoria);
                Console.WriteLine("Ingrese el cuil: ");
                string cuil = Console.ReadLine();
                Validaciones.validarCuil(cuil);
                Console.WriteLine("Ingrese el id fecha nacimiento:( dd/mm/yyyy ) ");
                string fechaNacimiento = Console.ReadLine();
                Validaciones.validarFecha(fechaNacimiento);
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el direccion: ");
                string direccion = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono: ");
                string telefono = Console.ReadLine();
                Validaciones.validarTelfono(telefono);
                Console.WriteLine("Ingrese el mail: ");
                string mail = Console.ReadLine();
                Validaciones.validarMail(mail);

                empleadoNegocio.AltaEmpleado(int.Parse(idEmpresa), int.Parse(idCategoria), int.Parse(cuil), DateTime.Parse(fechaNacimiento), int.Parse(id), nombre, apellido, direccion, long.Parse(telefono), mail);

            }
            catch(ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void TraerEmpresas(EmpresaNegocio empresaNegocio)
        {
            Console.WriteLine("Ingrese ID del empelado: ");
            string id = Console.ReadLine();
        
            try
            {
                Validaciones.validarEntero(id);
                Empresa e1 = empresaNegocio.GetByIdEmpleado(int.Parse(id));
                if (e1 is null)
                {
                    Console.WriteLine("No se encontro un empresa con ese id");
                }
                else
                {
                    Console.WriteLine("El empelado corresponde a la empresa: ");
                    Console.WriteLine(e1.ToString());
                }
              
            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void AltaEmpresa(EmpresaNegocio empresaNegocio)
        {
            

            try
            {
                Console.WriteLine("Ingrese el Id : ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                Console.WriteLine("Ingrese la razon social: ");
                string razonSocial = Console.ReadLine();
                Console.WriteLine("Ingrese el cuit: ");
                string cuit = Console.ReadLine();
                Validaciones.validarEntero(cuit);
                Console.WriteLine("Ingrese el domicilio: ");
                string domicilio = Console.ReadLine();
                empresaNegocio.AltaEmpresa(int.Parse(id), razonSocial, long.Parse(cuit), domicilio);

            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void TraerCategorias(CategoriaNegocio categoriaNegocio)
        {
            try
            {
                Console.WriteLine("Ingrese ID del empleado: ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                Categoria e1 = categoriaNegocio.GetByIdEmpleado(int.Parse(id));
            
                if (e1 is null)
                {
                    Console.WriteLine("No se encontro una categoria con ese id");
                }
                else
                {
                    Console.WriteLine("Pertenece a la siguente cateogria:");
                    Console.WriteLine(e1.ToString());
                }
            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }




        static void ReporteLiquidacionesCategoria(LiquidacionNegocio liquidacionNegocio)
        {
            Console.WriteLine("Ingrese el Id de la categoria: ");
            string idCategoria = Console.ReadLine();

            try
            {
                Validaciones.validarEntero(idCategoria);
                List<Liquidacion> liquidacionesCategoria = liquidacionNegocio.ReporteLiquidaciones(int.Parse(idCategoria));

                if (liquidacionesCategoria.Count == 0)
                {
                    Console.WriteLine("No se encontraron liquidaciones para esta categoria");
                }
                else
                {
                    Console.WriteLine("Se encontraron los siguientes liquidaciones: ");
                    foreach (Liquidacion l in liquidacionesCategoria)
                    {
                        Console.WriteLine(l.ToString());
                    }
                }
            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void ReporteEmpleadosEmpresa(EmpleadoNegocio empleadoNegocio)
        {
            Console.WriteLine("Ingrese el Id de la empresa: ");
            string idEmpresa = Console.ReadLine();
         
            try
            {
                Validaciones.validarEntero(idEmpresa);
                List<Empleado> empleadosEmpresa = empleadoNegocio.ReporteEmpleados(int.Parse(idEmpresa));

                if (empleadosEmpresa.Count == 0)
                {
                    Console.WriteLine("No se encontraron empleados para esa empresa");
                }
                else
                {
                    Console.WriteLine("Se encontraron los siguientes empelados: ");
                    foreach ( Empleado e in empleadosEmpresa)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void AltaCategoria(CategoriaNegocio categoriaNegocio)
        {
           
            try
            {
                Console.WriteLine("Ingrese el Id : ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                Console.WriteLine("Ingrese el nombre de la categoria: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el convenio: ");
                string convenio = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo basico: ");
                string sueldoBasico = Console.ReadLine();
                Validaciones.validarEntero(sueldoBasico);
                categoriaNegocio.AltaCategoria(int.Parse(id), nombre, convenio, double.Parse(sueldoBasico));

            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void TraerLiquidaciones(LiquidacionNegocio liquidacionNegocio)
        {
            try
            {
                Console.WriteLine("Ingrese ID empleado: ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                List<Liquidacion> listaLiquidaciones = liquidacionNegocio.GetById(int.Parse(id));
                if (listaLiquidaciones.Count == 0)
                {
                    Console.WriteLine("No se encontraron liquidaciones para ese id");
                }
                else
                {
                    Console.WriteLine("El id ingresdo posee las sigueintes liquidaciones:");
                    foreach (var item in listaLiquidaciones)
                    {
                        Console.WriteLine(item.ToString());
                    }

                }
                

            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void AltaLiquidacion(LiquidacionNegocio liquidacionNegocio)
        {
            try
            {
                Console.WriteLine("Ingrese el id de la liquidacion : ");
                string id = Console.ReadLine();
                Validaciones.validarEntero(id);
                Console.WriteLine("Ingrese el idEmpleado : ");
                string idEmpleado = Console.ReadLine();
                Validaciones.validarEntero(idEmpleado);
                Console.WriteLine("Ingrese el codigo de transferencia: ");
                string codigoTransferencia = Console.ReadLine();
                Validaciones.validarEntero(codigoTransferencia);
                Console.WriteLine("Ingrese el periodo: ");
                string periodo = Console.ReadLine();
                Validaciones.validarEntero(periodo);
                Console.WriteLine("Ingrese el bruto: ");
                string bruto = Console.ReadLine();
                Validaciones.validarEntero(bruto);
                Console.WriteLine("Ingrese el descuento : ");
                string descuentos = Console.ReadLine();
                Validaciones.validarEntero(descuentos);
                liquidacionNegocio.AltaLiquidacion(int.Parse(id), int.Parse(idEmpleado), int.Parse(codigoTransferencia), int.Parse(periodo), double.Parse(bruto), double.Parse(descuentos));

            }
            catch (ValidacionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine(" 1 - Consultar empelado con legajo");
            Console.WriteLine(" 2 - Alta empleado");
            Console.WriteLine(" 3 - Consultar empresa con codigo de empleado");
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