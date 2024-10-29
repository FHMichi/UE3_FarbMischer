namespace UE3_FarbMischer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateColor(object sender, EventArgs e)
        {
            pan.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value);
            lblRed.Text = trkRed.Value.ToString();
            lblGreen.Text = trkGreen.Value.ToString();
            lblBlue.Text = trkBlue.Value.ToString();
        }
    }
}
