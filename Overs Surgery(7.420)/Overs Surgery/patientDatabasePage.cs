using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Overs_Surgery
{
    public partial class patientDatabasePage : Form
    {
        Thread NewPatient;
        SqlConnection connection;
        SqlCommand checkAll;
        SqlDataAdapter Data;
        SqlCommand Search;
        SqlCommand Search2;
        SqlCommand Search3;
        string load = "Select * From Patient_Table";
        SqlDataAdapter Data2;
        SqlDataAdapter Data3;
        SqlDataAdapter Data4;

        Thread Return;

        public patientDatabasePage()
        {
            InitializeComponent();
        }
        private void Create()
        {
            Application.Run(new NewPatientRecord());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            NewPatient = new Thread(Create);
            NewPatient.SetApartmentState(ApartmentState.STA);
            NewPatient.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientDatabasePage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\Overs Surgery(7.0)\Overs Surgery\PatientDatabase.mdf;Integrated Security=True");
            connection.Open();
            checkAll = new SqlCommand(load, connection);
            checkAll.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            Data = new SqlDataAdapter(checkAll);
            Data.Fill(Dt);
            dataGridView1.DataSource = Dt;
            connection.Close();
        }

        private void txtBxPatientID_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            Search = new SqlCommand("Select * From Patient_Table WHERE Patient_ID like'%" + txtBxPatientID.Text + "%'" + "OR First_Name like " + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like '" + txtBxDob.Text + "%'", connection);
            DataTable dt2 = new DataTable();
            Data2 = new SqlDataAdapter(Search);
            Data2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            connection.Close();
        }

        private void txtBxDob_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            Search2 = new SqlCommand("Select * From Patient_Table WHERE First_Name like '" + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like '" + txtBxDob.Text + "%'", connection);
            DataTable dt3 = new DataTable();
            Data3 = new SqlDataAdapter(Search2);
            Data3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            connection.Close();
        }

        private void txtBxPatientName_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            Search3 = new SqlCommand("Select * From Patient_Table WHERE First_Name like '" + txtBxPatientName.Text + "%'" + "AND Date_Of_Birth like '" + txtBxDob.Text + "%'", connection);
            DataTable dt4 = new DataTable();
            Data4 = new SqlDataAdapter(Search3);
            Data4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            connection.Close();
        }
    }
}
