using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace diplom228
{
    
    public partial class Form1 : Form
    {
        private String ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;
        public static string a;
        public Form1()
        {
             
        InitializeComponent();
             
    }

        private void urovni_dostupaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.urovni_dostupaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.testerDataSet.test);
            this.KeyPreview = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.testerDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.urovni_dostupa". При необходимости она может быть перемещена или удалена.
            this.urovni_dostupaTableAdapter.Fill(this.testerDataSet.urovni_dostupa);
            string CommandText = "SELECT count(*) FROM users WHERE username='" + comboBox1.Text + "'AND pass='" + textBox2.Text + "'";

            SqlConnection Sconnection = new SqlConnection(@"Data Source=localhost;Initial Catalog=tester;Integrated Security=True");
            SqlCommand SCommand = new SqlCommand(CommandText, Sconnection);
            comboBox2.Text = " ";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string CommandText = "SELECT count(*) FROM users WHERE username='" + comboBox1.Text + "'AND pass='" + textBox2.Text + "'";

            ConnectionString = (@"Data Source=localhost;Initial Catalog=tester;Integrated Security=True");
            connection = new SqlConnection(ConnectionString);
            try
            {
                Console.WriteLine(comboBox1.Text + " and " + textBox2.Text);

                cmd.CommandText = "Select * from users "
                                + "where username = '" + comboBox1.Text + "' "
                                + "and pass = '" + textBox2.Text + "'";

                Console.WriteLine(cmd.CommandText);
                cmd.Connection = connection;
                connection.Open();
                reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    i++;
                }


                if (i == 1)
                {
                    Form2.user = comboBox1.Text;
                    Form2.dostup = "("+comboBox2.Text+")";
                   Form2 win = new Form2();
                    win.Owner = this;
                    win.Show();
                }
                else
                {
                    MessageBox.Show("Неверные данные для входа!", "Authentication Failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block = " + ex);
            }
            finally
            {

                connection.Close();
            }

            a = comboBox1.Text;
        }

        private void Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            } 
        }
    }
}
