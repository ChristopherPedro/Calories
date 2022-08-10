using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesBurned
{
    public partial class frmCalories : Form
    {
        public frmCalories()
        {
            InitializeComponent();
        }
       
        const double Cycling = 1;
        const double Running = 1.2;
        const double Rowing = 1.5;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            double Weight = 0;
            double Calories_burned = 0;
            int Minutes = 0;
            if (double.TryParse(WeightTextBox.Text,out Weight))
            {

            }    
            else
            {
                MessageBox.Show("Invalid input");
            }
            for (int i = 0;i < 5;i++)
            {
                Minutes = Minutes + 10;
                if (rdbCycling.Checked)
                {
                    Calories_burned = Calories_burned + (Cycling * Weight);                 
                }
                else if (rdbRunning.Checked)
                {
                    Calories_burned = Calories_burned + (Running * Weight);               
                }
                else
                {
                    Calories_burned = Calories_burned + (Rowing * Weight);                      
                }
                lstOutput.Items.Add(Minutes + "\t " + Math.Round(Calories_burned, 0));
                


            }
            lstOutput.Items.Add("");



        }
        private void rdbCycling_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void rdbRunning_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbRowing_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCalories_Load(object sender, EventArgs e)
        {
            lstOutput.Items.Add("Minutes\t Calories Burnt");
        }
    }
}
