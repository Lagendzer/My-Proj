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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void studGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studGroupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.meshcheryakovDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.meshcheryakovDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meshcheryakovDataSet.StudGroup". При необходимости она может быть перемещена или удалена.
            this.studGroupTableAdapter.Fill(this.meshcheryakovDataSet.StudGroup);

        }

        private void kursLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
