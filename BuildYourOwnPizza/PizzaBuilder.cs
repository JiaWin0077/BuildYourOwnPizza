using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildYourOwnPizza
{
    public partial class PizzaBuilder : Form, ObserverIF
    {
        CrustFactory cf;
        CrustIF cif;
        Pizza p;
        StreamReader sr;
        ToppingsAbs toppings;
        public Bitmap bitmap1;
        public Bitmap bitmap2;
        int startX;
        int startY;
        public bool paint;
        //Graphics g;
        public PizzaBuilder()
        {
            InitializeComponent();
            cf = new CrustFactory();
            showPrices();
            p = new Pizza();
            bitmap1 = new Bitmap(panel2.Width, panel2.Height);
            bitmap2 = new Bitmap(panel2.Width, panel2.Height);
            paint = false;
        }

        private void PizzaBuilder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //empty
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //empty
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //empty
        }

        public void update()
        {
            double d = p.getPrice();
            //double d2 = cif.getPrice();
            //double total = d + d2;
            label14.Text = d.ToString("#.00");
        }

        public void showPrices()
        {
            double currPrice;

            sr = File.OpenText("Sauce.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Sauce.createInstance(currPrice);
            label15.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Pepperoni.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Pepperoni.createInstance(currPrice);
            label16.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Mushrooms.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Mushrooms.createInstance(currPrice);
            label17.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Olives.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Olives.createInstance(currPrice);
            label18.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Cheese.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Sauce.createInstance(currPrice);
            label19.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Peppers.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Peppers.createInstance(currPrice);
            label20.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Spinach.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Spinach.createInstance(currPrice);
            label21.Text = toppings.getPrice().ToString();

            sr = File.OpenText("Bacon.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            toppings = Bacon.createInstance(currPrice);
            label22.Text = toppings.getPrice().ToString();

            sr = File.OpenText("ThinCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustThin.createInstance(currPrice);
            label30.Text = currPrice.ToString();

            sr = File.OpenText("PanCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustPan.createInstance(currPrice);
            label29.Text = currPrice.ToString();

            sr = File.OpenText("StuffedCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustStuffed.createInstance(currPrice);
            label28.Text = currPrice.ToString();

            sr = File.OpenText("FlatbreadCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustFlat.createInstance(currPrice);  
            label27.Text = currPrice.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        //Adds total price of crust and all toppings together
        private void button2_Click(object sender, EventArgs e)
        {
            p = new PizzaWrapper(p, cif);
            label14.Text = p.getPrice().ToString("#.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = new Pizza();
            bitmap1.Dispose();
            label14.Text = "0";
            bitmap1 = new Bitmap(panel2.Width, panel2.Height);
            //make everything visible on screen
            this.panel2.BackgroundImage = this.bitmap1;
            panel2.BackgroundImageLayout = ImageLayout.None;
        }

        private void drawImage(Image img, int x, int y)
        {
            Bitmap temp = new Bitmap(bitmap1);

            using (Graphics g = Graphics.FromImage(temp))
            {
                g.DrawImage(img, x, y);
            }

            bitmap2.Dispose();
            bitmap2 = new Bitmap(temp);
            this.panel2.BackgroundImage = this.bitmap2;
            temp.Dispose();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startX = e.X;
            startY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            String text;

            if (radioButton9.Checked)
            {
                text = "CrustThin";
                Image img = Image.FromFile("crust (1).png");
                drawImage(img, startX, startY);
                cif = CrustThin.createInstance();
                cif = cf.getCrustType(text, cif.getPrice());
            }
            else if (radioButton10.Checked)
            {
                text = "CrustPan";
                Image img = Image.FromFile("crust (1).png");
                drawImage(img, startX, startY);
                cif = CrustPan.createInstance();
                cif = cf.getCrustType(text, cif.getPrice());
            }
            else if (radioButton11.Checked)
            {
                text = "CrustStuffed";
                Image img = Image.FromFile("crust (1).png");
                drawImage(img, startX, startY);
                cif = CrustStuffed.createInstance();
                cif = cf.getCrustType(text, cif.getPrice());
            }
            else if (radioButton12.Checked)
            {
                text = "CrustFlat";
                Image img = Image.FromFile("crust (1).png");
                drawImage(img, startX, startY);
                cif = CrustFlat.createInstance();
                cif = cf.getCrustType(text, cif.getPrice());
            }
            else if (radioButton1.Checked)
            {
                Image img = Image.FromFile("sauce.png");
                drawImage(img, startX, startY);
                Sauce x = new Sauce();
                p.addToppings(x);
            }
            else if (radioButton2.Checked)
            {
                Image img = Image.FromFile("pepperoni (1).png");
                drawImage(img, startX, startY);
                Pepperoni x = new Pepperoni();
                p.addToppings(x);
            }
            else if (radioButton3.Checked)
            {
                Image img = Image.FromFile("mushroom.png");
                drawImage(img, startX, startY);
                Mushrooms x = new Mushrooms();
                p.addToppings(x);
            }
            else if (radioButton4.Checked)
            {
                Image img = Image.FromFile("olives.png");
                drawImage(img, startX, startY);
                Olives x = new Olives();
                p.addToppings(x);
            }
            else if (radioButton5.Checked)
            {
                Image img = Image.FromFile("cheese.png");
                drawImage(img, startX, startY);
                Cheese x = new Cheese();
                p.addToppings(x);
            }
            else if (radioButton6.Checked)
            {
                Image img = Image.FromFile("peppers.png");
                drawImage(img, startX, startY);
                Peppers x = new Peppers();
                p.addToppings(x);
            }
            else if (radioButton7.Checked)
            {
                Image img = Image.FromFile("spinach.png");
                drawImage(img, startX, startY);
                Spinach x = new Spinach();
                p.addToppings(x);
            }
            else if (radioButton8.Checked)
            {
                Image img = Image.FromFile("bacon.png");
                drawImage(img, startX, startY);
                Bacon x = new Bacon();
                p.addToppings(x);
            }

            p.observer(this);
            bitmap1 = new Bitmap(bitmap2);
            paint = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome w = new Welcome();
            w.Show();
            w.Activate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
