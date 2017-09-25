using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace POS
{
    public partial class Form1 : Form
    {
        #region
        public Form1()
        {
            InitializeComponent();
        
            purchasedView.View = View.Details;
            purchasedView.GridLines = true;
            Class1 c = new Class1();
            itemView.View = View.Details;
            itemView.GridLines = true;
            listView1.View = View.Details;
            itemView.Columns.Add("Item Name",150);
            itemView.Columns.Add("Price",95);
            purchasedView.Columns.Add("Item Name",120);
            purchasedView.Columns.Add("Quantity",70);
            purchasedView.Columns.Add("Amount",120);
            listView1.Columns.Add("Trans. No.",80);
            listView1.Columns.Add("Item", 100);
            listView1.Columns.Add("Amount", 100);
            listView1.Columns.Add("Quantity",100);
            listView1.Columns.Add("Date", 250);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            item1.Focus();
            Class1 c = new Class1();
            c.gege();
            itemView.View = View.Details;
            MySqlDataAdapter ada = new MySqlDataAdapter("Select * from item", c.g);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem it = new ListViewItem(dr["name"].ToString());
                it.SubItems.Add(dr["price"].ToString());
                itemView.Items.Add(it);
            }
            listView1.View = View.Details;
            MySqlDataAdapter ho = new MySqlDataAdapter("select * from trans", c.g);
            DataTable efan = new DataTable();
            ho.Fill(efan);
            for (int i = 0; i < efan.Rows.Count; i++)
            {
                DataRow rowrow = efan.Rows[i];
                ListViewItem lvi = new ListViewItem(rowrow["trans_no"].ToString());
                lvi.SubItems.Add(rowrow["item"].ToString());
                lvi.SubItems.Add(rowrow["amt"].ToString());
                lvi.SubItems.Add(rowrow["qty"].ToString());
                lvi.SubItems.Add(rowrow["date"].ToString());
                listView1.Items.Add(lvi);
            }
            
        }

        private void add1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            
            try
            {
                
                if (item1.Text == string.Empty || price1.Text == "0")
                {
                    itemView.Items.Clear();
                    MessageBox.Show("Please Complete all the fields before you proceed");
                    
                    c.gege();
                    MySqlDataAdapter ada = new MySqlDataAdapter("Select * from item", c.g);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem it = new ListViewItem(dr["name"].ToString());
                        it.SubItems.Add(dr["price"].ToString());
                        itemView.Items.Add(it);
                    }
                }
                else
                {
                    itemView.Items.Clear();
                    c = new Class1();
                    c.gege();
                    c.cmd("Insert into item(name,price) values('" + item1.Text + "','" + price1.Text + "')");
                    MySqlDataAdapter ada = new MySqlDataAdapter("Select * from item", c.g);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem it = new ListViewItem(dr["name"].ToString());
                        it.SubItems.Add(dr["price"].ToString());
                        itemView.Items.Add(it);
                    }
                    price1.Text = "0";
                    item1.Clear();
                    item1.Focus();
                }
            }
    
            catch (Exception)
            {

                MessageBox.Show("Please Complete all the fields before you proceed");
            }
        
    

        }
            
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }




        private void price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)&&((sender as TextBox).Text.IndexOf('.') > -2) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void item2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(qty.Text) >= 1)
                {
                    amt.Text = (Convert.ToDouble(price2.Text) * Convert.ToDouble(qty.Text)).ToString();
                }
                else if(qty.Text == string.Empty)
                {
                    qty.Text = "0";
                }
                else if(qty.Text == "0")
                {
                    qty.Text = "0";
                }
              
            }
            catch (Exception)
            {

         
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ge in purchasedView.SelectedItems)
            {
                purchasedView.Items.Remove(ge);
                Double a = Convert.ToDouble(ge.SubItems[2].Text);
                st.Text = (Convert.ToDouble(st.Text) - a).ToString();
            }
            ctr.Text = purchasedView.Items.Count.ToString();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            string a ="" ;

            foreach (ListViewItem h in purchasedView.Items)
                {
                    if (h.SubItems[0].Text == item2.Text)
                    {
                        a = h.SubItems[0].Text;
                    }

                }

         
            if (item2.Text == string.Empty || qty.Text =="0")
            {
                MessageBox.Show("Please select product before you proceed/ Please input the correct value");
            }
            else if (a == item2.Text)
            {
                ListViewItem hoho = purchasedView.FindItemWithText(a);
                
                double a1 = Convert.ToDouble(hoho.SubItems[1].Text) + Convert.ToDouble(qty.Text);
                double b = Convert.ToDouble(hoho.SubItems[2].Text) + Convert.ToDouble(amt.Text);
                hoho.SubItems[1].Text = a1.ToString();
                hoho.SubItems[2].Text = b.ToString();
                double a4 = 0;
                foreach (ListViewItem he in purchasedView.Items)
                {
                    a4 += Convert.ToDouble(he.SubItems[1].Text);
                }
                ctr.Text = a4.ToString();
                double a6 = 0;
                foreach (ListViewItem ge in purchasedView.Items)
                {
                    a6 += Convert.ToDouble(ge.SubItems[2].Text);
                }
                st.Text = a6.ToString();
                item2.Clear();
                price2.Text = "0";
                qty.Text = "0";
                amt.Text = "0";
            }
            else
            {
                ListViewItem ge;
                string[] haha = new string[3];
                haha[0] = item2.Text;
                haha[1] = qty.Text;
                haha[2] = amt.Text;
                ge = new ListViewItem(haha);
                st.Text = (Convert.ToDouble(st.Text) + Convert.ToDouble(amt.Text)).ToString();
                purchasedView.Items.Add(ge);
                double a4 = 0;
                foreach (ListViewItem he in purchasedView.Items)
                {
                    a4 += Convert.ToDouble(he.SubItems[1].Text);
                }
                ctr.Text = a4.ToString();
                item2.Clear();
                price2.Text = "0";
                qty.Text = "0";
                amt.Text = "0";
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true)
            {
                double a = Convert.ToDouble(st.Text) * 0.08;
                double b = Convert.ToDouble(st.Text) - a;
                st.Text = b.ToString();
            }
            else if (checkBox1.Checked == false)
            {
                double a = 0;
                foreach (ListViewItem ge in purchasedView.Items)
                {
                    a += Convert.ToDouble(ge.SubItems[2].Text);
                }
                st.Text = a.ToString();
            }
        }

        private void cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(st.Text) < Convert.ToDouble(cash.Text))
                {
                    change.Text = (Convert.ToDouble(cash.Text) - Convert.ToDouble(st.Text)).ToString();
                }
        
                else if (st.Text.Length == cash.Text.Length)
                {
                    if (Convert.ToDouble(st.Text) > Convert.ToDouble(cash.Text))
                    {
                        MessageBox.Show("Please input the right amount.");
                        change.Text = "0";
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please input the right amount.");
                change.Text = "0";
            } 
           
            
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (st.Text == "0" || cash.Text == "0") 
            {
                MessageBox.Show("Please complete all your payment and orders");
            }
            else
            {
                label22.Text = st.Text;
                label23.Text = cash.Text;
                label24.Text = change.Text;
                label13.Text = "";
                label25.Text = "";
                label26.Text = "";
                flyoutPanel1.ShowPopup();
                flyoutPanel1.ShowBeakForm();
               
                foreach (ListViewItem ge in purchasedView.Items)
                {
                    
                    Class1 ew = new Class1();
                    ew.gege();
                    DateTime date = DateTime.Now;
                    string g = date.ToString("mm-dd-yy-hh:mm:ss");
                    var prod = listView1.Items;
                    string gg = prod[listView1.Items.Count - 1].Text;
                 
                    ew.cmd("insert into trans(trans_no,item,amt,qty,date) values('" + (Convert.ToInt32(gg) + 1).ToString() + " ','" + ge.SubItems[0].Text + "','" + ge.SubItems[2].Text + "','" + ge.SubItems[1].Text + "','" + g + "')");
                    label13.Text += ge.SubItems[0].Text + Environment.NewLine;
                    label25.Text += ge.SubItems[1].Text + Environment.NewLine;
                    label26.Text += ge.SubItems[2].Text + Environment.NewLine;
                    
                }
               
                item2.Clear();
                qty.Text = "0";
                price2.Text = "0";
                amt.Text = "0";
                st.Text = "0";
                change.Text = "0";
                cash.Text = "0";
                Class1 c = new Class1();
                listView1.Items.Clear();
                MySqlDataAdapter ho = new MySqlDataAdapter("select * from trans", c.g);
                DataTable efan = new DataTable();
                ho.Fill(efan);
                for (int i = 0; i < efan.Rows.Count; i++)
                {
                    DataRow rowrow = efan.Rows[i];
                    ListViewItem lvi = new ListViewItem(rowrow["trans_no"].ToString());
                    lvi.SubItems.Add(rowrow["item"].ToString());
                    lvi.SubItems.Add(rowrow["amt"].ToString());
                    lvi.SubItems.Add(rowrow["qty"].ToString());
                    lvi.SubItems.Add(rowrow["date"].ToString());
                    listView1.Items.Add(lvi);
                }
            
                purchasedView.Items.Clear();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flyoutPanel2.ShowBeakForm();
            flyoutPanel2.ShowPopup();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemView_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ge in itemView.SelectedItems)
            {
                item2.Text = ge.SubItems[0].Text;
                price2.Text = ge.SubItems[1].Text;
                amt.Text = ge.SubItems[1].Text;
            }
            qty.Text = "1";
            qty.Focus();
        }


    }
}
