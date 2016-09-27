using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace WindowsFormsApplication2



{

    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            begin.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //When button is pressed it will disapear
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
            //// the text stars off as black and changes to white
            //countdown.ForeColor = Color.White;
            button1.Visible = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.beepsound);
            player.Play();
            countdown.Text = "Starting in 3";
            //this is the delay before it changes the text
            Refresh();
            Thread.Sleep(1000);
           
            player.Play();
            countdown.Text = "Starting in 2";
            Refresh();
            Thread.Sleep(1000);
            
            player.Play();
            countdown.Text = "Starting in 1";
            Refresh();
            Thread.Sleep(1000);
            player.Play();
            countdown.Text = "GO!!!";
            BackColor = Color.Green;
            Refresh();

            Thread.Sleep(1000);

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush brush = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.White);
            // draw your logo
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            formGraphics.DrawEllipse(drawPen, 100, 75, 100, 100);
            formGraphics.FillEllipse(brush, 100, 75, 100, 100);
            formGraphics.DrawString("rams", drawFont, brush2, 120, 100);
            Font = new Font("Arial", 40, FontStyle.Bold);
            formGraphics.DrawString("C", drawFont, brush2, 105, 100);
            Thread.Sleep(3000);

            BackColor = Color.Black;
            begin.Visible = true;
            countdown.BackColor = Color.Black;
            countdown.ForeColor = Color.Black;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void countdown_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void begin_Click(object sender, EventArgs e)
        {



            countdown.BackColor = Color.Black;
            countdown.ForeColor = Color.Black;
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);

                      
            // pause
            Thread.Sleep(2000);

            

            //Clear screen and draw animation
            formGraphics.Clear(Color.Black);                                
            formGraphics.FillPie(pacBrush, 50, 50, 40 ,60 , 30, 300);
            Thread.Sleep(1000);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 50, 50, 40, 60, 30, 360);
            Thread.Sleep(1000);


            //Clear screen and draw animation
            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 75, 50, 40, 60, 30, 300);
            Thread.Sleep(1000);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 100, 50, 40, 60, 30, 360);
            Thread.Sleep(1000);


            //Clear screen and draw animation
            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 150, 50, 40, 60, 30, 300);
            Thread.Sleep(1000);

            //Clear screen and draw animation
            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 200, 50, 40, 60, 30, 360);
            Thread.Sleep(1000);

            formGraphics.Clear(Color.Black);
            formGraphics.FillPie(pacBrush, 200, 50, 40, 60, 115,  300);
            Thread.Sleep(1000);



        }





    }
}
