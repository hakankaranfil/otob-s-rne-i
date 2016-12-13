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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        
        
        

        Random rsg = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 11) && (i!=5|| j<2))
                    {
                        
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Width * i;

                        btn.Text = sayac.ToString();
                        btn.Click += Buttonclick;
                        btn.BackColor = Color.Blue;
                        


                        this.Controls.Add(btn);

                        sayac++;
                    }
                }
            }
        }

        public void Buttonclick(object sender, EventArgs e)
        {
          
          Button  sec = sender as Button;

            sec.BackColor = Color.Red;
            sec.Enabled = false;
            Form2 frm = new Form2();
frm.Show();
          
            
            
          
         
            }
        
        }
    
        }
        

