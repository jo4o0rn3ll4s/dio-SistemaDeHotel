using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.models
{
    public class Reserva
    {   
        // Propriedades
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        
        // Construtores e Overlays
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;

        }

        // Métodos
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException($"O número de vagas disponíveis para a suíte {Suite.TipoSuite} é de {Suite.Capacidade}, sendo assim impossível alocar {hospedes.Count} pessoas.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor*(10/100);
            }
            return valor;
        }
    }
}