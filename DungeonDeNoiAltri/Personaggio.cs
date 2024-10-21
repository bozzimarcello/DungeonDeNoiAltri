using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDeNoiAltri
{
    public class Personaggio
    {
        public string Nome { get; set; }
        public int PuntiVita { get; set; }
        public int PuntiEsperienza { get; set; }
        private Random random = new Random();
        const int DADO_ATTACCO = 10;
        const int DADO_DIFESA = 20;

        public Personaggio(string nome)
        {
            Nome = nome;
            PuntiVita = 100;
            PuntiEsperienza = 0;
        }

        public virtual int Attacca()
        {
            PuntiEsperienza += 10;
            int tiroDado = random.Next(1, DADO_ATTACCO + 1);
            return tiroDado;
        }

        public virtual int Difendi()
        {
            PuntiEsperienza += 10;
            int tiroDado = random.Next(1, DADO_DIFESA + 1);
            return tiroDado;
        }
    }

}
