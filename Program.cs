Console.WriteLine("Inserta tu nombre:");
string nombre;
const string inicio = "Ahora inserte el número que cree que se ha generado:";
nombre = Console.ReadLine();
Console.WriteLine($@"Bienvenido {nombre}, estás apunto de jugar a un juego el cual consiste en adivinar un número entre el 1 y el 15
Las reglas son las siguientes:
- Tienes 3 oportunidades en total, es decir, veces que puedes fallar el número.
- Si te pasas en cuanto al número generado se te quitará una vida y se indicará que el numero es menor.
- Si te quedas corto en cuanto al número generado se te quitará una vida y se indicará que el número es mayor.");

Random rnd = new Random();
int numeroParaAdivinar = rnd.Next(1, 15);

Console.WriteLine(numeroParaAdivinar);
Console.WriteLine(inicio);

bool ganar = false;
int vidas = 3;
for (vidas = 3; vidas > 0; vidas--)
{
    int numeroElegido;
    string eleccionUsuario;

    eleccionUsuario = Console.ReadLine();
    numeroElegido = Int32.Parse(eleccionUsuario);

    Console.Write($"El número elegido ha sido el {numeroElegido}. ");
    if (numeroElegido == numeroParaAdivinar)
    {
        ganar = true;
        break;
    }
    else
    {
        if (numeroElegido < numeroParaAdivinar)
        {
            Console.WriteLine($@"El numero es mayor.
        Te quedan {vidas - 1} oportunidades.");
            ganar = false;
        }
        else
        {
            Console.WriteLine($@"El numero es menor.
        Te quedan {vidas - 1} oportunidades.");
            ganar = false;
        }
    }
};

if (ganar == true)
{
    Console.WriteLine(@$"Felicidades {nombre}, el número era el {numeroParaAdivinar}.");
};
if (ganar == false)
{
    Console.WriteLine(@$"Se te han acabado las oportunidades {nombre}, el número era el {numeroParaAdivinar}.
    Prueba suerte otra vez.");
};
