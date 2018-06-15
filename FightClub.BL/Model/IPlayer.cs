using System;

namespace FightClub.BL
{
    public interface IPlayer
    {
        string Name { get; }
        int HealthPoints { get; set; }
        BodyPart Blocked { get; set; }
        void GetHit(BodyPart choseBodyPart);
        event EventHandler<PlayerEventArgs> WoundEvent;
        event EventHandler<PlayerEventArgs> DeathEvent;
        event EventHandler<PlayerEventArgs> BlockEvent;
    }
}