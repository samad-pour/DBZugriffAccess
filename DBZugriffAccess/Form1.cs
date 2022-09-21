using System.Data.OleDb;

namespace DBZugriffAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAlleSehen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Users\\samad.pour\\source\\repos\\DB\\firma.accdb";

            // "Provider=Microsoft.Jet.OLEDB.4.0;" Falls: firma.mdb

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM personen";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                LstDisplay.Items.Clear();
                while (reader.Read())
                {
                    LstDisplay.Items.Add(reader["name"] + " # " +
                    reader["vorname"] + " # " +
                    reader["personalnummer"] + " # " +
                    reader["gehalt"] + " # " + reader["geburtstag"]);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAendern_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;
            string op;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Users\\samad.pour\\source\\repos\\DB\\firma.accdb";

            cmd.Connection = con;

            if (sender == BtnErhoehen)
                op = "*";
            else
                op = "/";

            cmd.CommandText =
            "UPDATE personen SET gehalt = gehalt " + op + " 1.05";

            try
            {
                con.Open();

                anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show("Datensätze geändert: " + anzahl);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}