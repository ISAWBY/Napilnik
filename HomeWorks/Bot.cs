﻿using System;

namespace HomeWorks
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
        }

        public void OnSeePlayer(Player player)
        {
            if (player == null) throw new ArgumentNullException(nameof(player));
            if (player.Dead) return;
            
            _weapon.Fire(player);
        }
    }
}