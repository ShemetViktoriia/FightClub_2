using FightClub.BL;

namespace FightClub_2
{
    public interface IView
    {
        // Logging of each outcome of the round
        void BlockDisplay(object sender, PlayerEventArgs e);
        void WoundDisplay(object sender, PlayerEventArgs e);
        void DeathDisplay(object sender, PlayerEventArgs e);

        // Beginning of the game
        void StartGameDisplay(object sender, GameModelEventArgs e);
        // End of the game
        void IsStartNewGame(object sender, PlayerEventArgs e);

        // Display health points on the form
        void LoadHealthPointsHuman(object sender, PlayerEventArgs e);
        void LoadHealthPointsComputer(object sender, PlayerEventArgs e);
    }
}
