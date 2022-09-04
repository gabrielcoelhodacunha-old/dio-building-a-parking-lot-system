namespace SistemaDeEstacionamento.Models
{
  public class Sistema
  {
    private Estacionamento? _estacionamento;

    public void Inicializar()
    {
      Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
      Console.Write("Digite o preço inicial: $");
      decimal.TryParse(Console.ReadLine(), out decimal precoInicial);
      Console.Write("Agora digite o preço por hora: $");
      decimal.TryParse(Console.ReadLine(), out decimal precoPorHora);
      _estacionamento = new Estacionamento(precoInicial, precoPorHora);
      int operacao;
      do
      {
        Console.Clear();
        operacao = _selecionarOperacao();
        _executarOperacao(operacao);
      } while (operacao != 4);
    }

    private int _selecionarOperacao()
    {
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Operacões disponíveis:");
      Console.WriteLine("[1] Cadastrar veículo");
      Console.WriteLine("[2] Remover veículo");
      Console.WriteLine("[3] Listar veículos");
      Console.WriteLine("[4] Encerrar");
      Console.WriteLine("----------------------------------------------------");
      Console.Write("Sua escolha: ");
      int.TryParse(Console.ReadLine(), out int operacao);
      Console.WriteLine("----------------------------------------------------");
      return operacao;
    }

    private void _executarOperacao(int operacao)
    {
      switch (operacao)
      {
        case 1:
          _estacionamento?.AdicionarVeiculo();
          break;
        case 2:
          _estacionamento?.RemoverVeiculo();
          break;
        case 3:
          _estacionamento?.ListarVeiculos();
          break;
        case 4:
          Console.WriteLine("Saindo ...");
          return;
        default:
          Console.WriteLine("Operacão inválida!");
          break;
      }
      Console.WriteLine("----------------------------------------------------");
      Console.Write("Pressione uma tecla para continuar");
      Console.ReadLine();
    }
  }
}