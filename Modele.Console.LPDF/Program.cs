using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jalon1.Entities;
using Jalon1;


namespace Modele.Console.LPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();

            ctx.Editeurs.Add(new Editeur("Timothé"));
            ctx.SaveChanges();
        }
    }
}
