using System;

// namespace ProdutoApp
// {
//     public class Produto
//     {
//         // Atributos
//         public string Nome { get; private set; }
//         public decimal Preco { get; private set; }
//         public int QuantidadeEmEstoque { get; private set; }

//         // Construtor
//         public Produto(string nome, decimal preco, int quantidadeEmEstoque)
//         {
//             Nome = nome;
//             Preco = preco;
//             QuantidadeEmEstoque = quantidadeEmEstoque;
//         }

//         // Método para adicionar itens ao estoque
//         public void AdicionarEstoque(int quantidade)
//         {
//             if (quantidade < 0)
//             {
//                 throw new ArgumentException("A quantidade a ser adicionada não pode ser negativa.");
//             }
//             QuantidadeEmEstoque += quantidade;
//             Console.WriteLine($"{quantidade} itens adicionados ao estoque. Quantidade atual: {QuantidadeEmEstoque}");
//         }

//         // Método para remover itens do estoque
//         public void RemoverEstoque(int quantidade)
//         {
//             if (quantidade < 0)
//             {
//                 throw new ArgumentException("A quantidade a ser removida não pode ser negativa.");
//             }
//             if (quantidade > QuantidadeEmEstoque)
//             {
//                 throw new InvalidOperationException("Não há quantidade suficiente no estoque para remover.");
//             }
//             QuantidadeEmEstoque -= quantidade;
//             Console.WriteLine($"{quantidade} itens removidos do estoque. Quantidade atual: {QuantidadeEmEstoque}");
//         }

//         // Método para exibir as informações do produto
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Produto: {Nome}");
//             Console.WriteLine($"Preço: {Preco:C}");
//             Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Criação de um objeto Produto
//             Produto produto = new Produto("Notebook", 2500.00m, 10);

//             // Exibição das informações do produto
//             produto.ExibirInformacoes();

//             // Adição de itens ao estoque
//             produto.AdicionarEstoque(5);

//             // Remoção de itens do estoque
//             produto.RemoverEstoque(3);

//             // Exibição das informações do produto novamente
//             produto.ExibirInformacoes();
//         }
//     }
// }

// ---------------------exercicio 2 ---------------------------

// using System;
// using System.Collections.Generic;

// namespace RegistroDeComprasApp
// {
//     public class Produto
//     {
//         // Atributos
//         public string Nome { get; set; }
//         public decimal Preco { get; set; }
//         public int QuantidadeEmEstoque { get; set; }

//         // Construtor
//         public Produto(string nome, decimal preco, int quantidadeEmEstoque)
//         {
//             Nome = nome;
//             Preco = preco;
//             QuantidadeEmEstoque = quantidadeEmEstoque;
//         }

//         // Método exibir as informações do produto
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Produto: {Nome}");
//             Console.WriteLine($"Preço: {Preco:C}");
//             Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
//         }
//     }

//     public class RegistroDeCompras
//     {
//         // Classe para representar uma compra
//         private class Compra
//         {
//             public DateTime Data { get; set; }
//             public Produto Produto { get; set; }
//             public decimal Valor { get; set; }

//             public Compra(DateTime data, Produto produto, decimal valor)
//             {
//                 Data = data;
//                 Produto = produto;
//                 Valor = valor;
//             }

//             public void ExibirInformacoes()
//             {
//                 Console.WriteLine($"Data: {Data}");
//                 Console.WriteLine($"Produto: {Produto.Nome}");
//                 Console.WriteLine($"Valor: {Valor:C}");
//             }
//         }

//         // Lista para armazenar as compras
//         private List<Compra> compras = new List<Compra>();

//         // Método para adicionar uma compra
//         public void AdicionarCompra(DateTime data, Produto produto, decimal valor)
//         {
//             Compra compra = new Compra(data, produto, valor);
//             compras.Add(compra);
//             Console.WriteLine("Compra adicionada com sucesso.");
//         }

//         // Método para listar todas as compras
//         public void ListarCompras()
//         {
//             Console.WriteLine("Lista de Compras:");
//             foreach (var compra in compras)
//             {
//                 compra.ExibirInformacoes();
//                 Console.WriteLine("-----------------------");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Criação de um objeto Produto
//             Produto produto1 = new Produto("Livro Clean Code", 50.00m, 10);
//             Produto produto2 = new Produto("Monitor Ultrawide", 1500.00m, 20);

//             // Criação de um objeto RegistroDeCompras
//             RegistroDeCompras registroDeCompras = new RegistroDeCompras();

//             // Adição de compras ao registro
//             registroDeCompras.AdicionarCompra(DateTime.Now, produto1, produto1.Preco);
//             registroDeCompras.AdicionarCompra(DateTime.Now, produto2, produto2.Preco);

//             // Listagem das compras registradas
//             registroDeCompras.ListarCompras();
//         }
//     }
// }

// ---------------------exercicio 3 ---------------------------


// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace CorretoraDeImoveisApp
// {
//     public class Imovel
//     {
//         // Atributos
//         public string Endereco { get; private set; }
//         public decimal Preco { get; set; }
//         public string Tipo { get; private set; }

//         // Construtor
//         public Imovel(string endereco, decimal preco, string tipo)
//         {
//             Endereco = endereco;
//             Preco = preco;
//             Tipo = tipo;
//         }

//         // Método para exibir as informações do imóvel
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Endereço: {Endereco}");
//             Console.WriteLine($"Preço: {Preco:C}");
//             Console.WriteLine($"Tipo: {Tipo}");
//         }
//     }

//     public class CorretoraDeImoveis
//     {
//         // Lista para armazenar os imóveis
//         private List<Imovel> imoveis = new List<Imovel>();

//         // Método para adicionar um imóvel
//         public void AdicionarImovel(string endereco, decimal preco, string tipo)
//         {
//             Imovel imovel = new Imovel(endereco, preco, tipo);
//             imoveis.Add(imovel);
//             Console.WriteLine("Imóvel adicionado com sucesso.");
//         }

//         // Método para listar todos os imóveis
//         public void ListarImoveis()
//         {
//             Console.WriteLine("Lista de Imóveis:");
//             foreach (var imovel in imoveis)
//             {
//                 imovel.ExibirInformacoes();
//                 Console.WriteLine("-----------------------");
//             }
//         }

//         // Método para calcular o valor médio dos imóveis
//         public decimal CalcularValorMedio()
//         {
//             if (imoveis.Count == 0)
//             {
//                 return 0;
//             }
//             return imoveis.Average(imovel => imovel.Preco);
//         }

//         // Método para alterar o preço de um imóvel
//         public void AlterarPrecoImovel(string endereco, decimal novoPreco)
//         {
//             var imovel = imoveis.FirstOrDefault(i => i.Endereco == endereco);
//             if (imovel != null)
//             {
//                 imovel.Preco = novoPreco;
//                 Console.WriteLine("Preço do imóvel alterado com sucesso.");
//             }
//             else
//             {
//                 Console.WriteLine("Imóvel não encontrado.");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             CorretoraDeImoveis corretora = new CorretoraDeImoveis();
//             bool sair = false;

//             while (!sair)
//             {
//                 Console.WriteLine("Menu:");
//                 Console.WriteLine("1. Inserir Imóvel");
//                 Console.WriteLine("2. Alterar Preço do Imóvel");
//                 Console.WriteLine("3. Apresentar Todos os Imóveis");
//                 Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
//                 Console.WriteLine("5. Sair");
//                 Console.Write("Escolha uma opção: ");
//                 int opcao = int.Parse(Console.ReadLine());

//                 switch (opcao)
//                 {
//                     case 1:
//                         Console.Write("Endereço: ");
//                         string endereco = Console.ReadLine();
//                         Console.Write("Preço: ");
//                         decimal preco = decimal.Parse(Console.ReadLine());
//                         Console.Write("Tipo: ");
//                         string tipo = Console.ReadLine();
//                         corretora.AdicionarImovel(endereco, preco, tipo);
//                         break;

//                     case 2:
//                         Console.Write("Endereço do imóvel a alterar: ");
//                         endereco = Console.ReadLine();
//                         Console.Write("Novo Preço: ");
//                         decimal novoPreco = decimal.Parse(Console.ReadLine());
//                         corretora.AlterarPrecoImovel(endereco, novoPreco);
//                         break;

//                     case 3:
//                         corretora.ListarImoveis();
//                         break;

//                     case 4:
//                         decimal valorMedio = corretora.CalcularValorMedio();
//                         Console.WriteLine($"Valor Médio dos Imóveis: {valorMedio:C}");
//                         break;

//                     case 5:
//                         sair = true;
//                         break;

//                     default:
//                         Console.WriteLine("Opção inválida.");
//                         break;
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }


// ---------------------exercicio 4 ---------------------------

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace AgendaTelefonicaApp
// {
//     public class Contato
//     {
//         // Atributos
//         public string Nome { get; private set; }
//         public string Telefone { get; private set; }
//         public string Email { get; private set; }

//         // Construtor
//         public Contato(string nome, string telefone, string email)
//         {
//             Nome = nome;
//             Telefone = telefone;
//             Email = email;
//         }

//         // Método para exibir as informações do contato
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Nome: {Nome}");
//             Console.WriteLine($"Telefone: {Telefone}");
//             Console.WriteLine($"E-mail: {Email}");
//         }
//     }

//     public class AgendaTelefonica
//     {
//         // Lista para armazenar os contatos
//         private List<Contato> contatos = new List<Contato>();

//         // Método para adicionar um contato
//         public void AdicionarContato(string nome, string telefone, string email)
//         {
//             Contato contato = new Contato(nome, telefone, email);
//             contatos.Add(contato);
//             Console.WriteLine("Contato adicionado com sucesso.");
//         }

//         // Método para remover um contato
//         public void RemoverContato(string nome)
//         {
//             var contato = contatos.FirstOrDefault(c => c.Nome == nome);
//             if (contato != null)
//             {
//                 contatos.Remove(contato);
//                 Console.WriteLine("Contato removido com sucesso.");
//             }
//             else
//             {
//                 Console.WriteLine("Contato não encontrado.");
//             }
//         }

//         // Método para buscar um contato pelo nome
//         public void BuscarContato(string nome)
//         {
//             var contato = contatos.FirstOrDefault(c => c.Nome == nome);
//             if (contato != null)
//             {
//                 contato.ExibirInformacoes();
//             }
//             else
//             {
//                 Console.WriteLine("Contato não encontrado.");
//             }
//         }

//         // Método para listar todos os contatos
//         public void ListarContatos()
//         {
//             Console.WriteLine("Lista de Contatos:");
//             foreach (var contato in contatos)
//             {
//                 contato.ExibirInformacoes();
//                 Console.WriteLine("-----------------------");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             AgendaTelefonica agenda = new AgendaTelefonica();
//             bool sair = false;

//             while (!sair)
//             {
//                 Console.WriteLine("Menu:");
//                 Console.WriteLine("1. Adicionar Contato");
//                 Console.WriteLine("2. Remover Contato");
//                 Console.WriteLine("3. Buscar Contato");
//                 Console.WriteLine("4. Listar Todos os Contatos");
//                 Console.WriteLine("5. Sair");
//                 Console.Write("Escolha uma opção: ");
//                 int opcao = int.Parse(Console.ReadLine());

//                 switch (opcao)
//                 {
//                     case 1:
//                         Console.Write("Nome: ");
//                         string nome = Console.ReadLine();
//                         Console.Write("Telefone: ");
//                         string telefone = Console.ReadLine();
//                         Console.Write("E-mail: ");
//                         string email = Console.ReadLine();
//                         agenda.AdicionarContato(nome, telefone, email);
//                         break;

//                     case 2:
//                         Console.Write("Nome do contato a remover: ");
//                         nome = Console.ReadLine();
//                         agenda.RemoverContato(nome);
//                         break;

//                     case 3:
//                         Console.Write("Nome do contato a buscar: ");
//                         nome = Console.ReadLine();
//                         agenda.BuscarContato(nome);
//                         break;

//                     case 4:
//                         agenda.ListarContatos();
//                         break;

//                     case 5:
//                         sair = true;
//                         break;

//                     default:
//                         Console.WriteLine("Opção inválida.");
//                         break;
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }


// ---------------------exercicio 5 ---------------------------

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace GerenciadorDeTarefasApp
// {
//     public class Tarefa
//     {
//         // Atributos
//         public string Descricao { get; private set; }
//         public DateTime DataDeVencimento { get; private set; }

//         // Construtor
//         public Tarefa(string descricao, DateTime dataDeVencimento)
//         {
//             Descricao = descricao;
//             DataDeVencimento = dataDeVencimento;
//         }

//         // Método para exibir as informações da tarefa
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Descrição: {Descricao}");
//             Console.WriteLine($"Data de Vencimento: {DataDeVencimento:dd/MM/yyyy}");
//         }

//         // Método para verificar se a tarefa deve ser executada hoje
//         public bool DeveSerExecutadaHoje()
//         {
//             return DataDeVencimento.Date == DateTime.Today;
//         }
//     }

//     public class GerenciadorDeTarefas
//     {
//         // Lista para armazenar as tarefas
//         private List<Tarefa> tarefas = new List<Tarefa>();

//         // Método para adicionar uma tarefa
//         public void AdicionarTarefa(string descricao, DateTime dataDeVencimento)
//         {
//             Tarefa tarefa = new Tarefa(descricao, dataDeVencimento);
//             tarefas.Add(tarefa);
//             Console.WriteLine("Tarefa adicionada com sucesso.");
//         }

//         // Método para remover uma tarefa
//         public void RemoverTarefa(string descricao)
//         {
//             var tarefa = tarefas.FirstOrDefault(t => t.Descricao == descricao);
//             if (tarefa != null)
//             {
//                 tarefas.Remove(tarefa);
//                 Console.WriteLine("Tarefa removida com sucesso.");
//             }
//             else
//             {
//                 Console.WriteLine("Tarefa não encontrada.");
//             }
//         }

//         // Método para listar todas as tarefas
//         public void ListarTarefas()
//         {
//             Console.WriteLine("Lista de Tarefas:");
//             foreach (var tarefa in tarefas)
//             {
//                 tarefa.ExibirInformacoes();
//                 Console.WriteLine("-----------------------");
//             }
//         }

//         // Método para listar as tarefas que devem ser executadas hoje
//         public void ListarTarefasParaHoje()
//         {
//             Console.WriteLine("Tarefas para Hoje:");
//             foreach (var tarefa in tarefas.Where(t => t.DeveSerExecutadaHoje()))
//             {
//                 tarefa.ExibirInformacoes();
//                 Console.WriteLine("-----------------------");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
//             bool sair = false;

//             while (!sair)
//             {
//                 Console.WriteLine("Menu:");
//                 Console.WriteLine("1. Adicionar Tarefa");
//                 Console.WriteLine("2. Remover Tarefa");
//                 Console.WriteLine("3. Listar Todas as Tarefas");
//                 Console.WriteLine("4. Listar Tarefas para Hoje");
//                 Console.WriteLine("5. Sair");
//                 Console.Write("Escolha uma opção: ");
//                 int opcao = int.Parse(Console.ReadLine());

//                 switch (opcao)
//                 {
//                     case 1:
//                         Console.Write("Descrição: ");
//                         string descricao = Console.ReadLine();
//                         Console.Write("Data de Vencimento (dd/MM/yyyy): ");
//                         DateTime dataDeVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
//                         gerenciador.AdicionarTarefa(descricao, dataDeVencimento);
//                         break;

//                     case 2:
//                         Console.Write("Descrição da tarefa a remover: ");
//                         descricao = Console.ReadLine();
//                         gerenciador.RemoverTarefa(descricao);
//                         break;

//                     case 3:
//                         gerenciador.ListarTarefas();
//                         break;

//                     case 4:
//                         gerenciador.ListarTarefasParaHoje();
//                         break;

//                     case 5:
//                         sair = true;
//                         break;

//                     default:
//                         Console.WriteLine("Opção inválida.");
//                         break;
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// ---------------------exercicio 6 ---------------------------

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace ProdutoApp
// {
//     public class Produto
//     {
//         // Atributos
//         public int Codigo { get; private set; }
//         public string Nome { get; private set; }
//         public decimal Preco { get; private set; }
//         public int QuantidadeEmEstoque { get; private set; }

//         // Construtor
//         public Produto(int codigo, string nome, decimal preco, int quantidadeEmEstoque)
//         {
//             Codigo = codigo;
//             Nome = nome;
//             Preco = preco;
//             QuantidadeEmEstoque = quantidadeEmEstoque;
//         }

//         // Método para adicionar itens ao estoque
//         public void AdicionarEstoque(int quantidade)
//         {
//             if (quantidade < 0)
//             {
//                 throw new ArgumentException("A quantidade a ser adicionada não pode ser negativa.");
//             }
//             QuantidadeEmEstoque += quantidade;
//             Console.WriteLine($"{quantidade} itens adicionados ao estoque. Quantidade atual: {QuantidadeEmEstoque}");
//         }

//         // Método para remover itens do estoque
//         public void RemoverEstoque(int quantidade)
//         {
//             if (quantidade < 0)
//             {
//                 throw new ArgumentException("A quantidade a ser removida não pode ser negativa.");
//             }
//             if (quantidade > QuantidadeEmEstoque)
//             {
//                 throw new InvalidOperationException("Não há quantidade suficiente no estoque para remover.");
//             }
//             QuantidadeEmEstoque -= quantidade;
//             Console.WriteLine($"{quantidade} itens removidos do estoque. Quantidade atual: {QuantidadeEmEstoque}");
//         }

//         // Método para exibir as informações do produto
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"Código: {Codigo}");
//             Console.WriteLine($"Produto: {Nome}");
//             Console.WriteLine($"Preço: {Preco:C}");
//             Console.WriteLine($"Quantidade em Estoque: {QuantidadeEmEstoque}");
//             Console.WriteLine("-----------------------");
//         }
//     }

//     public class GerenciadorDeProdutos
//     {
//         // Lista para armazenar os produtos
//         private List<Produto> produtos = new List<Produto>();

//         // Método para adicionar um produto
//         public void AdicionarProduto(int codigo, string nome, decimal preco, int quantidadeEmEstoque)
//         {
//             Produto produto = new Produto(codigo, nome, preco, quantidadeEmEstoque);
//             produtos.Add(produto);
//             Console.WriteLine("Produto adicionado com sucesso.");
//         }

//         // Método para listar todos os produtos
//         public void ListarProdutos()
//         {
//             Console.WriteLine("Lista de Produtos:");
//             foreach (var produto in produtos)
//             {
//                 produto.ExibirInformacoes();
//             }
//         }

//         // Método para consultar um produto pelo código
//         public void ConsultarProdutoPeloCodigo(int codigo)
//         {
//             var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
//             if (produto != null)
//             {
//                 produto.ExibirInformacoes();
//             }
//             else
//             {
//                 Console.WriteLine("Produto não encontrado.");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();
//             bool sair = false;

//             while (!sair)
//             {
//                 Console.WriteLine("Menu:");
//                 Console.WriteLine("1. Adicionar Produto");
//                 Console.WriteLine("2. Listar Todos os Produtos");
//                 Console.WriteLine("3. Consultar Produto pelo Código");
//                 Console.WriteLine("4. Sair");
//                 Console.Write("Escolha uma opção: ");
//                 int opcao = int.Parse(Console.ReadLine());

//                 switch (opcao)
//                 {
//                     case 1:
//                         Console.Write("Código: ");
//                         int codigo = int.Parse(Console.ReadLine());
//                         Console.Write("Nome: ");
//                         string nome = Console.ReadLine();
//                         Console.Write("Preço: ");
//                         decimal preco = decimal.Parse(Console.ReadLine());
//                         Console.Write("Quantidade em Estoque: ");
//                         int quantidadeEmEstoque = int.Parse(Console.ReadLine());
//                         gerenciador.AdicionarProduto(codigo, nome, preco, quantidadeEmEstoque);
//                         break;

//                     case 2:
//                         gerenciador.ListarProdutos();
//                         break;

//                     case 3:
//                         Console.Write("Código do produto a consultar: ");
//                         codigo = int.Parse(Console.ReadLine());
//                         gerenciador.ConsultarProdutoPeloCodigo(codigo);
//                         break;

//                     case 4:
//                         sair = true;
//                         break;

//                     default:
//                         Console.WriteLine("Opção inválida.");
//                         break;
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// ---------------------exercicio 7 ---------------------------
// using System.Collections.Generic;

// public class Musica
// {
//     public string Nome { get; set; }
//     public string Autor { get; set; }
//     public string Gravadora { get; set; }

//     public Musica(string nome, string autor, string gravadora)
//     {
//         Nome = nome;
//         Autor = autor;
//         Gravadora = gravadora;
//     }
// }

// public class Playlist
// {
//     private List<Musica> musicas;
//     public string DonoDaPlaylist { get; set; }
//     private Random random;

//     public Playlist(string donoDaPlaylist)
//     {
//         DonoDaPlaylist = donoDaPlaylist;
//         musicas = new List<Musica>();
//         random = new Random();
//     }

//     public void AdicionarMusica(Musica musica)
//     {
//         musicas.Add(musica);
//     }

//     public void TocarMusica()
//     {
//         if (musicas.Count == 0)
//         {
//             Console.WriteLine("A playlist está vazia.");
//             return;
//         }

//         int indice = random.Next(musicas.Count);
//         Musica musica = musicas[indice];
//         Console.WriteLine($"Tocando: {musica.Nome} - {musica.Autor}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Playlist playlist = new Playlist("Miriam");

//         playlist.AdicionarMusica(new Musica("Música 1", "Autor 1", "Gravadora 1"));
//         playlist.AdicionarMusica(new Musica("Música 2", "Autor 2", "Gravadora 2"));
//         playlist.AdicionarMusica(new Musica("Música 3", "Autor 3", "Gravadora 3"));

//         playlist.TocarMusica();
//         playlist.TocarMusica();
//         playlist.TocarMusica();
//     }
// }

// ---------------------exercicio 8 ---------------------------
//  Retornar nessa questão depois

// ---------------------exercicio 9 ---------------------------
//  Retornar nessa questão depois


// ---------------------exercicio 10 ---------------------------
// public class Animal
// {
//     public string Nome { get; set; }
//     public string Especie { get; set; }
//     public int Idade { get; set; }

//     public Animal(string nome, string especie, int idade)
//     {
//         Nome = nome;
//         Especie = especie;
//         Idade = idade;
//     }

//     public void EmitirSom()
//     {
//         Console.WriteLine($"{Nome} está fazendo um som.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Animal animal1 = new Animal("Pipoca", "Cachorro", 5);
//         Animal animal2 = new Animal("Nero", "Gato", 3);

//         Console.WriteLine($"Nome: {animal1.Nome}, Espécie: {animal1.Especie}, Idade: {animal1.Idade}");
//         animal1.EmitirSom();

//         Console.WriteLine($"Nome: {animal2.Nome}, Espécie: {animal2.Especie}, Idade: {animal2.Idade}");
//         animal2.EmitirSom();
//     }
// }

// ---------------------exercicio 11 ---------------------------

// public class Carro
// {
//     public string Modelo { get; set; }
//     public int Ano { get; set; }
//     public int Velocidade { get; private set; }

//     public Carro(string modelo, int ano)
//     {
//         Modelo = modelo;
//         Ano = ano;
//         Velocidade = 0;
//     }

//     public void Acelerar()
//     {
//         Velocidade += 10;
//         Console.WriteLine($"Acelerando o carro... Velocidade atual: {Velocidade} km/h");
//     }

//     public void Frear()
//     {
//         if (Velocidade >= 10)
//         {
//             Velocidade -= 10;
//         }
//         else
//         {
//             Velocidade = 0;
//         }
//         Console.WriteLine($"Freando o carro... Velocidade atual: {Velocidade} km/h");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Carro carro = new Carro("Argo", 2020);

//         Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade inicial: {carro.Velocidade} km/h");

//         carro.Acelerar();
//         carro.Acelerar();
//         carro.Frear();
//         carro.Frear();
//         carro.Frear(); //velocidade é 0
//     }
// }

// ---------------------exercicio 12 ---------------------------
//  Retornar nessa questão depois