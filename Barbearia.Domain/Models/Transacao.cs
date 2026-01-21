namespace Barbearia.Domain.Models;

public enum TipoTransacao { Entrada, Saida }

public class Transacao
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public TipoTransacao Tipo { get; set; }
    public string BarbeiroResponsavel { get; set; } = "Sistema";
    public DateTime Data { get; set; } = DateTime.Now;
}