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
using TicketReservationSystem.Models;
using TicketReservationSystem.Utils;

namespace TicketReservationSystem.Forms
{
    public partial class Edit : Form
    {
        int id;

        public Edit(int id)
        {
            this.id = id;
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(DB.dbString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT id, first_name, last_name, email, age, gender, height, weight, address, phone, join_date FROM tbl_customers WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textfirstname.Text = (string)reader["first_name"];
                                textlastname.Text = (string)reader["last_name"];
                                textemail.Text = (string)reader["email"];
                                textage.Text = "" + reader["age"];
                                textgender.Text = (string)reader["gender"];
                                textheight.Text = "" + reader["height"];
                                textweight.Text = "" + reader["weight"];
                                textaddress.Text = (string)reader["address"];
                                textphone.Text = "" + reader["phone"];
                                textphone.Text = textphone.Text.Trim();
                                textjoindate.Text = "" + reader["join_date"];
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

        private void FormProduct_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String firstname = textfirstname.Text;
            String lastname = textlastname.Text;
            String email = textemail.Text;
            String age = textage.Text;
            String gender = textgender.Text;
            String height = textheight.Text;
            String weight = textweight.Text;
            String address = textaddress.Text;
            String phone = textphone.Text;
            String joindate = textjoindate.Text;

            if (!Validator.ValidateText(firstname))
            {
                MessageBox.Show("Invalid FirstName");
                return;
            }

            else if (!Validator.ValidateText(lastname))
            {
                MessageBox.Show("Invalid LastName");
                return;
            }

            else if (!Validator.ValidateEmail(email))
            {
                MessageBox.Show("Invalid Email");
                return;
            }

            else if (!Validator.ValidateNumber(age))
            {
                MessageBox.Show("Invalid Age");
                return;
            }

            else if (gender != "Male" && gender != "Female")
            {
                MessageBox.Show("Invalid Gender");
                return;
            }

            else if (!Validator.ValidateNumber(height))
            {
                MessageBox.Show("Invalid Height");
                return;
            }

            else if (!Validator.ValidateNumber(weight))
            {
                MessageBox.Show("Invalid Weight");
                return;
            }

            else if (!Validator.ValidateText(address))
            {
                MessageBox.Show("Invalid Address");
                return;
            }

            else if (!Validator.ValidateNumber(phone))
            {
                MessageBox.Show("Invalid Phone");
                return;
            }


            using (SqlConnection conn = new SqlConnection(DB.dbString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE tbl_customers SET first_name = @first_name, last_name = @last_name, email = @email, age = @age, gender = @gender, height = @height, weight = @weight, address = @address, phone = @phone, join_date = @join_date WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@first_name", firstname);
                    cmd.Parameters.AddWithValue("@last_name", lastname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@join_date", joindate);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Added Succesfully");
                    }
                    catch (SqlException e2)
                    {
                        MessageBox.Show(e2.Message.ToString(), "Error Message");
                    }

                }
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textfirstname.Text = "";
            textlastname.Text = "";
            textemail.Text = "";
            textage.Text = "";
            textgender.Text = "";
            textheight.Text = "";
            textweight.Text = "";
            textaddress.Text = "";
            textphone.Text = "";
            textjoindate.Text = "";
        }
    }
}
