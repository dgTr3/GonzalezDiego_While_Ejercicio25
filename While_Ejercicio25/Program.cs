Console.WriteLine("Simular un menú que se repita hasta que el usuario elija salir.");
int opcion = 0;
while (opcion !=3)
{
    Console.WriteLine("1. saludar");
    Console.WriteLine("2. Mostrar hora");
    Console.WriteLine("3. Salir");
    Console.WriteLine("opcion: ");
    opcion = int.Parse(Console.ReadLine());
}