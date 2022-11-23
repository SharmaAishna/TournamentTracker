using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel model = new PersonModel();
                model.FirstName = FirstNameValue.Text;
                model.LastName = LastNameValue.Text;
                model.Email = EmailValue.Text;
                model.Phone = PhoneValue.Text;
                GlobalConfig.Connection.CreatePerson(model);
                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                PhoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill all the value");
            }
        }
        private bool ValidateForm()
        {
            if(FirstNameValue.Text.Length==0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (PhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
