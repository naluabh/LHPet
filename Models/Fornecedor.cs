using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPet.Models
{
    public class Fornecedor
    {
        public Fornecedor(int id, string nome, string cnpj, string email)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
            Email = email;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }

    }
}