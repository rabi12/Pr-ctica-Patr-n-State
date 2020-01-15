using System;
using System.Collections.Generic;
using System.Text;

namespace Estados
{
    class DesplegarMenu
    {
        public void desplegarMenu()
        {
            bool flag = false;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una opcion...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] Crear Alarma Activa");
                Console.WriteLine("[B] Crear Alarma Inactiva");
                Console.WriteLine("[Esc] Salirtnn");
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Estado Inicial Alarma Activa");

                        crearAlarmaActiva();

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Estado Inicial Alarma Inactiva");

                        EstadoAlarmaInactiva estadoInicialInactiva = new EstadoAlarmaInactiva();
                        Alarma alarmaInactivada = new Alarma(estadoInicialInactiva);

                        crearAlarmaInactiva();

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        flag = true;

                        break;
                }
            } while (!flag);
        }

        private void crearAlarmaActiva()
        {
            EstadoAlarmaActiva estadoInicial = new EstadoAlarmaActiva();
            Alarma alarma = new Alarma(estadoInicial);
            estadoInicial.setAlarma(alarma);
            desplegarMenuAlarma(alarma);
        }

        private void crearAlarmaInactiva()
        {
            EstadoAlarmaInactiva estadoInicialInactiva = new EstadoAlarmaInactiva();
            Alarma alarmaInactivada = new Alarma(estadoInicialInactiva);
            estadoInicialInactiva.setAlarma(alarmaInactivada);
            desplegarMenuAlarma(alarmaInactivada);
        }

        private void desplegarMenuAlarma(Alarma alarma)
        {
            bool flag = false;
            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione una opcion...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] Activar");
                Console.WriteLine("[B] Inactivar");
                Console.WriteLine("[Esc] Salirtnn");
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Activar Alarma");


                        string resultado = alarma.activar();
                        Console.WriteLine(resultado);

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Inactivar Alarma");

                        string resultadoActivar = alarma.desactivar();
                        Console.WriteLine(resultadoActivar);

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        flag = true;

                        break;
                }
            } while (!flag);
        }
    }
}
