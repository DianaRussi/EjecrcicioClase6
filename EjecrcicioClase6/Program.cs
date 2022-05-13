int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21); // Generar un número secreto

//Declaración e inicialización de variables
int intentos = 1; //variable para almacenar numero de intentos
int numero; // Variable que almacena el valor ingresado por el usuario
do
{
    Console.Write("Ingrese un número entre 1 y 20: "); //Pedir al usuario que ingrese un número
    numero = int.Parse(Console.ReadLine()); // Guardar número ingresado por el usuario en la variable numero

    if (numero < 0 || numero > 20)
    {
        //Imprime este mensaje cuando número número ingresado no esta entre 1 y 20
        Console.WriteLine("Valor incorrecto . el número que debes adivinar esta entre 1 y 20. Porfavor intenta de nuevo");
        intentos++; //Aumentar en 1 el número de intentos erroneos
    }
    else if (numero > numeroSecreto)
    {
        //Imprime este mensaje cuando número ingresado es mayor al numero secreto
        Console.WriteLine("Número muy grande. Porfavor intente de nuevo");
        intentos++; 
    }

    else if (numero < numeroSecreto)
    {
        //Imprime este mensaje cuando número ingresado es menor al numero secreto
        Console.WriteLine("Número muy pequeño. Porfavor intente de nuevo");
        intentos++;
    }
    else
    {
        // Imprime este mensaje cuando se adivine el número secreto
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}. Lo has logrado en {intentos} intentos!!");
    }
}
while (numero != numeroSecreto); 

// Repo https://github.com/DianaRussi/EjecrcicioClase6.git