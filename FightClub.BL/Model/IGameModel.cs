using System;

namespace FightClub.BL
{
    public interface IGameModel
    {
        event EventHandler<GameModelEventArgs> Start;
        IPlayer Human { get; }
        IPlayer Computer { get; }
        void StartGame();
        void NextMove(BodyPart bodyPart);
    }
}
