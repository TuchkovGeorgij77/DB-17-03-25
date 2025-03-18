namespace DB_06_03_25_gr
{
    partial class MainWindowForm
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
            this.CreateDBButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.DeleteDBButton = new System.Windows.Forms.Button();
            this.FillTableButton = new System.Windows.Forms.Button();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.ShowNamesButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.IncreaseCalButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SelectDbButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateDBButton
            // 
            this.CreateDBButton.Location = new System.Drawing.Point(13, 105);
            this.CreateDBButton.Name = "CreateDBButton";
            this.CreateDBButton.Size = new System.Drawing.Size(126, 40);
            this.CreateDBButton.TabIndex = 0;
            this.CreateDBButton.Text = "Создать базу данных";
            this.CreateDBButton.UseVisualStyleBackColor = true;
            this.CreateDBButton.Click += new System.EventHandler(this.CreateDBButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(13, 59);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(126, 40);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Отключиться";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(13, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(126, 40);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Подключиться к базе данных";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(158, 12);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(13, 13);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "0";
            // 
            // DeleteDBButton
            // 
            this.DeleteDBButton.Location = new System.Drawing.Point(12, 151);
            this.DeleteDBButton.Name = "DeleteDBButton";
            this.DeleteDBButton.Size = new System.Drawing.Size(126, 40);
            this.DeleteDBButton.TabIndex = 4;
            this.DeleteDBButton.Text = "Удалить базу данных";
            this.DeleteDBButton.UseVisualStyleBackColor = true;
            this.DeleteDBButton.Click += new System.EventHandler(this.DeleteDBButton_Click);
            // 
            // FillTableButton
            // 
            this.FillTableButton.Location = new System.Drawing.Point(12, 197);
            this.FillTableButton.Name = "FillTableButton";
            this.FillTableButton.Size = new System.Drawing.Size(126, 40);
            this.FillTableButton.TabIndex = 5;
            this.FillTableButton.Text = "Заполнить таблицу";
            this.FillTableButton.UseVisualStyleBackColor = true;
            this.FillTableButton.Click += new System.EventHandler(this.FillTableButton_Click);
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Location = new System.Drawing.Point(12, 243);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(126, 40);
            this.ShowDataButton.TabIndex = 7;
            this.ShowDataButton.Text = "Показать все данные таблицы";
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(145, 105);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(126, 40);
            this.CreateTableButton.TabIndex = 8;
            this.CreateTableButton.Text = "Создать таблицу";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Location = new System.Drawing.Point(145, 151);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(126, 40);
            this.DeleteTableButton.TabIndex = 9;
            this.DeleteTableButton.Text = "Удалить таблицу";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
            // 
            // ShowNamesButton
            // 
            this.ShowNamesButton.Location = new System.Drawing.Point(145, 243);
            this.ShowNamesButton.Name = "ShowNamesButton";
            this.ShowNamesButton.Size = new System.Drawing.Size(126, 40);
            this.ShowNamesButton.TabIndex = 10;
            this.ShowNamesButton.Text = "Показать только названия";
            this.ShowNamesButton.UseVisualStyleBackColor = true;
            this.ShowNamesButton.Click += new System.EventHandler(this.ShowNamesButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(277, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(486, 271);
            this.dataGridView.TabIndex = 11;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(637, 289);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(126, 40);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Добавить изменения";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // IncreaseCalButton
            // 
            this.IncreaseCalButton.Location = new System.Drawing.Point(13, 289);
            this.IncreaseCalButton.Name = "IncreaseCalButton";
            this.IncreaseCalButton.Size = new System.Drawing.Size(126, 55);
            this.IncreaseCalButton.TabIndex = 13;
            this.IncreaseCalButton.Text = "Увеличить калорийность всех продуктов в 2 раза";
            this.IncreaseCalButton.UseVisualStyleBackColor = true;
            this.IncreaseCalButton.Click += new System.EventHandler(this.IncreaseCalButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(277, 289);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(126, 40);
            this.DeleteDataButton.TabIndex = 14;
            this.DeleteDataButton.Text = "Удалить данные";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(769, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(165, 21);
            this.comboBox.TabIndex = 15;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // SelectDbButton
            // 
            this.SelectDbButton.Location = new System.Drawing.Point(769, 39);
            this.SelectDbButton.Name = "SelectDbButton";
            this.SelectDbButton.Size = new System.Drawing.Size(165, 40);
            this.SelectDbButton.TabIndex = 16;
            this.SelectDbButton.Text = "Выбрать СУБД";
            this.SelectDbButton.UseVisualStyleBackColor = true;
            this.SelectDbButton.Click += new System.EventHandler(this.SelectDbButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 387);
            this.Controls.Add(this.SelectDbButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.IncreaseCalButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ShowNamesButton);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.FillTableButton);
            this.Controls.Add(this.DeleteDBButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.CreateDBButton);
            this.Name = "MainWindowForm";
            this.Text = "Подключение к базам данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDBButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button DeleteDBButton;
        private System.Windows.Forms.Button FillTableButton;
        private System.Windows.Forms.Button ShowDataButton;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button DeleteTableButton;
        private System.Windows.Forms.Button ShowNamesButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button IncreaseCalButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button SelectDbButton;
    }
}

