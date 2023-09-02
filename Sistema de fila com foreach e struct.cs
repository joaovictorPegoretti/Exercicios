namespace Fila_de_atedimento {


    internal class Program
    {
        private static void Main(string[] args)
        {
            Dados[] cliente = new Dados[5];     // Array com base na struct Dados
            int op = 0;                        // Variavel para as opções de menu

                Console.WriteLine("      BEM VINDO AO CENTRO DE ATENDIMENTO");// --| MENU |--
            while (op != 4)                                                  // Estrutura de repetição para quando a opção for diferente de 4
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Selecione sua opção:\n1- Cadastrar\n2- Listar a fila\n3- Atendimento\n4- Sair"); // Opções do MENU
                Console.Write("R:");
                op = int.Parse(Console.ReadLine()!);                                                              // Irá ler a opção selecionada
                   
                switch (op)                              // --| ESTRUTURA DE OPÇÕES |--
                {
                    case 1:                            // --| CASO SEJA 1 |--
                        Console.Clear();              // Limpa o que veio antes
                        CadastrarCliente();          // Chama a função CadastrarCliente()
                        break;                      // Quebra o caso

                    case 2:                       // --| CASO SEJA 2 |-- 
                        Console.Clear();         // Limpa o que veio antes
                        ListarFila();           // Chama a função ListarFila()
                        break;                 // Quebra o caso

                    case 3:                  // --| CASO SEJA 3 |--
                        Console.Clear();    // Limpa o que veio antes
                        Atendimento();     // Chama a função Atendimento()
                        break;            // Quebra o caso

                    case 4:             // --| CASO SEJA 4 |--
                        Console.Clear();// Limpa o que veio antes
                        Console.WriteLine("Até a próxima,estaremos aqui para lhe atender");
                        Console.WriteLine("    (Pressione qualquer tecla para sair)");  
                        Console.ReadKey();  // Irá ler a tecla que você clicar
                        break;             // Quebra o caso

                    default:             // --| CASO NÃO SEJA NENHUMA DOS CASOS |--
                        Console.Clear();// Limpa o que veio antes
                        Console.WriteLine("            OPÇÃO INVÁLIDA");
                        Console.WriteLine("(Pressione qualquer tecla para voltar)");
                        Console.ReadKey();  // Irá ler a tecla que você clicar
                        Console.Clear();   // Limpa o que veio antes
                        break;            // Quebra o caso
                }


            }

            void CadastrarCliente()   // --| FUNÇÃO PARA CADASTRO |--
            {
                for (int i = 0; i < cliente.Length; i++)  // Estrutura de repetição enquanto i for menor que cliente.Length (5)
                {
                    Console.Clear();                     // Limpa o que veio antes
                    Console.WriteLine("             | CADASTRO |");   
                    Console.WriteLine("------------------------------------");
                    Console.Write($"Digite o nome do(a) {i + 1}° cliente: ");
                    cliente[i].nome = Console.ReadLine()!;                     // Irá ler o nome digitado para o cliente

                    Console.Write($"Digite o CPF do(a) {cliente[i].nome}: ");
                    cliente[i].cpf = Console.ReadLine()!;                    // Irá ler o cpf digitado para o cliente

                    Console.Write($"Digite a Senha do(a) {cliente[i].nome}: "); 
                    cliente[i].senha = int.Parse(Console.ReadLine()!);     // Irá ler a senha digitado para o cliente
                }
                Console.Clear();                                          // Limpa o que veio antes
            }

            void ListarFila()        // --| FUNÇÃO PARA LISTAR CLIENTES |--
            {
                Console.Clear();   // Limpa o que veio antes

                Sistema();        // Chama a função Sistema()

                Console.WriteLine("        FILA DE ATENDIMENTO:");
                Console.WriteLine("--------------------------------------");
                foreach (var fila in cliente)  // Estrutura de repetição com base no array cliente para fila do tipo var
                {
                    Console.WriteLine($"O Cliente:{fila.nome}, com o CFP:{fila.cpf} e tem a senha número:{fila.senha}\n"); // Mostra os dados dos clientes


                }
                Console.WriteLine("          | FIM DA FILA |");
                Console.WriteLine("(Pressione qualquer tecla para voltar)");
                Console.ReadKey(); // Irá ler a tecla que você clicar 
                Console.Clear();  // Limpa o que veio antes
            }

            void Atendimento()      // --| FUNÇÃO PARA ATENDIMENTO |--
            {
                Console.Clear();  // Limpa o que veio antes

                Sistema();      // Chama a função Sistema()

                for (int i = 0; i < cliente.Length; i++)  // Estrutura de repetição enquanto i for menor que cliente.Lenght(5)
                {
                    Console.WriteLine($"O Clinte: {cliente[i].nome} com a Senha: {cliente[i].senha}" + // Irá mostrar os nomes e senhas dos clientes
                        $"\nSerá o {i + 1}° a ser atendido ");  // Irá mostrar a ordem que será chamado cada cliente
                    Console.WriteLine("Aperte qualquer tecla para ver o próximo da fila");
                    Console.ReadKey(); // Irá ler qualquer tecla que você clicar
                    Console.Clear();  // Limpa o que veio antes
                }
                Console.WriteLine("                        FIM DO ATENDIMENTO");
                Console.WriteLine("               (Pressione qualquer tecla para voltar)");
                Console.ReadKey();  // Irá ler qualquer tecla que você clicar
                Console.Clear();   // Limpa o que veio antes

            }

            void Sistema()   // --| FUNÇÃO PARA ORGANIZAR OS DADOS E SENHA DOS CLIENTES NA ORDEM |--
            {

                int aux;           // Variavel para absorver o valor da senha
                string aux1, aux2;// Variaveis para absorver os valores de nome e cpf

                for (int x = 0; x < 4; x++)  // Estrutura de repetição enquanto x for menor que 4
                {
                    for (int i = 0; i < cliente.Length - 1; i++)  // Estrututara de repetição enquanto i for menor que cliente.Length(5) - 1
                    {
                        if (cliente[i].senha > cliente[i + 1].senha)  // Estrutura de condição
                        {
                            aux = cliente[i + 1].senha;        
                            aux1 = cliente[i + 1].nome;
                            aux2 = cliente[i + 1].cpf;
                            cliente[i + 1].senha = cliente[i].senha;
                            cliente[i + 1].nome = cliente[i].nome;
                            cliente[i + 1].cpf = cliente[i].cpf;
                            cliente[i].senha = aux;
                            cliente[i].nome = aux1;
                            cliente[i].cpf = aux2;

                        }
                    }
                }
            }

 
        }
    }

    public struct Dados        // Estrutura de armazenamento de variaveis
    {                         
        public string cpf;   // Variavel para cpf
        public string nome; // Variavel para nome
        public int senha;  // Variavel para senha
    }
}