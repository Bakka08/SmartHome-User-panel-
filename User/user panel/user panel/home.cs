using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace user_panel
{
    public partial class home : Form
    {
        string parametres = "SERVER=127.0.0.1; DATABASE=smarthome; UID=root; PASSWORD=";
        private MySqlConnection maconnexion;
        DataTable dataTable = new DataTable();
        int currRowIndex;
        
        string appartement;
        string s1;
        string s2;
        string s3;
        string s4;
        string s5;
        string s6;
        string s11;
        string s22;
        string s33;
        string s44;
        string s55;
        string s66;
        string s111;
        string s222;
        string s333;
        string s444;
        string s555;
        string s666;
        string s1111;
        string s2222;
        string s3333;
        string s4444;
        string s5555;
        string s6666;
        string s11111;
        string s22222;
        string s33333;
        string s44444;
        string s55555;
        string s66666;
        string test = "1";



        public home(string appartement)
        {
            
            this.appartement= appartement;
            InitializeComponent();
            tglcolor.FlatStyle = FlatStyle.Flat;
            tglcolor.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.FlatAppearance.BorderSize = 0;     
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Flat;
            button24.FlatAppearance.BorderSize = 0;
            button24.FlatStyle = FlatStyle.Flat;
            button25.FlatAppearance.BorderSize = 0;
            button25.FlatStyle = FlatStyle.Flat;
            button26.FlatAppearance.BorderSize = 0;
            button26.FlatStyle = FlatStyle.Flat;
            button27.FlatAppearance.BorderSize = 0;
            button27.FlatStyle = FlatStyle.Flat;
            button28.FlatAppearance.BorderSize = 0;
            button28.FlatStyle = FlatStyle.Flat;
            button29.FlatAppearance.BorderSize = 0;
            button29.FlatStyle = FlatStyle.Flat;
            button30.FlatAppearance.BorderSize = 0;
            button30.FlatStyle = FlatStyle.Flat;
            button31.FlatAppearance.BorderSize = 0;
            button31.FlatStyle = FlatStyle.Flat;
            
        }
        public void loadpanels()
        {
            
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select nom , id from zones where appartement = "+appartement+" LIMIT 5";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i=0;
            String[] myArray = new String[12];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                
                foreach (var item in dataRow.ItemArray)
                {
                    myArray[i] = item.ToString();
                    i++;
                }
                
            }
           
            if (i == 2)
            {
                label1.Text = myArray[0] + " :";
                label8.Text = myArray[1];
                label1.Visible = true;
                panel2.Visible = true;
                loadmachines1(myArray[1]);


            }
            if (i == 4)
            {
                label1.Text = myArray[0] + " :";
                label8.Text = myArray[1];
                label1.Visible = true;
                label2.Text = myArray[2] + " :";
                label9.Text = myArray[3];
                label2.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                loadmachines1(myArray[1]);
                loadmachines2(myArray[3]);

            }
            if (i == 6)
            {
                label1.Text = myArray[0] + " :";
                label8.Text = myArray[1];
                label1.Visible = true;
                label2.Text = myArray[2] + " :";
                label9.Text = myArray[3];
                label2.Visible = true;
                label3.Text = myArray[4] + " :";
                label10.Text = myArray[5];
                label3.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                loadmachines1(myArray[1]);
                loadmachines2(myArray[3]);
                loadmachines3(myArray[5]);

            }
            if (i == 8)
            {
                
                label1.Text = myArray[0]+" :";
                label8.Text = myArray[1];
                label1.Visible= true;
                label2.Text = myArray[2] + " :";
                label9.Text = myArray[3];
                label2.Visible = true;
                label3.Text = myArray[4] + " :";
                label10.Text = myArray[5];
                label3.Visible = true;
                label4.Text = myArray[6] + " :";
                label11.Text = myArray[7];
                label4.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                loadmachines1(myArray[1]);
                loadmachines2(myArray[3]);
                loadmachines3(myArray[5]);
                loadmachines4(myArray[7]);
                

            }
            if (i == 10)
            {
                label1.Text = myArray[0] + " :";
                label8.Text = myArray[1];
                label1.Visible = true;
                label2.Text = myArray[2] + " :";
                label9.Text = myArray[3];
                label2.Visible = true;
                label3.Text = myArray[4] + " :";
                label10.Text = myArray[5];
                label3.Visible = true;
                label4.Text = myArray[6] + " :";
                label11.Text = myArray[7];
                label4.Visible = true;
                label5.Text = myArray[8] + " :";
                label12.Text = myArray[9];
                label5.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                loadmachines1(myArray[1]);
                loadmachines2(myArray[3]);
                loadmachines3(myArray[5]);
                loadmachines4(myArray[7]);
                loadmachines5(myArray[9]);
                

            }
        }
        public void loadmachines1(string zone_id)
        {
            int tv = 0;
            int r = 0;
            int c = 0;
            int l = 0;
            int w = 0;
            int rd = 0;
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select status1,nom from machine where zone=" + zone_id + " LIMIT 6";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i = 0;
            
            String[] myArray = new String[12];
            string back="0";
            foreach (DataRow dataRow in dataTable.Rows)
            {

                foreach (var item in dataRow.ItemArray)
                {
                    myArray[i] = item.ToString();

                    if (myArray[i] == "TV" )
                    {
                        tv = 1;
                        s1 = back;

                    }
                    else if (myArray[i] == "Réfrigérateur")
                    {
                        r = 1;
                        s2 = back;
                    }
                    else if (myArray[i] == "Climatiseur")
                    {
                        c = 1;
                        s4 = back;
                    }
                    else if (myArray[i] == "lampe")
                    {
                        l = 1;
                        s5 = back;
                    }
                    else if (myArray[i] == "Wifi")
                    {
                        w = 1;
                        s6 = back;
                    }
                    else if (myArray[i] == "rideau")
                    {
                        rd = 1;
                        s3 = back;
                    }
                   
                       
                    
                    
                    i++;
                    }
            }
                

                    if (tv==1)
                    {
                
                pictureBox3.Visible = true;
                tglcolor.Visible = true;
                if (s1=="1")
                {
                    tglcolor.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    tglcolor.BackgroundImage = Properties.Resources.Screenshot_2;


                }



            }
                    if (r == 1)
                    {
               
                pictureBox4.Visible = true;
                button1.Visible = true;
                if (s2 == "1")
                {
                    button1.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button1.BackgroundImage = Properties.Resources.Screenshot_2;


                }


            }
                     if (c == 1)
                    {
                pictureBox6.Visible = true;
                button4.Visible = true;
                if (s3 == "1")
                {
                    button4.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button4.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
                    if (l == 1)
                    {
                
                pictureBox7.Visible= true;
                        button5.Visible= true;
                if (s4 == "1")
                {
                    button5.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button5.BackgroundImage = Properties.Resources.Screenshot_2;


                }


            }
                     if (w == 1)
                    {
                
                pictureBox8.Visible = true;
                button6.Visible = true;
                if (s5 == "1")
                {
                    button6.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button6.BackgroundImage = Properties.Resources.Screenshot_2;


                }


            }
                     if (rd == 1)
                    {
                pictureBox5.Visible = true;
                button2.Visible = true;
                if (s6 == "1")
                {
                    button2.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button2.BackgroundImage = Properties.Resources.Screenshot_2;


                }


            }

                




            
        }
        public void loadmachines2(string zone_id)
        {
            int tv = 0;
            int r = 0;
            int c = 0;
            int l = 0;
            int w = 0;
            int rd = 0;
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select status1,nom from machine where zone=" + zone_id + " LIMIT 6";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i = 0;
            String[] myArray = new String[12];
            foreach (DataRow dataRow in dataTable.Rows)
            {

                foreach (var item in dataRow.ItemArray)
                {
                    string back = "";
                    myArray[i] = item.ToString();

                    if (myArray[i] == "TV")
                    {
                        tv = 1;
                        s11 = back;
                    }
                    else if (myArray[i] == "Réfrigérateur")
                    {
                        r = 1;
                        s22 = back;
                    }
                    else if (myArray[i] == "Climatiseur")
                    {
                        c = 1;
                        s33 = back;
                    }
                    else if (myArray[i] == "lampe")
                    {
                        l = 1;
                        s44 = back;
                    }
                    else if (myArray[i] == "Wifi")
                    {
                        w = 1;
                        s55 = back;
                    }
                    else if (myArray[i] == "rideau")
                    {
                        rd = 1;
                        s66 = back;
                    }
                    back = myArray[i];
                    i++;
                }
            }


            if (tv == 1)
            {
                pictureBox14.Visible = true;
                button13.Visible = true;
                if (s11 == "1")
                {
                    button13.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button13.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (r == 1)
            {
                pictureBox13.Visible = true;
                button12.Visible = true;
                if (s22 == "1")
                {
                    button12.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button12.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (c == 1)
            {
                pictureBox11.Visible = true;
                button9.Visible = true;
                if (s33 == "1")
                {
                    button9.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button9.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (l == 1)
            {
                pictureBox10.Visible = true;
                button8.Visible = true;
                if (s44 == "1")
                {
                    button8.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button8.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (w == 1)
            {
                pictureBox9.Visible = true;
                button7.Visible = true;
                if (s55 == "1")
                {
                    button7.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button7.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (rd == 1)
            {
                pictureBox12.Visible = true;
                button11.Visible = true;
                if (s66 == "1")
                {
                    button11.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button11.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }







        }
        public void loadmachines3(string zone_id)
        {
            int tv = 0;
            int r = 0;
            int c = 0;
            int l = 0;
            int w = 0;
            int rd = 0;
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select status1 , nom from machine where zone=" + zone_id + " LIMIT 6";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i = 0;
            String[] myArray = new String[12];
            foreach (DataRow dataRow in dataTable.Rows)
            {

                foreach (var item in dataRow.ItemArray)
                {
                    string back = "0";
                    myArray[i] = item.ToString();

                    if (myArray[i] == "TV")
                    {
                        tv = 1;
                        s111 = back;
                    }
                    else if (myArray[i] == "Réfrigérateur")
                    {
                        r = 1;
                        s222 = back;
                    }
                    else if (myArray[i] == "Climatiseur")
                    {
                        c = 1;
                        s333= back;
                    }
                    else if (myArray[i] == "lampe")
                    {
                        l = 1;
                        s444=back;
                    }
                    else if (myArray[i] == "Wifi")
                    {
                        w = 1;
                        s555= back;
                    }
                    else if (myArray[i] == "rideau")
                    {
                        rd = 1;
                        s666 = back;
                    }
                    back = myArray[i];
                    i++;
                }
            }


            if (tv == 1)
            {
                pictureBox20.Visible = true;
                button19.Visible = true;
                if (s111 == "1")
                {
                    button19.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button19.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (r == 1)
            {
                pictureBox19.Visible = true;
                button18.Visible = true;
                if (s222 == "1")
                {
                    button18.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button18.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (c == 1)
            {
                pictureBox17.Visible = true;
                button16.Visible = true;
                if (s333 == "1")
                {
                    button16.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button16.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (l == 1)
            {
                pictureBox16.Visible = true;
                button15.Visible = true;
                if (s444 == "1")
                {
                    button15.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button15.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (w == 1)
            {
                pictureBox15.Visible = true;
                button14.Visible = true;
                if (s555 == "1")
                {
                    button14.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button14.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (rd == 1)
            {
                pictureBox18.Visible = true;
                button17.Visible = true;
                if (s666 == "1")
                {
                    button17.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button17.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }







        }
        public void loadmachines4(string zone_id)
        {
            int tv = 0;
            int r = 0;
            int c = 0;
            int l = 0;
            int w = 0;
            int rd = 0;
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select status1 , nom from machine where zone=" + zone_id + " LIMIT 6";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i = 0;
            String[] myArray = new String[12];
            foreach (DataRow dataRow in dataTable.Rows)
            {

                foreach (var item in dataRow.ItemArray)
                {
                    myArray[i] = item.ToString();
                    string back = "";

                    if (myArray[i] == "TV")
                    {
                        tv = 1;
                        s1111 = back;
                    }
                    else if (myArray[i] == "Réfrigérateur")
                    {
                        r = 1;
                        s2222= back;
                    }
                    else if (myArray[i] == "Climatiseur")
                    {
                        c = 1;
                        s3333= back;
                    }
                    else if (myArray[i] == "lampe")
                    {
                        l = 1;
                        s4444= back;
                    }
                    else if (myArray[i] == "Wifi")
                    {
                        w = 1;
                        s5555= back;
                    }
                    else if (myArray[i] == "rideau")
                    {
                        rd = 1;
                        s6666= back;
                    }
                    back = myArray[i];
                    i++;
                }
            }


            if (tv == 1)
            {
                pictureBox26.Visible = true;
                button25.Visible = true;
                if (s1111== "1")
                {
                    button25.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button25.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (r == 1)
            {
                pictureBox25.Visible = true;
                button24.Visible = true;
                if (s2222 == "1")
                {
                    button24.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button24.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (c == 1)
            {
                pictureBox23.Visible = true;
                button22.Visible = true;
                if (s3333 == "1")
                {
                    button22.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button22.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (l == 1)
            {
                pictureBox22.Visible = true;
                button21.Visible = true;
                if (s4444 == "1")
                {
                    button21.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button21.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (w == 1)
            {
                pictureBox21.Visible = true;
                button20.Visible = true;
                if (s5555 == "1")
                {
                    button20.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button20.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (rd == 1)
            {
                pictureBox24.Visible = true;
                button23.Visible = true;
                if (s6666 == "1")
                {
                    button23.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button23.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }








        }
        public void loadmachines5(string zone_id)
        {
            int tv = 0;
            int r = 0;
            int c = 0;
            int l = 0;
            int w = 0;
            int rd = 0;
            dataTable.Clear();
            maconnexion = new MySqlConnection(parametres);
            maconnexion.Open();
            string request = "select status1, nom from machine where zone=" + zone_id + " LIMIT 6";

            MySqlCommand cmd = new MySqlCommand(request, maconnexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);

            int i = 0;
            String[] myArray = new String[12];
            foreach (DataRow dataRow in dataTable.Rows)
            {

                foreach (var item in dataRow.ItemArray)
                {
                    myArray[i] = item.ToString();
                    string back = "";

                    if (myArray[i] == "TV")
                    {
                        tv = 1;
                        s11111 = back;

                    }
                    else if (myArray[i] == "Réfrigérateur")
                    {
                        r = 1;
                        s22222= back;
                    }
                    else if (myArray[i] == "Climatiseur")
                    {
                        c = 1;
                        s33333= back;
                    }
                    else if (myArray[i] == "lampe")
                    {
                        l = 1;
                        s44444= back;
                    }
                    else if (myArray[i] == "Wifi")
                    {
                        w = 1;
                        s55555= back;
                    }
                    else if (myArray[i] == "rideau")
                    {
                        rd = 1;
                        s66666= back;
                    }
                    back = myArray[i];
                    i++;
                }
            }


            if (tv == 1)
            {
                pictureBox32.Visible = true;
                button31.Visible = true;
                if (s11111 == "1")
                {
                    button31.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button31.BackgroundImage = Properties.Resources.Screenshot_2;


                }



            }
            if (r == 1)
            {
                pictureBox31.Visible = true;
                button30.Visible = true;
                if (s22222 == "1")
                {
                    button30.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button30.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (c == 1)
            {
                pictureBox29.Visible = true;
                button28.Visible = true;
                if (s33333 == "1")
                {
                    button28.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button28.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (l == 1)
            {
                pictureBox28.Visible = true;
                button27.Visible = true;
                if (s44444 == "1")
                {
                    button27.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button27.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (w == 1)
            {
                pictureBox27.Visible = true;
                button26.Visible = true;
                if (s55555 == "1")
                {
                    button26.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button26.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }
            if (rd == 1)
            {
                pictureBox30.Visible = true;
                button29.Visible = true;
                if (s66666 == "1")
                {
                    button29.BackgroundImage = Properties.Resources.Screenshot_1;


                }
                else
                {
                    button29.BackgroundImage = Properties.Resources.Screenshot_2;


                }

            }







        }


        private void home_Load(object sender, EventArgs e)
        {
            
        }

        private void tglcolor_Click(object sender, EventArgs e)
        {
            if (s1 == "1")
            {
                s1 = "0";
                
                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s1);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                    tglcolor.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s1 = "1";
                
                
                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s1);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                tglcolor.BackgroundImage = Properties.Resources.Screenshot_1;

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

        private void button32_Click(object sender, EventArgs e)
        {
            loadpanels();
            button32.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (s2 == "1")
            {
                s2 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s2);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button1.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s2 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s2);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button1.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s3 == "1")
            {
                s3 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s3);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button2.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s3 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s3);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button2.BackgroundImage = Properties.Resources.Screenshot_1;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s4 == "1")
            {
                s4 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s4);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button4.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s4 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s4);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button4.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s5 == "1")
            {
                s5 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s5);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button5.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s5 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s5);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button5.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (s6 == "1")
            {
                s6 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s6);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button6.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s6 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s6);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button6.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (s11 == "1")
            {
                s11 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s11);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button13.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s11 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s11);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button13.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (s22 == "1")
            {
                s22 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s22);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button12.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s22 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s22);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button12.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (s33 == "1")
            {
                s33 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s33);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button11.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s33 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s33);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button11.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (s44 == "1")
            {
                s44 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s44);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button9.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s44 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label8.Text;
                cmd.Parameters.AddWithValue("@status1", s44);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button9.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (s55 == "1")
            {
                s55 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s55);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button8.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s55= "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s55);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button8.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (s66 == "1")
            {
                s6 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s66);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button7.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s66 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label9.Text;
                cmd.Parameters.AddWithValue("@status1", s66);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button7.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (s111 == "1")
            {
                s111 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button19.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s111 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button19.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (s222 == "1")
            {
                s222 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button18.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s222 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button18.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (s333 == "1")
            {
                s333 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button17.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s333 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button17.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (s444 == "1")
            {
                s444 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button16.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s444 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button16.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (s555 == "1")
            {
                s555 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button15.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s555 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button15.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (s666 == "1")
            {
                s666 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button14.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s666 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label10.Text;
                cmd.Parameters.AddWithValue("@status1", s666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button14.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (s1111 == "1")
            {
                s1111 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s1111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button25.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s1111 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s1111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button25.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (s2222 == "1")
            {
                s2222 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s2222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button24.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s2222 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s2222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button24.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (s3333 == "1")
            {
                s3333 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s3333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button23.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s3333 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button23.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (s4444 == "1")
            {
                s4444 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s4444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button22.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s4444 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s4444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button22.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (s5555 == "1")
            {
                s5555 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s5555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button21.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s5555 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s5555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button21.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (s6666 == "1")
            {
                s6666 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s6666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button20.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s6666 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label11.Text;
                cmd.Parameters.AddWithValue("@status1", s6666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button20.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (s11111 == "1")
            {
                s11111 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s11111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button31.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s11111 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s11111);
                cmd.Parameters.AddWithValue("@nom", "TV");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button31.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (s22222 == "1")
            {
                s22222 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s22222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button30.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s22222 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s22222);
                cmd.Parameters.AddWithValue("@nom", "Réfrigérateur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button30.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (s33333 == "1")
            {
                s33333 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s33333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button29.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s33333 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s33333);
                cmd.Parameters.AddWithValue("@nom", "Rideau");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button29.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (s44444 == "1")
            {
                s44444 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s44444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button28.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s44444 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s44444);
                cmd.Parameters.AddWithValue("@nom", "Climatiseur");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button28.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (s55555 == "1")
            {
                s55555 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s55555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button27.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s55555 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s55555);
                cmd.Parameters.AddWithValue("@nom", "lampe");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button27.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (s66666 == "1")
            {
                s66666 = "0";

                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s66666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button26.BackgroundImage = Properties.Resources.Screenshot_2;


            }
            else
            {
                s66666 = "1";


                maconnexion = new MySqlConnection(parametres);
                maconnexion.Open();

                MySqlCommand cmd = maconnexion.CreateCommand();
                cmd.CommandText = "UPDATE machine SET status1= @status1 WHERE nom=@nom AND zone=" + label12.Text;
                cmd.Parameters.AddWithValue("@status1", s66666);
                cmd.Parameters.AddWithValue("@nom", "Wifi");

                cmd.ExecuteNonQuery();
                maconnexion.Close();
                button26.BackgroundImage = Properties.Resources.Screenshot_1;

            }
        }
    }
}
