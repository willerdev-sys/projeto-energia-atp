//Integrantes do Grupo: Willer Luiz da Silva Lopes | Fabio - ADS - 2026/2

int quantDias, i, DiasAcimaMed = 0, DiasAbaixoMed = 0;
double ConsumoTotal = 0, MediaDiaria, MaiorConsumo = int.MinValue, MenorConsumo = int.MaxValue;
double[]Consumo;

//Sistema para validar se a quantidade de dias informado pelo usuario está fora ou dentro do intervalo
do
{
    Console.WriteLine("Quantos dias serão analisados os consumos de kWh ? Min 7");
    quantDias = int.Parse(Console.ReadLine());
}while(quantDias < 7 || quantDias > 30);

Consumo = new double[quantDias]; //Vetor para armazenar o consumo de energia de cada dia

for(i=0; i < Consumo.Length; i++)//Usuario informará o consumo de cada dia em kWh e sempre que o valor em kWh for negativo o programa fará novamente a pergunta
{
    do{
    Console.WriteLine($"Informe em kWh o consumo do dia {i+1}/{quantDias} (Lembre-se valores negativos não serão aceitos)");
    Consumo[i] = double.Parse(Console.ReadLine());
    }while(Consumo[i]<0);
    ConsumoTotal += Consumo[i];
}

for (i=0; i < Consumo.Length; i++)//Apresentação de consumos por cada dia
{
Console.WriteLine($"Consumo do dia {i+1}/{quantDias}: {Consumo[i]} kWh");
}
Console.WriteLine("O consumo total foi de " + ConsumoTotal + " kWh"); //Apresentação de consumos totais do périodo
MediaDiaria = (ConsumoTotal/quantDias);
Console.WriteLine("O consumo médio díario é de: " + MediaDiaria + " kWh"); //Media diaria de consumo

//Condições para achar o maior consumo registrado e o dia em que ele ocorreu

for (i=0; i < Consumo.Length; i++)//Repetição para descobrir os maiores consumos de energia
{
    if(Consumo[i]>MaiorConsumo || Consumo[i]==MaiorConsumo)
    {
        MaiorConsumo = Consumo[i];
    }
}
for (i=0; i < Consumo.Length; i++)//Repetição para descobrir os dias de maiores consumos de energia
{
    if(MaiorConsumo == Consumo[i])
    {
        Console.WriteLine($"O maior consumo registrado foi de: " + Consumo[i] + " kWh" + " e aconteceu no dia " + (i+1));
    }
}

//Condições para achar o menor consumo registrado e o dia em que ele ocorreu

for (i=0; i < Consumo.Length; i++)//Repetição para descobrir os menores consumos de energia
{
    if(Consumo[i] < MenorConsumo || Consumo[i]==MenorConsumo)
    {
        MenorConsumo = Consumo[i];
    }
}
for (i=0; i < Consumo.Length; i++)//Repetição para descobrir os dias de menores consumos de energia
{
    if(MenorConsumo == Consumo[i])
    {
        Console.WriteLine($"O menor consumo registrado foi de: " + Consumo[i] + " kWh" + " e aconteceu no dia " + (i+1));
    }
}

//Quantidade de dias cujo consumo ficou acima e abaixo da média do período;
for(i=0; i < Consumo.Length; i++)
{
    if(Consumo[i] > MediaDiaria)
    {
        DiasAcimaMed++;
    }
    else if (Consumo[i] < MediaDiaria)
    {
        DiasAbaixoMed++;
    }
}

Console.WriteLine("Dos dias informados ficaram " + DiasAcimaMed + " dias acima da Média do período");
Console.WriteLine("Dos dias informados ficaram " + DiasAbaixoMed + " dias abaixo da Média do período");

for (i=0; i<Consumo.Length; i++)
{
    if(Consumo[i] < MediaDiaria * 0.8)
    {
        Console.WriteLine($"No dia {i+1}/{quantDias} o consumo foi de {Consumo[i]} kWh e possui: Baixo consumo de energia");
    }
    else if (Consumo[i] >= MediaDiaria * 0.8 && Consumo[i] <= MediaDiaria * 1.2)
    {
        Console.WriteLine($"No dia {i+1}/{quantDias} o consumo foi de {Consumo[i]} kWh e possui: Consumo normal de energia");
    }
    else
    {
        Console.WriteLine($"No dia {i+1}/{quantDias} o consumo foi de {Consumo[i]} kWh e possui: Alto consumo de energia");
    }
}