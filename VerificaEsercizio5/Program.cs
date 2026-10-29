
Random rand = new Random();

int randNum = rand.Next(0, 100);
int numInput = 0;
Console.WriteLine(randNum);
Console.Write("Indovina il numero: ");
numInput = Convert.ToInt32(Console.ReadLine());

do
{

    if (numInput != randNum)
    {

        if (numInput < randNum)
        {
            Console.WriteLine("Il numero randomico è maggiore");
        }
        else
        {
            Console.WriteLine("Il numero randomico è minore");
        }
        Console.WriteLine("Numero errato, riprova: ");
        numInput = Convert.ToInt32(Console.ReadLine());

    }

} while (numInput != randNum);

Console.WriteLine("Congratulazioni, hai indovinato!");