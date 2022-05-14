using Jalon1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly Context context;
        private static Manager _manager = null;

        public Manager()
        {
            context = new Context();
        }
    }
}
