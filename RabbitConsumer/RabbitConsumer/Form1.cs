using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitConsumer
{
    public partial class Form1 : Form
    {


        private static Consumer _consumer;
        int lastPosition;
        string _queueName = "Sezgin";
        Image bkg = Image.FromFile($"{ Application.StartupPath}\\car.jpg");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {








        }

        void Left()
        {
            lastPosition -= 1;
        }
        void Right()
        {
            lastPosition += 1;
        }
        void Up()
        {
            lastPosition -= 4;
        }
        void Down()
        {
            lastPosition += 4;
        }
        void RefreshPic()
        {
            string picName = "button" + lastPosition;


            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackgroundImage = null;

            }

            if (picName == "button1")
            {
                button1.BackgroundImage = bkg;
            }
            if (picName == "button2")
            {
                button2.BackgroundImage = bkg;
            }
            if (picName == "button3")
            {
                button3.BackgroundImage = bkg;
            }
            if (picName == "button4")
            {
                button4.BackgroundImage = bkg;
            }
            if (picName == "button5")
            {
                button5.BackgroundImage = bkg;
            }
            if (picName == "button6")
            {
                button6.BackgroundImage = bkg;
            }
            if (picName == "button7")
            {
                button7.BackgroundImage = bkg;
            }
            if (picName == "button8")
            {
                button8.BackgroundImage = bkg;
            }
            if (picName == "button9")
            {
                button9.BackgroundImage = bkg;
            }
            if (picName == "button10")
            {
                button10.BackgroundImage = bkg;
            }
            if (picName == "button11")
            {
                button11.BackgroundImage = bkg;
            }
            if (picName == "button12")
            {
                button12.BackgroundImage = bkg;
            }
            if (picName == "button13")
            {
                button13.BackgroundImage = bkg;
            }
            if (picName == "button14")
            {
                button14.BackgroundImage = bkg;
            }
            if (picName == "button15")
            {
                button15.BackgroundImage = bkg;
            }
            if (picName == "button16")
            {
                button16.BackgroundImage = bkg;
            }


        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {



        }

        public void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {






        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {


            button15.BackgroundImage = bkg;

            lastPosition = 15;

            for (; ; )
            {
                this.Refresh();

                Consumer _consumer = new Consumer(_queueName);

                if (_consumer._queue == "Left")
                {
                    if (lastPosition != 1 && lastPosition != 5 && lastPosition != 9 && lastPosition != 13)
                    {
                        Left();
                        RefreshPic();
                    }
                }

                if (_consumer._queue == "Right")
                {
                    if (lastPosition != 4 && lastPosition != 8 && lastPosition != 12 && lastPosition != 16)
                    {
                        Right();
                        RefreshPic();
                    }
                }

                if (_consumer._queue == "Up")
                {
                    if (lastPosition != 1 && lastPosition != 2 && lastPosition != 3 && lastPosition != 4)
                    {

                        Up();
                        RefreshPic();
                    }
                }

                if (_consumer._queue == "Down")
                {
                    if (lastPosition != 13 && lastPosition != 14 && lastPosition != 15 && lastPosition != 16)
                    {
                        Down();
                        RefreshPic();
                    }
                }
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
