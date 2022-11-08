namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
                //Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if ( hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja maior que o número de hóspedes recebido
                Console.WriteLine("O numero de hospedes ultrapassa a quantidade suportada!!");
                throw new ArgumentException($"Quantidade suportada:{Suite.Capacidade} : Quantidade de hospedes:{hospedes.Count}");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int a;
            //Retorna a quantidade de hóspedes (propriedade Hospedes)
            a = Hospedes.Count;
            return a;
        }

        public decimal CalcularValorDiaria()
        {
            //Retorna o valor da diária

            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            decimal desconto = valor * (decimal)0.1; 
            if (DiasReservados >= 10)
            {
                valor = valor - desconto;
            }
            return valor;
        }
    }
}