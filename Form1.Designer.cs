
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
            this.SelectAllFromTable_Button = new System.Windows.Forms.Button();
            this.Tables_ComboBox = new System.Windows.Forms.ComboBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // SelectAllFromTable_Button
            // 
            this.SelectAllFromTable_Button.Location = new System.Drawing.Point(670, 31);
            this.SelectAllFromTable_Button.Name = "SelectAllFromTable_Button";
            this.SelectAllFromTable_Button.Size = new System.Drawing.Size(118, 23);
            this.SelectAllFromTable_Button.TabIndex = 1;
            this.SelectAllFromTable_Button.Text = "Вывести";
            this.SelectAllFromTable_Button.UseVisualStyleBackColor = true;
            this.SelectAllFromTable_Button.Click += new System.EventHandler(this.SelectAllFromTable_Button_Click);
            // 
            // Tables_ComboBox
            // 
            this.Tables_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tables_ComboBox.FormattingEnabled = true;
            this.Tables_ComboBox.Location = new System.Drawing.Point(440, 31);
            this.Tables_ComboBox.Name = "Tables_ComboBox";
            this.Tables_ComboBox.Size = new System.Drawing.Size(214, 21);
            this.Tables_ComboBox.TabIndex = 2;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(12, 371);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(137, 42);
            this.Update_Button.TabIndex = 3;
            this.Update_Button.Text = "Сохранить изменения";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Tables_ComboBox);
            this.Controls.Add(this.SelectAllFromTable_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectAllFromTable_Button;
        private System.Windows.Forms.ComboBox Tables_ComboBox;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button button1;
    }
}

