using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDeNoiAltri
{
    public class Mago : Personaggio
    {
        public Mago(string nome) : base(nome)
        {
            PuntiMagia = 100;
        }

        public int PuntiMagia { get; set; }

    }
}
