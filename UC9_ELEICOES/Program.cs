int total, votos;
int mateus, jose, maria, amanda;
double porcenmateus, porcenjose, porcenmaria, porcenamanda;
int ganhador = 0;
int ganhador_votos = 0;


votos = 0;
mateus = 0;
jose = 0;
maria = 0;
amanda = 0;
total = 0;

while (votos != 5)
{
    Console.WriteLine("===============================================================");
    Console.WriteLine("|                         Votação                             |");
    Console.WriteLine("|                                                             |");
    Console.WriteLine("|           Para votar no candidato Mateus Pressione 1        |");
    Console.WriteLine("|           Para votar no candidato Jose Pressione 2          |");
    Console.WriteLine("|           Para votar na candidata Maria Pressione 3         |");
    Console.WriteLine("|           Para votar na candidata Amanda Pressione 4        |");
    Console.WriteLine("|                                                             |");
    Console.WriteLine("|             Para encerrar a votação pressione 5             |");
    Console.WriteLine("===============================================================");
    votos = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (votos)
    {
        case 1:

            Console.WriteLine("Voto para candidato Mateus ");
            mateus++;
            if (mateus > ganhador_votos)
            {
                ganhador_votos = mateus;
                ganhador = 1;
            }
            break;

        case 2:
            Console.WriteLine("Voto para candidato Jose ");
            jose++;
            if (jose > ganhador_votos)
            {
                ganhador_votos = jose;
                ganhador = 2;
            }
            break;

        case 3:
            Console.WriteLine("Voto para candidata Maria ");
            maria++;
            if (maria > ganhador_votos)
            {
                ganhador_votos = maria;
                ganhador = 3;
            }
            break;

        case 4:
            Console.WriteLine("Voto para candidata Amanda ");
            amanda++;
            if (amanda > ganhador_votos)
            {
                ganhador_votos = amanda;
                ganhador = 4;
            }
            break;


        default:
            Console.WriteLine("===============================================================");
            Console.WriteLine("|                         Votação                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                  Votação encerrada                          |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|           Pressione qualquer tecla para continuara          |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("===============================================================");
            Console.ReadLine();
            break;
    }

}

Console.Clear();

Console.WriteLine("===============================================================");
Console.WriteLine("|                                                             |");
Console.WriteLine("|                    Resultado da Votação                     |");
Console.WriteLine("|                                                             |");
Console.WriteLine("===============================================================");


total = mateus + jose + maria + amanda;
Console.WriteLine("Esta votação teve um total de " + total + " votos");

Console.WriteLine("Resultado de cada candidato");
Console.WriteLine("Mateus -> " + mateus);
Console.WriteLine("Jose -> " + jose);
Console.WriteLine("Maria -> " + maria);
Console.WriteLine("Amanda -> " + amanda);
Console.WriteLine("");
Console.WriteLine("> % votos (mateus): " + ((mateus * 100) / total).ToString("F") + "%");
Console.WriteLine("> % votos (jose): " + ((jose * 100) / total).ToString("F") + "%");
Console.WriteLine("> % votos (maria): " + ((maria * 100) / total).ToString("F") + "%");
Console.WriteLine("> % votos (amanda): " + ((amanda * 100) / total).ToString("F") + "%");
Console.WriteLine("");
Console.WriteLine("O vencedor da eleição é: " + ganhador + " com " + ganhador_votos + " votos");

if (mateus == ganhador_votos && ganhador != 1)
{
    Console.WriteLine("");
}