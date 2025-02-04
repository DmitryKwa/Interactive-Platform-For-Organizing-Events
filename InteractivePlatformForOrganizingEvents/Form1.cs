using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace InteractivePlatformForOrganizingEvents
{
    public partial class Form1 : Form
    {
        private DB dataBase = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                string s1 = "Vova", s2 = "18";

                string us = $"SELECT * FROM [InteractivePlatformForOrganizingEvents].[dbo].[User] WHERE (Name = '{s1}' and Age = '{s2}')";

                SqlCommand sqlCommand = new SqlCommand(us, dataBase.sqlConnectGetConnection());

                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    DataRow[] row = dataTable.Select();

                    _ = MessageBox.Show($"Успешно!, {row[0]["idUser"]}");
                }
                else
                {
                    _ = MessageBox.Show($"Увы!");
                }

                sqlCommand.Dispose();
                adapter.Dispose();
                dataTable.Dispose();
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.ToString()); }
        }
    }
}
