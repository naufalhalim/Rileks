using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rileks2
{
    public partial class UCGrafik : UserControl
    {
        public UCGrafik()
        {
           
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

            conn.Open();

            try
            {
                string new_column = "CREATE TABLE [dbo].[" + NamaTable + "] ([Id] int identity (1,1) not null, [Hasil] int, PRIMARY KEY CLUSTERED ([Id] ASC))";
                SqlCommand cmdc = new SqlCommand(new_column, conn);
                cmdc.ExecuteNonQuery();
                string insert_query1 = "insert into [" + NamaTable + "] (Hasil) values (@Hasil)";
                SqlCommand cmda = new SqlCommand(insert_query1, conn);
                cmda.Parameters.AddWithValue("@Hasil", TitikGrafik);
                cmda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                string insert_query = "insert into [" + NamaTable + "] (Hasil) values (@Hasil)";
                SqlCommand cmd = new SqlCommand(insert_query, conn);
                cmd.Parameters.AddWithValue("@Hasil", TitikGrafik);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            string aa = "Select * from [" + NamaTable + "]";
            SqlCommand cmdd = new SqlCommand(aa, conn);

            try
            {
                conn.Open();
                using (SqlDataReader read = cmdd.ExecuteReader())
                {
                    while (read.Read())

                    {
                        this.chart1.Series["Hasil"].Points.AddXY(read["Id"], read["Hasil"]);

                        chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
                        chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
                        chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                        //chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
                        chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(read["Id"]) - 6;
                        chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1;
                        chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 6;


                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(0.5, 1.5, "No depression");
                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(1.5, 2.5, "Mild depression");
                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(2.5, 3.5, "Moderate depression");
                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(3.5, 4.5, "Moderately severe depression");
                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(4.5, 5.5, "Severe depression");
                        chart1.ChartAreas["ChartArea1"].AxisY.CustomLabels.Add(5.5, 6.5, "");

                    }

                }
            }
            finally
            {
                conn.Close();
            }
        }

        private UCNama nama;
        private UCQuest9 point;
        public UCGrafik (UCNama nama)
        {
            InitializeComponent();
            this.nama = nama;
        }
        public UCGrafik(UCQuest9 point)
        {
            InitializeComponent();
            this.point=point;
        }

        string NamaTable = UCNama.jawaban;
        int TitikGrafik = UCQuest9.point;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCMusik"))
            {
                UCMusik musik = new UCMusik();
                musik.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(musik);
            }
            Form1.Instance.PnlContainer.Controls["UCMusik"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCHasil"].BringToFront();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
