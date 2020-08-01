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
    public partial class Members : Form
    {
        private DashBoard dashb;
        public Members(DashBoard dashBoard)
        {
            dashb = dashBoard;
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            dataGridView1.ForeColor = ThemeColor.SecondaryColor;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            RefreshTable();

        }

        private void RefreshTable()
        {
            using (SqlConnection conn = new SqlConnection(DB.dbString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT id as 'ID', first_name as 'First Name', last_name as 'Last Name', email as 'Email', age as 'Age', gender as 'Gender', height as 'Height', weight as 'Weight', address as 'Address', phone as 'Phone', join_date as 'Join Date' FROM tbl_customers;";
                    try
                    {
                        conn.Open();
                        DataTable dt = new DataTable();

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (SqlException e2)
                    {
                        MessageBox.Show(e2.Message.ToString(), "Error Message");
                    }

                }
            }
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

        private void btnedit_Click(object sender, EventArgs e)
        {

            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            int id = (int)dataGridView1.Rows[selectedIndex].Cells[0].Value;

            dashb.OpenChildForm(new Forms.Edit(id), null);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            int id = (int)dataGridView1.Rows[selectedIndex].Cells[0].Value;


            string message = "Are you sure you want to delete?";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Record Deleted Successfully");


                using (SqlConnection conn = new SqlConnection(DB.dbString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"DELETE FROM tbl_customers WHERE id = @id;";
                        cmd.Parameters.AddWithValue("@id", id);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            RefreshTable();
                        }
                        catch (SqlException e2)
                        {
                            MessageBox.Show(e2.Message.ToString(), "Error Message");
                        }

                    }
                }

            }




        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileDialog = new SaveFileDialog();

            savefileDialog.Filter = "Excel files (*.csv)|*.csv;";

            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = savefileDialog.FileName;

                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                ExportCSV.CreateCSVFile(ref dt, selectedFileName);

                MessageBox.Show("Succefully Exported", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
