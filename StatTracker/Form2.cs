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

namespace StatTracker
{
    public partial class Form2 : Form
    {
        string name;
        string position;
        string league;
        string year;
        string battingAverage;
        string hits;
        string era;
        string strikeOuts;

        public Form2()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        private void positionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = positionBox.Text;
        }

        private void leagueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            league = leagueBox.Text;
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            year = yearBox.Text;
        }

        private void battingBox_TextChanged(object sender, EventArgs e)
        {
            battingAverage = battingBox.Text;
        }

        private void hitsBox_TextChanged(object sender, EventArgs e)
        {
            hits = hitsBox.Text;
        }

        private void eraBox_TextChanged(object sender, EventArgs e)
        {
            era = eraBox.Text;
        }

        private void strikeoutsBox_TextChanged(object sender, EventArgs e)
        {
            strikeOuts = strikeoutsBox.Text;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Set up a SQL Connection
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projects;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // SQL Query Command
            string sql = "insert into ProspectStats ([name], [position], [league], [year], [batting average], [hits], [era], [strikeouts]) values (@name, @position, @league, @year, @battingaverage, @hits, @era, @strikeouts)";

            // Open the connection
            conn.Open();
            // set values to parameters and execute SQL query
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Update parameter with the object variable, if empty, then add DB Null value
                cmd.Parameters.AddWithValue("@name", ((object)name) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@position", ((object)position) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@league", ((object)league) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@year", ((object)year) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@battingaverage", ((object)battingAverage) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@hits", ((object)hits) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@era", ((object)era) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@strikeouts", ((object)strikeOuts) ?? DBNull.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Added");
            }
        }

    }
}
