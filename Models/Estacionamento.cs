namespace SistemaDeEstacionamento.Models
{
  public class Estacionamento
  {
    private decimal _precoInicial;
    private decimal _precoPorHora;
    private List<string> _veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
      _precoInicial = precoInicial;
      _precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
      Console.Write("Digite a placa do veículo para estacionar: ");
      string? placa = Console.ReadLine();
      if (String.IsNullOrEmpty(placa)) return;
      _veiculos.Add(placa);
    }

    public void RemoverVeiculo()
    {
      Console.Write("Digite a placa do veículo para remover: ");
      string? placa = Console.ReadLine();
      if (String.IsNullOrEmpty(placa)) return;
      if (_veiculos.Any((veiculo) => veiculo.ToUpper() == placa.ToUpper()))
      {
        Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        int.TryParse(Console.ReadLine(), out int horasNoEstacionamento);
        decimal precoTotal = _precoInicial + (_precoPorHora * horasNoEstacionamento);
        _veiculos.Remove(placa);
        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: ${precoTotal:.00}");
      }
      else Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }

    public void ListarVeiculos()
    {
      if (!_veiculos.Any()) Console.WriteLine("Não há veículos estacionados.");
      else
      {
        Console.WriteLine("Os veículos estacionados são:");
        foreach (string veiculo in _veiculos) Console.WriteLine(veiculo);
      }
    }
  }
}