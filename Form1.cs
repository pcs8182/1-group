using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arkanoid
{
    public partial class Form1 : Form
    {
        public int
            choose1,
            choose2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 form2 = new Form2();
            form2.Show();*/

            if (
                (
                    RB1_0.Checked ||
                    RB1_1.Checked
                ) && (
                    RB2_0.Checked ||
                    RB2_1.Checked ||
                    RB2_2.Checked ||
                    RB2_3.Checked ||
                    RB2_4.Checked ||
                    RB2_5.Checked ||
                    RB2_6.Checked ||
                    RB2_7.Checked ||
                    RB2_8.Checked ||
                    RB2_9.Checked
                )
            )
            {
                if (RB1_0.Checked) choose1 = 0;
                if (RB1_1.Checked) choose1 = 1;

                if (RB2_0.Checked) choose2 = 0;
                if (RB2_1.Checked) choose2 = 1;
                if (RB2_2.Checked) choose2 = 2;
                if (RB2_3.Checked) choose2 = 3;
                if (RB2_4.Checked) choose2 = 4;
                if (RB2_5.Checked) choose2 = 5;
                if (RB2_6.Checked) choose2 = 6;
                if (RB2_7.Checked) choose2 = 7;
                if (RB2_8.Checked) choose2 = 8;
                if (RB2_9.Checked) choose2 = 9;

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                button1.Visible = false;

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                button1.Enabled = false;

                LBinfo1.Visible = true;
                LBinfo2.Visible = true;
                LBinfo3.Visible = true;
                LBinfo4.Visible = true;
                LBinfo5.Visible = true;
                LBinfo6.Visible = true;

                LBinfo1.Enabled = true;
                LBinfo2.Enabled = true;
                LBinfo3.Enabled = true;
                LBinfo4.Enabled = true;
                LBinfo5.Enabled = true;
                LBinfo6.Enabled = true;

                button2.Visible = true;
                button2.Enabled = true;

                TBinfo1.Visible = true;
                TBinfo2.Visible = true;
                TBinfo3.Visible = true;
                TBinfo4.Visible = true;
                TBinfo5.Visible = true;
                TBinfo6.Visible = true;

                TBinfo1.Enabled = true;
                TBinfo2.Enabled = true;
                TBinfo3.Enabled = true;
                TBinfo4.Enabled = true;
                TBinfo5.Enabled = true;
                TBinfo6.Enabled = true;

                TBexport.Visible = true;
                TBexport.Enabled = true;

                Test1.Visible = false;
                Test2.Visible = false;
                Test3.Visible = false;

                switch (choose2)
                {
                    case 0:
                        LBinfo2.Text = "Название книги";
                        LBinfo3.Text = "Издательство";
                        LBinfo4.Text = "Город издания";
                        LBinfo5.Text = "Год издания";
                        LBinfo6.Text = "Кол-во страниц";
                        break;

                    case 1:
                        LBinfo2.Text = "Название справочника";
                        LBinfo3.Text = "Издательство";
                        LBinfo4.Text = "Город издания";
                        LBinfo5.Text = "Год издания";
                        LBinfo6.Text = "Кол-во страниц";
                        break;

                    case 2:
                        LBinfo1.Text = "ФИО автора (полностью)";
                        LBinfo2.Text = "Тема диссертации";
                        LBinfo3.Text = "Ученая степень";
                        LBinfo4.Text = "Специальность";
                        LBinfo5.Text = "Город";
                        LBinfo6.Text = "Год написания";
                        LBinfo7.Text = "Кол-во страниц";

                        LBinfo7.Visible = true;
                        LBinfo7.Enabled = true;

                        TBinfo7.Visible = true;
                        TBinfo7.Enabled = true;
                        break;

                    case 3:
                        LBinfo2.Text = "Название статьи";
                        LBinfo3.Text = "Название источника";
                        LBinfo4.Text = "Номер статьи";
                        LBinfo5.Text = "Год издания";
                        LBinfo6.Text = "Страницы (через тире)";
                        break;

                    case 4:
                        LBinfo1.Text = "Фамилия и имя автора";
                        LBinfo2.Text = "Название статьи";
                        LBinfo3.Text = "Название газеты";
                        LBinfo4.Text = "Дата издания";
                        LBinfo5.Text = "Год издания";
                        LBinfo6.Text = "Страница";
                        break;

                    case 5:
                        LBinfo1.Text = "Название документа";
                        LBinfo2.Text = "Кем выпущен";
                        LBinfo3.Text = "Год выпуска";
                        LBinfo4.Text = "Количество страниц";
                        LBinfo5.Text = "Область использования (опционально)";
                        LBinfo6.Visible = false;
                        LBinfo6.Enabled = false;
                        TBinfo6.Visible = false;
                        TBinfo6.Enabled = false;
                        break;

                    case 6:
                        LBinfo1.Text = "Название ресурса";
                        LBinfo2.Text = "Разработчик";
                        LBinfo3.Text = "Город";
                        LBinfo4.Text = "Издатель";
                        LBinfo5.Text = "Год издания";
                        LBinfo6.Text = "Тип и количество носителей";
                        break;

                    case 7:
                        LBinfo1.Text = "Название интернет-ресурса";
                        LBinfo2.Text = "Тип ресурса";
                        LBinfo3.Text = "Год создания";
                        LBinfo4.Text = "URL";
                        LBinfo5.Text = "Дата обращения";
                        LBinfo6.Text = "Режим доступа";
                        break;

                    case 8:
                        LBinfo2.Text = "Название статьи";
                        LBinfo3.Text = "Название интернет-ресурса";
                        LBinfo4.Text = "Тип ресурса";
                        LBinfo5.Text = "Год создания";
                        LBinfo6.Text = "URL";
                        LBinfo7.Text = "Дата обращения";

                        LBinfo7.Visible = true;
                        LBinfo7.Enabled = true;

                        TBinfo7.Visible = true;
                        TBinfo7.Enabled = true;
                        break;

                    case 9:
                        LBinfo2.Text = "Название";
                        LBinfo3.Text = "Тип издания";
                        LBinfo4.Text = "Читающие";
                        LBinfo5.Text = "Город";
                        LBinfo6.Text = "Тип и количество носителей";
                        LBinfo7.Text = "Общая длительность";

                        LBinfo7.Visible = true;
                        LBinfo7.Enabled = true;

                        TBinfo7.Visible = true;
                        TBinfo7.Enabled = true;
                        break;
                }
            }
            else MessageBox.Show("Вы не выбрали количество авторов и/или тип источника!", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = TBinfo1.Text.Split(' ');
            switch (choose2)
            {
                case 0:
                    TBexport.Text = $"{TBinfo1.Text} {TBinfo2.Text} / " +
                        $"{TBinfo1.Text}. - {TBinfo4.Text}: {TBinfo3.Text}, " +
                        $"{TBinfo5.Text}. - {TBinfo6.Text} c.";
                    break;

                case 1:
                    TBexport.Text = $"{TBinfo2.Text} / Сост. " +
                        $"{TBinfo1.Text}. - {TBinfo4.Text}: {TBinfo3.Text}, " +
                        $"{TBinfo5.Text}. - {TBinfo6.Text} c.";
                    break;

                case 2:
                    string[] science = TBinfo3.Text.Split(' ');
                    TBexport.Text = $"{names[0]} {names[1][0]}. {names[2][0]}. {TBinfo2.Text} : " +
                        $"диссертация {science[0]}а {science[1]} {science[2]}: {TBinfo4.Text} / " +
                        $"{TBinfo1.Text}. - {TBinfo5.Text}, " +
                        $"{TBinfo6.Text}. - {TBinfo7.Text} c.";
                    break;

                case 3:
                    TBexport.Text = $"{names[0]}, {names[1]} {names[2]} " +
                        $"{TBinfo2.Text} / {names[1]} {names[2]} {names[0]} // " +
                        $"{TBinfo3.Text} - {TBinfo5.Text}. - № {TBinfo4.Text}. - C. {TBinfo6.Text}";
                    break;

                case 4:
                    TBexport.Text = $"{names[0]}, {names[1][0]}. " +
                        $"{TBinfo2.Text} / {names[1][0]}. {names[0]} // " +
                        $"{TBinfo3.Text} - {TBinfo5.Text}. - {TBinfo4.Text} - C. {TBinfo6.Text}";
                    break;

                case 5:
                    TBexport.Text = $"{TBinfo1.Text} : [{TBinfo2.Text}]. -" +
                        $"{TBinfo3.Text} г. - {TBinfo4.Text} с.";
                    if (TBinfo5.Text != "")
                        TBexport.Text += $" - {TBinfo5.Text}";
                    break;

                case 6:
                    TBexport.Text = $"{TBinfo1.Text} / разработчик \"{TBinfo2.Text}\". - " +
                        $"{TBinfo3.Text}: {TBinfo4.Text}, {TBinfo5.Text}. - {TBinfo6.Text}";
                    break;

                case 7:
                    TBexport.Text = $"{TBinfo1.Text}: {TBinfo2.Text}. - " +
                        $"{TBinfo3.Text}. - URL: {TBinfo4.Text} (дата обращения:" +
                        $"{TBinfo5.Text}). - Режим доступа: {TBinfo6.Text}.";
                    break;

                case 8:
                    TBexport.Text = $"{names[0]} {names[1][0]}. {names[2][0]}. " +
                        $"{TBinfo2.Text} / {names[1]} {names[2]} {names[0]} // " +
                        $"{TBinfo3.Text}: {TBinfo4.Text}. - " +
                        $"{TBinfo5.Text}. - URL: {TBinfo6.Text} (дата обращения:" +
                        $"{TBinfo7.Text}).";
                    break;

                case 9:
                    TBexport.Text = $"{names[0]} {names[1][0]}. {names[2][0]}. " +
                        $"{TBinfo2.Text} :[{TBinfo3.Text}] / {names[1]} {names[2]} {names[0]}; " +
                        $"читают {TBinfo4.Text}. - {TBinfo5.Text}. - {TBinfo6.Text} ({TBinfo7.Text})";
                    break;
            }
        }
    }
}
