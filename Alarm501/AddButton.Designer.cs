
namespace Alarm501
{
    partial class AddButton
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
            this.uxTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.uxOnCheckBoxAdd = new System.Windows.Forms.CheckBox();
            this.uxCancelButtonAdd = new System.Windows.Forms.Button();
            this.uxSetButtonAdd = new System.Windows.Forms.Button();
            this.uxSoundCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxTimePickerAdd
            // 
            this.uxTimePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePickerAdd.Location = new System.Drawing.Point(12, 37);
            this.uxTimePickerAdd.Name = "uxTimePickerAdd";
            this.uxTimePickerAdd.Size = new System.Drawing.Size(132, 20);
            this.uxTimePickerAdd.TabIndex = 0;
            // 
            // uxOnCheckBoxAdd
            // 
            this.uxOnCheckBoxAdd.AutoSize = true;
            this.uxOnCheckBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOnCheckBoxAdd.Location = new System.Drawing.Point(161, 40);
            this.uxOnCheckBoxAdd.Name = "uxOnCheckBoxAdd";
            this.uxOnCheckBoxAdd.Size = new System.Drawing.Size(44, 20);
            this.uxOnCheckBoxAdd.TabIndex = 1;
            this.uxOnCheckBoxAdd.Text = "On";
            this.uxOnCheckBoxAdd.UseVisualStyleBackColor = true;
            // 
            // uxCancelButtonAdd
            // 
            this.uxCancelButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButtonAdd.Location = new System.Drawing.Point(12, 109);
            this.uxCancelButtonAdd.Name = "uxCancelButtonAdd";
            this.uxCancelButtonAdd.Size = new System.Drawing.Size(73, 40);
            this.uxCancelButtonAdd.TabIndex = 2;
            this.uxCancelButtonAdd.Text = "Cancel";
            this.uxCancelButtonAdd.UseVisualStyleBackColor = true;
            this.uxCancelButtonAdd.Click += new System.EventHandler(this.uxCancelButtonAdd_Click);
            // 
            // uxSetButtonAdd
            // 
            this.uxSetButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetButtonAdd.Location = new System.Drawing.Point(154, 109);
            this.uxSetButtonAdd.Name = "uxSetButtonAdd";
            this.uxSetButtonAdd.Size = new System.Drawing.Size(73, 40);
            this.uxSetButtonAdd.TabIndex = 3;
            this.uxSetButtonAdd.Text = "Set";
            this.uxSetButtonAdd.UseVisualStyleBackColor = true;
            this.uxSetButtonAdd.Click += new System.EventHandler(this.uxSetButtonAdd_Click);
            // 
            // uxSoundCombo
            // 
            this.uxSoundCombo.FormattingEnabled = true;
            this.uxSoundCombo.Items.AddRange(new object[] {
            "Radar",
            "Beacon",
            "Chimes",
            "Circuit",
            "Reflection"});
            this.uxSoundCombo.Location = new System.Drawing.Point(12, 78);
            this.uxSoundCombo.Name = "uxSoundCombo";
            this.uxSoundCombo.Size = new System.Drawing.Size(121, 21);
            this.uxSoundCombo.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 161);
            this.Controls.Add(this.uxSoundCombo);
            this.Controls.Add(this.uxSetButtonAdd);
            this.Controls.Add(this.uxCancelButtonAdd);
            this.Controls.Add(this.uxOnCheckBoxAdd);
            this.Controls.Add(this.uxTimePickerAdd);
            this.Name = "AddButton";
            this.Text = "Add Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxTimePickerAdd;
        private System.Windows.Forms.CheckBox uxOnCheckBoxAdd;
        private System.Windows.Forms.Button uxCancelButtonAdd;
        private System.Windows.Forms.Button uxSetButtonAdd;
        private System.Windows.Forms.ComboBox uxSoundCombo;
    }
}