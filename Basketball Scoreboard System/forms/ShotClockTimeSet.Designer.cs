namespace Basketball_Scoreboard_System.forms
{
    partial class ShotClockTimeSet
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.SecondsSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(12, 41);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(64, 24);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(83, 41);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(64, 24);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.Location = new System.Drawing.Point(95, 12);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(52, 23);
            this.LabelSeconds.TabIndex = 11;
            this.LabelSeconds.Text = "Seconds";
            this.LabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondsSelector
            // 
            this.SecondsSelector.Location = new System.Drawing.Point(12, 12);
            this.SecondsSelector.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsSelector.Name = "SecondsSelector";
            this.SecondsSelector.Size = new System.Drawing.Size(77, 23);
            this.SecondsSelector.TabIndex = 9;
            this.SecondsSelector.ValueChanged += new System.EventHandler(this.SecondsSelector_ValueChanged);
            // 
            // ShotClockTimeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 76);
            this.ControlBox = false;
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.SecondsSelector);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(175, 115);
            this.MinimumSize = new System.Drawing.Size(175, 115);
            this.Name = "ShotClockTimeSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Time";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonOK;
        private Label LabelSeconds;
        public NumericUpDown SecondsSelector;
    }
}