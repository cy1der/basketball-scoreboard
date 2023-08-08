namespace Basketball_Scoreboard_System.forms
{
    partial class MainClockTimeSet
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
            this.MinutesSelector = new System.Windows.Forms.NumericUpDown();
            this.SecondsSelector = new System.Windows.Forms.NumericUpDown();
            this.MSSelector = new System.Windows.Forms.NumericUpDown();
            this.Colon = new System.Windows.Forms.Label();
            this.Dot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(12, 41);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(64, 24);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(83, 41);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(64, 24);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // MinutesSelector
            // 
            this.MinutesSelector.Location = new System.Drawing.Point(12, 12);
            this.MinutesSelector.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesSelector.Name = "MinutesSelector";
            this.MinutesSelector.Size = new System.Drawing.Size(35, 23);
            this.MinutesSelector.TabIndex = 4;
            this.MinutesSelector.ValueChanged += new System.EventHandler(this.MinutesSelector_ValueChanged);
            // 
            // SecondsSelector
            // 
            this.SecondsSelector.Location = new System.Drawing.Point(57, 12);
            this.SecondsSelector.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsSelector.Name = "SecondsSelector";
            this.SecondsSelector.Size = new System.Drawing.Size(35, 23);
            this.SecondsSelector.TabIndex = 5;
            this.SecondsSelector.ValueChanged += new System.EventHandler(this.SecondsSelector_ValueChanged);
            // 
            // MSSelector
            // 
            this.MSSelector.Location = new System.Drawing.Point(103, 12);
            this.MSSelector.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MSSelector.Name = "MSSelector";
            this.MSSelector.Size = new System.Drawing.Size(44, 23);
            this.MSSelector.TabIndex = 6;
            this.MSSelector.ValueChanged += new System.EventHandler(this.MSSelector_ValueChanged);
            // 
            // Colon
            // 
            this.Colon.Location = new System.Drawing.Point(47, 12);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(10, 23);
            this.Colon.TabIndex = 7;
            this.Colon.Text = ":";
            this.Colon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(92, 12);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(11, 23);
            this.Dot.TabIndex = 8;
            this.Dot.Text = ".";
            this.Dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainClockTimeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 76);
            this.ControlBox = false;
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Colon);
            this.Controls.Add(this.MSSelector);
            this.Controls.Add(this.SecondsSelector);
            this.Controls.Add(this.MinutesSelector);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(175, 115);
            this.MinimumSize = new System.Drawing.Size(175, 115);
            this.Name = "MainClockTimeSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Time";
            ((System.ComponentModel.ISupportInitialize)(this.MinutesSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MSSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonOK;
        private Label Colon;
        private Label Dot;
        public NumericUpDown MinutesSelector;
        public NumericUpDown SecondsSelector;
        public NumericUpDown MSSelector;
    }
}