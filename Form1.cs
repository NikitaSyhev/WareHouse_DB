using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WareHouse
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=WareHouse.db";
        public Form1()
        {
            InitializeComponent();
            textBoxConn.Text = connectionString;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("Подключение успешно");

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ТипТовара";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            textBoxNameGoods.Text += $"ID: {reader["ID"]}, Название: {reader["Найменование"]}\r\n";

                        }
                    }
                }
            }
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM НазваниеТовара";

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {


                        while (rdr.Read())
                        {
                            textBoxNameGoods.Text += $"Название: {rdr["Название"]}\r\n";

                        }
                    }
                }
            }

        }

        private void buttonGoodsType_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();
            using (SQLiteConnection coon = new SQLiteConnection(connectionString))
            {
                coon.Open();
                using (SQLiteCommand cmd = coon.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM ТипТовара";
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())

                    {
                        while (rdr.Read())
                        {
                            textBoxNameGoods.Text += $"Найменование: {rdr["Найменование"]}\r\n";
                        }
                    }
                }

            }
        }

        private void buttonSuppl_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();
            using (SQLiteConnection coon = new SQLiteConnection(connectionString))
            {
                coon.Open();
                using (SQLiteCommand cmd = coon.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Поставщики";
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())

                    {
                        while (rdr.Read())
                        {
                            textBoxNameGoods.Text += $"Поставщик: {rdr["Найменование_поставщика"]}\r\n";
                        }
                    }
                }

            }

        }

        private void buttonGoodMax_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                  
                    cmd.CommandText = @"
                SELECT НазваниеТовара.Название, Склад.Количество
                FROM Склад
                JOIN НазваниеТовара ON Склад.ID_товара = НазваниеТовара.ID_ТипаТовара
                ORDER BY Склад.Количество DESC
                LIMIT 1;
            ";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                       
                        textBoxNameGoods.Clear();

                       
                        while (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            int maxQuantity = Convert.ToInt32(reader["Количество"]);

                            textBoxNameGoods.Text = $"Товар с максимальным количеством:\r\nНазвание: {productName}\r\nКоличество: {maxQuantity}\r\n";
                        }
                    }
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = @"
                SELECT НазваниеТовара.Название, Склад.Количество
                FROM Склад
                JOIN НазваниеТовара ON Склад.ID_товара = НазваниеТовара.ID_ТипаТовара
                ORDER BY Склад.Количество ASC 
                LIMIT 1;
            ";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        textBoxNameGoods.Clear();


                        while (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            int maxQuantity = Convert.ToInt32(reader["Количество"]);

                            textBoxNameGoods.Text = $"Товар с максимальным количеством:\r\nНазвание: {productName}\r\nКоличество: {maxQuantity}\r\n";
                        }
                    }
                }
            }

        }

        private void buttonMinCost_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    // SQL-запрос для выбора товара с минимальной себестоимостью
                    cmd.CommandText = @"
                SELECT НазваниеТовара.Название, Склад.Себестоимость
                FROM Склад
                JOIN НазваниеТовара ON Склад.ID_товара = НазваниеТовара.ID_ТипаТовара
                ORDER BY Склад.Себестоимость ASC
                LIMIT 1;
            ";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        
                        textBoxNameGoods.Clear();

                        
                        while (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            double minCost = Convert.ToDouble(reader["Себестоимость"]);

                            textBoxNameGoods.Text = $"Товар с минимальной себестоимостью:\r\nНазвание: {productName}\r\nСебестоимость: {minCost}\r\n";
                        }
                    }
                }
            }
        }

        private void buttonMaxCost_Click(object sender, EventArgs e)
        {
            textBoxNameGoods.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT НазваниеТовара.Название, Склад.Себестоимость
                FROM Склад
                JOIN НазваниеТовара ON Склад.ID_товара = НазваниеТовара.ID_ТипаТовара
                ORDER BY Склад.Себестоимость DESC
                LIMIT 1;
            ";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        textBoxNameGoods.Clear();


                        while (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            double minCost = Convert.ToDouble(reader["Себестоимость"]);

                            textBoxNameGoods.Text = $"Товар с минимальной себестоимостью:\r\nНазвание: {productName}\r\nСебестоимость: {minCost}\r\n";
                        }
                    }
                }
            }

        }
    }
    
}
