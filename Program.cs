using Tareas;

var tareasPendientes = new List<Tarea>();
var tareasRealizadas = new List<Tarea>();

var tarea1 = new Tarea()
{
    Id=1,
    Descripcion= "Tarea1",
    Duracion= 20
};
var tarea2 = new Tarea(){
    Id=2,
    Descripcion= "Ejercicio",
    Duracion= 10
};
var tarea3 = new Tarea(){
    Id=3,
    Descripcion= "Tarea3",
    Duracion= 40
};

tareasPendientes.Add(tarea1);
tareasPendientes.Add(tarea2);
tareasPendientes.Add(tarea3);

int idABuscar = 2;

Tarea tarea = null;

foreach (var tareaPendiente in tareasPendientes)
{
    if (idABuscar == tareaPendiente.Id)
    {
        tarea = tareaPendiente;
        break;
    }
}

if (tarea != null)
{
    tareasRealizadas.Add(tarea);
    tareasPendientes.Remove(tarea);
}

string descripcionABuscar= "Tarea";
bool encontrada = false;

foreach (var tareaPendiente in tareasPendientes)
{
    if (tareaPendiente.Descripcion.Contains(descripcionABuscar))
    {
        Console.WriteLine($"ID: {tareaPendiente.Id}, Descripcion: {tareaPendiente.Descripcion}, Duracion: {tareaPendiente.Duracion}" );
        encontrada = true;

    }
    
}

if (!encontrada)
{
    Console.WriteLine("No se encontraron tareas con esa descripcion");
}