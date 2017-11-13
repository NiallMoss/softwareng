using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Overs_Surgery;
using System.Threading;

namespace UI_Appoinment
{
    public partial class FormAppointHome : Form
    {
        Thread GoHome;
        public FormAppointHome()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ButtonAppointSubmit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
            GoHome = new Thread(ReturnToAppointment);
            GoHome.SetApartmentState(ApartmentState.STA);
            GoHome.Start();
            
               
        }
         private void ReturnToAppointment()
        {
            Application.Run(new AppointmentPage());

        }

        private void ButtonAppointSubmit_Click_1(object sender, EventArgs e)
        {

        }

        private void ListBoxGPs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
