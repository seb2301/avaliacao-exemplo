namespace Avaliacao
{
    public class Program
    {
        static public List<Pessoa> pessoas = new List<Pessoa>();
        // ou static public List<Pessoa> pessoas = [];
        static void Main()

        {
            int op = 0;
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Para Criar Pessoa");
                Console.WriteLine("2 - Para Listar Pessoas");
                Console.WriteLine("3 - Para Alterar Pessoa");
                Console.WriteLine("4 - Para Deletar Pessoa");
                Console.WriteLine("5 - Para Sair do Programa.");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CriarPessoa();
                        break;
                    case 2:
                        ListarPessoa();
                        break;
                    case 3:
                        AlterarPessoa();
                        break;
                    case 4:
                        DeletarPessoa();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do Programa - Tchau");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;


                }

            } while (op != 5);
            

        }

        //Criar Funcoes

        static void CriarPessoa() {
            Console.WriteLine("Criando uma Pessoa");
            Pessoa person = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa: ");
            person.Nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a Idade da pessoa");
            person.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o CPF da pessoa: ");
            person.Cpf = Console.ReadLine() ??"";


            pessoas.Add(person);
            Console.WriteLine("Pessoa criada com sucesso!");

        }
            static void ListarPessoa(){
                Console.WriteLine("Listando pessoa");
                if(pessoas.Count > 0){
                    foreach (Pessoa person in pessoas){
                        Console.WriteLine($"{person.Nome} - {person.Idade}");
                    }
                } else {
                    
                
                


                }
            }

            static void AlterarPessoa(){
                Console.WriteLine("Alterando Pessoa");

            }

            static void DeletarPessoa(){
                Console.WriteLine("Deletando uma pessoa");
                Console.WriteLine("informe o indice da pessoa para deletar");
                int indice = Convert.ToInt32(Console.ReadLine());
                if(indice >= 0 && indice < pessoas.Count){
                    pessoas.RemoveAt(indice);
                } else {
                    Console.WriteLine("Indice inválido");
                }
            }


        
    }
    
}