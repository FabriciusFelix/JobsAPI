using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJobs.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public bool Ativo { get; set; }
        public decimal Salario { get; set; }
    }
}