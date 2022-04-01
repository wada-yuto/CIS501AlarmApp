
namespace Alarm501_GUI
{
    partial class AddButton2
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
            this.uxOnCheckBoxAdd = new System.Windows.Forms.CheckBox();
            this.uxSoundCombo = new System.Windows.Forms.ComboBox();
            this.uxTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.uxCancelButtonAdd = new System.Windows.Forms.Button();
            this.uxSetButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxOnCheckBoxAdd
            // 
            this.uxOnCheckBoxAdd.AutoSize = true;
            this.uxOnCheckBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxOnCheckBoxAdd.Location = new System.Drawing.Point(161, 40);
            this.uxOnCheckBoxAdd.Name = "uxOnCheckBoxAdd";
            this.uxOnCheckBoxAdd.Size = new System.Drawing.Size(40, 17);
            this.uxOnCheckBoxAdd.TabIndex = 0;
            this.uxOnCheckBoxAdd.Text = "On";
            this.uxOnCheckBoxAdd.UseVisualStyleBackColor = true;
            // 
            // uxSoundCombo
            // 
            this.uxSoundCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.uxSoundCombo.TabIndex = 1;
            this.uxSoundCombo.SelectedIndexChanged += new System.EventHandler(this.uxSoundCombo_SelectedIndexChanged);
            // 
            // uxTimePickerAdd
            // 
            this.uxTimePickerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTimePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePickerAdd.Location = new System.Drawing.Point(13, 37);
            this.uxTimePickerAdd.Name = "uxTimePickerAdd";
            this.uxTimePickerAdd.Size = new System.Drawing.Size(132, 20);
            this.uxTimePickerAdd.TabIndex = 2;
            // 
            // uxCancelButtonAdd
            // 
            this.uxCancelButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCancelButtonAdd.Location = new System.Drawing.Point(12, 109);
            this.uxCancelButtonAdd.Name = "uxCancelButtonAdd";
            this.uxCancelButtonAdd.Size = new System.Drawing.Size(73, 40);
            this.uxCancelButtonAdd.TabIndex = 3;
            this.uxCancelButtonAdd.Text = "Cancel";
            this.uxCancelButtonAdd.UseVisualStyleBackColor = true;
            this.uxCancelButtonAdd.Click += new System.EventHandler(this.uxCancelButtonAdd_Click);
            // 
            // uxSetButtonAdd
            // 
            this.uxSetButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxSetButtonAdd.Location = new System.Drawing.Point(154, 109);
            this.uxSetButtonAdd.Name = "uxSetButtonAdd";
            this.uxSetButtonAdd.Size = new System.Drawing.Size(73, 40);
            this.uxSetButtonAdd.TabIndex = 4;
            this.uxSetButtonAdd.Text = "Set";
            this.uxSetButtonAdd.UseVisualStyleBackColor = true;
            this.uxSetButtonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddButton2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 161);
            this.Controls.Add(this.uxSetButtonAdd);
            this.Controls.Add(this.uxCancelButtonAdd);
            this.Controls.Add(this.uxTimePickerAdd);
            this.Controls.Add(this.uxSoundCombo);
            this.Controls.Add(this.uxOnCheckBoxAdd);
            this.Name = "AddButton2";
            this.Text = "AddButton2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxOnCheckBoxAdd;
        private System.Windows.Forms.ComboBox uxSoundCombo;
        private System.Windows.Forms.DateTimePicker uxTimePickerAdd;
        private System.Windows.Forms.Button uxCancelButtonAdd;
        private System.Windows.Forms.Button uxSetButtonAdd;
    }
}