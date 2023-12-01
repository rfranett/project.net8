using project.net8.models ;

int quantidadeEmEstoque = 3 ;
int quantidadeDeCompra = 0 ;
bool possivelVenda = quantidadeDeCompra > 0 && quantidadeEmEstoque >= quantidadeDeCompra;


Console.WriteLine($"Quantidade Em Estoque:{quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de Compra:{quantidadeDeCompra}");
Console.WriteLine($"É Possivel Realizar a Venda? {possivelVenda}");

if (quantidadeDeCompra == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda Realizada.");
}
else 
{
    Console.WriteLine("Desculpa. Não Temos a Quantidade Desejada em Estoque.");
}