namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine();
            Console.WriteLine("Padrão Mercosul - AAA1A11");
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            
            string plate = Console.ReadLine();
            plate = plate.ToUpper();

            if (string.IsNullOrWhiteSpace(plate) != true)
            {
                if (plate.Length == 7)
                {
                    veiculos.Add(plate);
                }
                else
                {
                    Console.WriteLine("Você ultrapassou os limites de caracteres. Rever o padrão da Placa.");
                }
            }
            else
            {
                Console.WriteLine("Você só poderá inserir valores válidos.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine();
            Console.WriteLine("Digite a placa do veículo para remover:");

            for (int aux = 0; aux < veiculos.Count; aux++)
            {
                Console.WriteLine($"{aux} - {veiculos[aux]}");
            }

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());;
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine();
                Console.WriteLine("Os veículos estacionados são:");

                for (int aux = 0; aux < veiculos.Count; aux++)
                {
                    Console.WriteLine($"{aux} - {veiculos[aux]}");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
