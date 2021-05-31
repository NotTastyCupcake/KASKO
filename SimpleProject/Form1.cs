using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SimpleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar; 
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void comboBoxMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Enabled = true;
            comboBoxModel.DataSource = Car.CarInfo.ModelsCars(comboBoxMark.SelectedIndex);
            comboBoxModel.DisplayMember = "Name";
            comboBoxModel.ValueMember = "Id";
        }
        
        private void checkBoxFranchise_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFranc.Enabled = checkBoxFranchise.Checked;
        }

        private void checkBoxRate_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRate.Enabled = checkBoxRate.Checked;
        }

        private void answ_Click(object sender, EventArgs e)
        {

            try
            {
                List<Car.Model.ModelCar> carContext = Car.CarInfo.ModelsCars(comboBoxMark.SelectedIndex);
                
                double kh = carContext[comboBoxModel.SelectedIndex].ModelCoef;

                int bt = Company.Company.CompRate(checkBoxRate.Checked, textBoxRate.Text);
                double kv = Car.CarInfo.CoeffBeginWork(dateTimePicker1.Value);
                double kf = Company.Company.CompFrancB(checkBoxFranchise.Checked);
                double ks = Person.PersonInfo.PersonStah(textBoxStah.Text);
                double ka = Person.PersonInfo.PersonAge(textBoxAge.Text);

                double ko = Car.CarInfo.CarSignalCoeff(checkBoxSignal.Checked);

                string res = Convert.ToString(Math.Round((bt * kv * kf * ks) + (kh * kv * ko), 2));

                label_res.Text = res;       //(Бт * Кв * Кф * Кс * Кр) + (Кх * Кв * Ко * Кр).;
            }

            catch when (comboBoxModel.Enabled == false || textBoxAge.Text.Length == 0 || textBoxStah.Text.Length == 0)
            {
                label_res.Text = "Введены не все данные";
            }

        }

    }

}
/*
Базовый тариф (Бт).
Дату начала эксплуатации авто (Кв).=
Коэффициент франшизы (Кф).
Возраст и стаж автовладельца (Кс).
Возможная рассрочка (Кр).
Коэффициент угона (Кх).=
Сигнализация (Ко).
Получается, что стоимость страховки = (Бт * Кв * Кф * Кс * Кр) + (Кх * Кв * Ко * Кр).
Стоит учесть то, что цифра в любом случае будет приблизительна, поэтому лучше доверить этот процесс страховому агенту.
*/