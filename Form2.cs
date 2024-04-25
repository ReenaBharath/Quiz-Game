using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzzGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random a1 = new Random();
            int ran1 = a1.Next(1, 5);
            if (ran1 == 1)
            {
                textBox1.Text = "What type of food is spaghetti?";//1
                button1.Text = "A) Pasta";
                button2.Text = "B) Bread";
                button3.Text = "C) Cheese";
                button4.Text = "D) Salad";
            }
            else if (ran1 == 2)
            {
                textBox1.Text = "What is the name of the preserved bodies of ancient Egypt?";//2
                button1.Text = "A) Mummies";
                button2.Text = "B) Aunties";
                button3.Text = "C) Daddies";
                button4.Text = "D) Grannies";
            }

            else if (ran1 == 3)
            {
                textBox1.Text = "The fictional character Tarzan is said to be LORD of which environment?";//3
                button1.Text = "A) The Jungle";
                button2.Text = "B) The Skies";
                button3.Text = "C) The Desert";
                button4.Text = "D) The Sea";
            }

            else if (ran1 == 4)
            {
                textBox1.Text = "Five interlocking rings is the well-know logo of which international event";//4
                button1.Text = "Oympic Games";
                button2.Text = "Miss World";
                button3.Text = "Tour de France";
                button4.Text = "FIFA World Cup";
            }
        }
        public static int score = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What type of food is spaghetti?" || textBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || textBox1.Text
                == "The fictional character Tarzan is said to be LORD of which environment?" || textBox1.Text == "Five interlocking rings is the well-know logo of which international event")
            {
                Random a2 = new Random();
                int ran2 = a2.Next(1, 3);

                if (ran2 == 1)
                {
                    score = 1000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?";//C; //5
                    button1.Text = "A) Sid";
                    button2.Text = "B) Bob";
                    button3.Text = "C) Andy";
                    button4.Text = "D) Alex";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }

                else if (ran2 == 2)
                {
                    score = 1000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What is the scientific study of plant life called?"; //C //6
                    button1.Text = "A) Meteorology";
                    button2.Text = "B) Nuclear Physic";
                    button3.Text = "C) Botany";
                    button4.Text = "D) Chemistry";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }
            }

            else if (textBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || textBox1.Text == "What does TYING THE KNOT mean for a couple?")
            {

                score = 5000;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "What is the full name of the rest of Cristiano Ronaldo…..?";//D //7
                button1.Text = "A) Romario Balotelli";
                button2.Text = "B) Santos Romario";
                button3.Text = "C) Dos Anka Sergio";
                button4.Text = "D) Dos Santo Aveiro";
                label4.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "Who is Peter Pan’s enemy?")

            {

                score = 20000;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "What came down and washed the spider away?"; //B //8
                button1.Text = "A) Slush";
                button2.Text = "B) Rain";
                button3.Text = "C) Snow";
                button4.Text = "D) Wind";
                label6.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets")
            {

                score = 5000000;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "What color is normally associated with hot temperature?";//B //9
                button1.Text = "A) Yellow";
                button2.Text = "B) White";
                button3.Text = "C) Red";
                button4.Text = "D) Blue";
                label14.BackColor = System.Drawing.Color.Indigo;
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || textBox1.Text == "What is the fear of confined spaces called?")
            {
                Random a3 = new Random();
                int ran3 = a3.Next(1, 3);
                if (ran3 == 1)
                {

                    score = 3000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What name is given to a golfer’s assistant who carries the clubs?"; //A //10
                    button1.Text = "A) Caddie";
                    button2.Text = "B) Gopher";
                    button3.Text = "C) Sherpa";
                    button4.Text = "D) Donkey";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran3 == 2)
                {

                    score = 3000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What does TYING THE KNOT mean for a couple?";//A //11
                    button1.Text = "Marriage";
                    button2.Text = "Buying a House";
                    button3.Text = "Buying Shoes";
                    button4.Text = "Kissing";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }

            }

            else if (textBox1.Text == "What came down and washed the spider away?")
            {

                score = 40000;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Which of these is a mineral?";//C //12
                button1.Text = "A) Vinegar";
                button2.Text = "B) Mustard";
                button3.Text = "C) Salt";
                button4.Text = "D) Pepper";
                label7.BackColor = System.Drawing.Color.Indigo;

            }

            else if (textBox1.Text == "How many sides doses pentagon have?")
            {

                score = 320000;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Which of the following plays CDs?";//C //13
                button1.Text = "A) Record play";
                button2.Text = "B) 8 Track play";
                button3.Text = "C) CD plays";
                button4.Text = "D) Tape play";
                label10.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "Who wrote ‘The Merry Wives of Windsor’s ?")

            {

                score = 2500000;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "At Which restaurant would you be able to order Chicken MacNuggets";//A //14
                button1.Text = "A) McDonald's";
                button2.Text = "B) Wendy's";
                button3.Text = "C) Taco Bell";
                button4.Text = "D) Burger King";
                label13.BackColor = System.Drawing.Color.Indigo;
            }

            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?" || textBox1.Text == "What is the scientific study of plant life called?")
            {
                Random a4 = new Random();
                int ran4 = a4.Next(1, 3);
                if (ran4 == 1)
                {

                    score = 2000;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "With which form of transport is the name Harley Davidson particularly associated?";//B //15
                    button1.Text = "A) Powerboat";
                    button2.Text = "B) Motorcycle";
                    button3.Text = "C) Jeep";
                    button4.Text = "D) Helicopter";
                    label2.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran4 == 2)
                {

                    score = 2000;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "What is the fear of confined spaces called?";//B //16
                    button1.Text = "A) Euphobia";
                    button2.Text = "B) Claustropobia";
                    button3.Text = "C) Acrophobia";
                    button4.Text = "D) Bibliophobia";
                    label2.BackColor = System.Drawing.Color.Indigo;

                }
            }
            else if (textBox1.Text == "Which of these is a mineral?")
            {

                score = 80000;
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "Which medical conditions caused by the lack of insulin produced by the pancreas?";//C //17
                button1.Text = "A) Cancer of the pancreas";
                button2.Text = "B) Glaucoma";
                button3.Text = "C) High Blood Pressure";
                button4.Text = "D) Diabetes";
                label8.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "Which of the following plays CDs?")/////////////
            {
                //clap.Play();
                score = 625000;
                button2.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Of the following, which is not a dog breed?";//D //18
                button1.Text = "A) Labrador Retriever";
                button2.Text = "B) Cocker Spaniel";
                button3.Text = "C) German Shepherd";
                button4.Text = "D) American Bobtail";
                label11.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "What color is normally associated with hot temperature?")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?")
            {

                score = 10000;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Who is Peter Pan’s enemy?";//A //19
                button1.Text = "A) Captain Hook";
                button2.Text = "B) Shark";
                button3.Text = "C) Tinker Bell";
                button4.Text = "D) Poison";
                label5.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "Which medical conditions caused by the lack of insulin produced by the pancreas?")
            {
                //clap.Play();
                score = 160000;
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "How many sides doses pentagon have?";//B //20
                button1.Text = "A) 4";
                button2.Text = "B) 5";
                button3.Text = "C) 6";
                button4.Text = "D) 3";

                label9.BackColor = System.Drawing.Color.Indigo;

            }
            else if (textBox1.Text == "Of the following, which is not a dog breed?")
            {
                //clap.Play();
                score = 1250000;
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "Who wrote ‘The Merry Wives of Windsor’s ?";//B //21
                button1.Text = "A) Hemingway";
                button2.Text = "B) Shakespeare";
                button3.Text = "C) Wilde";
                button4.Text = "D) Swift";
                label12.BackColor = System.Drawing.Color.Indigo;
            }

            else
            {
                Form f4 = new Form4();
                f4.Show();
                this.Hide();
                //player.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (textBox1.Text == "What type of food is spaghetti?" || textBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || textBox1.Text
                   == "The fictional character Tarzan is said to be LORD of which environment?" || textBox1.Text == "Five interlocking rings is the well-know logo of which international event")
                {
                    button3.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                if (textBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || textBox1.Text == "What does TYING THE KNOT mean for a couple?")
                {
                    button3.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                if (textBox1.Text == "Who is Peter Pan’s enemy?")
                {
                    button3.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                if (textBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets") 
                {
                    button2.Text = "";
                    button3.Text = "";
                    checkBox2.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;

                }

                if (textBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || textBox1.Text == "What is the fear of confined spaces called?")
                {
                    button3.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                if (textBox1.Text == "What came down and washed the spider away?")
                {
                    button3.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
                if (textBox1.Text == "Which medical conditions caused by the lack of insulin produced by the pancreas?")
                {
                    button1.Text = "";
                    button2.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                if (textBox1.Text == "Who wrote ‘The Merry Wives of Windsor’s ?")
                {
                    button1.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button4.Enabled = false;
                }
                if (textBox1.Text == "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?" || textBox1.Text == "What is the scientific study of plant life called?")
                {
                    button2.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
                if (textBox1.Text == "Which of these is a mineral?")
                {
                    button2.Text = "";
                    button4.Text = "";
                    checkBox2.Enabled = true;
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
                if (textBox1.Text == "Which of the following plays CDs?")
                {
                    button1.Text = "";
                    button2.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                if (textBox1.Text == "What color is normally associated with hot temperature?")
                {
                    button1.Text = "";
                    button2.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                if (textBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?")
                {
                    button3.Text = "";
                    button1.Text = "";
                    checkBox2.Enabled = false;
                    button3.Enabled = false;
                    button1.Enabled = false;
                }

                if (textBox1.Text == "How many sides doses pentagon have?")
                {
                    button1.Text = "";
                    button3.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button3.Enabled = false;
                }
                if (textBox1.Text == "Of the following, which is not a dog breed?")
                {
                    button1.Text = "";
                    button3.Text = "";
                    checkBox2.Enabled = false;
                    button1.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox1.Text == "What type of food is spaghetti?" || textBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || textBox1.Text
                   == "The fictional character Tarzan is said to be LORD of which environment?" || textBox1.Text == "Five interlocking rings is the well-know logo of which international event")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox1.Enabled = false;
                }


                if (textBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || textBox1.Text == "What does TYING THE KNOT mean for a couple?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox1.Enabled = false;
                }

                if (textBox1.Text == "Who is Peter Pan’s enemy?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox1.Enabled = false;

                }

                if (textBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox1.Enabled = false;
                }

                if (textBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || textBox1.Text == "What is the fear of confined spaces called?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "Which of these is a mineral?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "Which of the following plays CDs?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "What color is normally associated with hot temperature?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "How many sides doses pentagon have?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox1.Enabled = false;
                }
                if (textBox1.Text == "Of the following, which is not a dog breed?") {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox1.Enabled = false;
                }


            }

        }
    }
}