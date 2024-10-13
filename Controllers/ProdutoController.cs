using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    // Rota GET: /api/produto
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Produto1", "Produto2", "Produto3" };
    }

    // Rota GET com parâmetro: /api/produto/{id}
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"Produto {id}";
    }

    // Rota POST: /api/produto
    [HttpPost]
    public ActionResult<string> Post([FromBody] string produto)
    {
        return $"Produto {produto} criado com sucesso!";
    }
}
