

namespace TO_DO
{
    internal class Interface
    {        
        public Lista_Tarefas lista_Tarefas = new Lista_Tarefas();              

        public void tela_inicial()
        {            
            Console.WriteLine("============================================");
            Console.WriteLine("Escolha uma opção abaixo");
            Console.WriteLine("(1) - Cadastrar nova Tarefa");
            Console.WriteLine("(2) - Listar Tarefas");
            Console.WriteLine("(3) - Editar Tarefas");
            Console.WriteLine("(4) - Concluir Tarefas");
            Console.WriteLine("(5) - Excluir Tarefas");
            Console.WriteLine("(6) - Listar histórico de Tarefas");
            Console.WriteLine("(0) - Sair");
            Console.WriteLine("============================================");                    
            
        }

        public void escolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    lista_Tarefas.Cadastrar_Tarefa();
                    break;
                case 2:
                    lista_Tarefas.Listar_Tarefas();
                    break;
                case 3:
                    tela_editar_tarefa();
                    break;
                case 4:
                    tela_concluir_tarefa();
                    break;
                case 5:
                    tela_excluir_tarefa();
                    break;
                case 6:
                    lista_Tarefas.Listar_historico();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    Console.Clear();
                    break;
            }
        }

        private void tela_concluir_tarefa()
        {
            List<int> ID_validos = new List<int>();
            ID_validos = lista_Tarefas.listar_IDs();
            if (ID_validos.Count == 0)
            {
                Console.WriteLine("Não existe tarefa cadastrada");
                return;
            }
            lista_Tarefas.Listar_Resumo();

            while (true)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Digite o ID da tarefa a ser concluida");
                int ID = int.Parse(Console.ReadLine());
                if (ID_validos.Contains(ID) == false)
                {
                    Console.WriteLine("ID não encontrado, tente novamente");
                }
                else
                {
                    lista_Tarefas.Marcar_concluido(ID);
                    break;
                }
            }

        }

        public void tela_editar_tarefa()
        {           
            
            List<int> ID_validos = new List<int>();
            ID_validos = lista_Tarefas.listar_IDs();
            if (ID_validos.Count == 0)
            {
                Console.WriteLine("Não existe tarefa cadastrada");
                return;
            }

            lista_Tarefas.Listar_Resumo();
            while (true)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Digite o ID da tarefa a ser editada");
                int ID = int.Parse(Console.ReadLine());
                if (ID_validos.Contains(ID) == false)
                {
                    Console.WriteLine("ID não encontrado, tente novamente");
                }
                else
                {
                    Tarefa tarefa_editada = new Tarefa();                    
                    Console.WriteLine("Digite o título da tarefa");
                    tarefa_editada.titulo = Console.ReadLine();
                    Console.WriteLine("Digite a descrição da tarefa");
                    tarefa_editada.descricao = Console.ReadLine();
                    lista_Tarefas.Editar_Tarefa(ID, tarefa_editada);
                    break;
                }
            }
        }
        
        public void tela_excluir_tarefa()
        {
            List<int> ID_validos = new List<int>();
            ID_validos = lista_Tarefas.listar_IDs();
            if (ID_validos.Count == 0)
            {
                Console.WriteLine("Não existe tarefa cadastrada");
                return;
            }
            lista_Tarefas.Listar_Resumo();

            Console.WriteLine("============================================");
            Console.WriteLine("Digite o ID da tarefa a ser excluída");
            int ID = int.Parse(Console.ReadLine());
            lista_Tarefas.Excluir_Tarefa(ID);
        }

    }
}
