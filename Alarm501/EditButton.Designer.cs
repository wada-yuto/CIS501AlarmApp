
namespace Alarm501
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.uxOnCheckBoxEdit = new System.Windows.Forms.CheckBox();
            this.uxCancelButtonEdit = new System.Windows.Forms.Button();
            this.uxSetButtonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // uxTimePickerEdit
            // 
            this.uxTimePickerEdit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTimePickerEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.uxTimePickerEdit.CustomFormat = "hh:mm:ss tt";
            this.uxTimePickerEdit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.uxTimePickerEdit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTimePickerEdit.Location = new System.Drawing.Point(12, 37);
            this.uxTimePickerEdit.Name = "uxTimePickerEdit";
            this.uxTimePickerEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxTimePickerEdit.Size = new System.Drawing.Size(132, 20);
            this.uxTimePickerEdit.TabIndex = 1;
            this.uxTimePickerEdit.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.uxTimePickerEdit.ValueChanged += new System.EventHandler(this.uxTimePicker_ValueChanged);
            // 
            // uxOnCheckBoxEdit
            // 
            this.uxOnCheckBoxEdit.AutoSize = true;
            this.uxOnCheckBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOnCheckBoxEdit.Location = new System.Drawing.Point(161, 40);
            this.uxOnCheckBoxEdit.Name = "uxOnCheckBoxEdit";
            this.uxOnCheckBoxEdit.Size = new System.Drawing.Size(44, 20);
            this.uxOnCheckBoxEdit.TabIndex = 2;
            this.uxOnCheckBoxEdit.Text = "On";
            this.uxOnCheckBoxEdit.UseVisualStyleBackColor = true;
            // 
            // uxCancelButtonEdit
            // 
            this.uxCancelButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButtonEdit.Location = new System.Drawing.Point(12, 79);
            this.uxCancelButtonEdit.Name = "uxCancelButtonEdit";
            this.uxCancelButtonEdit.Size = new System.Drawing.Size(73, 40);
            this.uxCancelButtonEdit.TabIndex = 3;
            this.uxCancelButtonEdit.Text = "Cancel";
            this.uxCancelButtonEdit.UseVisualStyleBackColor = true;
            this.uxCancelButtonEdit.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxSetButtonEdit
            // 
            this.uxSetButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetButtonEdit.Location = new System.Drawing.Point(154, 80);
            this.uxSetButtonEdit.Name = "uxSetButtonEdit";
            this.uxSetButtonEdit.Size = new System.Drawing.Size(73, 40);
            this.uxSetButtonEdit.TabIndex = 4;
            this.uxSetButtonEdit.Text = "Set";
            this.uxSetButtonEdit.UseVisualStyleBackColor = true;
            this.uxSetButtonEdit.Click += new System.EventHandler(this.uxSetButtonEdit_Click);
            // 
            // EditButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 146);
            this.Controls.Add(this.uxSetButtonEdit);
            this.Controls.Add(this.uxCancelButtonEdit);
            this.Controls.Add(this.uxOnCheckBoxEdit);
            this.Controls.Add(this.uxTimePickerEdit);
            this.Controls.Add(this.label1);
            this.Name = "EditButton";
            this.RightToLeftLayout = true;
            this.Text = "Edit Alarm";
            this.Load += new System.EventHandler(this.EditButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker uxTimePickerEdit;
        private System.Windows.Forms.Button uxCancelButtonEdit;
        private System.Windows.Forms.Button uxSetButtonEdit;
        public System.Windows.Forms.CheckBox uxOnCheckBoxEdit;
    }
}