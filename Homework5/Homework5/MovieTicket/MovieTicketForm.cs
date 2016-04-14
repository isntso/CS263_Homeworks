using DiscountLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class MovieTicketForm : Form
    {
        private List<Discount> discounts;
        private double totalPrice;

        public MovieTicketForm()
        {
            InitializeComponent();
            discounts = new List<Discount>();

            foreach (string s in ConfigurationManager.AppSettings.AllKeys)
            {
                Discount discount = (Discount)Activator.CreateInstance(Type.GetType("DiscountLibrary." + s +
                    ", DiscountLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
                discounts.Add(discount);
                ticketCatagory.Items.Add(discount);
            }

            ticketCatagory.SelectedIndex = 0;
            totalPrice = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MovieTicket movieTicket = new MovieTicket();
            double originalPrice = movieTicket.Price;
            movieTicket.SetDiscount(discounts[ticketCatagory.SelectedIndex]);
            infoRichTextBox.Text = infoRichTextBox.Text.Substring(0, infoRichTextBox.Text.LastIndexOf("總計") == -1 ? 0 : infoRichTextBox.Text.LastIndexOf("總計"));
            infoRichTextBox.Text += string.Format("原價{0}, {1}{2}, 共{3}張 小計:{4}\n總計:{5}", originalPrice, discounts[ticketCatagory.SelectedIndex],
                movieTicket.Price, sheetTextBox.Text, movieTicket.Price * int.Parse(sheetTextBox.Text), totalPrice += movieTicket.Price * int.Parse(sheetTextBox.Text));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            infoRichTextBox.Text = string.Empty;
            totalPrice = 0;
            ticketCatagory.SelectedIndex = 0;
            sheetTextBox.Text = "1";
        }
    }
}