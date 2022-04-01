
namespace Alarm501_GUI
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
            this.uxEditButton = new System.Windows.Forms.Button();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxSnoozeButton = new System.Windows.Forms.Button();
            this.uxStopButton = new System.Windows.Forms.Button();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.uxAlarmOffTextBox = new System.Windows.Forms.TextBox();
            this.uxSoundLabel = new System.Windows.Forms.Label();
            this.uxSnoozeTimeUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEditButton
            // 
            this.uxEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxEditButton.Location = new System.Drawing.Point(25, 42);
            this.uxEditButton.Name = "uxEditButton";
            this.uxEditButton.Size = new System.Drawing.Size(87, 47);
            this.uxEditButton.TabIndex = 0;
            this.uxEditButton.Text = "Edit";
            this.uxEditButton.UseVisualStyleBackColor = true;
            this.uxEditButton.Click += new System.EventHandler(this.uxEditButton_Click);
            // 
            // uxAddButton
            // 
            this.uxAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddButton.Location = new System.Drawing.Point(142, 42);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(87, 47);
            this.uxAddButton.TabIndex = 1;
            this.uxAddButton.Text = "+";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // uxSnoozeButton
            // 
            this.uxSnoozeButton.Enabled = false;
            this.uxSnoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxSnoozeButton.Location = new System.Drawing.Point(25, 402);
            this.uxSnoozeButton.Name = "uxSnoozeButton";
            this.uxSnoozeButton.Size = new System.Drawing.Size(87, 47);
            this.uxSnoozeButton.TabIndex = 2;
            this.uxSnoozeButton.Text = "Snooze";
            this.uxSnoozeButton.UseVisualStyleBackColor = true;
            this.uxSnoozeButton.Click += new System.EventHandler(this.uxSnoozeButton_Click);
            // 
            // uxStopButton
            // 
            this.uxStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxStopButton.Location = new System.Drawing.Point(142, 402);
            this.uxStopButton.Name = "uxStopButton";
            this.uxStopButton.Size = new System.Drawing.Size(87, 47);
            this.uxStopButton.TabIndex = 3;
            this.uxStopButton.Text = "Stop";
            this.uxStopButton.UseVisualStyleBackColor = true;
            this.uxStopButton.Click += new System.EventHandler(this.uxStopButton_Click);
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.ItemHeight = 20;
            this.uxAlarmList.Location = new System.Drawing.Point(25, 108);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.Size = new System.Drawing.Size(204, 184);
            this.uxAlarmList.TabIndex = 4;
            // 
            // uxAlarmOffTextBox
            // 
            this.uxAlarmOffTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxAlarmOffTextBox.Enabled = false;
            this.uxAlarmOffTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAlarmOffTextBox.Location = new System.Drawing.Point(25, 301);
            this.uxAlarmOffTextBox.Name = "uxAlarmOffTextBox";
            this.uxAlarmOffTextBox.ReadOnly = true;
            this.uxAlarmOffTextBox.Size = new System.Drawing.Size(204, 13);
            this.uxAlarmOffTextBox.TabIndex = 5;
            // 
            // uxSoundLabel
            // 
            this.uxSoundLabel.Location = new System.Drawing.Point(25, 339);
            this.uxSoundLabel.Name = "uxSoundLabel";
            this.uxSoundLabel.Size = new System.Drawing.Size(204, 13);
            this.uxSoundLabel.TabIndex = 6;
            this.uxSoundLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // uxSnoozeTimeUpDown
            // 
            this.uxSnoozeTimeUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uxSnoozeTimeUpDown.Location = new System.Drawing.Point(25, 367);
            this.uxSnoozeTimeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxSnoozeTimeUpDown.Name = "uxSnoozeTimeUpDown";
            this.uxSnoozeTimeUpDown.Size = new System.Drawing.Size(204, 23);
            this.uxSnoozeTimeUpDown.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 461);
            this.Controls.Add(this.uxSnoozeTimeUpDown);
            this.Controls.Add(this.uxSoundLabel);
            this.Controls.Add(this.uxAlarmOffTextBox);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxStopButton);
            this.Controls.Add(this.uxSnoozeButton);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxEditButton);
            this.Name = "Form1";
            this.Text = "Alarm501";
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.Button uxSnoozeButton;
        private System.Windows.Forms.Button uxStopButton;
        private System.Windows.Forms.ListBox uxAlarmList;
        private System.Windows.Forms.TextBox uxAlarmOffTextBox;
        private System.Windows.Forms.Label uxSoundLabel;
        private System.Windows.Forms.NumericUpDown uxSnoozeTimeUpDown;
    }
}

