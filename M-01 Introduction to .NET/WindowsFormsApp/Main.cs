using HelloLibrary;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string welcomeMessage = HelloClass.GenerateWelcomeString(DateTime.Now, userName);
            MessageBox.Show(welcomeMessage);
        }
    }
}
