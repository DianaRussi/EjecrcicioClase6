int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21); // Generar un número secreto

//Declaración e inicialización de variables
int contador = 1;
var numero = 0;
do
{
    Console.Write("Ingrese un número entre 1 y 20: "); //Pedir al usuario que ingrese un número
    numero = int.Parse(Console.ReadLine()); // Guardar número ingresado por el usuario en la variable numero

    //Entra en este if si el número número ingresado no esta entre 1 y 20
    if (numero < 0 || numero > 20)
    {
        Console.WriteLine("Valor incorrecto . el número que debes adivinar esta entre 1 y 20. Porfavor intenta de nuevo");
        contador++; //Aumentar en 1 el número de intentos erroneos
    }
    //Entra en este if si el número ingresado es mayor al que se debe adivinar
    else if (numero > numeroSecreto)
    {
        Console.WriteLine("Número muy grande. Porfavor intente de nuevo");
        contador++; //Aumentar en 1 el número de intentos erroneos
    }

    //Entra en este if si el número ingresado es menor al que se debe adivinar
    else if (numero < numeroSecreto)
    {
        Console.WriteLine("Número muy pequeño. Porfavor intente de nuevo");
        contador++;
    }
    else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}. Lo has logrado en {contador} intentos!!");
    }
}
while (numero != numeroSecreto);

// Repo https://github.com/DianaRussi/EjecrcicioClase6.git