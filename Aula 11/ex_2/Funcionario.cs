using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOOex2
{
    internal class Funcionario
    {
        public string nome;
        public double salario_bruto;
        public double imposto;

        public Funcionario (string Nome, double SalarioBruto)
        {
            nome = Nome;
            salario_bruto = SalarioBruto;
            CalcImposto();
        }

        public void CalcImposto()
        {
            if (salario_bruto <= 2000)
            {
                imposto = salario_bruto * 0.10;
            }
            else if (salario_bruto <= 3000)
            {
                imposto = salario_bruto * 0.15;
            }
            else
            {
                imposto = salario_bruto * 0.20;
            }
        }
        public void AumentSalario(double porcentagem)
        {
            salario_bruto += salario_bruto * (porcentagem / 100);
            CalcImposto();
        }

        public void MostrarDados()
        {
            Console.WriteLine($"\nNome: {nome} \nSalário Líquido = {salario_bruto - imposto}");
        }
    }
}
