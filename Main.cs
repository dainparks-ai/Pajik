using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

      
        public Main(User user)
        {
            InitializeComponent();

            label144.Text = user.Username;
            label145.Text = user.FirstName;
            label146.Text = user.LastName;
            label150.Text = user.Address;
            label151.Text = user.City;
            label152.Text = user.Barangay;
            label149.Text = user.ContactNumber;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void info1_Click(object sender, EventArgs e)
        {

        }

        private void SETTINGS_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        Panel currentPanel;

        private void CloseAllPanels()
        {
            panel4.Height = 0;
            panel5.Height = 0;
            panel6.Height = 0;
            panel7.Height = 0;
            panel8.Height = 0;
            panel9.Height = 0;
            panel10.Height = 0;
            panel11.Height = 0;
            panel12.Height = 0;
            panel13.Height = 0;
         
        }

        private void OpenPanel(Panel panel)
        {
            CloseAllPanels();  

            currentPanel = panel;
            timer1.Start();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenPanel(panel4);
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPanel.Height += 10;

            if (currentPanel.Height >= 175)
            {
                timer1.Stop();
            }

        }

        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenPanel(panel5);

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            OpenPanel(panel7);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OpenPanel(panel6);

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            OpenPanel(panel8);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenPanel(panel11);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenPanel(panel9);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            OpenPanel(panel10);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            OpenPanel(panel13);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            OpenPanel(panel12);
        }

        private void label116_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label117_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label118_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label119_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label120_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label121_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label122_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label123_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label124_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void label125_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox9.Visible = true;
            pictureBox6.Visible = true;
            pictureBox10.Visible = true;
            pictureBox17.Visible = true;

            pictureBox14.Visible = false;
            pictureBox8.Visible = false;
            pictureBox13.Visible = false;
            pictureBox11.Visible = false;
            pictureBox15.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox14.Visible = true ;
            pictureBox8.Visible = true;
            pictureBox13.Visible = true;
            pictureBox11.Visible = true;
            pictureBox15.Visible = true;


            pictureBox5.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = false;
            pictureBox10.Visible = false;
            pictureBox17.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox9.Visible = true;
            pictureBox6.Visible = true;
            pictureBox10.Visible = true;
            pictureBox17.Visible = true;

            pictureBox14.Visible = true;
            pictureBox8.Visible = true;
            pictureBox13.Visible = true;
            pictureBox11.Visible = true;
            pictureBox15.Visible = true;
        }

        private void label139_Click(object sender, EventArgs e)
        {

        }

        private void label136_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();


            this.Close();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label141_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label144_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
