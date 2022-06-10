namespace NewTEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Level_CheckedChanged(object sender, EventArgs e)
            => tBox_Words.Text = (sender as RadioButton)?.Tag.ToString();
    }
}