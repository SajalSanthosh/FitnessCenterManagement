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
using TicketReservationSystem.Utils;

namespace TicketReservationSystem.Forms
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();


            GenerateStats();
        }

        private void GenerateStats()
        {
            using (SqlConnection conn = new SqlConnection(DB.dbString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    try
                    {
                        conn.Open();

                        cmd.CommandText = @"SELECT COUNT(*) AS 'total' from tbl_customers;";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                editTotal.Text = "" + reader["total"];
                            }
                        }

                        cmd.CommandText = @"SELECT COUNT(*) AS 'total' from tbl_customers WHERE gender = 'Male';";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                editTotalMale.Text = "" + reader["total"];
                            }
                        }
                        cmd.CommandText = @"SELECT COUNT(*) AS 'total' from tbl_customers WHERE gender = 'Female';";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                editTotalFemale.Text = "" + reader["total"];
                            }
                        }
                        
                        cmd.CommandText = @"SELECT AVG(height) AS 'avgh' from tbl_customers;";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                editAvgHeight.Text = "" + reader["avgh"];
                            }
                        }   

                        cmd.CommandText = @"SELECT AVG(weight) AS 'avgw' from tbl_customers;";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                editAvgWeight.Text = "" + reader["avgw"];
                            }
                        }
                    }
                    catch (SqlException e2)
                    {
                        MessageBox.Show(e2.Message.ToString(), "Error Message");
                    }

                }
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }


            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }

    }
}
