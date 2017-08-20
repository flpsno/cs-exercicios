using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRemoteData.Core.Entities;


namespace DemoRemoteData.Core.EF
{
    internal class EscolaDB:DbContext
    {
        public EscolaDB()
            : base(@"Data Source=(localdb)\v11.0;Initial Catalog=Escoladb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
            //: base(@"Server=tcp:demowcf.database.windows.net,1433;Initial Catalog=escoladb;Persist Security Info=False;User ID=fabiano;Password=AzurePa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            Database.SetInitializer(new CargaInicialDados());
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }

    internal class CargaInicialDados : CreateDatabaseIfNotExists<EscolaDB>
    {
        protected override void Seed(EscolaDB context)
        {
            var alunos = new List<Aluno> { 
                new Aluno{ Nome="Raphael Nalin", Sexo=Sexo.Masculino, Idade = 17},
                new Aluno{Nome="João da Silva", Sexo=Sexo.Masculino, Idade = 6},
                new Aluno{Nome="Maria Joaquina Santos",Sexo=Sexo.Feminino, Idade = 10} 
            };

            context.Alunos.AddRange(alunos);

            var funcionario = new Funcionario("Fabiano", "XYZ4477");
            context.Funcionarios.Add(funcionario);

            context.SaveChanges();


        }
    }

}
