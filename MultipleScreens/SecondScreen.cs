using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens
{
    public partial class SecondScreen : UserControl
    {
        public SecondScreen()
        {
            InitializeComponent();
            counterLabel.Text = Form1.counter + "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            Form1.ChangeScreen(this, new MainScreen());
            
        }
    }
}
