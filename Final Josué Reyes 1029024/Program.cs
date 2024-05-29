using Final_Josué_Reyes_1029024;
class Program
{
    static void Main(string[] args)
    {
        Gimnasio tools = new Gimnasio();

        int p;
        do
        {       //menu realizado con un ciclo do while
            Console.WriteLine("------Menu------");
            Console.WriteLine("");
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("1. Crear sede nueva");
            Console.WriteLine("2. Mostrar Clientes");
            Console.WriteLine("3. Mostrar Lecciones");
            Console.WriteLine("4. Mostrar Sedes");
            Console.WriteLine("5. Salir");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:
                    int cn = 0; //parametro de control para el ciclo while
                    Console.WriteLine("Ingrese cuantas sedes tendra el gimnasio (maximo 10)");
                    int n = int.Parse(Console.ReadLine()); //solicita cuantas sedes desea crear.
                    while (cn == 0) //validacion de que no se sobrepase el limite de sedes
                    {

                        if (n > 10)
                        {
                            Console.WriteLine("Se excedio el numero de sedes, intentelo de nuevo");
                            n = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            int s = 1;
                            for (int i = 0; i < n; i++) //ciclo for para agregar las sedes que solicite el usuario
                            {                           //tomando como parametro la variable n.
                                tools.CrearSede(s,i);
                                s++;
                            }
                            cn = 1;
                        }
                    }
                    break;

                case 2:
                   tools.imprimirClientes(); //impresion de los clientes de cada sede
                    break;

                    case 3:
                        tools.imprimirLecciones(); //impresion de las lecciones de cada sede
                        break;

                    case 4:
                        tools.imprimirSedes(); //impresion de la ubicacion de cada sede
                        break;

                    default: //opción salir
                        Console.WriteLine("");
                        Console.WriteLine("Vuelva pronto");
                        break;
            }
        } while (p != 5);
    }
}