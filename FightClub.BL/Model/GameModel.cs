using System;

namespace FightClub.BL
{
    public class GameModelEventArgs : EventArgs
    {
        public int RoundSequence { get; }

        public GameModelEventArgs(int roundSequence)
        {
            RoundSequence = roundSequence;
        }
    }

    public class GameModel : IGameModel
    {
        private readonly int totalPlayers = 2;
        public IPlayer Human { get; }
        public IPlayer Computer { get; }
        private int round;

        public GameModel(string userName)
        {
            Human = new Player(userName);
            Computer = new Player("Computer");
        }
        public event EventHandler<GameModelEventArgs> Start;

        public void NextMove(BodyPart bodyPart)
        {
            round++;
            switch (round % 2)
            {
                case 0: // Computer attack
                    Human.Blocked = bodyPart;
                    Human.GetHit((BodyPart)(new Random()).Next(Enum.GetNames(typeof(BodyPart)).Length)); // Computer choose random BodyPart
                    break;
                case 1: // Player attack
                    Computer.Blocked = (BodyPart)(new Random()).Next(Enum.GetNames(typeof(BodyPart)).Length);  // Computer choose random BodyPart
                    Computer.GetHit(bodyPart);
                    break;
                default:
                    break;
            }
        }

        public void StartGame()
        {
            //Randomly determine who will play first
            // round==0 -> Human 
            // round==1 -> Computer 
            round = new Random().Next(0, totalPlayers);
            Human.HealthPoints = Player.maxHealthPoints;
            Computer.HealthPoints = Player.maxHealthPoints;
            Start?.Invoke(this, new GameModelEventArgs(round));
        }
    }
}

