using System;

namespace FightClub.BL
{
    /// <summary>
    /// This class is required so that event arguments can return the player's name and current health points
    /// </summary>
    public class PlayerEventArgs : EventArgs
    {
        public string Name { get; }
        public int Health { get; }

        public PlayerEventArgs(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }

    public class Player : IPlayer
    {
        /// <summary>
        /// Represents the event Block - the player blocked a part of the body from being hit
        /// </summary>
        public event EventHandler<PlayerEventArgs> BlockEvent;
        private void OnBlock()
        {
            BlockEvent?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
        }

        /// <summary>
        /// Represents the event Wound - the player didn't block a part of the body from being hit and did not lose all his health points
        /// </summary>
        public event EventHandler<PlayerEventArgs> WoundEvent;
        private void OnWound()
        {
            WoundEvent?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
        }

        /// <summary>
        /// Represents the event Death - the player didn't block a part of the body from being hit and lost all his health points
        /// </summary>
        public event EventHandler<PlayerEventArgs> DeathEvent;
        private void OnDeath()
        {
            DeathEvent?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
        }


        /// <summary>
        /// Property player's Name
        /// </summary>
        public string Name { get; }


        /// <summary>
        /// Property full player's Health Points
        /// </summary>
        private int healthPoints;
        public int HealthPoints
        {
            get => healthPoints;
            set
            {
                if (value > 0)
                {
                    healthPoints = value;
                    OnWound();
                }
                else
                {
                    healthPoints = 0;
                    OnDeath();
                }
            }
        }

        /// <summary>
        /// Property Blocked player's body part
        /// </summary>
        public BodyPart Blocked { get; set; }


        /// <summary>
        /// Const field player's Max Health Points
        /// </summary>
        public const int maxHealthPoints = 100;


        /// <summary>
        /// Readonly field player's Deducted Points
        /// </summary>
        private const int deductedHealthPoints = 10;


        /// <summary>
        /// Represents one-parameter constructor
        /// </summary>
        /// <param name="name">Player's name</param>
        public Player(string name)
        {
            Name = name;
        }


        /// <summary>
        /// Represents method of taking part of the body that was hited
        /// </summary>
        /// <param name="bodyPart">Player's body part</param>
        public void GetHit(BodyPart bodyPartHited)
        {
            if (Blocked == bodyPartHited) OnBlock();
            else HealthPoints -= deductedHealthPoints;
        }
    }
}
