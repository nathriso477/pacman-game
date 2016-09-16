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

        }

        private void button1_Click(object sender, EventArgs e)
        {   //When button is pressed it will disapear
            Button clickedButton = (Button)sender;
            clickedButton.Visible = false;
            //// the text stars off as black and changes to white
            //countdown.ForeColor = Color.White;

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
         //backround color changes green for "go"
            BackColor = Color.Green;

        private void begin_Click(object sender, EventArgs e)
        {
            //grahpics start here
            BackColor = Color.Black;
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            formGraphics.DrawEllipse(drawPen, 25, 25, 100, 200);
            Thread.Sleep(3000);
        }
    }
}
