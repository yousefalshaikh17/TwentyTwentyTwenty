namespace TwentyTwentyTwenty
{
    partial class FormOverlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startButton = new Button();
            instructionLabel = new Label();
            countdownLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            countdownTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top;
            startButton.AutoSize = true;
            startButton.Font = new Font("Arial", 24F);
            startButton.Location = new Point(233, 440);
            startButton.Margin = new Padding(3, 10, 3, 3);
            startButton.Name = "startButton";
            startButton.Size = new Size(333, 7);
            startButton.TabIndex = 1;
            startButton.Text = "Start Countdown";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Dock = DockStyle.Fill;
            instructionLabel.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionLabel.ForeColor = Color.White;
            instructionLabel.Location = new Point(3, 0);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(794, 215);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Test Test Test Test Test Test ";
            instructionLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // countdownLabel
            // 
            countdownLabel.AutoSize = true;
            countdownLabel.Dock = DockStyle.Fill;
            countdownLabel.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countdownLabel.ForeColor = Color.White;
            countdownLabel.Location = new Point(3, 215);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(794, 215);
            countdownLabel.TabIndex = 2;
            countdownLabel.Text = "00";
            countdownLabel.TextAlign = ContentAlignment.TopCenter;
            countdownLabel.Visible = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(instructionLabel, 0, 0);
            tableLayoutPanel.Controls.Add(startButton, 0, 1);
            tableLayoutPanel.Controls.Add(countdownLabel, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            // 
            // FormOverlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Name = "FormOverlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "20-20-20 Timer";
            TopMost = true;
            Load += FormOverlay_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button startButton;
        private Label instructionLabel;
        private Label countdownLabel;
        private TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Timer countdownTimer;
    }
}