using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Type dgvType = dataGridView.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView, true, null);
        }

        private SQLiteConnection conn = new SQLiteConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            { 
                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
                        builder["Data Source"] = dlg.FileName;
                        conn.ConnectionString = builder.ConnectionString;
                        conn.Open();
                        DataTable table = conn.GetSchema("Tables");
                        string[] tableNames = table.AsEnumerable()
                            .Select(s => s.Field<string>(table.Columns[2].ToString()))
                            .ToArray<string>();
                        foreach(string name in tableNames)
                        {
                            listBox.Items.Add(name);
                        }
                    }
                    catch (SQLiteException msg)
                    {
                        MessageBox.Show(msg.Message);
                    }                    
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count == 0)
                return;

            string tableName = listBox.SelectedItems[0].ToString();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from " + tableName, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }
    }
}
