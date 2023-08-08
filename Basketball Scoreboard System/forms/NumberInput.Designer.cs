namespace Basketball_Scoreboard_System.forms
{
    partial class NumberInput
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
            this.NumberSelector = new System.Windows.Forms.NumericUpDown();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberSelector
            // 
            this.NumberSelector.Location = new System.Drawing.Point(12, 12);
            this.NumberSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberSelector.Name = "NumberSelector";
            this.NumberSelector.Size = new System.Drawing.Size(135, 23);
            this.NumberSelector.TabIndex = 14;
            this.NumberSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberSelector.ValueChanged += new System.EventHandler(this.NumberSelector_ValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(12, 41);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(64, 24);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(83, 41);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(64, 24);
            this.ButtonOK.TabIndex = 13;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // NumberInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 76);
            this.ControlBox = false;
            this.Controls.Add(this.NumberSelector);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NumberInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Number";
            ((System.ComponentModel.ISupportInitialize)(this.NumberSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public NumericUpDown NumberSelector;
        private Button ButtonCancel;
        private Button ButtonOK;
    }
}