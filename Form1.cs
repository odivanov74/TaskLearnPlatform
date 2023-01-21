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
        DataSet data = new DataSet();
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommandBuilder commandBuilder;

        public Form1()
        {
            InitializeComponent();
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
            connection.Close();
        }

        private void SelectAllFromTable_Button_Click(object sender, EventArgs e)
        {
            string cmd = "";
            //чистка dataGridView
            if (table != null)
            {
                while (table.Rows.Count > 0)
                {
                    table.Rows.RemoveAt(0);
                }
                while (table.Columns.Count > 0)
                {
                    table.Columns.RemoveAt(0);
                }
                dataGridView1.DataSource = table;
            }

            if (Tables_ComboBox.SelectedItem.ToString() == "All")
            {
                foreach (var item in Tables_ComboBox.Items)
                {                    
                    if (item.ToString() != "All")
                    {
                        cmd = $"select * from {item.ToString()};";
                        commandBuilder = new SqlCommandBuilder(adapter);
                        adapter = new SqlDataAdapter(cmd, connection);
                        adapter.Fill(data);                      
                    }
                }
            }
            else
            {
                cmd = $"Select * from {Tables_ComboBox.SelectedItem.ToString()};";
                adapter = new SqlDataAdapter(cmd, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(data);
            }
            
            table = data.Tables[0];
            dataGridView1.DataSource = table;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            
            adapter.Update(data);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string res = "";
            res += dataGridView1.SelectedCells[0].Value.ToString() + Environment.NewLine;
            res += dataGridView1.SelectedCells[0].ColumnIndex.ToString() + ":" + dataGridView1.SelectedCells[0].RowIndex.ToString() + Environment.NewLine;
            res += data.Tables[0].Columns[dataGridView1.SelectedCells[0].ColumnIndex].ColumnName + Environment.NewLine;
            res += dataGridView1.SelectedCells[0].Value;
            MessageBox.Show(res);
        }
    }
}
