using System.Net.WebSockets;
using System.Runtime.Versioning;

namespace Final_Josué_Reyes_1029024;

public class Sede
{
    public string Ubicacion { get; set; }
    public string Clientes {get; set; }

    public string Lecciones { get; set; }

   
public Sede(string Ubicacion, string Clientes, string lecciones){
    this.Ubicacion = Ubicacion;
    this.Clientes = Clientes;
    this.Lecciones = lecciones;  
}
}


