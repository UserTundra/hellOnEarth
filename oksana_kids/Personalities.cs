using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class Personalities : Form
    {
        public Personalities()
        {
            InitializeComponent();
        }

        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();

        private void Personalities_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet6.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter1.Fill(this.bd_kidsDataSet6.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.T01_personalities". При необходимости она может быть перемещена или удалена.
            this.t01_personalitiesTableAdapter.Fill(this.bd_kidsDataSet.T01_personalities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.T10_organizations". При необходимости она может быть перемещена или удалена.
            this.t10_organizationsTableAdapter.Fill(this.bd_kidsDataSet.T10_organizations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.R02_pupils_classes". При необходимости она может быть перемещена или удалена.
            this.r02_pupils_classesTableAdapter.Fill(this.bd_kidsDataSet.R02_pupils_classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet.R01_people_category". При необходимости она может быть перемещена или удалена.
            this.r01_people_categoryTableAdapter.Fill(this.bd_kidsDataSet.R01_people_category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSetGender.R00_decode". При необходимости она может быть перемещена или удалена.
            this.r00_decodeTableAdapter.Fill(this.bd_kidsDataSetGender.R00_decode);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSet1.T01_2_others". При необходимости она может быть перемещена или удалена.
            this.t01_2_othersTableAdapter.Fill(this.bd_kidsDataSet1.T01_2_others);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_kidsDataSetPupils.T01_1_pupils". При необходимости она может быть перемещена или удалена.
            this.t01_1_pupilsTableAdapter.Fill(this.bd_kidsDataSetPupils.T01_1_pupils);

            study_class.Enabled = false;
            study_years.Enabled = false;

            birth_date.Format = DateTimePickerFormat.Custom;
            birth_date.CustomFormat = "dd.mm.yyyy";

            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            human_category.DropDownStyle = ComboBoxStyle.DropDownList;
            study_class.DropDownStyle = ComboBoxStyle.DropDownList;
            place_work_study.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void loadStudyYears()
        {
            int classIdx = study_class.SelectedIndex + 1;

            var linq = (from i in bd.R02_pupils_classes
                        where i.code_class == classIdx
                        select new
                        {
                            f = i.study_years
                        });

            foreach (var item in linq)
            {
                study_years.Text = item.f;
            }


        }

        private void study_class_TextChanged(object sender, EventArgs e)
        {
            loadStudyYears();
        }

        private void human_category_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (human_category.SelectedValue.ToString() == "2")
                    {
                        study_class.Enabled = true;
                        study_years.Enabled = true;
                    }
                else
                    {
                        study_class.Enabled = false;
                        study_years.Enabled = false;
                    }
            }
            catch(Exception ee) { MessageBox.Show("!!!"); MessageBox.Show(ee.StackTrace); }
            
        }

        private void T01addButton_Click(object sender, EventArgs e)
        {
            if (surname.Text == "" || name.Text == "" || patronymic.Text == "" || login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                try
                {
                    bd_kidsDataSet.T01_personalitiesRow row;
                    row = bd_kidsDataSet.T01_personalities.NewT01_personalitiesRow();
                    row.surname = surname.Text;
                    row.name = name.Text;
                    row.patronymic = patronymic.Text;

                    //birth_date.Format = DateTimePickerFormat.Custom;
                    //birth_date.CustomFormat = "dd.mm.yyyy";

                    row.date_birth = "dd.mm.yyyy";
                    row.gender = (long)gender.SelectedValue;
                    row.code_category = (long)human_category.SelectedValue;
                    row.id_org = (long)place_work_study.SelectedValue;
                    if (human_category.SelectedValue.ToString() == "2")
                    {
                        row.code_class = (int)study_class.SelectedValue;
                    }
                    else
                    {
                        

                    }
                    row.login = login.Text;
                    row.password = password.Text;
                    row.date_updating = DateTime.Now.ToString("dd.mm.yyyy");
                    row.note = note.Text == " " ? " " : note.Text;

                    this.bd_kidsDataSet.T01_personalities.Rows.Add(row);
                    this.t01_personalitiesTableAdapter.Update(this.bd_kidsDataSet.T01_personalities);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

                gridViewOthers.Refresh();
                gridViewPupils.Refresh();
            }
        }

        private void study_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
