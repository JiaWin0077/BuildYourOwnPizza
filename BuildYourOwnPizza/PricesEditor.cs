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
    public partial class PricesEditor : Form
    {
        CrustFactory cf;
        Pizza p;
        CrustIF cif;
        StreamWriter sw;
        StreamReader sr;
        ToppingsAbs ta;
        public PricesEditor()
        {
            InitializeComponent();
            cf = new CrustFactory();
        }

        private void PricesEditor_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            String text;

            switch (index)
            {
                case 0:
                    text = "CrustThin";
                    cif = CrustThin.createInstance();
                    cif = cf.getCrustType(text, cif.getPrice());
                    label3.Text = cif.getPrice().ToString();
                    break;
                case 1:
                    text = "CrustPan";
                    cif = CrustPan.createInstance();
                    cif = cf.getCrustType(text, cif.getPrice());
                    label3.Text = cif.getPrice().ToString();
                    break;
                case 2:
                    text = "CrustStuffed";
                    cif = CrustPan.createInstance();
                    cif = cf.getCrustType(text, cif.getPrice());
                    label3.Text = cif.getPrice().ToString();
                    break;
                case 3:
                    text = "CrustFlat";
                    cif = CrustPan.createInstance();
                    cif = cf.getCrustType(text, cif.getPrice());
                    label3.Text = cif.getPrice().ToString();
                    break;
                case 4:
                    ta = Sauce.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 5:
                    ta = Pepperoni.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 6:
                    ta = Mushrooms.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 7:
                    ta = Olives.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 8:
                    ta = Cheese.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 9:
                    ta = Peppers.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 10:
                    ta = Spinach.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
                case 11:
                    ta = Bacon.createInstance();
                    label3.Text = ta.getPrice().ToString();
                    break;
            }
        }

        public void showPrices()
        {
            double currPrice;

            sr = File.OpenText("Sauce.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Sauce.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Pepperoni.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Pepperoni.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Mushrooms.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Mushrooms.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Olives.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Olives.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Cheese.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Sauce.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Peppers.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Peppers.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Spinach.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Spinach.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("Bacon.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            ta = Bacon.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("ThinCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustThin.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("PanCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustPan.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("StuffedCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustStuffed.createInstance(currPrice);
            sr.Close();
            sr = File.OpenText("FlatbreadCrust.txt");
            currPrice = Convert.ToDouble(sr.ReadLine());
            cif = CrustFlat.createInstance(currPrice);
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = showDialog("Enter new price:", "Update Prices");
            label3.Text = price.ToString();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    sw = File.CreateText("ThinCrust.txt");
                    sw.WriteLine(price);
                    break;
                case 1:
                    sw = File.CreateText("PanCrust.txt");
                    sw.WriteLine(price);
                    break;
                case 2:
                    sw = File.CreateText("StuffedCrust.txt");
                    sw.WriteLine(price);
                    break;
                case 3:
                    sw = File.CreateText("FlatbreadCrust.txt");
                    sw.WriteLine(price);
                    break;
                case 4:
                    sw = File.CreateText("Sauce.txt");
                    sw.WriteLine(price);
                    break;
                case 5:
                    sw = File.CreateText("Pepperoni.txt");
                    sw.WriteLine(price);
                    break;
                case 6:
                    sw = File.CreateText("Mushrooms.txt");
                    sw.WriteLine(price);
                    break;
                case 7:
                    sw = File.CreateText("Olives.txt");
                    sw.WriteLine(price);
                    break;
                case 8:
                    sw = File.CreateText("Cheese.txt");
                    sw.WriteLine(price);
                    break;
                case 9:
                    sw = File.CreateText("Peppers.txt");
                    sw.WriteLine(price);
                    break;
                case 10:
                    sw = File.CreateText("Spinach.txt");
                    sw.WriteLine(price);
                    break;
                case 11:
                    sw = File.CreateText("Bacon.txt");
                    sw.WriteLine(price);
                    break;

            }
            sw.Close();
        }

        public static double showDialog(string text, string title)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 200;
            prompt.Text = title;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            if (textBox.Text == "")
            {
                return 0;
            }
            return Convert.ToDouble(textBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
