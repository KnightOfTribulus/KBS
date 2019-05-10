namespace SBKInterface
{
    partial class Form2
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
            this.StartWorkingB = new System.Windows.Forms.Button();
            this.okB = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.doneB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartWorkingB
            // 
            this.StartWorkingB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWorkingB.Location = new System.Drawing.Point(760, 422);
            this.StartWorkingB.Name = "StartWorkingB";
            this.StartWorkingB.Size = new System.Drawing.Size(420, 140);
            this.StartWorkingB.TabIndex = 1;
            this.StartWorkingB.Text = "Начать работу с СоЗ";
            this.StartWorkingB.UseVisualStyleBackColor = true;
            this.StartWorkingB.Click += new System.EventHandler(this.StartWorkingB_Click);
            // 
            // okB
            // 
            this.okB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okB.Location = new System.Drawing.Point(1186, 422);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(420, 140);
            this.okB.TabIndex = 3;
            this.okB.Text = "Подтвердить";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Visible = false;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(470, 225);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1000, 170);
            this.textBox.TabIndex = 2;
            this.textBox.Visible = false;
            // 
            // doneB
            // 
            this.doneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneB.Location = new System.Drawing.Point(1667, 40);
            this.doneB.Name = "doneB";
            this.doneB.Size = new System.Drawing.Size(200, 100);
            this.doneB.TabIndex = 15;
            this.doneB.Text = "Готово";
            this.doneB.UseVisualStyleBackColor = true;
            this.doneB.Visible = false;
            this.doneB.Click += new System.EventHandler(this.doneB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.doneB);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.StartWorkingB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartWorkingB;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button doneB;
    }
}