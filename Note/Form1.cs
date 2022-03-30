using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Test". При необходимости она может быть перемещена или удалена.

            using (SqlConnection conn = new SqlConnection(@"Server=krababster;Database=TestDB;Trusted_Connection=True;"))
            {
                conn.Open();
                string sqlCommand = "SELECT * FROM[Name];";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn);
                DataSet ds = new DataSet();
                adapter.Fill(this.dataSet1.Test);

                //foreach (DataTable item in ds.Tables)
                //{
                //    foreach (DataColumn col in item.Columns)
                //    {
                //        Console.Write($"{col.ColumnName}\t");
                //    }
                //    Console.WriteLine();

                //    foreach (DataRow row in item.Rows)
                //    {
                //        foreach (object rowItem in row.ItemArray)
                //        {
                //            Console.Write($"{rowItem.ToString()}\t");
                //        }
                //        Console.WriteLine();
                //    }
                //}
            }
        }
    }
}
