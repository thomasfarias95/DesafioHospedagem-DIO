using System.Net.Security;
using System.Security.Authentication;
using System.Text;
using Desafio_Projeto_Hospedagem_de_Hotel__DIO.Models;

  
            
            Console.OutputEncoding = Encoding.UTF8;

           
            List<Pessoa> hospedes = new List<Pessoa>();

            
            Pessoa p1 = new Pessoa(nome: "Hóspede", sobrenome: "1");
            Pessoa p2 = new Pessoa(nome: "Hóspede", sobrenome: "2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", valorDiaria: 30.00M, capacidade: 2);

            
            Reserva reserva = new Reserva(diasReservados: 5);
            
            try
            {
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(hospedes);
                
                
                Console.WriteLine("--- Detalhes da Reserva ---");
                Console.WriteLine($"Suíte: {reserva.Suite.TipoSuite}");
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Dias Reservados: {reserva.DiasReservados}");
                Console.WriteLine($"Valor Diária Bruto: R$ {reserva.Suite.ValorDiaria:N2}");
                Console.WriteLine($"Valor Total da Reserva: R$ {reserva.CalcularValorDiaria():N2}");
                
                Console.WriteLine("\nTeste de Desconto (Reservando 10 dias):");
                Reserva reservaDesconto = new Reserva(10);
                reservaDesconto.CadastrarSuite(suite);
                reservaDesconto.CadastrarHospedes(hospedes);
                Console.WriteLine($"Valor Total (10 dias, com 10% desconto): R$ {reservaDesconto.CalcularValorDiaria():N2}");

            }
            catch (Excecao ex)
            {
                Console.WriteLine($"\n[ERRO] Não foi possível completar a reserva: {ex.Message}");
            }
        
    