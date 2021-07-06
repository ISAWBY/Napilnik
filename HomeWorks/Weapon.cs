using System;

namespace HomeWorks
{
    class Weapon
    {
        private readonly int _damage;
        private int _bullets;
        
        public Weapon(int damage, int bullets)
        {
            if(damage < 0 || bullets < 0) throw new ArgumentOutOfRangeException();
            
            _damage = damage;
            _bullets = bullets;
        }
        
        public void Fire(Player player)
        {
            if (_bullets <= 0) throw new ArgumentOutOfRangeException(nameof(_bullets));
            if (player == null) throw new ArgumentNullException(nameof(player));
            
            player.TakeDamage(_damage);
            _bullets--;
        }
    }
}