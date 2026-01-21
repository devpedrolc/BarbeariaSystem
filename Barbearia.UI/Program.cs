using Barbearia.Domain.Models;
using Barbearia.Infrastructure.Data;

var repo = new RepositorioFinanceiro();
var transacoes = repo.Carregar();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Novo Serviço | 2. Relatório | 0. Sair");
    var op = Console.ReadLine();
    if (op == "0") break;
    if (op == "1") Registrar();
    if (op == "2") Relatorio();
}

void Registrar()
{
    Console.Write("Valor: ");
    decimal.TryParse(Console.ReadLine(), out decimal v);
    transacoes.Add(new Transacao { Descricao = "Serviço", Valor = v, Tipo = TipoTransacao.Entrada });
    repo.Salvar(transacoes);
}

void Relatorio()
{
    Console.WriteLine($"Total: R$ {transacoes.Sum(t => t.Valor):N2}");
    Console.ReadKey();
}