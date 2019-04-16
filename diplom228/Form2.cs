using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom228
{
    public partial class Form2 : Form
    {
        public static string user;
        public static string dostup;
        public Form2()
        {
            InitializeComponent();
        }

        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.platformi". При необходимости она может быть перемещена или удалена.
            this.platformiTableAdapter.Fill(this.testerDataSet.platformi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.testerDataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.testerDataSet.projects);

            panel1.Hide();
           label2.Text = user;
            label3.Text = dostup;
            panel2.Hide();
            if (label3.Text == "(Тестировщик)")
            {
                справочникиToolStripMenuItem.Visible = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);
            this.productsTableAdapter.InsertQuery(nazvanieTextBox.Text, proizvoditelTextBox.Text);
            this.productsTableAdapter.Fill(this.testerDataSet.products);
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);
            this.productsTableAdapter.DeleteQuery(Convert.ToInt32(id_prodTextBox.Text));
            this.productsTableAdapter.Fill(this.testerDataSet.products);
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);
            

        }
    }
}
