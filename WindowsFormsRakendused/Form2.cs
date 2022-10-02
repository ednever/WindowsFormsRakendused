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
        Label timeLeft;
        //string l_nimed[,];
        public Form2()
        {
            this.Text = "Math Quiz";
            this.Name = "Form2";
            this.ClientSize = new Size(800, 450);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;


            tableLayoutPanel1 = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
            };
            timeLeft = new Label
            {
                Size = new Size(101, 25),
                Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                //Location = new Point(0, 0),
                Location = new Point(165, 11),
                Text = "Time Left",
            };


            //l_nimed = new string[5, 4];
            //for (int i = 0; i < 4; i++)
            //{
            //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Persent, 25F));
            //    for (int j = 0; j < 5; j++)
            //    {
            //        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Persent, 20F));
            //        var l_nimi = "L" + j.ToString(); + i.ToString();
            //        l_nimed[j, i] = l_nimi;
            //        if (j == 1)
            //        {
            //            text = tehed[i]; //tehed = new string[4] {"+","-","/","*"}
            //        }
            //        else if (j == 3)
            //        {
            //            text = "=";
            //        }
            //        else if (j == 4)
            //        {
            //            text = "vastus";
            //        }
            //        else
            //        {
            //            text = l_nimi;
            //        }
            //        Label l = new Label { Text = text };
            //        TableLayoutPanel.Controls.Add(l, j, i);
            //    }
            //}
            //this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(timeLeft);
        }
        //private bool CheckTheAnswer()
        //{
        //    if ((addend1 + addend2 == sum.Value)
        //        && (minuend - subtrahend == difference.Value)
        //        && (multiplicand * multiplier == product.Value)
        //        && (dividend / divisor == quotient.Value))
        //        return true;
        //    else
        //        return false;
        //}
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    if (CheckTheAnswer())
        //    {
        //        timer.Stop();
        //        MessageBox.Show("You got all the answers right!\nCongratulations!");
        //        startButton.Enabled = true;
        //    }
        //    else if (timeLeft > 0)
        //    {
        //        timeLeft = timeLeft - 1;
        //        timeLabel.Text = timeLeft + " seconds";
        //    }
        //    else
        //    {
        //        timer.Stop();
        //        timeLabel.Text = "Time's up!";
        //        MessageBox.Show("You didn't finish in time.", "Sorry!");
        //        sum.Value = addend1 + addend2;
        //        difference.Value = minuend - subtrahend;
        //        product.Value = multiplicand * multiplier;
        //        quotient.Value = dividend / divisor;
        //        startButton.Enabled = true;
        //    }
        //}
    }
}
