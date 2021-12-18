namespace TO_DO
{
    internal class Tarefa
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }

        public bool pendente { get; set; }
        public bool ativo { get; set; }
        public DateTime data_criacao { get; set; }
        public DateTime? data_termino { get; set; }

        public Tarefa() {}

        public Tarefa(int ID, string titulo = "vazio", string descricao = "vazio")
        {
            this.ID = ID;
            this.titulo = titulo;
            this.descricao = descricao;
            this.pendente = true;
            this.ativo = true;
            this.data_criacao = DateTime.Now;            
        }          
    
    }



}
