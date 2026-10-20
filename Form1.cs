using PRG272Group5PM;
using PRG272Group5PM.BuildLayer;
using PRG272Group5PM.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRG272Final1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnimalID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecies.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtRecovery.Text))
            {
                MessageBox.Show("Please enter all details");
                return;
            }
            try
            {
                string animalID = txtAnimalID.Text.Trim();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                string age = txtAge.Text.Trim();
                int RS = Convert.ToInt32(txtRecovery.Text.Trim());
                string status;
                string housing;

                bool hasWR = animalID.Contains("WR-");
                int islength = animalID.Length;

                if (RS > 100 || RS < 0)
                {
                    MessageBox.Show("Recovery status out of bounts.");
                    txtRecovery.Focus();
                    return;
                }

                if (hasWR == true && islength == 7)
                {
                    string letters = animalID.Substring(0, 3);

                    letters.ToUpper();
                    string realAID = letters + animalID.Substring(animalID.IndexOf('-'));
                    DataHandler handler = new DataHandler();
                    Calculations calculat = new Calculations();

                    status = calculat.CalculatorStatus(RS);
                    housing = calculat.CalculateHousing(status);

                    handler.AddAnimal(animalID, name, species, age, RS, status, housing);
                    txtAnimalID.Clear();
                    txtName.Clear();
                    txtSpecies.Clear();
                    txtAge.Clear();
                    txtRecovery.Clear();
                    txtAge.Clear();

                    FileHandler fh = new FileHandler();
                    List<Animals> animal = fh.readAnimals();

                    // Ensure designer columns map to properties
                    dgvAnimals.AutoGenerateColumns = false;
                    dgvAnimals.DataSource = animal;
                }
                else
                {
                    MessageBox.Show("Incorrect ID syntax. ID must contain WR- followed by 4 numbers");
                    txtAnimalID.Clear();
                    txtAnimalID.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileHandler fh = new FileHandler();
            List<Animals> animal = fh.readAnimals();

            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.DataSource = animal;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            string animalID = txtUpID.Text.Trim();
            string oldValue = txtOldValue.Text.Trim();
            string newValue = txtNewValue.Text.Trim();

            handler.UpdateAnimal(animalID, oldValue, newValue);

            try
            {
                DataHandler detect = new DataHandler();

                detect.DetectRS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FileHandler fh = new FileHandler();
            List<Animals> animal = fh.readAnimals();

            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.DataSource = animal;

            txtUpID.Clear();
            txtOldValue.Clear();
            txtNewValue.Clear();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
