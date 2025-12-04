public interface IEntrevistadoService
{
    void Criar(Entrevistado e);
    void Atualizar(Entrevistado e);
    Entrevistado BuscarCpf(string cpf);
    List<Entrevistado> BuscarTodos();
}