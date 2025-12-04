using System.Collections.Generic;

// Implementação do serviço usando o repositório
public class EntrevistadoService : IEntrevistadoService {
    private readonly IEntrevistadoRepository _repo;
    public EntrevistadoService(IEntrevistadoRepository repo){
        _repo = repo;
    }

    public void Criar(Entrevistado e) {
        // regra de negócio: não permitir CPF repetido (repo já trata) e
        // se mora de aluguel obrigar valor do aluguel maior que zero
        if(e.MoraAluguel && (!e.ValorAluguel.HasValue || e.ValorAluguel.Value <= 0)) {
            throw new System.Exception("Se mora de aluguel, informe o valor do aluguel maior que zero.");
        }
        _repo.Criar(e);
    }

    public void Atualizar(Entrevistado e) {
        if(e.MoraAluguel && (!e.ValorAluguel.HasValue || e.ValorAluguel.Value <= 0)) {
            throw new System.Exception("Se mora de aluguel, informe o valor do aluguel maior que zero.");
        }
        _repo.Atualizar(e);
    }

    public Entrevistado BuscarCpf(string cpf) {
        return _repo.BuscarCpf(cpf);
    }

    public List<Entrevistado> BuscarTodos() {
        return _repo.BuscarTodos();
    }
}