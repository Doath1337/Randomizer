using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public  Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                int min, max;
                min = Convert.ToInt32(textBox1.Text);
                max = Convert.ToInt32(textBox2.Text);
                Random rnd = new Random();
                int valueRnd = rnd.Next(min, max);
                textBox4.Text = valueRnd.ToString();
            }
            catch(System.ArgumentOutOfRangeException)
            {
                MinAndMaxError Error= new MinAndMaxError();
                Error.Show();
            }
            
        }

        
    }
}
//System.ArgumentOutOfRangeException