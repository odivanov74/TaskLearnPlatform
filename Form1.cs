using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_HW46
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DataSet data;
        SqlDataAdapter adapter;        
        SqlCommandBuilder commandBuilder;        
        DataView dataView = new DataView();       

        public Form1()
        {
            InitializeComponent(); 
            try
            {
                connection = new SqlConnection(@"Data Source=DESKTOP-MHB46B8\SQLEXPRESS;Initial catalog=TaskLearnPlatform;Integrated Security=true;");
                SqlCommand command = new SqlCommand("select * from TaskLearnPlatform.information_schema.tables", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Tables_ComboBox.Items.Add("All");
                while (reader.Read())
                {
                    Tables_ComboBox.Items.Add(reader.GetString(2));
                }
                Tables_ComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SelectAllFromTable_Button.Enabled = false;
            }
            finally
            {
                connection.Close();
            }
            
            SwitchEnable(false);
            Filter_GroupBox.Enabled = false;
            NoSort_RadioButton.Checked = true;
        }

        private void SelectAllFromTable_Button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = new Clean(data).Action("");

                if (Tables_ComboBox.SelectedItem.ToString() == "All")
                {
                    SwitchEnable(false);
                    data = new DataSet();
                    foreach (var item in Tables_ComboBox.Items)
                    {
                        if (item.ToString() != "All")
                        {
                            adapter = new SqlDataAdapter($"select * from {item.ToString()};", connection);
                            adapter.Fill(data);
                        }
                    }
                }
                else
                {
                    SwitchEnable(true);
                    data = new DataSet();
                    adapter = new SqlDataAdapter($"Select * from {Tables_ComboBox.SelectedItem.ToString()};", connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Fill(data);
                }

                dataGridView1.DataSource = new Sort(data).Action(String.Empty);
                NoSort_RadioButton.Checked = true;
                Filter_GroupBox.Enabled = true;
                Filter_TextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }       

        private void Update_Button_Click(object sender, EventArgs e)
        {            
            adapter.Update(data);
        }      

        public void SwitchEnable(bool key)
        {
            Sort_GroupBox.Enabled = key;            
            Update_Button.Enabled = key;
        }        

        private void Tables_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tables_ComboBox.SelectedItem.ToString() != "All")
            {                
                ColumnName_ComboBox.Items.Clear();
                SqlCommand command = new SqlCommand($"select * from {Tables_ComboBox.SelectedItem.ToString()}", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();                
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ColumnName_ComboBox.Items.Add(reader.GetName(i));
                    }
                    break;
                }
                connection.Close();
                SwitchEnable(false);
                Filter_GroupBox.Enabled = false;
                ColumnName_ComboBox.SelectedIndex = 0;                             
            } 
            else SwitchEnable(false);
        }

        private void ColumnName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoSort_RadioButton.Checked = true;            
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (DescSort_RadioButton.Checked)            
                dataGridView1.DataSource = new Sort(data).Action($"{ColumnName_ComboBox.SelectedItem.ToString()} DESC");
            
            if (AscSort_RadioButton.Checked)            
                dataGridView1.DataSource = new Sort(data).Action($"{ColumnName_ComboBox.SelectedItem.ToString()} ASC");
            
            if (NoSort_RadioButton.Checked && Tables_ComboBox.SelectedItem.ToString() != "All")
                dataGridView1.DataSource = new Sort(data).Action(String.Empty);
            Filter_TextBox.Text = "";
        }       

        private void OnFilter_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new FilterData(data).Action(Filter_TextBox.Text);
        }
    }
}
