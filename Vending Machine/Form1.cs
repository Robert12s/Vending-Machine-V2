using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drinkSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (drinkSelect.SelectedIndex)
            {
                case 0:
                    pictureBox1.BackgroundImage = Vending_Machine.Properties.Resources.Large_product_shot_Coca_Cola_Classic_updated;
                    break;
                case 1:
                    pictureBox1.BackgroundImage = Vending_Machine.Properties.Resources.pdp_hero_kozs_Mobile;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Vending_Machine.Properties.Resources._0002117_diet_coke_can_75_oz_135247_200;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Vending_Machine.Properties.Resources.pepsi_zero;
                    break;
                case 4:
                    pictureBox1.BackgroundImage = Vending_Machine.Properties.Resources.pepsi_12oz;
                    break;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (drinkSelect.SelectedItem != null)
            {
                string drinkSelected = drinkSelect.SelectedItem.ToString();
                Console.WriteLine($"{drinkSelected} Purchased");
                labelOutput.Text = $"{drinkSelected} Purchased";
            }
            else
            {
                Console.WriteLine("No Drink Selected");
            }
        }

    }
}
