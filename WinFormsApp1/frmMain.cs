using System.Text;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chkCorn_CheckedChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (CheckBox chk in grpVeggies.Controls)
            {
                if (chk.Checked == true)
                    count++;
            }

            if (count > 2)
            {  
                if(sender != null)
                    (sender as CheckBox).Checked = false;
                
                MessageBox.Show("Cannot select more than two vegetables.  Please select only two.", "Error");
              
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder lunch = new StringBuilder();

            lunch.AppendLine($"{txtStudentName.Text}'s lunch menu:");

            foreach (RadioButton chk in grpMeats.Controls)
            {
                if (chk.Checked == true)
                    lunch.AppendLine($"Entree: {chk.Text}");
            }

            foreach (CheckBox chk in grpVeggies.Controls)
            {
                if (chk.Checked == true)
                    lunch.AppendLine($"Vegetable: {chk.Text}");
            }


            foreach (RadioButton chk in grpDrinks.Controls)
            {
                if (chk.Checked == true)
                    lunch.AppendLine($"Drink: {chk.Text}");
            }


            foreach (RadioButton chk in grpDessert.Controls)
            {
                if (chk.Checked == true)
                    lunch.AppendLine($"Dessert: {chk.Text}");
            }

            MessageBox.Show(lunch.ToString(), "Student Lunch Results: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}