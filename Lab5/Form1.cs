namespace Programming
{
    public partial class Form1 : Form
    {
        private MyFigure fig;
        public Form1()
        {
            InitializeComponent();
        }

        private void increaseMovementValue_Click(object sender, EventArgs e)
        {
            int movementPerSecond = Convert.ToInt32(movementPerSecondStatusLabel.Text) + 1;
            movementPerSecondStatusLabel.Text = movementPerSecond.ToString();
            formTimer.Interval = Convert.ToInt32(1000.0 / movementPerSecond);
        }

        private void decreaseMovementValue_Click(object sender, EventArgs e)
        {
            int movementPerSecond = Convert.ToInt32(movementPerSecondStatusLabel.Text) - 1;
            movementPerSecondStatusLabel.Text = movementPerSecond.ToString();
            formTimer.Interval = Convert.ToInt32(1000.0 / movementPerSecond);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formPictureBox.Image = new Bitmap(formPictureBox.Width, formPictureBox.Height);

            fig = new MyFigure(formPictureBox, 750);
            formTimer.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTimer.Enabled = false;
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            fig.Move();
            labelPosX.Text = fig.posX.ToString();
            labelPosY.Text = fig.posY.ToString();
        }
    }
}