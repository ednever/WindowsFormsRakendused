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
using System.IO;

namespace WindowsFormsRakendused
{
    public partial class Form3 : Form
    {        
        TableLayoutPanel tableLayoutPanel1;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        Label firstClicked, secondClicked = null;
        Label timerLabel;
        Timer timer;
        TextBox textBox;


        public Form3()
        {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(550, 530);
            this.Text = "Sobivus mäng";

            tableLayoutPanel1 = new TableLayoutPanel
            {
                Location = new Point(0, 30),
                Size = new Size(550, 500),
                Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                BackColor = Color.CornflowerBlue,                
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                AutoSize = false,                
            };

            timerLabel = new Label
            {
                Location = new Point(225, 0),
                Size = new Size(100, 30),
                Text = "Katsed: "
            };

            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int j = 0; j < 4; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    Label l = new Label 
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter, 
                        Font = new Font("Webdings", 48, FontStyle.Bold),
                    };
                    tableLayoutPanel1.Controls.Add(l, j, i);
                    l.Click += label_Click;
                }
            }            
            timer = new Timer { Interval = 750 };
            timer.Tick += timer_Tick;
            maaraIkoonidRuutudesse();
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(timerLabel);            
        }

        void maaraIkoonidRuutudesse()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        int tok = 0;
        void label_Click(object sender, EventArgs e)
        {
            tok++;
            if (tok == 100)
            {
                MessageBox.Show("Salajane saavutus!");
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
            if (timer.Enabled == true) 
                return;
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                voiduKontroll();
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }                
                timer.Start();
            }
        }
        int tik = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            tik++;
            timer.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
            timerLabel.Text = "Katsed: " + (10 - tik).ToString();
            //if (tik >= 10)
            //{
            //    MessageBox.Show("Sa kasutasid kõiki katset!", "GAME OVER");
            //    Application.Restart();
            //}
        }
        void voiduKontroll()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Sa otsisid välja kõik ikoonid", "Palju õnne! ");
            textBox = new TextBox
            {
                Location = new Point(0, 0),
            };
            this.Controls.Add(textBox);
            textBox.DoubleClick += TextBox_DoubleClick;
            //Application.Restart();
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            textBox.Enabled = false;
            string text = textBox.Text;

            using (StreamWriter from_file = new StreamWriter(@"..\..\..\Voitjad.txt"))
            {
                if (text != null)
                {
                    from_file.WriteLine(text + ", " + tik.ToString() + ";");
                }
            }
        }
    }
}
