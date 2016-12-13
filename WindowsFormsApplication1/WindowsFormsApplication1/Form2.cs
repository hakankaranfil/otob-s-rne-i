using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string isimsoyisim;
        

       
        private void kaydetbtn_Click(object sender, EventArgs e)
        {
           
        isimsoyisim = textBox1.Text;
            listBox1.Items.Add(isimsoyisim);
            this.Hide();
            
           
            
        }
    }
}
