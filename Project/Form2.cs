using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Project
{
    public partial class Form2 : Form
    {
        struct Guest
        {
            public int number;
            public string fio;
            public string birthday;

        }
        const int guests_amount = 5;
        Guest[] guests = new Guest[guests_amount];
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Form2(int number)
        {
            InitializeComponent();
            if (!File.Exists("Resources/cards.txt"))
            {
                logger.Fatal("Файл карточек клиентов не найден");
            }
            StreamReader f = new StreamReader("Resources/cards.txt");
            for (int i = 0; i < guests_amount; i++)
            {
                int num = int.Parse(f.ReadLine());
                string fio = f.ReadLine();
                string birthday = f.ReadLine();
                if (num == number)
                {
                    label8.Text = fio;
                    label1.Text = birthday;
                }
                guests[i] = new Guest { number = num, fio = fio, birthday = birthday };
                f.ReadLine();
            }
            f.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DaysDecrement();
        }
            
        public void DaysIncrement()
        {
            int n = int.Parse(label4.Text);
            if (n == 99) return;
            n++;
            if (n < 10)
                label4.Text = "  0" + n.ToString() + "  ";
            else label4.Text = "  " + n.ToString() + "  ";
        }
        public void DaysDecrement()
        {
                int n = int.Parse(label4.Text);
                if (n == 0) return;
                n--;
                if (n < 10)
                    label4.Text = "  0" + n.ToString() + "  ";
                else label4.Text = "  " + n.ToString() + "  ";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DaysIncrement();
        }
    }
}
