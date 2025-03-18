/*
 * Переделать с DataSet и DataTable
 * Обновляет с помощью активного подключения
 * Обновляет локально
 */


using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;


namespace DB_06_03_25_gr
{
    public partial class MainWindowForm : Form
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;

        private DataSet _dataSet;
        private DbDataAdapter _dataAdapter;


        // Новое:
        private DbConnection _dbConnection;
        private DbProviderFactory _dbProviderFactory;
        DataTable dataTable;


        public MainWindowForm()
        {
            InitializeComponent();
            TextLabel.Text = "";

            DisconnectButton.Enabled = false;
            CreateDBButton.Enabled = false;
            DeleteDBButton.Enabled = false;
            FillTableButton.Enabled = false;
            //ShowDataButton.Enabled = false;
            CreateTableButton.Enabled = false;
            DeleteTableButton.Enabled = false;
            ShowNamesButton.Enabled = false;
            IncreaseCalButton.Enabled = false;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            _sqlConnection = new SqlConnection("Integrated Security=SSPI;User=DESKTOP-J9GNRTJ\\MSI;Server=DESKTOP-J9GNRTJ\\SQLEXPRESS");

            ConnectButton.Enabled = false;
            DisconnectButton.Enabled = true;
            CreateDBButton.Enabled = true;
            DeleteDBButton.Enabled = true;
            FillTableButton.Enabled = true;
            ShowDataButton.Enabled = true;
            CreateTableButton.Enabled = true;
            DeleteTableButton.Enabled = true;
            ShowNamesButton.Enabled = true;
            IncreaseCalButton.Enabled = true;

            TextLabel.Text = "Подключился";
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            _sqlConnection.Close();
            _sqlConnection = null;

            ConnectButton.Enabled = true;
            DisconnectButton.Enabled = false;
            CreateDBButton.Enabled = false;
            DeleteDBButton.Enabled = false;
            FillTableButton.Enabled = false;
            ShowDataButton.Enabled = false;
            CreateTableButton.Enabled = false;
            DeleteTableButton.Enabled = false;
            ShowNamesButton.Enabled = false;
            IncreaseCalButton.Enabled = false;

            TextLabel.Text = "Отключился";
        }

        private void CreateDBButton_Click(object sender, EventArgs e)
        {
            if (_sqlConnection != null)
            {
                string query = "CREATE DATABASE VegetablesFruitis;";
                _sqlCommand = new SqlCommand(query, _sqlConnection);
                TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Создал";
            }

        }

        private void DeleteDBButton_Click(object sender, EventArgs e)
        {
            if (_sqlConnection != null)
            {
                string query = "DROP DATABASE VegetablesFruitis;";
                _sqlCommand = new SqlCommand(query, _sqlConnection);
                TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Удалил";
            }
        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            if (_sqlConnection != null)
            {
                string query = "INSERT INTO VegetablesFruitis.dbo.VegetablesFruits" +
                    "(type, name, color, calorie)" +
                    "VALUES" +
                    "('Овощ', 'Огурец', 'Зеленый', '16')," +
                    " ('Овощ', 'Помидор', 'Красный', '18')," +
                    " ('Фрукт', 'Персик', 'Красный', '45')," +
                    " ('Фрукт', 'Банан', 'Желтый', '91');";
                _sqlCommand = new SqlCommand(query, _sqlConnection);
                TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Заполнил";
            }
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            _sqlConnection.Open();
            string query = "CREATE TABLE VegetablesFruitis.dbo.VegetablesFruits" +
                    "(id INT IDENTITY(1,1) PRIMARY KEY" +
                    ", type NVARCHAR(100)" +
                    ", name NVARCHAR(100)" +
                    ", color NVARCHAR(100)" +
                    ", calorie NVARCHAR(100)" +
                    ")";
            _sqlCommand = new SqlCommand(query, _sqlConnection);
            TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Создал таблицу";
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            if (_sqlConnection != null)
            {
                string query = "DROP TABLE VegetablesFruitis.dbo.VegetablesFruits;";
                _sqlCommand = new SqlCommand(query, _sqlConnection);
                TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Удалил";
            }
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            _dbConnection.ConnectionString = "Integrated Security=SSPI;User=DESKTOP-J9GNRTJ\\MSI;Server=DESKTOP-J9GNRTJ\\SQLEXPRESS";

           string query = "SELECT * FROM VegetablesFruitis.dbo.VegetablesFruits;";

            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataAdapter.SelectCommand = _dbConnection.CreateCommand();
            _dataAdapter.SelectCommand.CommandText = query;

            dataTable = new DataTable();
            _dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void ShowNamesButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM VegetablesFruitis.dbo.VegetablesFruits;";

            _dataAdapter = new SqlDataAdapter(query, _sqlConnection);
            //_sqlCommandBuilder = new SqlCommandBuilder(_dataAdapter);
            _dataSet = new DataSet();
            _dataAdapter.Fill(_dataSet, "NameDataTable");
            dataGridView.DataSource = _dataSet.Tables["NameDataTable"];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _dataAdapter.Update(_dataSet, "AllDataTeble");
            TextLabel.Text = "Обновил";
        }

        private void IncreaseCalButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in _dataSet.Tables["AllDataTeble"].Rows)
            {
                string x = row.Field<string>("calorie");
                int a = Int32.Parse(x);
                a = a * 2;
                row.SetField("calorie", a.ToString());
            }
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            _dataSet.Clear();
        }

        private void SelectDbButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DbProviderFactories.GetFactoryClasses();
            dataGridView.DataSource = dataTable;
            comboBox.Items.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                comboBox.Items.Add(r["InvariantName"]);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dbProviderFactory = DbProviderFactories.GetFactory(comboBox.SelectedItem.ToString());
            _dbConnection = _dbProviderFactory.CreateConnection();
            TextLabel.Text = "Выбрана" + comboBox.SelectedItem.ToString();
        }
    }
}
