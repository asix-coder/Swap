using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();

            lucinda = new Elephant() { Name = "Lucinda", Earsize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", Earsize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant bufor = lloyd;
            lloyd = lucinda;
            lucinda = bufor;

            MessageBox.Show("Objects swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hello", lucinda);

            lloyd = lucinda;
            lloyd.Earsize = 4321;
            lloyd.WhoAmI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lucinda.SpeakTo(lloyd, "Witaj");
        }
    }
}
