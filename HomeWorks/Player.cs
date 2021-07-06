using System;

namespace HomeWorks
{
    class Player
    {
        private int _health;
        
        public Player(int health)
        {
            _health = health > 0 ?  health : throw new ArgumentOutOfRangeException();
        }
        
        public bool Dead => _health <= 0;
        
        public void TakeDamage(int damage)
        {
            if (Dead) throw new InvalidOperationException(nameof(TakeDamage));
            if (damage < 0) throw new ArgumentOutOfRangeException(nameof(damage));

            _health -= damage;

            if (_health <= 0) 
                _health = 0;
        }
    }
}