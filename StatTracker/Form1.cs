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


namespace StatTracker
{
    public partial class Form1 : Form
    {
        string name;
        string position;
        string overall;
        string potential;
        string draftYear;
        string draftRound;
        string draftSpot;

        Form2 newform = new Form2();

        public Form1()
        {
            InitializeComponent();

        }

        private void DraftForm_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        private void positionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = positionBox.Text;
        }

        private void overallBox_ValueChanged(object sender, EventArgs e)
        {
            overall = overallBox.Text;
        }

        private void potentialBox_TextChanged(object sender, EventArgs e)
        {
            potential = potentialBox.Text;
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            draftYear = yearBox.Text;
        }

        private void draftRoundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            draftRound = draftRoundBox.Text;
        }

        private void spotBox_TextChanged(object sender, EventArgs e)
        {
            draftSpot = spotBox.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Set up SQL Server Connection
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projects;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // SQL Query to execute later
            string sql = "insert into Prospects ([name], [position], [overall], [potential], [draft year], [draft round], [draft spot]) values (@name, @position, @overall, @potential, @draftyear, @draftround, @draftspot)";

            // Open the Server connection
            conn.Open();
            // Assign values to the parameters and execute the above querey 
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Update parameter with the object variable, if empty, then add DB Null value
                cmd.Parameters.AddWithValue("@name", ((object)name) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@position", ((object)position) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@overall", ((object)overall) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@potential", ((object)potential) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@draftyear", (object)draftYear ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@draftround", ((object)draftRound) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@draftspot", ((object)draftSpot) ?? DBNull.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Added");
            }
        }

        private void form2Button_Click(object sender, EventArgs e)
        {
            // Open the Prospect Stats Form
            newform.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
    
}
