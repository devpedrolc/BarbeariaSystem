using System.Text.Json;
using Barbearia.Domain.Models;

namespace Barbearia.Infrastructure.Data;

public class RepositorioFinanceiro
{
    private const string NomeArquivo = "financeiro.json";

    public void Salvar(List<Transacao> lista)
    {
        var opcoes = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(NomeArquivo, JsonSerializer.Serialize(lista, opcoes));
    }

    public List<Transacao> Carregar()
    {
        if (!File.Exists(NomeArquivo)) return new List<Transacao>();
        return JsonSerializer.Deserialize<List<Transacao>>(File.ReadAllText(NomeArquivo)) ?? new List<Transacao>();
    }
}