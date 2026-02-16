namespace Autoclicker.UI.Forms
{
    partial class Main
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
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableKeybind = new System.Windows.Forms.Label();
            this.CpsSlider = new System.Windows.Forms.TrackBar();
            this.IgnoreInMenusCheckBox = new System.Windows.Forms.CheckBox();
            this.AllowWhileShiftingCheckBox = new System.Windows.Forms.CheckBox();
            this.ExhaustCheckBox = new System.Windows.Forms.CheckBox();
            this.NoHitDelayCheckBox = new System.Windows.Forms.CheckBox();
            this.CpsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CpsSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Location = new System.Drawing.Point(82, 12);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(59, 17);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.Text = "Enable";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            this.EnableCheckBox.CheckedChanged += new System.EventHandler(this.EnableCheckBox_CheckedChanged);
            // 
            // EnableKeybind
            // 
            this.EnableKeybind.AutoSize = true;
            this.EnableKeybind.Location = new System.Drawing.Point(138, 13);
            this.EnableKeybind.Name = "EnableKeybind";
            this.EnableKeybind.Size = new System.Drawing.Size(39, 13);
            this.EnableKeybind.TabIndex = 1;
            this.EnableKeybind.Text = "[None]";
            this.EnableKeybind.Click += new System.EventHandler(this.EnableKeybind_Click);
            this.EnableKeybind.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnableKeybind_PreviewKeyDown);
            // 
            // CpsSlider
            // 
            this.CpsSlider.Location = new System.Drawing.Point(15, 41);
            this.CpsSlider.Maximum = 250;
            this.CpsSlider.Minimum = 50;
            this.CpsSlider.Name = "CpsSlider";
            this.CpsSlider.Size = new System.Drawing.Size(175, 45);
            this.CpsSlider.TabIndex = 2;
            this.CpsSlider.TickFrequency = 10000;
            this.CpsSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.CpsSlider.Value = 140;
            this.CpsSlider.ValueChanged += new System.EventHandler(this.CpsSlider_ValueChanged);
            // 
            // IgnoreInMenusCheckBox
            // 
            this.IgnoreInMenusCheckBox.AutoSize = true;
            this.IgnoreInMenusCheckBox.Location = new System.Drawing.Point(15, 92);
            this.IgnoreInMenusCheckBox.Name = "IgnoreInMenusCheckBox";
            this.IgnoreInMenusCheckBox.Size = new System.Drawing.Size(101, 17);
            this.IgnoreInMenusCheckBox.TabIndex = 3;
            this.IgnoreInMenusCheckBox.Text = "Ignore in menus";
            this.IgnoreInMenusCheckBox.UseVisualStyleBackColor = true;
            this.IgnoreInMenusCheckBox.CheckedChanged += new System.EventHandler(this.IgnoreInMenusCheckBox_CheckedChanged);
            // 
            // AllowWhileShiftingCheckBox
            // 
            this.AllowWhileShiftingCheckBox.AutoSize = true;
            this.AllowWhileShiftingCheckBox.Location = new System.Drawing.Point(15, 115);
            this.AllowWhileShiftingCheckBox.Name = "AllowWhileShiftingCheckBox";
            this.AllowWhileShiftingCheckBox.Size = new System.Drawing.Size(114, 17);
            this.AllowWhileShiftingCheckBox.TabIndex = 4;
            this.AllowWhileShiftingCheckBox.Text = "Allow while shifting";
            this.AllowWhileShiftingCheckBox.UseVisualStyleBackColor = true;
            this.AllowWhileShiftingCheckBox.CheckedChanged += new System.EventHandler(this.AllowWhileShiftingCheckBox_CheckedChanged);
            // 
            // ExhaustCheckBox
            // 
            this.ExhaustCheckBox.AutoSize = true;
            this.ExhaustCheckBox.Location = new System.Drawing.Point(163, 92);
            this.ExhaustCheckBox.Name = "ExhaustCheckBox";
            this.ExhaustCheckBox.Size = new System.Drawing.Size(64, 17);
            this.ExhaustCheckBox.TabIndex = 5;
            this.ExhaustCheckBox.Text = "Exhaust";
            this.ExhaustCheckBox.UseVisualStyleBackColor = true;
            this.ExhaustCheckBox.CheckedChanged += new System.EventHandler(this.ExhaustCheckBox_CheckedChanged);
            // 
            // NoHitDelayCheckBox
            // 
            this.NoHitDelayCheckBox.AutoSize = true;
            this.NoHitDelayCheckBox.Location = new System.Drawing.Point(163, 115);
            this.NoHitDelayCheckBox.Name = "NoHitDelayCheckBox";
            this.NoHitDelayCheckBox.Size = new System.Drawing.Size(82, 17);
            this.NoHitDelayCheckBox.TabIndex = 6;
            this.NoHitDelayCheckBox.Text = "No hit delay";
            this.NoHitDelayCheckBox.UseVisualStyleBackColor = true;
            this.NoHitDelayCheckBox.CheckedChanged += new System.EventHandler(this.NoHitDelayCheckBox_CheckedChanged);
            // 
            // CpsLabel
            // 
            this.CpsLabel.AutoSize = true;
            this.CpsLabel.Location = new System.Drawing.Point(195, 54);
            this.CpsLabel.Name = "CpsLabel";
            this.CpsLabel.Size = new System.Drawing.Size(48, 13);
            this.CpsLabel.TabIndex = 7;
            this.CpsLabel.Text = "14.0 cps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autoclicker v1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(186, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "By @thom-01";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CpsLabel);
            this.Controls.Add(this.NoHitDelayCheckBox);
            this.Controls.Add(this.ExhaustCheckBox);
            this.Controls.Add(this.AllowWhileShiftingCheckBox);
            this.Controls.Add(this.IgnoreInMenusCheckBox);
            this.Controls.Add(this.CpsSlider);
            this.Controls.Add(this.EnableKeybind);
            this.Controls.Add(this.EnableCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.CpsSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.Label EnableKeybind;
        private System.Windows.Forms.TrackBar CpsSlider;
        private System.Windows.Forms.CheckBox IgnoreInMenusCheckBox;
        private System.Windows.Forms.CheckBox AllowWhileShiftingCheckBox;
        private System.Windows.Forms.CheckBox ExhaustCheckBox;
        private System.Windows.Forms.CheckBox NoHitDelayCheckBox;
        private System.Windows.Forms.Label CpsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}