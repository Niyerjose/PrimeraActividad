using System;

namespace PrimerPunto
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;

            do
            {
                Console.WriteLine("1. Primer Punto");
                Console.WriteLine("2. Segundo Punto");
                Console.WriteLine("3. Tercer Punto");
                Console.WriteLine("4. Salir");

                Console.WriteLine("Ingrese la opcion que desea realizar(1/2/3/4): ");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        PrimerPunto();
                        break;
                    case 2:
                        Console.Clear();
                        SegundoPunto();
                        break;
                    case 3:
                        Console.Clear();
                        TercerPunto();
                        break;
                    default:
                        Console.WriteLine("Fin.");
                        break;
                }

            } while (op != 4);
        }

        private static void PrimerPunto()
        {
            try
            {
                Console.WriteLine("ADVERTENCIA: Ingrese los valores decimales con COMA(,) EJ (3,1) ");

                double nota1, nota2, nota3, promedio;
                Console.WriteLine("Ingrese la primera nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la tercera nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio < 3)
                {
                    Console.WriteLine("La nota del estudiante fue: "+promedio);
                    Console.WriteLine("El estudiante perdio la materia");
                }
                else
                {
                    Console.WriteLine("La nota del estudiante fue: " + promedio);
                    Console.WriteLine("El estudiante ganó la materia");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al ingresar los datos!......");
            }

        }

        private static void SegundoPunto()
        {
            try
            {
                int edad;
                string sexo;
                double pulsacion;
                Console.WriteLine("Ingrese su edad: ");
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese su sexo (f/m)");
                sexo = Console.ReadLine();

                if (sexo.Equals("f"))
                {
                    pulsacion = (220 - edad) / 10;
                }
                else if (sexo.Equals("m"))
                {
                    pulsacion = (210 - edad) / 10;
                }
                else
                {
                    pulsacion = 0;
                }

                Console.WriteLine("Las pulsaciones que debe tener esta persona por cada 10 segundos de ejercicio aeróbico es: "+ pulsacion);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error al ingresar los datos!......");
            }

        }

        private static void TercerPunto()
        {
            string nombreCliente,numeroCuenta;
            double saldoApetura,consignarSaldo,retirarSaldo;

            Console.WriteLine("Información del cliente");

            Console.WriteLine("Ingrese el nombre del cliente: ");
            nombreCliente = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de cuenta: ");
            numeroCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo de apertura: ");
            saldoApetura = Convert.ToDouble(Console.ReadLine());

            int op;

            do
            {
                Console.WriteLine("1. Consignar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Terminar Proceso");
                Console.WriteLine("Ingrese la opcion que desea realizar(1/2/3): ");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad que desea cosignar: ");
                        consignarSaldo = Convert.ToDouble(Console.ReadLine());
                        if (consignarSaldo < 0)
                        {
                            Console.WriteLine("Intenga ingresar un valor menor a 0");
                        }
                        else
                        {
                            saldoApetura = (saldoApetura + consignarSaldo);
                        }
                        Console.WriteLine("El saldo ahora es de: "+ saldoApetura);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cantidad que desea retirar: ");
                        retirarSaldo = Convert.ToDouble(Console.ReadLine());
                        if(retirarSaldo> saldoApetura || retirarSaldo<0)
                        {
                            Console.WriteLine("Cantidad insuficiente");
                        }
                        else
                        {
                            saldoApetura = (saldoApetura - retirarSaldo);
                        }
                        Console.WriteLine("El saldo ahora es de: " + saldoApetura);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            } while (op != 3);

        }
    }
}
