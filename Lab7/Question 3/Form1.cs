using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enteredId;
            if (int.TryParse(idTextBox.Text, out enteredId))
            {
                bool isValid = VerifyEmployeeId(enteredId);
                resultLabel.Text = isValid ? "Valid Employee ID" : "Invalid Employee ID";
            }
            else
            {
                resultLabel.Text = "Invalid ID format";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
