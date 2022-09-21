namespace Flappy_Bird_Game
{
    public partial class Form1: Form


    {

        int gravity = 10;
        int pipeSpeed = 12;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;

            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;

            scoreText.Text = "Score: " + score;

            if (pipeTop.Left <-170)
            {
                pipeTop.Left = 800;
                score++;
            }
            if (pipeBottom.Left <-170)
            {
                pipeBottom.Left = 1300;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gameKeyIsDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void endGame ()
        {
            gameTimer.Stop();
            scoreText.Text += "        !!!Game Over!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}