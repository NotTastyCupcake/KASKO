
namespace SimpleProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
            
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStah = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSignal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.textBoxFranc = new System.Windows.Forms.TextBox();
            this.checkBoxFranchise = new System.Windows.Forms.CheckBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_res = new System.Windows.Forms.Label();
            this.checkBoxRate = new System.Windows.Forms.CheckBox();
            this.answ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата начала эксплуатации Авто";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStah);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Location = new System.Drawing.Point(284, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о водителе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стаж вождения водителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Возраст водителя";
            // 
            // textBoxStah
            // 
            this.textBoxStah.Location = new System.Drawing.Point(6, 100);
            this.textBoxStah.MaxLength = 2;
            this.textBoxStah.Name = "textBoxStah";
            this.textBoxStah.Size = new System.Drawing.Size(40, 23);
            this.textBoxStah.TabIndex = 4;
            this.textBoxStah.Text = "0";
            this.textBoxStah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxAge
            // 
            this.textBoxAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAge.Location = new System.Drawing.Point(6, 41);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(40, 23);
            this.textBoxAge.TabIndex = 2;
            this.textBoxAge.Tag = "";
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSignal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxModel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxMark);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об авто";
            // 
            // checkBoxSignal
            // 
            this.checkBoxSignal.AutoSize = true;
            this.checkBoxSignal.Location = new System.Drawing.Point(6, 155);
            this.checkBoxSignal.Name = "checkBoxSignal";
            this.checkBoxSignal.Size = new System.Drawing.Size(155, 19);
            this.checkBoxSignal.TabIndex = 6;
            this.checkBoxSignal.Text = "Наличие сигнализации";
            this.checkBoxSignal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Модель авто";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.Enabled = false;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(6, 126);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 23);
            this.comboBoxModel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Марка авто";
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Items.AddRange(new object[] {
            "Lada",
            "Tayota"});
            this.comboBoxMark.Location = new System.Drawing.Point(6, 82);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(200, 23);
            this.comboBoxMark.TabIndex = 2;
            this.comboBoxMark.SelectedIndexChanged += new System.EventHandler(this.comboBoxMark_SelectedIndexChanged);
            // 
            // textBoxFranc
            // 
            this.textBoxFranc.Enabled = false;
            this.textBoxFranc.Location = new System.Drawing.Point(462, 46);
            this.textBoxFranc.Name = "textBoxFranc";
            this.textBoxFranc.PlaceholderText = "от 10 000,00 руб.";
            this.textBoxFranc.Size = new System.Drawing.Size(100, 23);
            this.textBoxFranc.TabIndex = 4;
            this.textBoxFranc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // checkBoxFranchise
            // 
            this.checkBoxFranchise.AutoSize = true;
            this.checkBoxFranchise.Location = new System.Drawing.Point(462, 21);
            this.checkBoxFranchise.Name = "checkBoxFranchise";
            this.checkBoxFranchise.Size = new System.Drawing.Size(84, 19);
            this.checkBoxFranchise.TabIndex = 5;
            this.checkBoxFranchise.Text = "Франшиза";
            this.checkBoxFranchise.UseVisualStyleBackColor = true;
            this.checkBoxFranchise.CheckedChanged += new System.EventHandler(this.checkBoxFranchise_CheckedChanged);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Enabled = false;
            this.textBoxRate.Location = new System.Drawing.Point(462, 94);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.PlaceholderText = "от 20 000,00 руб.";
            this.textBoxRate.Size = new System.Drawing.Size(100, 23);
            this.textBoxRate.TabIndex = 6;
            this.textBoxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_res);
            this.groupBox3.Location = new System.Drawing.Point(285, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 45);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат (руб.)";
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(7, 19);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(94, 15);
            this.label_res.TabIndex = 0;
            this.label_res.Text = "Введите данные";
            // 
            // checkBoxRate
            // 
            this.checkBoxRate.AutoSize = true;
            this.checkBoxRate.Location = new System.Drawing.Point(462, 72);
            this.checkBoxRate.Name = "checkBoxRate";
            this.checkBoxRate.Size = new System.Drawing.Size(110, 19);
            this.checkBoxRate.TabIndex = 7;
            this.checkBoxRate.Text = "Базовый тариф";
            this.checkBoxRate.UseVisualStyleBackColor = true;
            this.checkBoxRate.CheckedChanged += new System.EventHandler(this.checkBoxRate_CheckedChanged);
            // 
            // answ
            // 
            this.answ.Location = new System.Drawing.Point(462, 123);
            this.answ.Name = "answ";
            this.answ.Size = new System.Drawing.Size(100, 24);
            this.answ.TabIndex = 8;
            this.answ.Text = "Ответ";
            this.answ.UseVisualStyleBackColor = true;
            this.answ.Click += new System.EventHandler(this.answ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 208);
            this.Controls.Add(this.answ);
            this.Controls.Add(this.checkBoxRate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.checkBoxFranchise);
            this.Controls.Add(this.textBoxFranc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Калькулятор КАСКО";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.CheckBox checkBoxSignal;
        private System.Windows.Forms.TextBox textBoxFranc;
        private System.Windows.Forms.CheckBox checkBoxFranchise;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.CheckBox checkBoxRate;
        private System.Windows.Forms.Button answ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

