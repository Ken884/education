using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan start = dateTimePicker2.Value.TimeOfDay;
            TimeSpan end = dateTimePicker3.Value.TimeOfDay;
            TimeSpan rest = RestDuration(start, end);
            TimeSpan night = new TimeSpan(22, 0, 0);


            int wage = Convert.ToInt32(textBox1.Text);
            int hourly = Convert.ToInt32((end - start - rest).TotalHours);
            int dayShift = Convert.ToInt32((night - start - rest).TotalHours);
            int nightShift = Convert.ToInt32((end - night).TotalHours);
            int salaryBase = wage * hourly;
            int salary;

            if (start > end)
            {
                textBox4.Text = " Error";
            }

            else if (Convert.ToInt32(textBox1.Text) < 964)
            {
                textBox4.Text = " Error";
            }

            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (end < night)
                {
                    salary = salaryBase + (int)(salaryBase * 0.35);//休日
                    textBox4.Text = salary.ToString();
                }
                else
                {
                    salary = (int)(wage * dayShift * 1.35) + (int)(wage * nightShift * 1.6);//休日深夜
                    textBox4.Text =salary.ToString();
                }
            }
            else if (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                if ((end > night) && (hourly <= 8))//平日深夜
                {
                    salary = salaryBase + (int)(wage * nightShift * 0.25);
                    textBox4.Text = salary.ToString();
                }
                else if ((end < night) && (hourly > 8))//平日時間外
                {
                    salary = salaryBase + (int)(wage * (hourly - 8) * 0.25);
                    textBox4.Text = salary.ToString();
                }
                
                else if((end > night) && (hourly > 8))//平日深夜時間外
                {
                    salary = salaryBase + (int)(wage * (dayShift - 8) * 0.25) + (int)(wage * nightShift * 0.5);
                    textBox4.Text = salary.ToString();
                }
                else
                {
                    salary = salaryBase;
                    textBox4.Text = salary.ToString();
                }
            }

            




        }

        public static TimeSpan RestDuration(TimeSpan start, TimeSpan end)
        {
            TimeSpan rest12 = new TimeSpan(12, 0, 0);
            TimeSpan rest13 = new TimeSpan(13, 0, 0);
            TimeSpan none = new TimeSpan(0, 0, 0);

            if ((start >= rest12) && (start <= rest13))
            {
                return rest13 - start;
            }
            else if ((rest13 >= end) && (rest12 <= end))
            {
                return end - rest12;
            }
            else if ((start < rest12) && (rest13 < end))
            {
                return rest13 - rest12;
            }
            else
            {
                return none;
            }
        }




    }
}
