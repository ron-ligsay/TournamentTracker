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

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
     /// <summary>
     /// Creating Prize Form
     /// </summary>
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

            }
        }

        private bool ValidateForm()
        {
            // 5:00:00
            bool output = true;

            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool PlaceNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!PlaceNumberValidNumber)
            {
                output = false;
                // you can add loging error report
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0) 
            {
                output = false;
            }


            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {

            }

            return output;
        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
