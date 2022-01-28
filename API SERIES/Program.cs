using System;

namespace API_Series
{
    class Program
    {
        static SeriesRepositorios repositorio = new SeriesRepositorios();
        static void Main (string[] args)
        {
            string optionUser = ObterOptionUser();
            while (optionUser != "X")
            {
                switch (optionUser)
                {
                    case "1":
                        Listarserie();
                        break;
                    case "2":
                        Inserirserie();
                        break;
                    case "3":
                        Atualizarserie();
                        break;
                    case "4":
                        Excluirserie();
                        break;
                    case "5":
                        Visualizarserie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
						throw new ArgumentOutOfRangeException();
                }
            }
            optionUser = ObterOptionUser();
            Console.WriteLine("Obrigado por usar este serviço!");
            Console.ReadLine();
        }
        public static void Listarserie()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;                
            }
            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0} - {1}", serie.retornoID(), serie.retornoTitle());                
            }       
        }
        public static void Inserirserie()
        {
            Console.WriteLine("Insira uma nova série:");
            foreach (int i in Enum.GetValues(typeof(gender)))          
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(gender), i));
            }
            Console.WriteLine("Escolha entre um dos gêneros acima: ");
            int entergender = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o  título da série");
            string entertitle = Console.ReadLine();

            Console.WriteLine("Qual o ano de lançamento? ");
            int enteryear = int.Parse(Console.ReadLine());

            Console.WriteLine("Descreva a série: ");
            string enterdescription = Console.ReadLine();

            Series novaserie = new Series(id: repositorio.ProximoID(),
                                            genero: (gender) entergender,
                                            titulo: entertitle,
                                            ano: enteryear,
                                            descricao: enterdescription);
            repositorio.Insere(novaserie);
        }
          private static void Atualizarserie()
        {
            Console.WriteLine("Por favor, informe o ID da série a ser atualizada: ");
            int idserie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(gender)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(gender), i));
            }
            Console.WriteLine("Escolha entre um dos gêneros acima: ");
            int entergender = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o  título da série");
            string entertitle = Console.ReadLine();

            Console.WriteLine("Qual o ano de lançamento? ");
            int enteryear = int.Parse(Console.ReadLine());

            Console.WriteLine("Descreva a série: ");
            string enterdescription = Console.ReadLine();

            Series atualizaserie = new Series(id: idserie, 
                                            genero: (gender) entergender,
                                            titulo: entertitle,
                                            ano: enteryear,
                                            descricao: enterdescription);
            repositorio.Atualiza(idserie, atualizaserie);
        }
        private static void Excluirserie()
        {
            Console.WriteLine("Entre com o ID da série a ser excluída: ");
            int idserie = int.Parse(Console.ReadLine());
            repositorio.Exlcui(idserie);
        }
        private static void Visualizarserie()
        {
            Console.WriteLine("Digite o ID da série desejada: ");
            int idserie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetonraPorID(idserie);
            Console.WriteLine(serie);
        }
        private static string ObterOptionUser()
        {
        Console.WriteLine("Olá, seja bemv vindo ao cadastro de séries do Bruno Couto");
        Console.WriteLine("");
        Console.WriteLine("Por favor entre com uma das opções abaixo:");
                    Console.WriteLine("");
        Console.WriteLine("1 - Listar séries");
        Console.WriteLine("2 - Inserir uma nova série");
        Console.WriteLine("3 - Atualizar uma série");
        Console.WriteLine("4 - Excluir uma série");
        Console.WriteLine("5 - Visualizar série");
        Console.WriteLine("C - Limpar a tela");
        Console.WriteLine("X - Sair");
        string optionUser = Console.ReadLine().ToUpper();
        return optionUser;
        }
      
    }
}
