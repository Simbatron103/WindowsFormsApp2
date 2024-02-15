using Puzzle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Image[] imagesFirst = { Resources.A1, Resources.B1, Resources.C11, Resources.D1 };
        Image[] imagesSecond = { Resources.A2, Resources.B2, Resources.C21, Resources.D2 };
        Image[] imagesThird = { Resources.A3, Resources.B3, Resources.C31, Resources.D3 };
        Image[] imagesFourth = { Resources.A4, Resources.B4, Resources.C41, Resources.D4 };
        Image[] imagesFifth = { Resources.goofy_cat, Resources.cat_cat_side_eye, Resources.silly_cat, Resources.shocked_shocked_cat};
        Random random = new Random();   
        int first = 0;
        int second = 1;
        int third = 2;  
        int fourth = 3;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Detta gör så att first är till för pictureBox1 och second är till för pictureBox2 o.s.v sedan väljer programmet ett tal mellan 0, 3 som i detta fall är olika bilder som blir representerat av nummerna. 
            pictureBox1.Image = imagesFirst[first];
            pictureBox2.Image = imagesSecond[second];
            pictureBox3.Image = imagesThird[third];
            pictureBox4.Image = imagesFourth[fourth];
            first = random.Next(0, imagesFirst.Length);
            second = random.Next(0, imagesSecond.Length);
            third = random.Next(0, imagesThird.Length);
            fourth = random.Next(0, imagesFourth.Length);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*if (pictureBox1.Image == Resources.A1)
            {
                pictureBox1.Image = Resources.B1;
            }
            if (pictureBox1.Image == Resources.B1)
            {
                pictureBox1.Image = Resources.C11;
            }
            if (pictureBox1.Image == Resources.C11)
            {
                pictureBox1.Image = Resources.D1;
            }
            if (pictureBox1.Image == Resources.D1)
            {
                pictureBox1.Image = Resources.A1;
            }*/
            //first = first + 1 betyder att det är bildens nummer + 1 om någon klickar på pictureBoxen så den går till nästa bild om den inte är på största nummret för då går den tillbaka till 0.
           

            first = first + 1;

            if (first >= imagesFirst.Length)
            {
                first = 0;
            }

            pictureBox1.Image = imagesFirst[first];
             //Om first second third och fourth är lika kommer ett messagebox dycka upp som visar att alla är lika.
            if (first == second && second == third && third == fourth)
            {
                pictureBox5.Image = Resources.goofy_cat;
            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            second = second + 1;

            if (second >= imagesSecond.Length)
            {
                second = 0;
            }

            pictureBox2.Image = imagesSecond[second];
            if (first == second && second == third && third == fourth )
            {
                pictureBox5.Image = Resources.cat_cat_side_eye;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            third = third + 1;

            if (third >= imagesThird.Length)
            {
                third = 0;
            }

            pictureBox3.Image = imagesThird[third];
            if (first == second && second == third && third == fourth)
            {
                pictureBox5.Image = Resources.silly_cat;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            fourth = fourth + 1;

            if (fourth >= imagesFourth.Length)
            {
                fourth = 0;
            }

            pictureBox4.Image = imagesFourth[fourth];
            if (first == second && second == third && third == fourth)
            {
                pictureBox5.Image = Resources.shocked_shocked_cat;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
