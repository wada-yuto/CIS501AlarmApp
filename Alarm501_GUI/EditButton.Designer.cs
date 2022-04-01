
namespace Alarm501_GUI
{
    partial class EditButton
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
            this.uxTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.uxOnCheckBoxEdit = new System.Windows.Forms.CheckBox();
            this.uxCancelButtonEdit = new System.Windows.Forms.Button();
            this.uxSetButtonEdit = new System.Windows.Forms.Button();
            this.uxAlarmSoundCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxTimePickerEdit
            // 
            this.uxTimePickerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTimePickerEdit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePickerEdit.Location = new System.Drawing.Point(12, 37);
            this.uxTimePickerEdit.Name = "uxTimePickerEdit";
            this.uxTimePickerEdit.Size = new System.Drawing.Size(132, 20);
            this.uxTimePickerEdit.TabIndex = 0;
            // 
            // uxOnCheckBoxEdit
            // 
            this.uxOnCheckBoxEdit.AutoSize = true;
            this.uxOnCheckBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxOnCheckBoxEdit.Location = new System.Drawing.Point(161, 40);
            this.uxOnCheckBoxEdit.Name = "uxOnCheckBoxEdit";
            this.uxOnCheckBoxEdit.Size = new System.Drawing.Size(42, 19);
            this.uxOnCheckBoxEdit.TabIndex = 1;
            this.uxOnCheckBoxEdit.Text = "On";
            this.uxOnCheckBoxEdit.UseVisualStyleBackColor = true;
            // 
            // uxCancelButtonEdit
            // 
            this.uxCancelButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCancelButtonEdit.Location = new System.Drawing.Point(12, 109);
            this.uxCancelButtonEdit.Name = "uxCancelButtonEdit";
            this.uxCancelButtonEdit.Size = new System.Drawing.Size(73, 40);
            this.uxCancelButtonEdit.TabIndex = 2;
            this.uxCancelButtonEdit.Text = "Cancel";
            this.uxCancelButtonEdit.UseVisualStyleBackColor = true;
            this.uxCancelButtonEdit.Click += new System.EventHandler(this.uxCancelButtonEdit_Click);
            // 
            // uxSetButtonEdit
            // 
            this.uxSetButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxSetButtonEdit.Location = new System.Drawing.Point(154, 109);
            this.uxSetButtonEdit.Name = "uxSetButtonEdit";
            this.uxSetButtonEdit.Size = new System.Drawing.Size(73, 40);
            this.uxSetButtonEdit.TabIndex = 3;
            this.uxSetButtonEdit.Text = "Set";
            this.uxSetButtonEdit.UseVisualStyleBackColor = true;
            this.uxSetButtonEdit.Click += new System.EventHandler(this.uxSetButtonEdit_Click);
            // 
            // uxAlarmSoundCombo
            // 
            this.uxAlarmSoundCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAlarmSoundCombo.FormattingEnabled = true;
            this.uxAlarmSoundCombo.Items.AddRange(new object[] {
            "Radar",
            "Beacon",
            "Chimes",
            "Circuit",
            "Reflection"});
            this.uxAlarmSoundCombo.Location = new System.Drawing.Point(12, 75);
            this.uxAlarmSoundCombo.Name = "uxAlarmSoundCombo";
            this.uxAlarmSoundCombo.Size = new System.Drawing.Size(132, 23);
            this.uxAlarmSoundCombo.TabIndex = 4;
            this.uxAlarmSoundCombo.SelectedIndexChanged += new System.EventHandler(this.uxAlarmSoundCombo_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 161);
            this.Controls.Add(this.uxAlarmSoundCombo);
            this.Controls.Add(this.uxSetButtonEdit);
            this.Controls.Add(this.uxCancelButtonEdit);
            this.Controls.Add(this.uxOnCheckBoxEdit);
            this.Controls.Add(this.uxTimePickerEdit);
            this.Name = "EditButton";
            this.Text = "EditButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxTimePickerEdit;
        private System.Windows.Forms.CheckBox uxOnCheckBoxEdit;
        private System.Windows.Forms.Button uxCancelButtonEdit;
        private System.Windows.Forms.Button uxSetButtonEdit;
        private System.Windows.Forms.ComboBox uxAlarmSoundCombo;
    }
}