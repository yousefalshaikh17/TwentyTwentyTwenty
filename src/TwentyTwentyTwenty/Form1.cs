using System.Diagnostics;
using Microsoft.Toolkit.Uwp.Notifications;

namespace TwentyTwentyTwenty
{
    public partial class Form1 : Form
    {
        int reminderMinutes;
        int durationSeconds;
        int distanceFeet;
        bool playSoundWhenDone;
        bool allowSnooze;
        int snoozeMinutes;

        public Form1(int reminderMinutes = 20, int durationSeconds = 20, int distanceFeet = 20, bool allowSnooze = true, int snoozeMinutes = 5)
        {
            InitializeComponent();

            this.reminderMinutes = reminderMinutes;
            this.durationSeconds = durationSeconds;
            this.distanceFeet = distanceFeet;
            this.allowSnooze = allowSnooze;
            this.snoozeMinutes = snoozeMinutes;

            Load += Form1_Load;
            ShowSnoozeToast();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Hide main form
            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
            //this.Hide();

            // Register the Toast activation handler
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                var arguments = toastArgs.Argument;

                if (arguments.Contains("action=snoozeTimer"))
                    SnoozeReminder();
            };

            // Start timer
            //routineTimer.Start();
            notificationTimer.Start();

            //DisplayOverlay();
        }

        private void ShowSnoozeToast()
        {
            new ToastContentBuilder()
                .AddArgument("action", "snoozeTimer")
                .AddText("It has almost been 20 minutes!")
                .AddText("Please prepare yourself. If you'd like to snooze, press the snooze button.")
                .AddButton(new ToastButton()
                    .SetContent("Snooze")
                    .AddArgument("action", "snoozeTimer")
                    .SetBackgroundActivation())
                .Show();
        }

        private void SnoozeReminder()
        {
            Debug.WriteLine("Snooze");
        }

        private void StartReminderTimer(object? sender, EventArgs e)
        {
            routineTimer.Start();
            notificationTimer.Start();
        }

        private void DisplayOverlay()
        {
            routineTimer.Stop();
            notificationTimer.Stop();

            FormOverlay display = new FormOverlay(durationSeconds, distanceFeet);
            display.FormClosed += StartReminderTimer;
            display.Show();
        }


        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            notificationTimer.Stop();
            if (allowSnooze)
            {
                ShowSnoozeToast();
            }
        }

        private void RoutineTimer_Tick(object sender, EventArgs e)
        {
            //var overlay = new FormOverlay();
            //overlay.Show();
        }
    }
}
