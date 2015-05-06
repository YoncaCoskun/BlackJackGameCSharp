using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            

             if (count==1)
            {
                int a1, a2, sum;
                a1 = rnd.Next(1, 11);
                a2 = rnd.Next(1, 11);

                sum = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label12.Text = sum.ToString();

                
            }
             if (count == 2)
             {
                 int a3,sum;
                 a3 = rnd.Next(1, 11);
                 label3.Text = a3.ToString();

                 sum = Convert.ToInt32(label1.Text)+Convert.ToInt32(label2.Text)+a3;
                 label12.Text = sum.ToString();

             }
            else if (count==3)
            {
                int a4, sum;
                a4 = rnd.Next(1,11);
                label4.Text = a4.ToString();

                sum = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label12.Text = sum.ToString();

            }
             if (label1.Text=="1")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
             }
             if (label1.Text == "2")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
             }
             if (label1.Text == "3")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
             }
             if (label1.Text == "4")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
             }
             if (label1.Text == "5")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
             }
             if (label1.Text == "6")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
             }
             if (label1.Text == "7")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
             }
             if (label1.Text == "8")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
             }
             if (label1.Text == "9")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
             }
             if (label1.Text == "10")
             {
                 pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-10.gif";
             }


             if (label2.Text=="1")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
             }
             if (label2.Text == "2")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
             }
             if (label2.Text == "3")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
             }
             if (label2.Text == "4")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
             }
             if (label2.Text == "5")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
             }
             if (label2.Text == "6")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
             }
             if (label2.Text == "7")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
             }
             if (label2.Text == "8")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
             }
             if (label2.Text == "9")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
             }
             if (label2.Text == "10")
             {
                 pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-vale.gif";
             }


             if (label3.Text == "1")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
             }
             if (label3.Text == "2")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
             }
             if (label3.Text == "3")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
             }
             if (label3.Text == "4")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
             }
             if (label3.Text == "5")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
             }
             if (label3.Text == "6")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
             }
             if (label3.Text == "7")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
             }
             if (label3.Text == "8")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
             }
             if (label3.Text == "9")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
             }
             if (label3.Text == "10")
             {
                 pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-kiz.gif";
             }


             if (label4.Text == "1")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
             }
             if (label4.Text == "2")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
             }
             if (label4.Text == "3")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
             }
             if (label4.Text == "4")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
             }
             if (label4.Text == "5")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
             }
             if (label4.Text == "6")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
             }
             if (label4.Text == "7")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
             }
             if (label4.Text == "8")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
             }
             if (label4.Text == "9")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
             }
             if (label4.Text == "10")
             {
                 pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-papaz.gif";
             }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, sum;
            b1 = rnd.Next(1,11);
            b2 = rnd.Next(1,11);
            sum = b1 + b2;

            label10.Text = b1.ToString();
            label9.Text = b2.ToString();
            label13.Text = sum.ToString();


            if (sum<16)
            {
                int b3;
                b3 = rnd.Next(1,11);
                label8.Text = b3.ToString();
                sum = sum + b3;
                label13.Text = sum.ToString();

            }
            if (sum<16)
            {
                int b4;
                b4 = rnd.Next(1,11);
                label7.Text = b4.ToString();
                sum = sum + b4;
                label13.Text = sum.ToString();
            }


            if (label10.Text == "1")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
            }
            if (label10.Text == "2")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
            }
            if (label10.Text == "3")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
            }
            if (label10.Text == "4")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
            }
            if (label10.Text == "5")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
            }
            if (label10.Text == "6")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
            }
            if (label10.Text == "7")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
            }
            if (label10.Text == "8")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
            }
            if (label10.Text == "9")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
            }
            if (label10.Text == "10")
            {
                pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-papaz.gif";
            }

            if (label9.Text == "1")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
            }
            if (label9.Text == "2")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
            }
            if (label9.Text == "3")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
            }
            if (label9.Text == "4")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
            }
            if (label9.Text == "5")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
            }
            if (label9.Text == "6")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
            }
            if (label9.Text == "7")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
            }
            if (label9.Text == "8")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
            }
            if (label9.Text == "9")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
            }
            if (label9.Text == "10")
            {
                pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-10.gif";
            }

            if (label8.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-kiz.gif";
            }


            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif";
            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif";
            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sinek-vale.gif";
            }
            
        }
        int playerScore = 0;
        int PCScore = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int playerSum, PCSum;
            playerSum = Convert.ToInt32(label12.Text);
            PCSum = Convert.ToInt32(label13.Text);

            if (playerSum > PCSum  && playerSum <= 21)
            {
                playerScore = playerScore + 10;
                label20.Text = playerScore.ToString();
            }
            if (PCScore >playerScore && PCScore <= 21)
            {
                PCScore = PCScore + 10;
                label21.Text = PCScore.ToString();

            }
          
            if (PCScore==playerScore && PCScore <= 21 &&playerScore <= 21)
            {
                PCScore = PCScore + 10;
                playerScore = playerScore + 10;

                label20.Text = playerScore.ToString();
                label21.Text = PCScore.ToString();
            }
            if (playerScore==50)
            {
                MessageBox.Show("You are Winner!!!");
            }
            if (PCScore == 50)
            {
                MessageBox.Show("You are Lost,Sorry!!!");
            }
            if (PCScore <=21 && playerScore >21)
            {
                PCScore = PCScore + 10;
                label21.Text = PCScore.ToString();
            }
            if (playerScore <=21 && PCScore >21)
            {
                playerScore = playerScore + 10;
                label20.Text = playerScore.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label12.Text = "0";
            label13.Text = "0";

            button3.Enabled = true;
            button4.Enabled = false;

            pictureBox3.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox4.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox5.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox6.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox10.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox9.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox8.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
            pictureBox7.ImageLocation = "C:\\Users\\Yonca\\Desktop\\card\\sirt.gif";
           
        }

      

     
    }
}
