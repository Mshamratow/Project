using Project;
using System.Text;
using Xunit.Abstractions;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void Test1()
        {
            Form1 form1 = new Form1();
            form1.textBox2.Text = "Чешк";
            form1.radioButton1.Checked = true;
            Assert.True(form1.panel2.HasChildren);
        }
        [Fact]
        public void Test2()
        {
            Form1 form1 = new Form1();
            form1.radioButton1.Checked = true;
            Assert.Equal("Зарезервировано", form1.checked_status);
        }
        [Fact]
        public void Test3()
        {
            Form1 form1 = new Form1();
            Form1.Guest[] array = new Form1.Guest[5];
            array[0] = new Form1.Guest { fio = "Осетрова Надежда Карповна", status = "Зарезервировано" };
            array[1] = new Form1.Guest { fio = "Зарипов Руслан Марселевич", status = "Зарезервировано" };
            array[2] = new Form1.Guest { fio = "Гарипов Захар Муратович", status = "Заняты" };
            array[3] = new Form1.Guest { fio = "Гарипов Захар Муратович", status = "Заняты" };
            array[4] = new Form1.Guest { fio = "Гарипов Захар Муратович", status = "Заняты" };
            form1.Filtrate(array, "Зарезервировано", "Зарип");
            form1.DeleteColumns();
            Assert.Equal(true, form1.active_labels[0].IsDisposed);
        }

        [Fact]
        public void Test4()
        {
            Form2 form2 = new Form2(1);
            string temp = form2.label4.Text;
            form2.DaysIncrement();
            Assert.NotEqual(form2.label4.Text, temp);
        }

        [Fact]
        public void Test5()
        {
            Form2 form2 = new Form2(1);
            string temp = form2.label4.Text;
            form2.DaysIncrement();
            form2.DaysDecrement();
            Assert.Equal(form2.label4.Text, temp);
        }
    }
}