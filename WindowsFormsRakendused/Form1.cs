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
    public partial class Form1 : Form
    {
        TableLayoutPanel tableLayoutPanel1;
        PictureBox pictureBox1;
        CheckBox checkBox1;
        FlowLayoutPanel flowLayoutPanel1;
        Button closeButton;
        Button backgroundButton;
        Button clearButton;
        Button showButton;
        OpenFileDialog openFileDialog1;
        ColorDialog colorDialog1;
        public Form1()
        {
            
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Name = "Form1";
            this.Text = "Piltide vaatamine";
            tableLayoutPanel1 = new TableLayoutPanel
            {
                ColumnCount = 2,                
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "tableLayoutPanel1",
                RowCount = 2,                
                Size = new Size(800, 450),
                TabIndex = 0,
            };
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            pictureBox1 = new PictureBox
            {
                BorderStyle = BorderStyle.Fixed3D,
                Dock = DockStyle.Fill,
                Location = new Point(3, 3),
                Name = "pictureBox1",
                Size = new Size(794, 399),
                TabIndex = 0,
                TabStop = false,
            };
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);

            checkBox1 = new CheckBox
            {
                Location = new Point(3, 408),
                Name = "checkBox1",
                Size = new Size(104, 24),
                TabIndex = 1,
                Text = "Venitada",
            };
            checkBox1.CheckedChanged += checkbox1_CheckedChanged;

            flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Location = new Point(123, 408),
                Name = "flowLayoutPanel1",
                Size = new Size(674, 39),
                TabIndex = 2,
            };
            flowLayoutPanel1.Controls.Add(checkBox1);


            showButton = new Button
            {
                AutoSize = true,
                Location = new Point(596, 3),
                Name = "showButton",
                Size = new Size(75, 23),
                TabIndex = 0,
                Text = "Näita pilt",
                UseVisualStyleBackColor = true,

            };
            showButton.Click += Tegevus;

            clearButton = new Button
            {
                AutoSize = true,
                Location = new Point(475, 3),
                Name = "clearButton",
                Size = new Size(115, 23),
                TabIndex = 1,
                Text = "Tühjenda pilt",
                UseVisualStyleBackColor = true,

            };
            clearButton.Click += Tegevus;

            backgroundButton = new Button
            {
                AutoSize = true,
                Location = new Point(357, 3),
                Name = "backgroundButton",
                Size = new Size(112, 23),
                TabIndex = 2,
                Text = "Määrake taustavärv",
                UseVisualStyleBackColor = true,
            };
            backgroundButton.Click += backgroundButton_Click;

            closeButton = new Button
            {
                AutoSize = true,
                Location = new Point(276, 3),
                Name = "closeButton",
                Size = new Size(75, 23),
                TabIndex = 3,
                Text = "Sulge",
                UseVisualStyleBackColor = true,
            };
            closeButton.Click += Tegevus;

            openFileDialog1 = new OpenFileDialog
            {
                FileName = "openFileDialog1",
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*",
            };

            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)(pictureBox1)).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)(pictureBox1)).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(checkBox1);
            this.Controls.Add(flowLayoutPanel1);
            this.Controls.Add(showButton);
            this.Controls.Add(clearButton);
            this.Controls.Add(backgroundButton);
            this.Controls.Add(closeButton);
        }
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
                pictureBox1.BackColor = colorDialog1.Color;
        }
        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void Tegevus(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            if (nupp_sender.Text == "Näita")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Load(openFileDialog1.FileName);
            }
            else if (nupp_sender.Text == "Kustuta")
            {
                pictureBox1.Image = null;

            }
            else if (nupp_sender.Text == "Kinni")
            {
                this.Close();
            }
        }
    }
}
