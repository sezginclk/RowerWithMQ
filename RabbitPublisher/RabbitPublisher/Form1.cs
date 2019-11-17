using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitPublisher
{
    public partial class Form1 : Form
    {

        string _queueName = "Sezgin";
        Publisher _publisher;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string sendMessage = "Left";
            _publisher = new Publisher(_queueName, sendMessage);

            //MessageBox.Show("YESS");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string sendMessage = "Up";
            _publisher = new Publisher(_queueName, sendMessage);
            //MessageBox.Show("YESS");


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sendMessage = "Right";
            _publisher = new Publisher(_queueName, sendMessage);
            //MessageBox.Show("YESS");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string sendMessage = "Down";
            _publisher = new Publisher(_queueName, sendMessage);

            //MessageBox.Show("YESS");
        }
    }
}
