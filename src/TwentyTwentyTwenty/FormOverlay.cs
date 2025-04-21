using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TwentyTwentyTwenty;

namespace TwentyTwentyTwenty
{
    public partial class FormOverlay : Form
    {
        private int secondsLeft = 20;

        private readonly int durationSeconds;
        private readonly int distanceFeet;

        public FormOverlay(int durationSeconds, int distanceFeet)
        {
            InitializeComponent();

            this.durationSeconds = durationSeconds;
            this.distanceFeet = distanceFeet;

            KeyPreview = true;
            Load += FormOverlay_Load;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cleanup timer
            countdownTimer.Stop();
            countdownTimer.Dispose();

            base.OnFormClosing(e);
        }

        private void CountdownFinished()
        {
            Close();
        }

        private void UpdateCountdownDisplay()
        {
            countdownLabel.Text = secondsLeft.ToString();
        }

        private void StartCountdown()
        {
            secondsLeft = durationSeconds;
            UpdateCountdownDisplay();
            countdownTimer.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            startButton.Visible = false;
            instructionLabel.Text = LocalizationManager.GetFormattedString("CountdownInstructionMessage", new Dictionary<string, object>
            {
                ["distance"] = 20,
            });
            StartCountdown();
            countdownLabel.Visible = true;
        }

        private void FormOverlay_Load(object? sender, EventArgs e)
        {
            instructionLabel.Text = LocalizationManager.GetFormattedString("StartInstructionMessage", new Dictionary<string, object>
            {
                ["distance"] = 20,
                ["seconds"] = 20,
            });

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Close();
                }
            };
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft -= 1;
            if (secondsLeft > 0)
                UpdateCountdownDisplay();
            else
                CountdownFinished();
        }
    }
}
