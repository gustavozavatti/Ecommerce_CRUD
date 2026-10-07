using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<Produto> produtos = new List<Produto>();

//GET: http://localhost:5016
app.MapGet("/", () => "API do Ecommerce");

//POST: http://localhost:5016/api/produto/cadastrar
app.MapPost("/api/produto/cadastrar", ([FromBody] Produto? produtoCadastrar) =>
{
    if (produtoCadastrar == null)
        return Results.BadRequest("Produto inválido.");
    

    if (string.IsNullOrWhiteSpace(produtoCadastrar.Nome) || produtoCadastrar.Valor <= 0)
        return Results.BadRequest("Dados do produto são obrigatórios.");
    

    if(produtos.FirstOrDefault(p => p.Nome == produtoCadastrar.Nome) != null)
        return Results.BadRequest("Produto já cadastrado.");

    produtos.Add(produtoCadastrar);
    return Results.Created("", produtoCadastrar);

});

//GET: http://localhost:5016/api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    if(produtos.Count == 0)
        return Results.NotFound("Não existem produtos cadastrados");

    return Results.Ok(produtos);
});

//GET: http://localhost:5016/api/produto/buscar/nome_produto
app.MapGet("/api/produto/buscar/{nome}", ([FromRoute]string nome) =>
{
    Produto? produtoEncontrado = produtos.FirstOrDefault(p => p.Nome == nome);

    if(produtoEncontrado != null)
        return Results.Ok(produtoEncontrado);

    return Results.NotFound("Produto não encontrado");
});

//DELETE: http://localhost:5016/api/produto/deletar/id_produto
app.MapDelete("/api/produto/deletar/{id}", ([FromRoute]string id) =>
{
    Produto? produtoDeletar = produtos.FirstOrDefault(p => p.Id == id);

    if(produtoDeletar != null)
    {
        produtos.Remove(produtoDeletar);
        return Results.Ok("Produto deletado com sucesso!");
    }

    return Results.NotFound("Produto não encontrado");
} );

app.MapPut("/api/produto/alterar/{id}", ([FromRoute]string id, [FromBody]Produto? produtoAlterado) =>
{
    if(produtoAlterado is null)
        return Results.BadRequest("Produto inválido.");

    if (string.IsNullOrWhiteSpace(produtoAlterado.Nome) || produtoAlterado.Valor <= 0)
        return Results.BadRequest("Dados do produto são obrigatórios.");
    
    if (produtos.FirstOrDefault(produtosCadastrados => produtosCadastrados.Nome == produtoAlterado.Nome && produtosCadastrados.Id != id) != null)
        return Results.BadRequest("Esse produto já foi cadastrado");

    Produto? produtoEncontrado = produtos.FirstOrDefault(p => p.Id == id);  

    if(produtoEncontrado != null)
    {
        produtoEncontrado.Nome = produtoAlterado.Nome;
        produtoEncontrado.Valor = produtoAlterado.Valor;
        return Results.Ok("Produto atualizado com sucesso!");
    }

    return Results.NotFound("Produto não encontrado");

});

app.Run();