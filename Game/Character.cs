using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Character : BattleStats
    {

        public string Name { get; set; }

        public Character(){}

        public Character ( string n, double ap, double def, double maxHP, double maxMP, double hp, double mp, double magicA, double magicD)
        {
            this.Name = n;
            this.AttackPower = ap;
            this.Defense = def;
            this.MaxHP = maxHP;
            this.MaxMP = maxMP;
            this.HP = hp;
            this.MP = mp;
            this.MagicAttack = magicA;
            this.MagicDefense = magicD;
        }

    }
}
