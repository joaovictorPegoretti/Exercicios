Produto[] produtos = new Produto[5];                            // Array com base na struct Produtos
int op = 0;                                                    // Variavel para as opçoes


Console.WriteLine(">>> BEM VINDO AO SEU ESTOQUE <<<");        // --| INÍCIO |--
while (op != 4)                                              // Estrutura de repetição enquanto a opção for diferente de 4 
{
    Console.WriteLine("\n  ----| MENU |----");             // --| MENU |--
    Console.WriteLine("1- Cadastrar produtos(Máximo de 5)\n2- Listar seus produtos\n3- Sair");
    Console.WriteLine(">>(Selecione atráves dos números)<<\n--------------------------------");
    Console.Write("Digite sua opção:");
    op = int.Parse(Console.ReadLine()!);     // Irá ler a resposta da opção

    switch (op)                             // Estrutura de casos com base nas respostas do MENU
    {
        case 1:                           // Caso seja 1
            Console.Clear();             // Limpa o que veio antes
            CadastrarProduto();         // Chama a função CadastrarProduto();
            break;                     // Qeubra o caso

        case 2:                      // Caso seja 2 
            Console.Clear();        // Limpa o que veio antes
            ListarProdutos();      // Chama a função ListarProdutos();
            break;                // Quebra o caso

        case 3:                 // Caso seja 3
            Console.Clear();   // Limpa o que veio antes
            Console.WriteLine("Obrigado por usar nosso código");
            Console.WriteLine("(Pressione qualquer botão para fechar)");
            Console.ReadKey();// Lê qualquer tecla que você clicar
            break;           // Quebra o caso
        
        default:           // Caso não seja nenhuma opção
            Console.Clear();  // Limpa o que veio antes
            Console.WriteLine("Opção inválida");
            break;           // Quebra o caso
    }

}
void ListarProdutos()    //Função para Listar os produtos
{ 
    Console.Clear();   // Limpa o que veio antes
    int i = 1;        // Variavel para repetição
    foreach (var dados in produtos)  // Estrututa de repetição com base nos valores do Array produtos para o var dados
    {
        Console.WriteLine("---SUA LISTA DE ESTOQUE---");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"{i}° PRODUTO:");
        Console.WriteLine($"Nome: {dados.nome}\nPreço: R${dados.preco}\nCódigo: {dados.cod}");
        Console.WriteLine("--------------------------------");
        i++;
    }
}


void CadastrarProduto()      // Função para Cadastrar Produtos
{
    for(int i = 0; i < produtos.Length; i++)   // Estrututa de repetição enquanto i for menor que produtos.Lenght(5)
    {
        Console.Clear();
        Console.Write($"Qual o nome do {i+1}° Produto:");
        produtos[i].nome  = Console.ReadLine()!;   // Lê o nome digitado pelo usuário

        Console.Write($"Qual o valor do(a) {produtos[i].nome}:");
        produtos[i].preco = decimal.Parse(Console.ReadLine()!);  // Lê o valor digitado pelo usuário e converte de string para decimal

        Console.Write($"Qual o código do(a) {produtos[i].nome}:");
        produtos[i].cod = Console.ReadLine()!;  // Lê o código do produto digitado pelo usuário
    }
}

public struct Produto        // Estrututa de armazenamento de variaveis
{                           
    public string cod;     // Variavel para código
    public string nome;   // Variavel para nome
    public decimal preco;// Variavel para preço

}