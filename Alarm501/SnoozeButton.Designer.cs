
namespace Alarm501
{
    partial class SnoozeButton
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
            this.uxSnoozeTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxSetButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSnoozeTimeUpDown
            // 
            this.uxSnoozeTimeUpDown.Location = new System.Drawing.Point(12, 37);
            this.uxSnoozeTimeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uxSnoozeTimeUpDown.Name = "uxSnoozeTimeUpDown";
            this.uxSnoozeTimeUpDown.Size = new System.Drawing.Size(215, 20);
            this.uxSnoozeTimeUpDown.TabIndex = 0;
            // 
            // uxSetButton
            // 
            this.uxSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetButton.Location = new System.Drawing.Point(154, 109);
            this.uxSetButton.Name = "uxSetButton";
            this.uxSetButton.Size = new System.Drawing.Size(73, 40);
            this.uxSetButton.TabIndex = 1;
            this.uxSetButton.Text = "Set";
            this.uxSetButton.UseVisualStyleBackColor = true;
            this.uxSetButton.Click += new System.EventHandler(this.uxSetButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(12, 109);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(73, 40);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // SnoozeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 161);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSetButton);
            this.Controls.Add(this.uxSnoozeTimeUpDown);
            this.Name = "SnoozeButton";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTimeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxSnoozeTimeUpDown;
        private System.Windows.Forms.Button uxSetButton;
        private System.Windows.Forms.Button uxCancelButton;
    }
}