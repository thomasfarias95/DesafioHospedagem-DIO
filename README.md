Sistema Básico de Gerenciamento de Hospedagem em C#


🏨 Visão Geral do Projeto

Este projeto é uma implementação básica de um sistema de gerenciamento de reservas e cálculo de diárias para um hotel, desenvolvido em C#. O foco principal é aplicar conceitos de Programação Orientada a Objetos (POO), como encapsulamento de dados, e implementar regras de negócio robustas com tratamento de exceções personalizadas.

O projeto utiliza a estrutura de Console Application (.NET 7/8) e está contido no namespace Desafio_Projeto_Hospedagem_de_Hotel__DIO.Models.

🏗️ Estrutura e Classes Principais

O sistema é construído em torno de três entidades principais, além de uma classe de exceção personalizada para lidar com erros de validação:

Classe

Descrição

Pessoa

Representa o hóspede, contendo nome e sobrenome.

Suite

Representa o quarto ou suíte. Contém TipoSuite, ValorDiaria e a Capacidade máxima de hóspedes.

Reserva

A classe central de negócio. Associa uma Suite a uma lista de Hospedes por um período de DiasReservados. Contém a lógica de cálculo de valor e validação de capacidade.

Excecao

Uma classe de exceção customizada (class Excecao : Exception) usada para lançar erros de regra de negócio, como exceder a capacidade.

🎯 Regras de Negócio Implementadas

As regras de negócio são validadas e calculadas dentro da classe Reserva:

1. Validação de Capacidade (Impedimento de Reserva)
O método CadastrarHospedes garante que:

A lista de hóspedes (hospedes.Count) não exceda a Capacidade da Suite cadastrada.

Se a capacidade for excedida, uma exceção do tipo Excecao é lançada, impedindo o cadastro da reserva.

2. Cálculo da Diária com Desconto
O método CalcularValorDiaria determina o valor total da hospedagem, aplicando a seguinte regra:

Se o número de DiasReservados for igual ou superior a 10, é concedido um desconto de 10% sobre o valor total.

🚀 Como Executar o Projeto

Pré-requisito: Certifique-se de ter o .NET SDK (versão 6.0 ou superior) instalado.

Execução: Navegue até a pasta raiz do projeto no seu terminal (onde o arquivo .csproj está) e use o comando:

dotnet run

Exemplo de Saída (Demonstração)
A classe Program no arquivo demonstra dois cenários: uma reserva normal e um teste de desconto.

--- Detalhes da Reserva ---
Suíte: Premium
Hóspedes: 2
Dias Reservados: 5
Valor Diária Bruto: R$ 30,00
Valor Total da Reserva: R$ 150,00

Teste de Desconto (Reservando 10 dias):
Valor Total (10 dias, com 10% desconto): R$ 270,00
