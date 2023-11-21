using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chupikov_ISP1_KD21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Эй, мир!";
            this.BackColor = Color.Pink;
            this.ForeColor = Color.Red; 
            this.Size = new Size(400, 400);
    
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Привет");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1(); 
            newForm1.Show(); 
            Form2 newForm2 = new Form2(newForm1); 
            newForm2.Show();
            Form2 newForm = new Form2(this);
            newForm.Show();

        }
    }
}
