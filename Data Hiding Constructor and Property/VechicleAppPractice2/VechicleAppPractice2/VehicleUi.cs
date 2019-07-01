using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void VehicleUi_Load(object sender, EventArgs e)
        {

        }
        Vehicle vehicle = new Vehicle();
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.Name = vehicleNameTextBox.Text;
            vehicle.RegNo = regNoTextBox.Text;
            vehicle.SpeedList = new List<int>();
            MessageBox.Show("Create successful.");
        }
        
        private void EnterButton_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(speedTextBox.Text);
            
            vehicle.SpeedList.Add(speed);
            MessageBox.Show("Entered.");
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vehicle.GetMinimumSpeed().ToString();
            maxSpeedTextBox.Text = vehicle.GetMaximumSpeed().ToString();
            averageSpeedTextBox.Text = vehicle.GetAverageSpeed().ToString();
        }
    }
}
