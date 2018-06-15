using System;
using System.Windows.Forms;
using FightClub.BL;

namespace FightClub_2
{
    public partial class GameForm : Form, IView, IController
    {
        private readonly IGameModel _game;
        public GameForm(IGameModel game)
        {
            InitializeComponent();
            _game = game;
        }

        #region Implements interface IView
        public void BlockDisplay(object sender, PlayerEventArgs e)
        {
            richTextBox.AppendText("  "+"<"+e.Name +">"+ "\tis blocked");
            //MessageBox.Show(e.Health.ToString());
            ChangeLabelAttackOrProtect();
        }

        public void WoundDisplay(object sender, PlayerEventArgs e)
        {
            richTextBox.AppendText("  "+ "<" + e.Name + ">" + "\tis wounded");
            //MessageBox.Show(e.Health.ToString());
            ChangeLabelAttackOrProtect();
        }

        public void DeathDisplay(object sender, PlayerEventArgs e)
        {
            richTextBox.AppendText("  "+ "<"+e.Name + ">" + "\tis DEAD!");
            //MessageBox.Show(e.Health.ToString());
            btnHead.Enabled = false;
            btnTorso.Enabled = false;
            btnLegs.Enabled = false;
        }

        public void StartGameDisplay(object sender, GameModelEventArgs e)
        {
            richTextBox.Clear();
            if (e.RoundSequence % 2 == 0)
            {
                richTextBox.AppendText("  Firstly you attack Computer, hit him\n");
                lblAttackOrProtect.Text = "Attack";
            }
            else
            {
                richTextBox.AppendText("  Firstly Computer attacks you, protect yourself\n");
                lblAttackOrProtect.Text = "Protect";
            }
        }

        public void IsStartNewGame(object sender, PlayerEventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show(e.Name + " lost. \nHow about new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                btnHead.Enabled = true;
                btnTorso.Enabled = true;
                btnLegs.Enabled = true;
                _game.StartGame();
            }
        }

        public void LoadHealthPointsHuman(object sender, PlayerEventArgs e)
        {
            lblHumanHp.Text = e.Health.ToString();
            progressBarHuman.Value = e.Health;
        }

        public void LoadHealthPointsComputer(object sender, PlayerEventArgs e)
        {
            lblComputerHp.Text = e.Health.ToString();
            progressBarComputer.Value = e.Health;
        }
        #endregion


        #region Implements interface IController
        public void ButtonPartBody_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnHead)
                _game.NextMove(BodyPart.Head);
            else if (btn == btnTorso)
                _game.NextMove(BodyPart.Torso);
            else if (btn == btnLegs)
                _game.NextMove(BodyPart.Legs);
        }
        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
            _game.Human.BlockEvent += BlockDisplay;
            _game.Computer.BlockEvent += BlockDisplay;
            _game.Human.WoundEvent += WoundDisplay;
            _game.Human.WoundEvent += LoadHealthPointsHuman;
            _game.Computer.WoundEvent += WoundDisplay;
            _game.Computer.WoundEvent += LoadHealthPointsComputer;
            _game.Human.DeathEvent += DeathDisplay;
            _game.Computer.DeathEvent += DeathDisplay;
            _game.Human.DeathEvent += LoadHealthPointsHuman;
            _game.Computer.DeathEvent += LoadHealthPointsComputer;
            _game.Human.DeathEvent += IsStartNewGame;
            _game.Computer.DeathEvent += IsStartNewGame;
            _game.Start += StartGameDisplay;
            _game.StartGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Game Fight Club.\nGood luck!","Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetDefaultValues()
        {
            lblHuman.Text = _game.Human.Name;
            lblComputer.Text = _game.Computer.Name;
            lblHumanHp.Text = _game.Human.HealthPoints.ToString();
            lblComputerHp.Text = _game.Human.HealthPoints.ToString();
            progressBarHuman.Value = _game.Human.HealthPoints;
            progressBarComputer.Value = _game.Computer.HealthPoints;
            toolStripStatusLabel.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss dddd");
        }

        private void ChangeLabelAttackOrProtect()
        {
            if (lblAttackOrProtect.Text == "Attack")
            {
                lblAttackOrProtect.Text = "Protect";
                richTextBox.AppendText("  ->\tprotect yourself\n");
            }
            else
            {
                lblAttackOrProtect.Text = "Attack";
                richTextBox.AppendText("  ->\thit enemy\n");
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.ScrollToCaret();
        }

       
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you really want to quit this game? ", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No) e.Cancel=true;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Close();
        }
    }
}
