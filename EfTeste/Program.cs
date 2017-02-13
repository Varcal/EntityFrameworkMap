using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EfTeste.Models;

namespace EfTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EfContext())
            {
                var pessoa = context.Pessoas.Include(x => x.Documentos).SingleOrDefault(x=>x.Id == 2);

                if (pessoa == null) return;
               
                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
            }

            
            Console.ReadKey();
        }
    }
}
