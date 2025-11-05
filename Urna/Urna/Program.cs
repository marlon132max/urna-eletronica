using System;

using System;

class UrnaVoto
{
    static void Main()
    {
        // Corrigindo o nome das variáveis
        int voto;
        int kalil = 0, zema = 0, tiririca = 0, branco = 0, nulo = 0;
        double continuar;
        Console.WriteLine(" URNA VOTE COM SABEDORIA E RESPONSABILIDADE ");
        Console.WriteLine("1 - Kalil");
        Console.WriteLine("2 - Zema");
        Console.WriteLine("3 - Tiririca Júnior");
        Console.WriteLine("4 - Voto em Branco");
        Console.WriteLine($"Data e hora: {DateTime.Now}");

        do
        {
            Console.Write("Digite o número do seu voto: ");
            voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case 1:
                    kalil++;
                    Console.WriteLine("Você votou em Kalil!");
                    break;
                case 2:
                    zema++;
                    Console.WriteLine("Você votou em Zema!");
                    break;
                case 3:
                    tiririca++;
                    Console.WriteLine("Você votou em Tiririca Júnior!");
                    break;
                case 4:
                    branco++;
                    Console.WriteLine("Você votou em Branco!");
                    break;
                default:
                    nulo++;
                    Console.WriteLine("Voto nulo!");
                    break;
            }

            Console.Write("Deseja votar novamente? (s/n): ");
            continuar = double.Parse(Console.ReadLine());

        } while (continuar == 's' || continuar == 'S');
        Console.WriteLine("RESULTADO DA VOTAÇÃO:");
        Console.WriteLine("Kalil: {kalil} votos");
        Console.WriteLine("Zema: {zema} votos");
        Console.WriteLine("Tiririca Júnior: {tiririca} votos");
        Console.WriteLine("Brancos: {branco} votos");
        Console.WriteLine("Nulos: {nulo} votos");
        Console.WriteLine("FIM DA VOTAÇÃO SUA VOTAÇAO E SIGILOSA!");
    }
}
