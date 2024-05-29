namespace Final_Josué_Reyes_1029024;

public class Gimnasio
{
    Sede[] Gyms = new Sede[10]; //arreglo de sedes


    public void CrearSede(int s, int i) //metodo para crear un gimnasio
    {
        Console.WriteLine($"Ingrese la ubicación de la sede #{s}"); //se solicita la ubicacion
        string ubicacion = Console.ReadLine();

        Console.WriteLine($"Ingrese los clientes separandolos con una coma"); //se solicitan los clientes
        string clientes = Console.ReadLine();
       

        Console.WriteLine("Ingrese las lecciones separandolas con una coma"); //Se solicitan las lecciones
        string lecciones = Console.ReadLine();
        

        Sede sede1 = new Sede(ubicacion, clientes, lecciones); //creacion del objeto
        Gyms[i] = sede1; //asignacion del objeto en el arreglo creado al principio

    }

   
    public void imprimirClientes()
    {

        for (int i = 0; i < Gyms.Length; i++)
        {

            if (Gyms[i] != null)
            {
                Console.WriteLine($"Clientes del gimnasio #{i+1}: {Gyms[i].Clientes}" );
            }
            else
            {
                Console.Write("");
            }
        }

    }

    public void imprimirLecciones()
    {

        for (int i = 0; i < Gyms.Length; i++)
        {

            if (Gyms[i] != null)
            {
                Console.WriteLine($"Lecciones del gimnasio #{i+1}: {Gyms[i].Lecciones}" );
            }
            else
            {
                Console.Write("");
            }
        }

    }

    public void imprimirSedes()
    {

        for (int i = 0; i < Gyms.Length; i++)
        {

            if (Gyms[i] != null)
            {
                Console.WriteLine($"Sede #{i+1}: {Gyms[i].Ubicacion}" );
            }

        }

    }
}
