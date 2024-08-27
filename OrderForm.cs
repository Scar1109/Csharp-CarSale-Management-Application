using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderForm : Form
    {
        private CarData car;
        public OrderForm(CarData selectedCar)
        {
            InitializeComponent();
            car = selectedCar;

            // Set the car details


        }
    }
}
