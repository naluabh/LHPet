using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPet.Models
{
    public class Cliente
    {
        public Cliente(int id,string nome, string cpf, string email, string paciente)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Paciente = paciente;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Paciente { get; set; }

    }
}