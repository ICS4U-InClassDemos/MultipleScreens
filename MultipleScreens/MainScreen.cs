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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SecondScreen ss = new SecondScreen();
            ss.Location = new Point((f.Width - ss.Width) / 2, (f.Height - ss.Height) / 2);
            f.Controls.Add(ss);

            Form1.counter++;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Green;
            exitButton.BackColor = Color.Black;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            exitButton.BackColor = Color.Green;
        }
    }
}
