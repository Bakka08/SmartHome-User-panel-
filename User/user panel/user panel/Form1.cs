using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace user_panel
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='smarthome';username=root;password=");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();
        
        DataTable dataTable = new DataTable();
        int currRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            adapter = new MySqlDataAdapter("SELECT `nom`, `mdp` FROM `user` WHERE `nom` = '" + textBox1.Text + "' AND `mdp` = '" + textBox2.Text + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Username Or Password Are Invalid");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                string id;
                dataTable.Clear();
                connection.Open();
                string request = "select appartement from user";
                MySqlCommand cmd = new MySqlCommand(request, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);

                int i;
                String[] myArray = new String[1];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    i = 0;
                    foreach (var item in dataRow.ItemArray)
                    {
                        myArray[i] = item.ToString();
                        i++;
                    }
                    id = myArray[0].ToString() ;
                    home a = new home(id); 
                    this.Hide();
                    a.Show();
                }

                table.Clear();
                
               
        }




    }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult dialogClose = MessageBox.Show("Voulez vous vraiment fermer l'application ?", "Quitter le programme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogClose == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogClose == DialogResult.Cancel)
            {
                //do something else
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
