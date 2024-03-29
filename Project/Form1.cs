using NLog;

namespace Project
{
    public partial class Form1 : Form
    {
        public struct Guest
        {
            public int number;
            public string imagepath;
            public string status;
            public string fio;
            public string first_date;
            public string last_date;

        }
        const int guests_amount = 5;
        Guest[] guests = new Guest[guests_amount];
        Guest[] active_guests = new Guest[guests_amount];
        public Label[] active_labels = new Label[guests_amount] { new Label(), new Label(), new Label(), new Label(), new Label() };
        public string checked_status;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Filtrate(Guest[] ag, string status, string fio)
        {
            for (int i = 0; i < guests_amount; i++)
            {
                Guest guest = guests[i];
                if (guest.status == status && guest.fio.Contains(fio))
                {
                    ag[i] = guest;
                }
                else ag[i] = new Guest { };
            }
        }

        public void ShowColumns(Guest[] fg)
        {
            int j = 0;
            for (int i = 0; i < guests_amount; i++)
            {
                Guest guest = fg[i];
                if (guest.number == 0)
                {
                    active_labels[i] = new Label();
                    continue;
                }
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = guest.fio;
                lbl.Font = new Font("Arial", 16);
                lbl.Visible = true;
                lbl.Show();
                lbl.BackColor = Color.LightGray;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Location = new Point(25, 100 + j * 40);
                lbl.Parent = panel2;
                lbl.MouseDoubleClick += select_field;
                active_labels[i] = lbl;
                j++;
            }
        }

        public void DeleteColumns()
        {
            for (int i = 0; i < guests_amount; i++)
            {
                active_labels[i].Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            if (!File.Exists("Resources/guests.txt"))
            {
                logger.Fatal("Файл карточек клиентов не найден");
                return;
            }
            StreamReader f = new StreamReader("Resources/guests.txt");
            for (int i = 0; i < guests_amount; i++)
            {
                int num = int.Parse(f.ReadLine());
                string path = f.ReadLine();
                string status = f.ReadLine();
                string fio = f.ReadLine();
                string first_date = f.ReadLine();
                string last_date = f.ReadLine();

                guests[i] = new Guest { number = num, imagepath = path, status = status, fio = fio, first_date = first_date, last_date = last_date };
                active_guests[i] = guests[i];
                f.ReadLine();
            }
            f.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checked_status = "Зарезервировано";
                DeleteColumns();
                Filtrate(active_guests, checked_status, textBox2.Text);
                ShowColumns(active_guests);
                logger.Trace("Выбран фильтр Зарезервировано");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = (textBox2.Text == "");
            DeleteColumns();
            Filtrate(active_guests, checked_status, textBox2.Text);
            ShowColumns(active_guests);
            logger.Trace("Значения поля поиска изменено: " + textBox2.Text);
        }




        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checked_status = "Свободные";
                DeleteColumns();
                Filtrate(active_guests, checked_status, textBox2.Text);
                ShowColumns(active_guests);
                logger.Trace("Выбран фильтр Свободные");
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checked_status = "Заняты";
                DeleteColumns();
                Filtrate(active_guests, checked_status, textBox2.Text);
                ShowColumns(active_guests);
                logger.Trace("Выбран фильтр Заняты");
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checked_status = "Выписываются";
                DeleteColumns();
                Filtrate(active_guests, checked_status, textBox2.Text);
                ShowColumns(active_guests);
                logger.Trace("Выбран фильтр Выписываются");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void select_field(object sender, MouseEventArgs e)
        {
            string fio = ((Label)sender).Text;
            for (int j = 0; j < guests_amount; j++)
            {
                Guest guest = active_guests[j];
                if (guest.fio == fio)
                {
                    label14.Text = guest.number.ToString();
                    logger.Trace("Поле номера заполнено: " + label14.Text);
                    if (!File.Exists("Resources/avatars/" + guest.imagepath))
                    {
                        logger.Error("Аватарка клиента не найдена");
                    }
                    else 
                        pictureBox3.Image = System.Drawing.Image.FromFile("Resources/avatars/" + guest.imagepath);
                    logger.Trace($"Картинка {guest.imagepath} отображена");
                    label7.Text = guest.status;
                    logger.Trace("Поле статуса заполнено: " + label7.Text);
                    label8.Text = guest.fio;
                    logger.Trace("Поле ФИО заполнено: " + label8.Text);
                    label11.Text = guest.first_date;
                    logger.Trace("Поле даты заезда заполнено: " + label11.Text);
                    label12.Text = guest.last_date;
                    logger.Trace("Поле даты выезда заполнено: " + label12.Text);
                    break;
                }
            }
            logger.Debug("Выбран человек: " + fio);
            logger.Debug("Поля заполнены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label14.Text == "")
            {
                logger.Warn("Попытка просмотра пустой карточки");
                return;
            }
            Form2 form2 = new Form2(int.Parse(label14.Text));
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt") + " AM         ";
        }
    }
}