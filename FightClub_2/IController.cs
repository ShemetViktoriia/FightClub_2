using System;

namespace FightClub_2
{
    public interface IController
    {
        // Represents event by pressing one of the body parts buttons
        // The controller will collect data for transmission to the model
        void ButtonPartBody_Click(object sender, EventArgs e);
    }
}
