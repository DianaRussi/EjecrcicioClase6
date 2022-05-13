int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int contador = 1;
var numero = 0;
do
{
    Console.Write("Ingrese un número entre 1 y 20: ");
    numero = int.Parse(Console.ReadLine());

    
     if (numero < 0 || numero > 20)
    {
        Console.WriteLine("Valor incorrecto . el número que debes adivinar esta entre 1 y 20. Porfavor intenta de nuevo");
        contador++;
    }
    else if (numero > numeroSecreto)
    {
        Console.WriteLine("Número muy grande. Porfavor intente de nuevo");
        contador++;
    }
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