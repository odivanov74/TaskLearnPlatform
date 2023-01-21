
namespace Sql_HW46
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tables_ComboBox = new System.Windows.Forms.ComboBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.AscSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.DescSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.Sort_GroupBox = new System.Windows.Forms.GroupBox();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.NoSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.ColumnName_ComboBox = new System.Windows.Forms.ComboBox();
            this.Filter_TextBox = new System.Windows.Forms.TextBox();
            this.SelectAllFromTable_Button = new System.Windows.Forms.Button();
            this.OnFilter_Button = new System.Windows.Forms.Button();
            this.Filter_GroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Sort_GroupBox.SuspendLayout();
            this.Filter_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // Tables_ComboBox
            // 
            this.Tables_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tables_ComboBox.FormattingEnabled = true;
            this.Tables_ComboBox.Location = new System.Drawing.Point(391, 31);
            this.Tables_ComboBox.Name = "Tables_ComboBox";
            this.Tables_ComboBox.Size = new System.Drawing.Size(216, 21);
            this.Tables_ComboBox.TabIndex = 2;
            this.Tables_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Tables_ComboBox_SelectedIndexChanged);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(12, 362);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(137, 42);
            this.Update_Button.TabIndex = 3;
            this.Update_Button.Text = "Сохранить изменения";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // AscSort_RadioButton
            // 
            this.AscSort_RadioButton.AutoSize = true;
            this.AscSort_RadioButton.Location = new System.Drawing.Point(16, 50);
            this.AscSort_RadioButton.Name = "AscSort_RadioButton";
            this.AscSort_RadioButton.Size = new System.Drawing.Size(109, 17);
            this.AscSort_RadioButton.TabIndex = 5;
            this.AscSort_RadioButton.TabStop = true;
            this.AscSort_RadioButton.Text = "По возрастанию";
            this.AscSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // DescSort_RadioButton
            // 
            this.DescSort_RadioButton.AutoSize = true;
            this.DescSort_RadioButton.Location = new System.Drawing.Point(16, 73);
            this.DescSort_RadioButton.Name = "DescSort_RadioButton";
            this.DescSort_RadioButton.Size = new System.Drawing.Size(93, 17);
            this.DescSort_RadioButton.TabIndex = 6;
            this.DescSort_RadioButton.TabStop = true;
            this.DescSort_RadioButton.Text = "По убыванию";
            this.DescSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Sort_GroupBox
            // 
            this.Sort_GroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Sort_GroupBox.Controls.Add(this.Sort_Button);
            this.Sort_GroupBox.Controls.Add(this.NoSort_RadioButton);
            this.Sort_GroupBox.Controls.Add(this.ColumnName_ComboBox);
            this.Sort_GroupBox.Controls.Add(this.AscSort_RadioButton);
            this.Sort_GroupBox.Controls.Add(this.DescSort_RadioButton);
            this.Sort_GroupBox.Location = new System.Drawing.Point(391, 68);
            this.Sort_GroupBox.Name = "Sort_GroupBox";
            this.Sort_GroupBox.Size = new System.Drawing.Size(216, 152);
            this.Sort_GroupBox.TabIndex = 7;
            this.Sort_GroupBox.TabStop = false;
            this.Sort_GroupBox.Text = "Сортировка";
            // 
            // Sort_Button
            // 
            this.Sort_Button.Location = new System.Drawing.Point(16, 119);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(184, 21);
            this.Sort_Button.TabIndex = 12;
            this.Sort_Button.Text = "Применить";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // NoSort_RadioButton
            // 
            this.NoSort_RadioButton.AutoSize = true;
            this.NoSort_RadioButton.Location = new System.Drawing.Point(16, 96);
            this.NoSort_RadioButton.Name = "NoSort_RadioButton";
            this.NoSort_RadioButton.Size = new System.Drawing.Size(106, 17);
            this.NoSort_RadioButton.TabIndex = 13;
            this.NoSort_RadioButton.TabStop = true;
            this.NoSort_RadioButton.Text = "Без сортировки";
            this.NoSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ColumnName_ComboBox
            // 
            this.ColumnName_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnName_ComboBox.FormattingEnabled = true;
            this.ColumnName_ComboBox.Location = new System.Drawing.Point(16, 23);
            this.ColumnName_ComboBox.Name = "ColumnName_ComboBox";
            this.ColumnName_ComboBox.Size = new System.Drawing.Size(184, 21);
            this.ColumnName_ComboBox.TabIndex = 12;
            this.ColumnName_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnName_ComboBox_SelectedIndexChanged);
            // 
            // Filter_TextBox
            // 
            this.Filter_TextBox.Location = new System.Drawing.Point(6, 23);
            this.Filter_TextBox.Name = "Filter_TextBox";
            this.Filter_TextBox.Size = new System.Drawing.Size(153, 20);
            this.Filter_TextBox.TabIndex = 8;
            // 
            // SelectAllFromTable_Button
            // 
            this.SelectAllFromTable_Button.Location = new System.Drawing.Point(621, 31);
            this.SelectAllFromTable_Button.Name = "SelectAllFromTable_Button";
            this.SelectAllFromTable_Button.Size = new System.Drawing.Size(166, 23);
            this.SelectAllFromTable_Button.TabIndex = 1;
            this.SelectAllFromTable_Button.Text = "Вывести";
            this.SelectAllFromTable_Button.UseVisualStyleBackColor = true;
            this.SelectAllFromTable_Button.Click += new System.EventHandler(this.SelectAllFromTable_Button_Click);
            // 
            // OnFilter_Button
            // 
            this.OnFilter_Button.Location = new System.Drawing.Point(6, 50);
            this.OnFilter_Button.Name = "OnFilter_Button";
            this.OnFilter_Button.Size = new System.Drawing.Size(120, 21);
            this.OnFilter_Button.TabIndex = 10;
            this.OnFilter_Button.Text = "Применить";
            this.OnFilter_Button.UseVisualStyleBackColor = true;
            this.OnFilter_Button.Click += new System.EventHandler(this.OnFilter_Button_Click);
            // 
            // Filter_GroupBox
            // 
            this.Filter_GroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Filter_GroupBox.Controls.Add(this.Filter_TextBox);
            this.Filter_GroupBox.Controls.Add(this.OnFilter_Button);
            this.Filter_GroupBox.Location = new System.Drawing.Point(622, 68);
            this.Filter_GroupBox.Name = "Filter_GroupBox";
            this.Filter_GroupBox.Size = new System.Drawing.Size(165, 82);
            this.Filter_GroupBox.TabIndex = 12;
            this.Filter_GroupBox.TabStop = false;
            this.Filter_GroupBox.Text = "Фильтр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 414);
            this.Controls.Add(this.Filter_GroupBox);
            this.Controls.Add(this.Sort_GroupBox);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Tables_ComboBox);
            this.Controls.Add(this.SelectAllFromTable_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "TaskLearnPlatform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Sort_GroupBox.ResumeLayout(false);
            this.Sort_GroupBox.PerformLayout();
            this.Filter_GroupBox.ResumeLayout(false);
            this.Filter_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Tables_ComboBox;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.RadioButton AscSort_RadioButton;
        private System.Windows.Forms.RadioButton DescSort_RadioButton;
        private System.Windows.Forms.GroupBox Sort_GroupBox;
        private System.Windows.Forms.TextBox Filter_TextBox;
        private System.Windows.Forms.Button SelectAllFromTable_Button;
        private System.Windows.Forms.Button OnFilter_Button;
        private System.Windows.Forms.ComboBox ColumnName_ComboBox;
        private System.Windows.Forms.RadioButton NoSort_RadioButton;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.GroupBox Filter_GroupBox;
    }
}

