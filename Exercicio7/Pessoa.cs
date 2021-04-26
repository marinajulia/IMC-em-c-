using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7 {
    class Pessoa {
        public double peso;
        public double altura;

        public double IMC() {

            return peso / (altura * altura);

        }
        public string Resultado(double imc) {

            string retorno;

            if (imc <= 18.5) {
                retorno = "Abaixo do peso";
            }
            else if (imc > 18.5 && imc <= 25) {
                retorno = "Peso normal";
            }
            else if (imc > 25 && imc <= 30) {
                retorno = "Acima do peso";
            }
            else if (imc > 30 && imc <= 35) {
                retorno = "Obesidade 1";
            }
            else if (imc > 45 && imc <= 40) {
                retorno = "Obesidade 2";
            }
            else if (imc >= 40) {
                retorno = "Obesidade 3";
            }
            else {
                retorno = "Obesidade 3";
            }
            return retorno ;

        }
        public void mensagem() {
            double obterIMC = IMC();
            string obterResultado = Resultado(obterIMC);

            Console.WriteLine("Seu IMC é: " + obterIMC);
            Console.WriteLine("Seu tipo é: " + obterResultado);
        }

    }

}