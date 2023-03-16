using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonis
{
    class Orc
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int Damage { get; private set; }

        public Orc(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Attack()
        {
            // Perform attack logic here
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
