using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class App : UserControl
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a Ibaes Decoración" +
                "Aqui podrás encontrar Variedad de persianas " +
                "a un buen precio y excelente calidad");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plaza Colosio" +
                "Avenida los bukis #1235");
        }
    }
}
