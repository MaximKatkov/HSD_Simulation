using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void castomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.castomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void castomersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.castomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "modelDataSet.Castomers". При необходимости она может быть перемещена или удалена.
            this.castomersTableAdapter.Fill(this.modelDataSet.Castomers);

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(genderCheckBox.CheckState==CheckState.Checked)
            {
                genderCheckBox.Text = "Male";
            }
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";
            }
            else
            {
                genderCheckBox.Text = "??";
            }
        }
    }
}
