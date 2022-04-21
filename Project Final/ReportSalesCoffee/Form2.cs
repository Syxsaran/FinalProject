using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSalesCoffee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonCoffee.Checked == true)
            {
                Visible = false;
                Coffee coffee = new Coffee();
                coffee.Visible = true;
            }
            if (radioButtonSweet.Checked == true)
            {
                Visible = false;
                Sweet sweet = new Sweet();
                sweet.Visible = true;
            }
            if (radioButtonfood.Checked == true)
            {
                Visible = false;
                Food food = new Food();
                food.Visible = true;
            }
        }
    }
}
