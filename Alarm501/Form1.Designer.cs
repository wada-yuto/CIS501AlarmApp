
namespace Alarm501
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxSnoozeButton = new System.Windows.Forms.Button();
            this.uxStopButton = new System.Windows.Forms.Button();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.uxEditButton = new System.Windows.Forms.Button();
            this.uxAlarmOffTextBox = new System.Windows.Forms.TextBox();
            this.alarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddButton
            // 
            this.uxAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.uxSnoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSnoozeButton.Location = new System.Drawing.Point(25, 329);
            this.uxSnoozeButton.Name = "uxSnoozeButton";
            this.uxSnoozeButton.Size = new System.Drawing.Size(87, 47);
            this.uxSnoozeButton.TabIndex = 2;
            this.uxSnoozeButton.Text = "Snooze";
            this.uxSnoozeButton.UseVisualStyleBackColor = true;
            this.uxSnoozeButton.Click += new System.EventHandler(this.uxSnoozeButton_Click);
            // 
            // uxStopButton
            // 
            this.uxStopButton.Enabled = false;
            this.uxStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStopButton.Location = new System.Drawing.Point(142, 330);
            this.uxStopButton.Name = "uxStopButton";
            this.uxStopButton.Size = new System.Drawing.Size(87, 46);
            this.uxStopButton.TabIndex = 3;
            this.uxStopButton.Text = "Stop";
            this.uxStopButton.UseVisualStyleBackColor = true;
            this.uxStopButton.Click += new System.EventHandler(this.uxStopButton_Click);
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.ItemHeight = 20;
            this.uxAlarmList.Location = new System.Drawing.Point(25, 108);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxAlarmList.Size = new System.Drawing.Size(204, 184);
            this.uxAlarmList.TabIndex = 4;
            // 
            // uxEditButton
            // 
            this.uxEditButton.Enabled = false;
            this.uxEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditButton.Location = new System.Drawing.Point(25, 42);
            this.uxEditButton.Name = "uxEditButton";
            this.uxEditButton.Size = new System.Drawing.Size(87, 47);
            this.uxEditButton.TabIndex = 5;
            this.uxEditButton.Text = "Edit";
            this.uxEditButton.UseVisualStyleBackColor = true;
            this.uxEditButton.Click += new System.EventHandler(this.uxEditButton_Click);
            // 
            // uxAlarmOffTextBox
            // 
            this.uxAlarmOffTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxAlarmOffTextBox.Location = new System.Drawing.Point(25, 301);
            this.uxAlarmOffTextBox.Name = "uxAlarmOffTextBox";
            this.uxAlarmOffTextBox.ReadOnly = true;
            this.uxAlarmOffTextBox.Size = new System.Drawing.Size(204, 13);
            this.uxAlarmOffTextBox.TabIndex = 6;
            // 
            // alarmBindingSource
            // 
            this.alarmBindingSource.DataSource = typeof(Alarm501.Alarm);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 418);
            this.Controls.Add(this.uxAlarmOffTextBox);
            this.Controls.Add(this.uxEditButton);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxStopButton);
            this.Controls.Add(this.uxSnoozeButton);
            this.Controls.Add(this.uxAddButton);
            this.Name = "Form1";
            this.Text = "Alarm501";
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.Button uxSnoozeButton;
        private System.Windows.Forms.Button uxStopButton;
        private System.Windows.Forms.ListBox uxAlarmList;
        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.BindingSource alarmBindingSource;
        private System.Windows.Forms.TextBox uxAlarmOffTextBox;
    }
}

