using System;
using System.Windows.Forms;

namespace BuildYourOwnPizza
{
    public partial class Welcome : Form
    {
        ReadWrite rw = new ReadWrite();
        Thread edit;
        Thread build;
        public Welcome()
        {
            InitializeComponent();
            rw = new ReadWrite();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaBuilder pb = new PizzaBuilder();
            pb.Show();
            pb.Activate();
            build = new Thread(new ThreadStart(pb.showPrices));
            this.Hide();
            build.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PricesEditor pe = new PricesEditor();
            pe.Show();
            pe.Activate();
            edit = new Thread(new ThreadStart(pe.showPrices));
            this.Hide();
            edit.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}