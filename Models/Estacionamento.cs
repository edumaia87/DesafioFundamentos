namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal PrecoInicial = 0;
        private readonly decimal PrecoPorHora = 0;
        private readonly List<string> Veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            Veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {valorTotal},00");
            } else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for (int i = 0; i < Veiculos.Count; i++)
                {
                    Console.WriteLine($"{Veiculos[i]}\n");
                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}