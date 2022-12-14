using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace WindowsFormsRakendused
{
    public partial class Form2 : Form
    {
        TableLayoutPanel tableLayoutPanel1;
        Timer timer;
        Label timeLabel;
        Button startButton, calc;
        OpenFileDialog openFileDialog;

        NumericUpDown[] vastused = new NumericUpDown[4];

        int[] num1 = new int[4];
        int[] num2 = new int[4];
        string[] tehed = new string[4] { "+", "-", "/", "*" };
        string text;
        public Form2()
        {

            this.Text = "Matemaatika test";
            this.ClientSize = new Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = true;

            Random rnd = new Random();

            tableLayoutPanel1 = new TableLayoutPanel
            {
                ColumnCount = 6,
                Location = new Point(0, 150),
                Size = new Size(500, 250),
                Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                BackColor = Color.CornflowerBlue,
            };

            timeLabel = new Label
            {
                Location = new Point(200, 0),
                AutoSize = false,
                Size = new Size(200, 30),
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                Text = "Timer:",
            };

            startButton = new Button
            {
                Text = "Kontrolli",
                Location = new Point(400, 0),
            };
            startButton.Click += startButton_Click;

            calc = new Button
            {
                Text = "Kalkulaator",
                Location= new Point(0, 0)
            };
            calc.Click += Calc_Click;

            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    if (j == 0)
                    {
                        if ((tehed[i] == "/" || tehed[i] == "*") && j == 2)
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
                    else if (j == 2)
                    {
                        if ((tehed[i] == "/" || tehed[i] == "*") && j == 2)
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
                    else if (j == 3)
                    {
                        text = "=";
                    }
                    else if (j == 4)
                    {
                        vastused[i] = new NumericUpDown
                        {
                            Name = tehed[i],
                            Minimum = -20,
                            Maximum = 200,
                            Size = new Size(100, 50),
                            Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                        };
                        tableLayoutPanel1.Controls.Add(vastused[i], j, i);
                    }
                    Label l = new Label
                    {
                        AutoSize = false,
                        Size = new Size(60, 50),
                        Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = text,
                        BackColor = Color.CornflowerBlue,
                    };
                    tableLayoutPanel1.Controls.Add(l, j, i);                    
                }
            }

            timer = new Timer { Interval = 750 };
            timer.Tick += timer_Tick;
            timer.Start();

            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(startButton);
            this.Controls.Add(timeLabel);
            this.Controls.Add(calc);
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        bool CheckTheAnswer() // vastuste kontroll
        {
            if ((num1[0] + num2[0] == vastused[0].Value)
                && (num1[1] - num2[1] == vastused[1].Value)
                && (num1[2] / num2[2] == vastused[2].Value)
                && (num1[3] * num2[3] == vastused[3].Value))
                return true;
            else
                return false;
        }
        int tik = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            tik++;
            timeLabel.Text = "Timer: " + (100 - tik).ToString();
            if (100 - tik == 0)
            {
                timer.Stop();
                MessageBox.Show("Taim on läbi!");
                Application.Restart();
            }
        }
        void startButton_Click(object sender, EventArgs e) //vastuste kontroll
        {
            if (CheckTheAnswer()) // kui vastused on õiged
            {
                timer.Stop();
                MessageBox.Show("Kõik vastused on õiged!\nPalju õnne!");
                startButton.Enabled = true;
                Application.Restart();
            }
            else // kui vastused ei ole õiged vastuste lahtristesse kirjutatakse õiged vastused
            {
                timer.Stop();
                MessageBox.Show("Kõik vastused ei ole õiged!\nVaata õiged vastused!");
                vastused[0].Value = num1[0] + num2[0];
                vastused[1].Value = num1[1] - num2[1];
                vastused[2].Value = num1[2] / num2[2];
                vastused[3].Value = num1[3] * num2[3];
                startButton.Enabled = true;
            }
        }
    }
}
