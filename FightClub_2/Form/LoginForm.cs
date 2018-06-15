using System;
using FightClub.BL;
using System.Windows.Forms;


namespace FightClub_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            IGameModel gameModel = new GameModel(txtUserName.Text);
            GameForm gameForm = new GameForm(gameModel);
            gameForm.FormClosed += GameForm_FormClosed;
            this.Hide();
            gameForm.Show();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            btnGO.Enabled = (String.IsNullOrEmpty(txtUserName.Text) || (txtUserName.Text).IndexOf(" ") == 0) ? false : true;
        }
    }
}
