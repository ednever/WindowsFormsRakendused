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
        Timer timer;
        public Form3()
        {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(550, 500);
            this.Text = "Sobivus mäng";           

            tableLayoutPanel1 = new TableLayoutPanel
            {
                Location = new Point(0, 0),
                Size = new Size(550, 500),
                Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186))),
                BackColor = Color.CornflowerBlue,                
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                AutoSize = false,
                
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
        void label_Click(object sender, EventArgs e)
        {
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
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
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
            MessageBox.Show("Sa otsisid välja kõik ikoonid", "Palju õnne");
            Close();
        }
    }
}
