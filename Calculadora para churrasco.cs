namespace Calculadora_do_Churras
{
    internal class Program
    {
        static Carne[] carnes = new Carne[10];           // Array carnes com base na Struct Carne
        static Bebida[] bebidas = new Bebida[10];       // Array bebidas com base na Struct Bebida
        static int convidados, op = 0, quantc, quantb; // Variaiveis convidados = Para a quantidade de convidados
                                                      // op = Para as opções, quantc = Para quantidade de carne
                                                     //quantb = Para quantidade de bebidas

        static void Main(string[] args)
        {

            Console.WriteLine("              BORA FAZER UM CHURRAS?");           // --| INÍCIO |--   
            Console.WriteLine("mas antes, sempre bom fazer um cálculo antes da facada!!!");

            Console.WriteLine("------------------------------------------------------");

            while (op != 4)   // Estrutura de repetição enquanto a opção for diferente de 4
            {
                Console.WriteLine("Escolha sua opção:(Com base nos números)"); // --| MENU |--
                Console.WriteLine("1- Quantidades de convidados");
                Console.WriteLine("2- Qual carne e quantos Kg");
                Console.WriteLine("3- Qual bebida e quantas");
                Console.WriteLine("4- Resultado");
                Console.Write("\nR:");
                op = int.Parse(Console.ReadLine()!); // Lê a resposta da opção digitada pelo usuário

                switch(op)  // Estrutura de opções com base nas respostas
                {
                    case 1:  // Caso seja 1
                        Console.Clear();  // Limpa o que veio antes
                        Console.Write("Digite quantos convidados iram vim no churrasco: ");
                        convidados = int.Parse(Console.ReadLine()!);// Limpa o que veio antes
                        Console.WriteLine("\nPressione qualquer tecla para voltar");
                        Console.ReadKey();            // Lê qualquer tecla que você clicar
                        Console.Clear();             // Limpa o que veio antes
                        break;                      // Quebra o caso

                    case 2:                       // Caso seja 2
                        Console.Clear();         // Limpa o que veio antes
                        Carnes();               // Chama a função Carnes()
                        break;                 // Quebra o caso

                    case 3:                  // Caso seja 3
                        Console.Clear();    // Limpa o que veio antes
                        Bebidas();         // Chama a função Bebidas()
                        break;            // Quebra o caso

                    case 4:             // Caso seja 4
                        Console.Clear();//limpa o que veio antes
                        Resultado();  // Chama a função Resultado()
                        break;       // Quebra o caso

                    default:       // Caso não seja nenhuma opção
                        Console.Clear();   // Limpa o que veio antes
                        Console.Write("              Opção inválida");
                        Console.WriteLine("Pressione qualquer tecla para voltar");
                        Console.ReadKey(); // Lê qualquer tecla que você clicar
                        Console.Clear();  // Limpa o que veio antes
                        break;           // Quebra o caso
                }
            }
            }

       static void Carnes()     // Função para cadastrar as carnes e sua quantidade para o churrasco
        {
            Console.WriteLine("QUANTOS tipos de carnes vai usar no Churrasco:");
            quantc = int.Parse(Console.ReadLine()!);    // Lê quantos tipos de carne o usuário deseja
            Console.Clear();                           // Limpa o que veio antes

            for (int i = 0; i < quantc; i++)         // Estrutura de repetição com base na quantidade de tipo que o usuário quer 
            {
                Console.Write("Qual carne deseja(Ex: Linguinça, Picanha...): ");
                carnes[i].tipocarne = Console.ReadLine()!; // Lê qual o tipo de carne deseja

                Console.Write($"\nQual o preço da(o) {carnes[i].tipocarne} (Ex: 29.90): ");
                carnes[i].precocarne = decimal.Parse(Console.ReadLine()!);  // Lê a preço do tipo de carne desejado

                Console.Write($"\nQual a quantidade de {carnes[i].tipocarne} em KG (Ex: 2.5 KG): ");
                carnes[i].quantcarne = decimal.Parse(Console.ReadLine()!);    // Lê a quantidade em KG que deseja da carne
                Console.Clear(); // Limpa o que deseja 
            }

            Console.WriteLine("     Todas as carnes adicionadas");
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();// Lê qualquer tecla que você clicar
            Console.Clear(); // Limpa o que veio antes
            }

        static void Bebidas()  // Função para cadastrar as bebidas e sua quantidade para o churrasco
        {
            Console.Write("QUANTOS tipos de bebidas vai ter no Churrasco:");
            quantb = int.Parse(Console.ReadLine()!);  // Lê quantos tipos de bebida o usuário deseja
            Console.Clear();                         // Limpa o que veio antes

            for (int i = 0; i < quantb; i++)        // Estrutura de repetição com base na quantidade de tipo da bebida que o usuário quer
            {
                Console.Write("Qual bebida deseja (Ex: Brahma, heineken...): ");
                bebidas[i].tipobebida = Console.ReadLine()!;  // Lê qual o tipo  de bebida deseja

                Console.Write($"\nQual o preço da(o) {bebidas[i].tipobebida} (Ex: 4.90): ");
                bebidas[i].precobebida = decimal.Parse(Console.ReadLine()!);  // Lê o preço do tipo de bebida desejado

                Console.Write($"\nQual a quantidade de {bebidas[i].tipobebida} em Un (Ex: 12 Un: ");
                bebidas[i].quantbebida = int.Parse(Console.ReadLine()!);  // Lê a quantidade em Un que deseja de bebida
                Console.Clear();   // Limpa o que veio antes
            }

            Console.WriteLine("     Todas as bebidas adicionadas");
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();  // Lê qualquer tecla que você clicar
            Console.Clear();   // Limpa o que veio antes
        }

        static void Resultado()   // Função para calcular quanto ficara o valor por pessoa na parte da carne e bebida
        {
            Console.WriteLine($"Sendo {convidados} convidados para o churrasco ");
            Console.WriteLine("\nFicara por pessoa esses valores:");
            decimal resulc = 0, resulb = 0;         // Variaiveis resulc = Irá lê o valor calculado para cada pessoa na parte da carne
                                                   // resulb = Irá lê o valor calculado para cada pessoa na parte da bebida
            Console.WriteLine("\n         PARTE DA CARNE");
            Console.WriteLine("-----------------------------------");
            
            for(int i = 0;i < quantc;i++)         // Estrutura de repetição com base na quantidade de tipo da carne que o usuário quer
            {
                resulc += (carnes[i].quantcarne * carnes[i].precocarne);  // Calcula a quantidade vezes o preço da carne e a varariavel resulc absorve
            }

            Console.WriteLine($"\nPOR PESSOA: R${resulc/convidados}");  // Mostra o valor calculado da carne

            Console.WriteLine("\n         PARTE DA BEBIDA");
            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < quantb; i++)                          // Estrutura de repetição com base na quantidade de tipo de bebida que o usuário quer
            {
                resulb += (bebidas[i].quantbebida * bebidas[i].precobebida);  // Calcula a quantidade vezes o preço da bebida e a varariavel resulb absorve
            }
            Console.WriteLine($"\nPOR PESSOA: R${resulb/convidados}");       // Mostra o valor calculado da bebida

        }
    }
      struct Carne      // Estrutura de armazenamento de variaveis Carne
    {
        public decimal precocarne;  // Variavel para o preço da carne
        public string tipocarne;   // Variavel para o tipo da carne
        public decimal quantcarne;// Variavel para a quantidade da carne
    }

    public struct Bebida        // Estrutura de armazenamento de variaveis Bebida
    {
        public decimal precobebida; // Variavel para o preço da bebida
        public string tipobebida;  // Variavel para o tipo da bebida
        public int quantbebida;   // Variavel para a quantidade de bebida

    }
}