using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
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
            textBox4.Clear();
            Random rnd = new Random();
            int count = Convert.ToInt32(textBox3.Text);
            int min, max;
            min = Convert.ToInt32(textBox1.Text);
            max = Convert.ToInt32(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                List<int> list = new List<int>(count);
                var Delete = list.Distinct();
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        int valueRnd = rnd.Next(min, max);
                        list.Add(valueRnd);
                        var set = new HashSet<int>();
                        lock (list)
                        {
                            foreach (var item in list)
                            {
                                if (!set.Add(item))
                                {
                                    list.RemoveAt(list.Count - 1);
                                    
                                    break;
                                }

                            }
                        }

                        
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        MinAndMaxError Error = new MinAndMaxError();
                        Error.Show();
                    }
                    catch (System.FormatException)
                    {
                        FormatException Error = new FormatException();
                        Error.Show();
                    }
                }
                for (int j = 0; j < list.Count - 1; j++)
                {
                    textBox4.Text += list[j].ToString() + " ";
                }

            }
            else if (checkBox1.Checked == false)
            {
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        int valueRnd = rnd.Next(min, max);
                        textBox4.Text += valueRnd.ToString() + " ";
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        MinAndMaxError Error = new MinAndMaxError();
                        Error.Show();
                    }
                    catch (System.FormatException)
                    {
                        FormatException Error = new FormatException();
                        Error.Show();
                    }
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }

}





//System.ArgumentOutOfRangeException