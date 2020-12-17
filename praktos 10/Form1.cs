using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktos_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList mas = new ArrayList();
        //Добавление
        private void Add_Click(object sender, EventArgs e)
        {            
            mas.Add(Convert.ToInt32(zn.Text));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(mas.ToArray());
        }
        //Очистить
        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            mas.Clear();
            zn.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //Удалить запись
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {                
                mas.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(mas.ToArray());
            }
            else MessageBox.Show("Выделите ячейку");
        }
        //О программе
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №10\n" +
                "Платов Андрей ИСП-31\n" +
                "Проверить, имеется ли в одномерном массиве хотя бы один элемент, попадающий в интервал[а; b].");
        }
        //Выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //кнопка по заданию
        private void button1_Click(object sender, EventArgs e)
        {
            bool f1 = false;
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            for (int i = 0; i < mas.Count; i++)
            {
                if (a <= Convert.ToInt32(mas[i]) && Convert.ToInt32(mas[i]) <= b)
                {
                    f1 = true;
                    break;                  
                }
                else f1 = false;
            }
            if (f1 == true) MessageBox.Show("Есть число");
            else MessageBox.Show("Нет числа");
        }
    }
}
