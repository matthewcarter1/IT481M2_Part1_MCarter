using IT481M2_Part1_MCarter.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481M2_Part1_MCarter
{
    public partial class Form1 : Form
    { 
        // create a new instance of the BusinessAccessLayer class
        BusinessAccessLayer bus = new BusinessAccessLayer() { };

        // the constructor initializes the form
        public Form1()
        {
            InitializeComponent();
        }

        // this event handler is called when the user clicks the first button
        private void button1_Click(object sender, EventArgs e)
        {
            // create a new instance of the BusinessAccessLayer class
            BusinessAccessLayer bus = new BusinessAccessLayer();

            // call the SelectClients() method on the BusinessAccessLayer instance
            // and set the text of the richTextBox1 control to the result
            richTextBox1.Text = bus.SelectClients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create a new instance of the BusinessAccessLayer class
            BusinessAccessLayer bus = new BusinessAccessLayer();

            // call the CountClients() method on the BusinessAccessLayer instance
            // and set the text of the richTextBox1 control to the result
            richTextBox1.Text = bus.CountClients();
        }
    }
}
