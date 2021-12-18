namespace TO_DO
{
    internal class Lista_Tarefas
    {
        List<Tarefa> lista_tarefas = new List<Tarefa>();

        public void Cadastrar_Tarefa()
        {
            
            Console.WriteLine("Digite o Título da Tarefa");
            string ? titulo = Console.ReadLine();
            Console.WriteLine("Digite a Descrição da Tarefa");
            string? descricao = Console.ReadLine();

            lista_tarefas.Add(new Tarefa { ID = lista_tarefas.Count, titulo = titulo, descricao = descricao, pendente = true, ativo = true, data_criacao = DateTime.Now });            

        }

        public void Editar_Tarefa(int ID, Tarefa tarefa_editada) 
        {            
            
            for (int i = 0; i < lista_tarefas.Count; i++)
            {
                if (lista_tarefas[i].ID == ID)
                {
                    lista_tarefas[i].titulo = tarefa_editada.titulo;
                    lista_tarefas[i].descricao = tarefa_editada.descricao;
                    break;
                }
            }
        }

        public void Marcar_concluido(int ID)
        {
            for(int i = 0; i < lista_tarefas.Count; i++)
            {
                if(lista_tarefas[i].ID == ID)
                {
                    lista_tarefas[i].pendente = false;
                    lista_tarefas[i].data_termino = DateTime.Now;
                }
            }
        }

        public void Listar_Tarefas()
        {
            foreach(Tarefa tarefa in lista_tarefas)
            {
                if (lista_tarefas.Count <= 0)
                {
                    Console.WriteLine("Não há tarefa cadastradas");
                    return;
                }
                if (tarefa.ativo)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine($"ID =\t {tarefa.ID}");
                    Console.WriteLine($"Título =\t {tarefa.titulo}");
                    Console.WriteLine($"Descrição =\t {tarefa.descricao}");
                    Console.WriteLine($"pendente =\t {tarefa.pendente}");
                    Console.WriteLine($"Data Criação =\t {tarefa.data_criacao}");
                    Console.WriteLine($"Data Termino =\t {tarefa.data_termino}");
                    Console.WriteLine("=======================================");
                    Console.WriteLine(" ");
                }                
            }
        }

        public void Listar_Resumo()
        {
            foreach (Tarefa tarefa in lista_tarefas)
            {
                if (lista_tarefas.Count <= 0)
                {
                    Console.WriteLine("Não há tarefa cadastradas");
                    return;
                }
                if (tarefa.ativo)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine($"ID =\t {tarefa.ID}");
                    Console.WriteLine($"Título =\t {tarefa.titulo}");
                    Console.WriteLine($"pendente =\t {tarefa.pendente}");
                    Console.WriteLine("=======================================");
                    Console.WriteLine(" ");
                }
            }
        }

        public void Listar_historico()
        {
            foreach (Tarefa tarefa in lista_tarefas)
            {
                if (lista_tarefas.Count <= 0)
                {
                    Console.WriteLine("Não há tarefa cadastradas");
                    return;
                }                
                Console.WriteLine("=======================================");
                Console.WriteLine($"ID =\t {tarefa.ID}");
                Console.WriteLine($"Título =\t {tarefa.titulo}");
                Console.WriteLine($"Descrição =\t {tarefa.descricao}");
                Console.WriteLine($"pendente =\t {tarefa.pendente}");
                Console.WriteLine($"Data Criação =\t {tarefa.data_criacao}");
                Console.WriteLine($"Data Termino =\t {tarefa.data_termino}");
                Console.WriteLine($"excluído =\t {tarefa.ativo}");
                Console.WriteLine("=======================================");
                Console.WriteLine(" ");
                               
            }
        }

        public void Excluir_Tarefa(int ID)
        {
            for (int i = 0; i < lista_tarefas.Count; i++)
            {                
                if (lista_tarefas[i].ID == ID)
                {
                    lista_tarefas[i].ativo = false;
                    lista_tarefas[i].data_termino = DateTime.Now;
                    break;
                }
            }
        }

        public List<int> listar_IDs()
        {            
            List<int> IDs_validos = new List<int>();
            foreach(Tarefa tarefa in lista_tarefas)
            {
                if (tarefa.ativo)
                {
                    IDs_validos.Add(tarefa.ID);
                }
                
            }
            return IDs_validos;
        }

    }
}
