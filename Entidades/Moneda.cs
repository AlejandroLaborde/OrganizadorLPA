using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moneda
    {
        private int monedaID;
        private string descripcion;

       
        public Moneda(int monedaID, string moneda)
        {
            this.monedaID = monedaID;
            this.descripcion = moneda;
        }
    }
}
