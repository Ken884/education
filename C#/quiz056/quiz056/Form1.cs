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
            TimeSpan nightEnd = new TimeSpan(5, 0, 0);


            double wage = Convert.ToDouble(textBox1.Text);
            double hourly = Convert.ToDouble((end - start - rest).TotalHours);
            double dayShift = Convert.ToDouble((night - start - rest).TotalHours);
            double nightShift = Convert.ToDouble(NightDuration(start, end).TotalHours);
            double salaryBase = wage * hourly;
            double salary;

            Console.WriteLine(nightShift);

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
                if (hasNightDuration(start, end))
                {
                    salary = (wage * dayShift * 1.35) + (wage * nightShift * 1.6);//休日深夜
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                    
                }
                else
                {
                    salary = salaryBase + (salaryBase * 0.35);//休日
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                }
            }
            else if (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                if ((hasNightDuration(start, end)) && (hourly <= 8))//平日深夜
                {
                    salary = salaryBase + (wage * nightShift * 0.25);
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                }
                else if (!(hasNightDuration(start, end)) && (hourly > 8))//平日時間外
                {
                    salary = salaryBase + (wage * (hourly - 8) * 0.25);
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                }
                
                else if((hasNightDuration(start,end)) && (start > nightEnd) && (hourly > 8))//平日深夜時間外(終業時のみ深夜)
                {
                    salary = salaryBase + (wage * (dayShift - 8) * 0.25) + (wage * nightShift * 0.5);
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                }
                else if ((hasNightDuration(start, end)) && (start < nightEnd) && (hourly > 8))
                {
                    salary = salaryBase + (wage * (hourly - nightShift - 8) * 0.25)
                        + (wage * nightShift * 0.5);
                    textBox4.Text = Convert.ToInt32(salary).ToString();
                }
                else
                {
                    salary = salaryBase;
                    textBox4.Text = Convert.ToInt32(salary).ToString();
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

        public static TimeSpan NightDuration(TimeSpan start, TimeSpan end)
        {
            TimeSpan zero = new TimeSpan(0, 0, 0);
            TimeSpan five = new TimeSpan(5, 0, 0);
            TimeSpan twentytwo = new TimeSpan(22, 0, 0);

            if(start > twentytwo || end < five)
            {
                return end - start;
            }

            else if (start < five && end < twentytwo)
            {
                return five - start;
            }

            else if(start < five && end > twentytwo)
            {
                return (end - twentytwo) + (five - start);
            }

            else if(start > five && end > twentytwo)
            {
                return end - twentytwo;
            }
            else
            {
                return zero;
            }
        }

        public static bool hasNightDuration(TimeSpan start, TimeSpan end)
        {
            var five = new TimeSpan(5, 0, 0);
            var twentytwo = new TimeSpan(22, 0, 0);
            return start < five || end > twentytwo;
        }




    }
}
