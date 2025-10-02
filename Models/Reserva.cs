using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Projeto_Hospedagem_de_Hotel__DIO.Models
{
     public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        
        public Reserva() 
        { 
            Hospedes = new List<Pessoa>(); 
        }

        public Reserva(int diasReservados) : this() 
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new Excecao("É necessário cadastrar a Suíte antes de cadastrar os hóspedes.");
            }

            if (Suite.Capacidade >= hospedes.Count) 
            {
                Hospedes = hospedes;
            } 
            else 
            {
               
                throw new Excecao($"Capacidade da suíte ({Suite.Capacidade}) excedida pelo número de hóspedes ({hospedes.Count}).");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                throw new Excecao("A suíte deve ser cadastrada para calcular o valor da diária.");
            }
            
          
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            
            if (DiasReservados >= 10) 
            {
                
                valorTotal *= 0.90M;
            }

            return valorTotal;
        }
    }

    [Serializable]
    internal class Excecao : Exception
    {
        public Excecao()
        {
        }

        public Excecao(string? message) : base(message)
        {
        }

        public Excecao(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
