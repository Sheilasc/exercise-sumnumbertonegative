//Crear un programa que sume todos aquellos números leídos desde el teclado mientras no sean negativos
internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        int num = Leer("Ingrese un numero : ");
        
        while (num >=0)
        {
        suma = suma + num;
        Console.WriteLine("Ingresa otro numero :");
        num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("La suma es: " +suma);
    }

        public static int Leer(string mensaje)
    {       
        for (int intentos = 0; intentos < 3; intentos++)
        {
            Console.WriteLine(mensaje);
                string numeroComoString = Console.ReadLine();
                int valorReal = 0;
                bool sePuedeConvertir = Int32.TryParse(numeroComoString, out valorReal);

                if (sePuedeConvertir)
                {
                    return valorReal;
                }
                else
                {
                    Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
                }
        }
        throw new Exception("No se pude leer nada");
    }
}