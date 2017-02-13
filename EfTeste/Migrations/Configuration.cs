using System.Collections.Generic;
using EfTeste.Models;

namespace EfTeste.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EfTeste.EfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EfTeste.EfContext context)
        {

            var cpf = new DocumentoTipo
            {
                Nome = "CPF"
            };

            context.DocumentosTipos.Add(cpf);

            var rg = new DocumentoTipo
            {
                Nome = "RG"
            };

            context.DocumentosTipos.Add(rg);
            context.SaveChanges();


            var documentoTipo = context.DocumentosTipos.Find(1);

            var doc = new Documento
            {
                DocumentoTipo =  documentoTipo,
                Numero= "23456789099"
            };

            

            var pessoa = new Pessoa
            {
                Nome = "Fulano de Tal",
                Documentos = new List<Documento>() { doc }
            };

            context.Pessoas.Add(pessoa);
            

            context.SaveChanges();
        }
    }
}
