namespace SBKInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTreeB = new System.Windows.Forms.Button();
            this.RuleOrTextPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateTextB = new System.Windows.Forms.Button();
            this.CreateRuleB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteNewRuleB = new System.Windows.Forms.Button();
            this.SaveNewRuleB = new System.Windows.Forms.Button();
            this.RuleTextTB = new System.Windows.Forms.TextBox();
            this.FinalRuleTextPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteRuleTextB = new System.Windows.Forms.Button();
            this.ChangeRuleTextB = new System.Windows.Forms.Button();
            this.RuleTextLable = new System.Windows.Forms.Label();
            this.DeletePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectB = new System.Windows.Forms.Button();
            this.DeleteAllB = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.doneB = new System.Windows.Forms.Button();
            this.plusLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.legendPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.RuleOrTextPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.FinalRuleTextPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.legendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTreeB
            // 
            this.CreateTreeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTreeB.Location = new System.Drawing.Point(760, 242);
            this.CreateTreeB.Name = "CreateTreeB";
            this.CreateTreeB.Size = new System.Drawing.Size(420, 140);
            this.CreateTreeB.TabIndex = 0;
            this.CreateTreeB.Text = "Создать новое дерево";
            this.CreateTreeB.UseVisualStyleBackColor = true;
            this.CreateTreeB.Click += new System.EventHandler(this.CreateTreeB_Click);
            // 
            // RuleOrTextPanel
            // 
            this.RuleOrTextPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RuleOrTextPanel.ColumnCount = 1;
            this.RuleOrTextPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RuleOrTextPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.RuleOrTextPanel.Controls.Add(this.label1, 0, 0);
            this.RuleOrTextPanel.Location = new System.Drawing.Point(250, 443);
            this.RuleOrTextPanel.Name = "RuleOrTextPanel";
            this.RuleOrTextPanel.RowCount = 2;
            this.RuleOrTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RuleOrTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.RuleOrTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RuleOrTextPanel.Size = new System.Drawing.Size(200, 100);
            this.RuleOrTextPanel.TabIndex = 1;
            this.RuleOrTextPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CreateTextB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreateRuleB, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CreateTextB
            // 
            this.CreateTextB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateTextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTextB.Location = new System.Drawing.Point(100, 3);
            this.CreateTextB.Name = "CreateTextB";
            this.CreateTextB.Size = new System.Drawing.Size(91, 35);
            this.CreateTextB.TabIndex = 4;
            this.CreateTextB.Text = "Вывод";
            this.CreateTextB.UseVisualStyleBackColor = true;
            this.CreateTextB.Click += new System.EventHandler(this.CreateTextB_Click);
            // 
            // CreateRuleB
            // 
            this.CreateRuleB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateRuleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRuleB.Location = new System.Drawing.Point(3, 3);
            this.CreateRuleB.Name = "CreateRuleB";
            this.CreateRuleB.Size = new System.Drawing.Size(91, 35);
            this.CreateRuleB.TabIndex = 3;
            this.CreateRuleB.Text = "Условие";
            this.CreateRuleB.UseVisualStyleBackColor = true;
            this.CreateRuleB.Click += new System.EventHandler(this.CreateRuleB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление нового узла";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddPanel.ColumnCount = 1;
            this.AddPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddPanel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.AddPanel.Controls.Add(this.RuleTextTB, 0, 0);
            this.AddPanel.Location = new System.Drawing.Point(456, 443);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.RowCount = 2;
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.AddPanel.Size = new System.Drawing.Size(200, 100);
            this.AddPanel.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DeleteNewRuleB, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.SaveNewRuleB, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 36);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // DeleteNewRuleB
            // 
            this.DeleteNewRuleB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteNewRuleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNewRuleB.Location = new System.Drawing.Point(100, 3);
            this.DeleteNewRuleB.Name = "DeleteNewRuleB";
            this.DeleteNewRuleB.Size = new System.Drawing.Size(91, 30);
            this.DeleteNewRuleB.TabIndex = 4;
            this.DeleteNewRuleB.Text = "Отмена";
            this.DeleteNewRuleB.UseVisualStyleBackColor = true;
            this.DeleteNewRuleB.Click += new System.EventHandler(this.DeleteNewRuleB_Click);
            // 
            // SaveNewRuleB
            // 
            this.SaveNewRuleB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveNewRuleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveNewRuleB.Location = new System.Drawing.Point(3, 3);
            this.SaveNewRuleB.Name = "SaveNewRuleB";
            this.SaveNewRuleB.Size = new System.Drawing.Size(91, 30);
            this.SaveNewRuleB.TabIndex = 3;
            this.SaveNewRuleB.Text = "Сохранить";
            this.SaveNewRuleB.UseVisualStyleBackColor = true;
            this.SaveNewRuleB.Click += new System.EventHandler(this.SaveNewRuleB_Click);
            // 
            // RuleTextTB
            // 
            this.RuleTextTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuleTextTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RuleTextTB.Location = new System.Drawing.Point(3, 3);
            this.RuleTextTB.Multiline = true;
            this.RuleTextTB.Name = "RuleTextTB";
            this.RuleTextTB.Size = new System.Drawing.Size(194, 52);
            this.RuleTextTB.TabIndex = 0;
            // 
            // FinalRuleTextPanel
            // 
            this.FinalRuleTextPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FinalRuleTextPanel.ColumnCount = 1;
            this.FinalRuleTextPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FinalRuleTextPanel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.FinalRuleTextPanel.Controls.Add(this.RuleTextLable, 0, 0);
            this.FinalRuleTextPanel.Enabled = false;
            this.FinalRuleTextPanel.Location = new System.Drawing.Point(662, 443);
            this.FinalRuleTextPanel.Name = "FinalRuleTextPanel";
            this.FinalRuleTextPanel.RowCount = 2;
            this.FinalRuleTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.FinalRuleTextPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.FinalRuleTextPanel.Size = new System.Drawing.Size(200, 100);
            this.FinalRuleTextPanel.TabIndex = 3;
            this.FinalRuleTextPanel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DeleteRuleTextB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ChangeRuleTextB, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 36);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // DeleteRuleTextB
            // 
            this.DeleteRuleTextB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteRuleTextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRuleTextB.Location = new System.Drawing.Point(100, 3);
            this.DeleteRuleTextB.Name = "DeleteRuleTextB";
            this.DeleteRuleTextB.Size = new System.Drawing.Size(91, 30);
            this.DeleteRuleTextB.TabIndex = 4;
            this.DeleteRuleTextB.Text = "Удалить";
            this.DeleteRuleTextB.UseVisualStyleBackColor = true;
            // 
            // ChangeRuleTextB
            // 
            this.ChangeRuleTextB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeRuleTextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeRuleTextB.Location = new System.Drawing.Point(3, 3);
            this.ChangeRuleTextB.Name = "ChangeRuleTextB";
            this.ChangeRuleTextB.Size = new System.Drawing.Size(91, 30);
            this.ChangeRuleTextB.TabIndex = 3;
            this.ChangeRuleTextB.Text = "Изменить";
            this.ChangeRuleTextB.UseVisualStyleBackColor = true;
            // 
            // RuleTextLable
            // 
            this.RuleTextLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RuleTextLable.AutoSize = true;
            this.RuleTextLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RuleTextLable.Location = new System.Drawing.Point(40, 19);
            this.RuleTextLable.Name = "RuleTextLable";
            this.RuleTextLable.Size = new System.Drawing.Size(120, 20);
            this.RuleTextLable.TabIndex = 2;
            this.RuleTextLable.Text = "Текст правила";
            this.RuleTextLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeletePanel.ColumnCount = 1;
            this.DeletePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DeletePanel.Controls.Add(this.ConnectB, 0, 1);
            this.DeletePanel.Controls.Add(this.DeleteAllB, 0, 0);
            this.DeletePanel.Enabled = false;
            this.DeletePanel.Location = new System.Drawing.Point(44, 443);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.RowCount = 2;
            this.DeletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DeletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DeletePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DeletePanel.Size = new System.Drawing.Size(200, 100);
            this.DeletePanel.TabIndex = 4;
            this.DeletePanel.Visible = false;
            // 
            // ConnectB
            // 
            this.ConnectB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectB.Location = new System.Drawing.Point(3, 53);
            this.ConnectB.Name = "ConnectB";
            this.ConnectB.Size = new System.Drawing.Size(194, 44);
            this.ConnectB.TabIndex = 6;
            this.ConnectB.Text = "Скрепить";
            this.ConnectB.UseVisualStyleBackColor = true;
            // 
            // DeleteAllB
            // 
            this.DeleteAllB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAllB.Location = new System.Drawing.Point(3, 3);
            this.DeleteAllB.Name = "DeleteAllB";
            this.DeleteAllB.Size = new System.Drawing.Size(194, 44);
            this.DeleteAllB.TabIndex = 5;
            this.DeleteAllB.Text = "Удалить всю ветку";
            this.DeleteAllB.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Control;
            this.button0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button0.Location = new System.Drawing.Point(870, 100);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(200, 100);
            this.button0.TabIndex = 13;
            this.button0.UseVisualStyleBackColor = false;
            // 
            // doneB
            // 
            this.doneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneB.Location = new System.Drawing.Point(1667, 40);
            this.doneB.Name = "doneB";
            this.doneB.Size = new System.Drawing.Size(200, 100);
            this.doneB.TabIndex = 14;
            this.doneB.Text = "Готово";
            this.doneB.UseVisualStyleBackColor = true;
            this.doneB.Visible = false;
            this.doneB.Click += new System.EventHandler(this.doneB_Click);
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusLabel.Location = new System.Drawing.Point(1140, 121);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(40, 42);
            this.plusLabel.TabIndex = 15;
            this.plusLabel.Text = "+";
            this.plusLabel.Visible = false;
            // 
            // minusLabel
            // 
            this.minusLabel.AutoSize = true;
            this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusLabel.Location = new System.Drawing.Point(760, 121);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(30, 42);
            this.minusLabel.TabIndex = 16;
            this.minusLabel.Text = "-";
            this.minusLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вывод";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Условие";
            // 
            // legendPanel
            // 
            this.legendPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.legendPanel.ColumnCount = 1;
            this.legendPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.legendPanel.Controls.Add(this.label6, 0, 0);
            this.legendPanel.Controls.Add(this.label4, 0, 1);
            this.legendPanel.Controls.Add(this.label5, 0, 2);
            this.legendPanel.Location = new System.Drawing.Point(44, 40);
            this.legendPanel.Name = "legendPanel";
            this.legendPanel.RowCount = 3;
            this.legendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.legendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.legendPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.legendPanel.Size = new System.Drawing.Size(200, 100);
            this.legendPanel.TabIndex = 19;
            this.legendPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Обозначения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.legendPanel);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.doneB);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.FinalRuleTextPanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.RuleOrTextPanel);
            this.Controls.Add(this.CreateTreeB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ввод нового дерева";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.RuleOrTextPanel.ResumeLayout(false);
            this.RuleOrTextPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.FinalRuleTextPanel.ResumeLayout(false);
            this.FinalRuleTextPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.DeletePanel.ResumeLayout(false);
            this.legendPanel.ResumeLayout(false);
            this.legendPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTreeB;
        private System.Windows.Forms.TableLayoutPanel RuleOrTextPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CreateTextB;
        private System.Windows.Forms.Button CreateRuleB;
        private System.Windows.Forms.TableLayoutPanel AddPanel;
        private System.Windows.Forms.TextBox RuleTextTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button DeleteNewRuleB;
        private System.Windows.Forms.Button SaveNewRuleB;
        private System.Windows.Forms.TableLayoutPanel FinalRuleTextPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button DeleteRuleTextB;
        private System.Windows.Forms.Button ChangeRuleTextB;
        private System.Windows.Forms.Label RuleTextLable;
        private System.Windows.Forms.TableLayoutPanel DeletePanel;
        private System.Windows.Forms.Button ConnectB;
        private System.Windows.Forms.Button DeleteAllB;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button doneB;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel legendPanel;
        private System.Windows.Forms.Label label6;
    }
}

