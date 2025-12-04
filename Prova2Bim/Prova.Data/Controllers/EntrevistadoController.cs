using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EntrevistadoController : ControllerBase
{
    private readonly IEntrevistadoService service;
    public EntrevistadoController(IEntrevistadoService s) { service = s; }

    [HttpPost]
    public IActionResult Criar(Entrevistado e) { service.Criar(e); return Ok(); }

    [HttpPut]
    public IActionResult Atualizar(Entrevistado e) { service.Atualizar(e); return Ok(); }

    [HttpGet("{cpf}")]
    public IActionResult Buscar(string cpf) { return Ok(service.BuscarCpf(cpf)); }

    [HttpGet]
    public IActionResult BuscarTodos() { return Ok(service.BuscarTodos()); }
}