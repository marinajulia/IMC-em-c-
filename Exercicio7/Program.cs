using System;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a sua altura:");
            double alturaPaciente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso");
            double pesoPaciente = Convert.ToDouble(Console.ReadLine());

            Pessoa paciente = new Pessoa();
            paciente.altura = alturaPaciente;
            paciente.peso = pesoPaciente;
            paciente.mensagem();

 
        }
    }
}
