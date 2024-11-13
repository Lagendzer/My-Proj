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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.meshcheryakovDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.StudGroup". При необходимости она может быть перемещена или удалена.
            this.studGroupTableAdapter.Fill(this.meshcheryakovDataSet.StudGroup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.meshcheryakovDataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.meshcheryakovDataSet.Student);

        }
    }
}
