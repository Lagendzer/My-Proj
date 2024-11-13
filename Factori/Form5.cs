using heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heeeeeeeeeeeeeh
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void examBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.meshcheryakovDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Lecturer". При необходимости она может быть перемещена или удалена.
            this.lecturerTableAdapter.Fill(this.meshcheryakovDataSet.Lecturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.meshcheryakovDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.meshcheryakovDataSet.Exam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            examBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            examBindingSource.MovePrevious();
        }
        private void button3_Click(object sender, EventArgs e) {
            examBindingSource.AddNew();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            examBindingSource.MoveLast();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            examBindingSource.MoveNext();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            examBindingSource.RemoveCurrent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.meshcheryakovDataSet);
        }
    
    }
}
