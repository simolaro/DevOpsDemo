﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get;  }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0 ; distance < radius / 2 ; distance++)
                foreach(Enemy enemy in game.Enemies)
                {
                    if(Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;    
                    }
                }
            target = Move(direction, target, game.Boundaries);
            return false;
        }
        
    }
}
