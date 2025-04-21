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
            this.routineTimer.Start();



            DisplayOverlay();
        }
        private void ContinueTimer(object? sender, EventArgs e)
        {
            routineTimer.Start();
        }

        private void DisplayOverlay()
        {
            routineTimer.Stop();
            int durationSeconds = 20;
            int distanceFeet = 20;
            bool playSoundWhenDone = true;
            bool allowSnooze = true;
            int snoozeMinutes = 5;
            FormOverlay display = new FormOverlay(durationSeconds, distanceFeet);
            display.FormClosed += ContinueTimer;
            display.Show();

        }

        private void RoutineTimer_Tick(object sender, EventArgs e)
        {
            //var overlay = new FormOverlay();
            //overlay.Show();
        }
    }
}
