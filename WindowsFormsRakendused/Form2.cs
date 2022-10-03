using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRakendused
{
    public partial class Form2 : Form
    {
        TableLayoutPanel tableLayoutPanel1;
        Timer timer;
        Label timeLeft, timeLabel;
        Button startButton;
        NumericUpDown[] vastused = new NumericUpDown[4];
        string text;
        int[] num1 = new int[4];
        int[] num2 = new int[4];
        public Form2()
        {
            this.Text = "Math Quiz";
            this.Name = "Form2";
            this.ClientSize = new Size(800, 450);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            string[] tehed;
            Random rnd = new Random();
            Button startButton = new Button();
            

            tableLayoutPanel1 = new TableLayoutPanel
            {
                Name = "Timer",
                Location = new Point(100, 36),
                Size = new Size(1000, 1000),
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                BackColor = Color.Magenta,
            };
            timeLeft = new Label
            {
                Size = new Size(101, 25),
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                Location = new Point(165, 11),
                Text = "Time Left",                
            };

            startButton = new Button
            {

            };

            tehed = new string[4] { "+", "-", "/", "*" };
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    if (j == 0)
                    {
                        if ((tehed[i] == "/" || tehed[i] == "/") && j == 2)
                        {
                            text = rnd.Next(1, 10).ToString();
                            num1[i] = int.Parse(text);
                        }
                        else
                        {
                            text = rnd.Next(1, 20).ToString();
                            num1[i] = int.Parse(text);
                        }
                    }
                    else if (j == 1)
                    {
                        text = tehed[i];
                    }
                    else if (j == 3)
                    {
                        text = "=";
                    }
                    else if (j == 4)
                    {
                        vastused[i] = new NumericUpDown
                        {
                            Name = tehed[i],
                            DecimalPlaces = 1,
                            Minimum = -10,
                            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                        };
                        tableLayoutPanel1.Controls.Add(vastused[i], j, i);
                    }
                    else if (j == 2)
                    {
                        if ((tehed[i] == "/" || tehed[i] == "/") && j == 2)
                        {
                            text = rnd.Next(1, 10).ToString();
                            num2[i] = int.Parse(text);
                        }
                        else
                        {
                            text = rnd.Next(1, 20).ToString();
                            num2[i] = int.Parse(text);
                        }
                    }
                    Label l = new Label { Text = text };
                    tableLayoutPanel1.Controls.Add(l, j, i);
                }
            }

            timer = new Timer();
            timer.Start();
            timer.Tick += timer_Tick;

            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(timeLeft);
        }
        private bool CheckTheAnswer()
        {
            if ((num1[0] + num2[0] == vastused[0].Value) 
                && (num1[1] - num2[1] == vastused[1].Value) 
                && (num1[2] * num2[2] == vastused[2].Value)
                && (num1[3] / num2[3] == vastused[3].Value))
                return true;
            else
                return false;
        }
        int tik = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            tik++;
            timeLabel = new Label
            {
                Text = tik.ToString(),
                Size = new Size(101, 25),
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                //Location = new Point(266, 25),
                Location = new Point(0, 0),
            };
            this.Controls.Add(timeLabel);
            if (CheckTheAnswer())
            {
                timer.Stop();
                MessageBox.Show("Kõik vastused on õiged!\nPalju õnne!");
                //startButton.Enabled = true;
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                //vastused[0].Value = num1[0] + num2[0];
                //vastused[1].Value = num1[0] - num2[0];
                //vastused[2].Value = num1[0] * num2[0];
                //vastused[3].Value = num1[0] / num2[0];
                //startButton.Enabled = true;
            }
        }
    }
}
