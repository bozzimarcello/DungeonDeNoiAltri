using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDeNoiAltri
{
    public class Guerriero : Personaggio
    {
        public int PuntiForza { get; set; }
        public int PuntiArmatura { get; set; }

        public Guerriero(string nome) : base(nome)
        {
            PuntiForza = 10;
            PuntiArmatura = 5;
        }

        public override int Attacca()
        {
            int tiroDado = base.Attacca();
            return tiroDado + PuntiForza;
        }

        public override int Difendi()
        {
            int tiroDado = base.Difendi();
            return tiroDado + PuntiArmatura;
        }
    }
}
