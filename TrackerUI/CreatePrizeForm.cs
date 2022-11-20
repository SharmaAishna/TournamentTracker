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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
                if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text, 
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text
                    );
               GlobalConfig.Connection.CreatePrize(model); 
                PlaceNameValue.Text = " ";
                PlaceNumberValue.Text = " ";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has Invalid information.Please check and try again");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(PlaceNumberValue.Text, out placeNumber);
            if(!placeNumberValid)
            {
                output = false;
            }
            if(placeNumber<1)
            {
                output = false;
            }
            if(PlaceNameValue.Text.Length==0)
            {
                output=false;
            }
            decimal prizeAmount = 0;
            double pricePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out pricePercentage);
            if (!prizeAmountValid||!prizePercentageValid)
            {
                output = false;//there should be 0 atleast in both textbox
            }
            if(prizeAmount<=0 && pricePercentage<=0)
            {
                output = false;
            }
            if(prizeAmount<0|| pricePercentage>100)
            {
                output = false;
            }
            return output;
        }
    }
}
