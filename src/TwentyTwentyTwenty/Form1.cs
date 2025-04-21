using System.Diagnostics;

namespace TwentyTwentyTwenty
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Hide main form
            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
            //this.Hide();

            // Start timer
            this.routine_timer.Start();

            int durationSeconds = 20;
            int distanceFeet = 20;

            bool playSoundWhenDone = true;
            bool allowSnooze = true;
            int snoozeMinutes = 5;

            new FormOverlay(durationSeconds, distanceFeet).Show();
        }

        private void routine_timer_Tick(object sender, EventArgs e)
        {
            //var overlay = new FormOverlay();
            //overlay.Show();
        }
    }
}
