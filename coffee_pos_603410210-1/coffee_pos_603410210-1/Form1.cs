using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410210_1
{
    public partial class Form1 : Form
    {
        String sa1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kan("Latte)(Hot)", "35");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            kan("Milo)(Ice)", "25");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        public void kan(String Menu, String Baht)
        {
            String[] kun = { Menu, Baht };
            var kin = new ListViewItem(kun);
            listView1.Items.Add(kin);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        bool ok = false;
        private void button46_Click(object sender, EventArgs e)
        {
            ttb1.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;
            }
            else
                tabControl1.SelectedTab = Payment;
            if (listView1.Items.Count > 0) sef();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kan("Esspresso)(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kan("Americano)(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kan("Esspresso)(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kan("Esspresso)(Frappe)", "50");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kan("Americano)(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kan("Latte)(Ice)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kan("Latte)(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kan("Mocha)(Hot)", "35");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kan("ThaiTea)(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kan("Greentea)(Hot)", "20");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kan("Mocha)(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kan("Mocha)(Frappe)", "50");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            kan("Cappuccino)(Hot)", "35");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            kan("Cappuccino)(Ice)", "45");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kan("Cappuccino)(Frappe)", "50");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            kan("Greentea)(Ice)", "25");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kan("Greentea)(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            kan("ThaiTea)(Hot)", "20");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kan("ThaiTea)(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kan("CoCoa)(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kan("CoCoa)(Ice)", "25");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kan("CoCoa)(Frappe)", "30");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            kan("Milk)(Hot)", "20");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            kan("Milk)(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            kan("Milk)(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            kan("MilkTea)(Ice)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            kan("MilkTea)(Frappe)", "30");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            kan("LemonTea)(Ice)", "25");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            kan("LemonTea)(Frappe)", "30");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            kan("Milo)(Hot)", "20");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            kan("Milo)(Frappe)", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            kan("Nescafe)(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            kan("Nescafe)(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            kan("Nescafe)(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            kan("NesteaTea)(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            kan("NesteaTea)(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            kan("NesteaTea)(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            kan("Italian Soda)(Ice)", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            kan("Red lime Soda)(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            kan("Honey lime Soda)(Ice)", "25");
        }

        double na;
        public String[] ListPrice()
        {
            na = 0;
            String[] a = new string[listView1.Items.Count];
            int kb = listView1.Items.Count;
            for (int i = 0; i < kb; i++)
            {
                na += double.Parse(listView1.Items[i].SubItems[1].Text);
                a[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label25.Text = na.ToString();
            return a;
        }
        public String[] inListPrice()
        {
            String[] C = new string[listView1.Items.Count];
            int k = listView1.Items.Count;
            for (int i = 0; i < na; i++)
            {
                C[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return C;
        }

        public void sef()
        {
            string[] su = ListPrice();
            string[] no = ListPrice();
            string file1 = "Coffee Shop" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill = "Coffee Shop";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n";
            filebill += Menu + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                filebill += su[i] + new string(' ', 20) + no[i] + "Bath" + "\r\n";
            }
            filebill += "\r\n";
            filebill += "Total Price : " + label25.Text;
            System.IO.File.WriteAllText(sa1 + @"\" + file1 + ".txt", filebill);
            ttb1.Text += filebill + "\r\n" + "\r\n" + "\r\n" + "Save Flie at" + sa1 + @"\" + file1 + ".txt";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            label25.Text = "";
            ttb1.Text = "";
        }
    }
}

        
        
    
        
         



        
        


    

      
        
