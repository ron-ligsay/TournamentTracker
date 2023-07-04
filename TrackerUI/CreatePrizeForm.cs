using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;
            int palceNumber = 0;
            // 5:00:00
            bool PlaceNumberValidNumber = int.TryParse(placeNumberValue.Text, out palceNumber);

            if (!PlaceNumberValidNumber)
            {
                output = false;
            }

            if (PlaceNumberValidNumber < 1)
            {
                output = false;
            }

            return output;
        }
    }
}
