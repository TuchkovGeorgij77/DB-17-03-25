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
        private DataTable _dataTable;


        public MainWindowForm()
        {
            InitializeComponent();
            TextLabel.Text = "";

            ConnectButton.Enabled = false;
            DisconnectButton.Enabled = false;
            CreateDBButton.Enabled = false;
            DeleteDBButton.Enabled = false;
            FillTableButton.Enabled = false;
            ShowDataButton.Enabled = false;
            CreateTableButton.Enabled = false;
            DeleteTableButton.Enabled = false;
            ShowNamesButton.Enabled = false;
            IncreaseCalButton.Enabled = false;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            _dbConnection.ConnectionString = "Integrated Security=SSPI;User=DESKTOP-6NP6TQ3\\Student;Server=DESKTOP-6NP6TQ3\\SQLEXPRESS";
            _dbConnection.Open();

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
            _dbConnection.Close();

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
                string query_ = "CREATE DATABASE VegetablesFruitis;";
                _sqlCommand = new SqlCommand(query_, _sqlConnection);
                TextLabel.Text = _sqlCommand.ExecuteNonQuery().ToString() + " Создал";
            }

            string query = "CREATE DATABASE VegetablesFruitis;";

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
            string query = "SELECT * FROM VegetablesFruitis.dbo.VegetablesFruits;";

            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataAdapter.SelectCommand = _dbConnection.CreateCommand();
            _dataAdapter.SelectCommand.CommandText = query;

            _dataTable = new DataTable();
            _dataAdapter.Fill(_dataTable);
            dataGridView.DataSource = _dataTable;
        }

        private void ShowNamesButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM VegetablesFruitis.dbo.VegetablesFruits;";

            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataAdapter.SelectCommand = _dbConnection.CreateCommand();
            _dataAdapter.SelectCommand.CommandText = query;

            _dataTable = new DataTable();
            _dataAdapter.Fill(_dataTable);
            dataGridView.DataSource = _dataTable;
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

            ConnectButton.Enabled = true;
        }
    }
}
