using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.Add("Canoe");
            cbxType.Items.Add("Kayak");
            cbxType.Items.Add("Paddleboard");
        }

        private void btnCheckReserve_Click(object sender, EventArgs e)
        {
            string type = cbxType.SelectedItem.ToString();
            int num_adults;
            int num_children;

            /* Set the condition to validate the data entered by the user
             * for the number of adults and children to make a reservation
             * for renting a boat */
            if (Int32.TryParse(txtNumAdults.Text, out num_adults) == false)
            {

                lblCheckReserve.Text = "Invalid data";
                lblCheckReserve.BackColor = Color.Red;
                MessageBox.Show("You must enter a number", "Error");
                return;
            }
            else if (num_adults < 0)
            {
                lblCheckReserve.Text = "Invalid data";
                lblCheckReserve.BackColor = Color.Red;
                MessageBox.Show("You can't enter a negative number", "Error");
                return;
            }
            else if (Int32.TryParse(txtNumChildren.Text, out num_children) == false)
            {
                lblCheckReserve.Text = "Invalid data";
                lblCheckReserve.BackColor = Color.Red;
                MessageBox.Show("You must enter a number", "Error");
                return;
            }
            else if (num_children < 0)
            {
                lblCheckReserve.Text = "Invalid data";
                lblCheckReserve.BackColor = Color.Red;
                MessageBox.Show("You can't enter a negative number", "Error");
                return;
            }
            /* Set the condition for each type of boats, in which how many persons are allowed
             * to rent and get the data from the user and then 
             * display the status of the reservation */

            /* Creating a new method named CheckCanoe and its calling statment
             * using a refactoring */

            CheckCanoe(type, num_adults, num_children);

        }

        private void CheckCanoe(string type, int num_adults, int num_children)
        {
            if (type == "Canoe")
            {

                if ((num_adults == 2 && num_children == 0) || (num_adults == 1 && num_children == 1))
                {

                    lblCheckReserve.Text = "You are good to reserve this boat! " + "\n" +
                                           "Please click the 'Reserve' button to complete the reservation process! " + "\n";
                    lblCheckReserve.BackColor = Color.LightGreen;
                    txtNumAdults.Enabled = false;
                    txtNumChildren.Enabled = false;
                    cbxType.Enabled = false;
                    btnReserve.Enabled = true;
                }
                else
                {
                    lblCheckReserve.Text = "Invalid data";
                    lblCheckReserve.BackColor = Color.Red;
                    MessageBox.Show("This boat can be reserved only for either 2 adults or one adult and one child", "Error");
                    return;
                }
            }
            /* Creating a new method named CheckKayak and its calling statment
             * using a refactoring */

            CheckKayak(type, num_adults, num_children);
        }

        private void CheckKayak(string type, int num_adults, int num_children)
        {
            if (type == "Kayak")
            {
                if (num_adults == 1 && num_children == 0)
                {
                    lblCheckReserve.Text = "You are good to reserve this boat! " + "\n" +
                                           "Please click the 'Reserve' button to complete the reservation process! " + "\n";
                    lblCheckReserve.BackColor = Color.LightGreen;
                    txtNumAdults.Enabled = false;
                    txtNumChildren.Enabled = false;
                    cbxType.Enabled = false;
                    btnReserve.Enabled = true;


                }
                else
                {
                    lblCheckReserve.Text = "Invalid data";
                    lblCheckReserve.BackColor = Color.Red;
                    MessageBox.Show("This boat can be reserved for only one adult", "Error");
                    return;
                }
            }
            /* Creating a new method named CheckPaddleBoard and its calling statment
             * using a refactoring */

            CheckPaddleBoard(type, num_adults, num_children);
        }

        private void CheckPaddleBoard(string type, int num_adults, int num_children)
        {
            if (type == "Paddleboard")
            {
                if (num_adults == 1 && num_children <= 1)
                {
                    lblCheckReserve.Text = "You are good to reserve this boat! " + "\n" +
                                           "Please click the 'Reserve' button to complete the reservation process! " + "\n";
                    lblCheckReserve.BackColor = Color.LightGreen;
                    txtNumAdults.Enabled = false;
                    txtNumChildren.Enabled = false;
                    cbxType.Enabled = false;
                    btnReserve.Enabled = true;
                }
                else
                {
                    lblCheckReserve.Text = "Invalid data";
                    lblCheckReserve.BackColor = Color.Red;
                    MessageBox.Show("This boat can be reserved for either only one adult or one adult and one child", "Error");
                    return;
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Display the details of the reservation
            lblCheckReserve.Text = "";
            lblCheckReserve.BackColor = BackColor;
            MessageBox.Show("Your reservation for renting a boat is confirmed. " + "\n" +
                "Here is the detail of your reservation: " + "\n" +
                "Type of boat: " + cbxType.SelectedItem  + "\n" +
                "Number of persons on the reservation: " + "\n" + 
                "Adults = " + txtNumAdults.Text + "\n" + "Children = " + txtNumChildren.Text + "\n" +
                "Thank You for renting with us! " + "\n", "Confirmation for Reservation ");
            
             
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            /* Reseting the form after the user reserve to rent a boat of his/her own selection 
             * and make ready the form for another entries */
            txtNumAdults.Text = "";
            txtNumChildren.Text = "";
            lblCheckReserve.Text = "";
            lblCheckReserve.BackColor = BackColor;

            txtNumAdults.Enabled = true;
            txtNumChildren.Enabled = true;
            cbxType.Enabled = true;
            btnCheckReserve.Enabled = true;
            btnReserve.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
