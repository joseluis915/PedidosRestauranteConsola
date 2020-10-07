using System;
using System.Threading;

namespace PedidosRestauranteC
{
    class Tarea3
    {

        static void Main()
        {
            int cubierto = 1;
            int cuchara = 1;
            int cucharaPostre = 1;
            int cuchillo = 1;
            int personas;

            void Utencilios()
            {
                Console.WriteLine("————————————————————————————————————————————");
                Console.WriteLine("La cantidad de utencilios actual es:");
                Console.WriteLine("———————————————");
                Console.WriteLine($"Cubiertos: {cubierto} ");
                Console.WriteLine($"Cuchara: {cuchara} ");
                Console.WriteLine($"CucharaPostre: {cucharaPostre} ");
                Console.WriteLine($"Cuchillos: {cuchillo} ");
                Console.WriteLine("————————————————————————————————————————————");
                Console.Write("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

            for (personas = 1; personas <= 5; personas++)
            {
                Console.WriteLine("—————————————————————————————————————————————");
                Console.WriteLine($"Pedido de la Persona #{personas}");
                Console.WriteLine("—————————————————————————————————————————————");
                Console.WriteLine("1) Realizar pedido");
                Console.WriteLine("2) Siguiente persona");
                Console.WriteLine("3) Salir");

                Console.Write("\nDigite una opcion: ");
                int menu;
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("————————————————————");
                        Console.WriteLine("1) Entrada");
                        Console.WriteLine("2) Plato fuerte");
                        Console.WriteLine("3) Postre");
                        Console.WriteLine("————————————————————");
                        Console.Write("\nDigite una opcion: ");
                        int plato;
                        plato = int.Parse(Console.ReadLine());
                        Console.WriteLine("————————————————————");

                        if (plato == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("————————————————————");
                            Console.WriteLine("1) Cubierto");
                            Console.WriteLine("2) Cuchara");
                            Console.WriteLine("3) Cuchara Postre");
                            Console.WriteLine("4) Cuchillo");
                            Console.WriteLine("5) Ninguno");
                            Console.WriteLine("————————————————————");
                            Console.Write("\nDigite una opcion: ");
                            int utencilio;
                            utencilio = int.Parse(Console.ReadLine());
                            Console.WriteLine("————————————————————");

                            if (utencilio == 1)
                            {
                                if (cubierto <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cubiertos disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cubierto--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cubierto++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            if (utencilio == 2)
                            {
                                if (cuchara <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cucharas disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cuchara--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cuchara++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            if (utencilio == 3)
                            {
                                if (cucharaPostre <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cuchara de Postre disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cucharaPostre--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cucharaPostre++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            if (utencilio == 4)
                            {
                                if (cuchillo <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cuchillo Postre disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cuchillo--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cuchillo++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            
                        }

                        if (plato == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("————————————————————");
                            Console.WriteLine("1) Cubierto");
                            Console.WriteLine("2) Cuchara");
                            Console.WriteLine("3) Cuchillo");
                            Console.WriteLine("————————————————————");
                            Console.Write("\nDigite una opcion: ");
                            int utencilio;
                            utencilio = int.Parse(Console.ReadLine());
                            Console.WriteLine("————————————————————");

                            if (utencilio == 1)
                            {
                                if (cubierto <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cubiertos disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cubierto--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cubierto++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            if (utencilio == 2)
                            {
                                if (cuchara <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cucharas disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cuchara--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cuchara++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                            
                            if (utencilio == 3)
                            {
                                if (cuchillo <= 0)
                                {
                                    Console.WriteLine("Ya no quedan Cuchillo Postre disponibles.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    cuchillo--;
                                    Utencilios();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    cuchillo++;
                                    Utencilios();
                                    Console.Clear();
                                }
                            }
                        }

                        if (plato == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("————————————————————");
                            Console.WriteLine("1) Cuchara Postre");
                            Console.WriteLine("————————————————————");
                            Console.Write("\nDigite una opcion: ");
                            int utencilio3;
                            utencilio3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("————————————————————");
                            
                            if (cucharaPostre <= 0)
                            {
                                Console.WriteLine("Ya no quedan Cuchara de Postre disponibles.");
                                Console.ReadKey();
                            }
                            else
                            {
                                cucharaPostre--;
                                Utencilios();
                                Thread.Sleep(TimeSpan.FromSeconds(10));
                                cucharaPostre++;
                                Utencilios();
                                Console.Clear();
                            }
                        }
                        break;

                    case 2:
                        Console.Clear();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("\n\n***Error*** Debes digitar una opcion del 1 al 3.");
                        Console.ReadKey();
                        Console.Clear();
                        Main();
                        break;
                }
            }
        }
    }
}