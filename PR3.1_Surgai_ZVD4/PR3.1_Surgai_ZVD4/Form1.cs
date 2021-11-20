using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3._1_Surgai_ZVD4
{
    public partial class Form1 : Form
    {
        List<CarInfo> carInfoList = new List<CarInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CarInfo car;

            if (whiteRadioButton.Checked)
            {
                car = new CarInfo(carNumberTextBox.Text, modelTextBox.Text, whiteRadioButton.Text, ownersFirstNameTextBox.Text, ownersLastNameTextBox.Text);
            }
            else
            if (blackRadioButton.Checked)
            {
                car = new CarInfo(carNumberTextBox.Text, modelTextBox.Text, blackRadioButton.Text, ownersFirstNameTextBox.Text, ownersLastNameTextBox.Text);
            }
            else

                car = new CarInfo(carNumberTextBox.Text, modelTextBox.Text, redRadioButton.Text, ownersFirstNameTextBox.Text, ownersLastNameTextBox.Text);

            carInfoList.Add(car);

            carsNumbersListBox.Items.Clear();
            carsNumbersListBox.Items.AddRange(carInfoList.Select(c => c.Number).ToArray());

            carNumberTextBox.Clear();
            modelTextBox.Clear();
            ownersFirstNameTextBox.Clear();
            ownersLastNameTextBox.Clear();
        }

        private void carsNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carNumberTextBox.Text = carsNumbersListBox.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            carInfoList.RemoveAll(c => c.Number == carsNumbersListBox.SelectedItem);

            carsNumbersListBox.Items.Clear();

            for (int i = 0; i < carInfoList.Count; i++)
                carsNumbersListBox.Items.Add(carInfoList[i].Number);
        }
    }
}
