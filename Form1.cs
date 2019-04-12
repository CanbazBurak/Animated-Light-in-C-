using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animasyon_Yazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(label1.Text);
            a++;
            label1.Text = a.ToString();

            if (a==1)
                button1.BackColor = Color.Red;
            if(a==2)
            button2.BackColor = Color.Red;
            if(a==3)
            button3.BackColor = Color.Red;
            if(a==4)
            button4.BackColor = Color.Red;
            if(a==5)
            button5.BackColor = Color.Red;
            if(a==6)
                button10.BackColor = Color.Red;
            if(a==7)
                button15.BackColor = Color.Red;
            if(a==8)
                button20.BackColor = Color.Red;
            if(a==9)
                button25.BackColor = Color.Red;
            if(a==10)
                button24.BackColor = Color.Red;
            if(a==11)
                button23.BackColor = Color.Red;
            if(a==12)
                button22.BackColor = Color.Red;
            if(a==13)
                button21.BackColor = Color.Red;
            if(a==14)
                button16.BackColor = Color.Red;
            if(a==15)
                button11.BackColor = Color.Red;
            if(a==16)
                button6.BackColor = Color.Red;
            if(a==17)
                button7.BackColor = Color.Yellow;
            if(a==18)
                button8.BackColor = Color.Yellow;
            if(a==19)
                button9.BackColor = Color.Yellow;
            if(a==20)
                button14.BackColor = Color.Yellow;
            if(a==21)
                button19.BackColor = Color.Yellow;
            if(a==22)
                button18.BackColor = Color.Yellow;
            if(a==23)
                button17.BackColor = Color.Yellow;
            if(a==24)
                button12.BackColor = Color.Yellow;
            if (a == 25)
                pictureBox1.Visible = true;







        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
        }
    }
}
