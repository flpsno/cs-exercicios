using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    public class CadCliDB:DbContext
    {
        public CadCliDB()
            //: base(@"Data Source=(localdb)\v11.0;Initial Catalog=cadclidb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
            : base(@"Server=tcp:demo483.database.windows.net,1433;Initial Catalog=cadclidb;Persist Security Info=False;User ID=fabiano;Password=AzurePa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            Database.SetInitializer(new CargaInicial());
        }


        public DbSet<Cliente> Clientes { get; set; }


    }

    public class CargaInicial : CreateDatabaseIfNotExists<CadCliDB>
    {
        protected override void Seed(CadCliDB context)
        {
            var clientes = new List<Cliente> { 
                new Cliente{Nome="Fabiano"},
                new Cliente{Nome="Priscila",Idade = 39},
                new Cliente{Nome="Raphael",Idade = 17},
                new Cliente{Nome="Isabel",Idade = 58},
            };

            context.Clientes.AddRange(clientes);
            context.SaveChanges();



        }
    }


}
