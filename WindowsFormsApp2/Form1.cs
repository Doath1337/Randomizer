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
       


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox4.Text);
            }
            catch
            {
                textBox4.Text = @"""SPAAAAAAAAAAAAAAAAAAAAAAACE""";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Clear();
                Random rnd = new Random();
                int count = Convert.ToInt32(textBox3.Text);
                int min, max;
                min = Convert.ToInt32(textBox1.Text);
                max = Convert.ToInt32(textBox2.Text) + 1;
                if (max < min)
                {
                    MinAndMaxError Error = new MinAndMaxError();
                    Error.Show();
                }

                if (checkBox1.Checked == true && max - min >= count)
                {

                    List<int> list = new List<int>(count);
                    var Delete = list.Distinct();

                    for (int i = 0; list.Count != count; i++)
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
                    for (int j = 0; j < list.Count; j++)
                    {
                        textBox4.Text += list[j].ToString() + " ";
                    }

                }
                else if (checkBox1.Checked == false)
                {
                    for (int i = 0; i < count; i++)
                    {

                        int valueRnd = rnd.Next(min, max);
                        textBox4.Text += valueRnd.ToString() + " ";


                    }
                }
                else if (checkBox1.Checked == true && max - min < count)
                {
                    textBox4.Text += "The number of digits is less than their values from min to max";
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
    }

}





//System.ArgumentOutOfRangeException