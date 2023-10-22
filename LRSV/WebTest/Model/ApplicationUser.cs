﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace WebTest.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Salario { get;set; }
        public string Cpf { get; set; }
        public string Genero { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string HorarioTrabalho { get; set; }
        public int JornadaSemanal { get; set; }
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public virtual ICollection<Beneficios> Beneficios { get; set; }
        public virtual ICollection<Pagamentos> Pagamentos { get; set; }
        public ApplicationUser()
        {
            Beneficios = new List<Beneficios>();
            Pagamentos = new List<Pagamentos>();
        }
    }
}
