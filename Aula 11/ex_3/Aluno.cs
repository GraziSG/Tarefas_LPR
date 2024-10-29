using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOOex3
{
    internal class Aluno
    {
        public string nome;
        public short marticula;
        public double prova1;
        public double prova2;
        public double trabalho;

        public double media()
        {
            return ((prova1 * 2.5) + (prova2 * 2.5) + (trabalho * 2)) / 7;

        }
        public double final()
        {
            if (media() < 6)
            {
                return 6 - media();
            }
            return 0;
        }
    }
}