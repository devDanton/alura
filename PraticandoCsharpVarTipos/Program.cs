int numero = 42;

int quantidade;
quantidade = 40;

var caracter = 'a';

Console.WriteLine(quantidade);
quantidade++;
Console.WriteLine(quantidade);

/* Conversão implícita
* Tipos menores para tipos maiores
*/
long numeroGrande = quantidade;

/* Conversão explícita (cast)
* Tipos maiores para tipos menores
*/
byte numeroGrande2 =(byte) numeroGrande;

// Divisão entre inteiros
int valorUnitario = 30/4;
Console.WriteLine(valorUnitario);

/* Divisão entre ponto flutuante
* Pelo menos um dos valores deve ser do tipo ponto flutuante para que o resultado também seja ponto flutuante
*/
double valorFlutuante = 30.0/4;
Console.WriteLine(valorFlutuante);
PrintLinha();

/* Calculando a idade
* Imagine que você está desenvolvendo um sistema para um cadastro de usuários. Uma das funcionalidades desse sistema é calcular a idade do usuário para oferecer conteúdo e serviços adequados à sua faixa etária.
* Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.
* Exemplo de entrada:
*   int anoNascimento = 1997; 
* Saída esperada (Supondo que o ano atual seja 2025):
*   Sua idade é: 28 anos 
*/

int anoNascimento = 1997;
int anoAtual = DateTime.Now.Year - anoNascimento;
Console.WriteLine($"Sua idade é: {anoAtual} anos");
PrintLinha();

/* Você foi contratado por uma empresa beneficente, que recebe doações de pessoas físicas e jurídicas para ajudar comunidades carentes. Algumas dessas doações são anônimas, e outras são registradas com os dados do doador. Além disso, as doações são depositadas em dois tipos de contas: corrente ou poupança. Recentemente, uma doação anônima no valor de R$500 foi feita para a conta poupança da empresa.

Crie um programa que:

Declare uma variável para armazenar o valor recebido da doação.
Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
    * Use P para conta poupança.
    * Use C para conta corrente
Saída esperada:
    Valor recebido: R$500 
    Doação anônima: True 
    Tipo de conta: P 
 */

float varorDoacao = 500.00f;
bool doacaoAnonina = true;
char tipoConta = 'P';

Console.WriteLine($"Valor recebido: R${varorDoacao}");
Console.WriteLine($"Doação anônima: {doacaoAnonina}");
Console.WriteLine($"Tipo de conta: {tipoConta}");

string v = "-";
PrintLinha();

void PrintLinha()
{
    Console.WriteLine(String.Empty.PadLeft(Console.BufferWidth, '-'));
}


/*Você trabalha para uma empresa de turismo que organiza passeios e viagens internacionais. Muitos dos destinos oferecidos pela empresa utilizam o sistema imperial de medidas, onde as distâncias são fornecidas em milhas. No entanto, os clientes brasileiros estão mais familiarizados com o sistema métrico, que utiliza quilômetros.

Para facilitar a comunicação com os clientes, sua missão é criar um sistema de conversão de distâncias que transforme milhas em quilômetros, utilizando a fórmula:

1 milha = 1.60934 quilômetros.

Crie um programa que:

Declare uma variável que receba o valor das milhas.
Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
Exiba o resultado no console.
Saída esperada:

10 milhas equivalem a 16,0934 quilômetros. */

float milha = 1.60934f;

float distanciaEmMilhas = 10f;
float distanciaEmQuilometros = distanciaEmMilhas * milha;

Console.WriteLine($"{distanciaEmMilhas} milhas equivalem a {distanciaEmQuilometros} quilômetros.");
PrintLinha();

