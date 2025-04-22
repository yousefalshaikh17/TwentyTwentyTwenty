namespace TwentyTwentyTwenty
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            routineTimer = new System.Windows.Forms.Timer(components);
            notificationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // routineTimer
            // 
            routineTimer.Interval = 20000;
            routineTimer.Tick += RoutineTimer_Tick;
            // 
            // notificationTimer
            // 
            notificationTimer.Interval = 5000;
            notificationTimer.Tick += NotificationTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer routineTimer;
        private System.Windows.Forms.Timer notificationTimer;
    }
}
