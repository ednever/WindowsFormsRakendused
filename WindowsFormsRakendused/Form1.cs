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
    //public partial class Form1 : Form
    //{
    //    TableLayoutPanel tableLayoutPanel1;
    //    PictureBox pictureBox1;
    //    CheckBox checkBox1;
    //    FlowLayoutPanel flowLayoutPanel1;
    //    Button closeButton;
    //    Button backgroundButton;
    //    Button clearButton;
    //    Button showButton;
    //    OpenFileDialog openFileDialog1;
    //    ColorDialog colorDialog1;
    //    public Form1()
    //    {
    //        this.Name = "Form1";
    //        this.Text = "Piltide vaatamine";
    //        this.ClientSize = new Size(800, 450);
    //        this.AutoScaleDimensions = new SizeF(6F, 13F);
    //        this.AutoScaleMode = AutoScaleMode.Font;

    //        tableLayoutPanel1 = new TableLayoutPanel
    //        {
    //            ColumnCount = 2,
    //            Dock = DockStyle.Fill,
    //            Location = new Point(0, 0),
    //            Name = "tableLayoutPanel1",
    //            RowCount = 2,
    //            Size = new Size(800, 450),
    //            TabIndex = 0,
    //        };

    //        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
    //        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
    //        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
    //        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

    //        pictureBox1 = new PictureBox
    //        {
    //            BorderStyle = BorderStyle.Fixed3D,
    //            Dock = DockStyle.Fill,
    //            Location = new Point(3, 3),
    //            Name = "pictureBox1",
    //            Size = new Size(794, 399),
    //            TabIndex = 0,
    //            TabStop = false,
    //        };
    //        tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);

    //        checkBox1 = new CheckBox
    //        {
    //            Location = new Point(3, 408),
    //            Name = "checkBox1",
    //            Size = new Size(104, 24),
    //            TabIndex = 1,
    //            Text = "Venitada",
    //        };
    //        checkBox1.CheckedChanged += checkbox1_CheckedChanged;

    //        flowLayoutPanel1 = new FlowLayoutPanel
    //        {
    //            Dock = DockStyle.Fill,
    //            FlowDirection = FlowDirection.RightToLeft,
    //            Location = new Point(123, 408),
    //            Name = "flowLayoutPanel1",
    //            Size = new Size(674, 39),
    //            TabIndex = 2,
    //        };
    //        flowLayoutPanel1.Controls.Add(checkBox1);


    //        showButton = new Button
    //        {
    //            AutoSize = true,
    //            Location = new Point(596, 3),
    //            Name = "showButton",
    //            Size = new Size(75, 23),
    //            TabIndex = 0,
    //            Text = "Näita",
    //            UseVisualStyleBackColor = true,

    //        };
    //        showButton.Click += Tegevus;

    //        clearButton = new Button
    //        {
    //            AutoSize = true,
    //            Location = new Point(475, 3),
    //            Name = "clearButton",
    //            Size = new Size(115, 23),
    //            TabIndex = 1,
    //            Text = "Kustuta",
    //            UseVisualStyleBackColor = true,

    //        };
    //        clearButton.Click += Tegevus;

    //        backgroundButton = new Button
    //        {
    //            AutoSize = true,
    //            Location = new Point(357, 3),
    //            Name = "backgroundButton",
    //            Size = new Size(112, 23),
    //            TabIndex = 2,
    //            Text = "Määrake taustavärv",
    //            UseVisualStyleBackColor = true,
    //        };
    //        backgroundButton.Click += backgroundButton_Click;

    //        closeButton = new Button
    //        {
    //            AutoSize = true,
    //            Location = new Point(276, 3),
    //            Name = "closeButton",
    //            Size = new Size(75, 23),
    //            TabIndex = 3,
    //            Text = "Kinni",
    //            UseVisualStyleBackColor = true,
    //        };
    //        closeButton.Click += Tegevus;

    //        openFileDialog1 = new OpenFileDialog
    //        {
    //            FileName = "openFileDialog1",
    //            Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*",
    //        };

    //        tableLayoutPanel1.SuspendLayout();
    //        ((ISupportInitialize)(pictureBox1)).BeginInit();
    //        flowLayoutPanel1.SuspendLayout();
    //        this.SuspendLayout();

    //        tableLayoutPanel1.ResumeLayout(false);
    //        ((ISupportInitialize)(pictureBox1)).EndInit();
    //        flowLayoutPanel1.ResumeLayout(false);
    //        flowLayoutPanel1.PerformLayout();
    //        this.ResumeLayout(false);

    //        this.Controls.Add(this.tableLayoutPanel1);
    //        this.Controls.Add(this.pictureBox1);
    //        this.Controls.Add(this.checkBox1);
    //        this.Controls.Add(this.flowLayoutPanel1);
    //        this.Controls.Add(this.showButton);
    //        this.Controls.Add(this.clearButton);
    //        this.Controls.Add(this.backgroundButton);
    //        this.Controls.Add(this.closeButton);
    //    }
    //    private void backgroundButton_Click(object sender, EventArgs e)
    //    {
    //        if (colorDialog1.ShowDialog() == DialogResult.OK)
    //            pictureBox1.BackColor = colorDialog1.Color;
    //    }
    //    private void checkbox1_CheckedChanged(object sender, EventArgs e)
    //    {
    //        if (checkBox1.Checked)
    //            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    //        else
    //            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
    //    }
    //    private void Tegevus(object sender, EventArgs e)
    //    {
    //        Button nupp_sender = (Button)sender;
    //        if (nupp_sender.Text == "Näita")
    //        {
    //            if (openFileDialog1.ShowDialog() == DialogResult.OK)
    //                pictureBox1.Load(openFileDialog1.FileName);
    //        }
    //        else if (nupp_sender.Text == "Kustuta")
    //        {
    //            pictureBox1.Image = null;

    //        }
    //        else if (nupp_sender.Text == "Kinni")
    //        {
    //            this.Close();
    //        }
    //    }
    //}
    public partial class Form1 : Form
    {
        TableLayoutPanel tableLayoutPanel1;
        PictureBox pictureBox1;
        CheckBox checkBox1;
        FlowLayoutPanel flowLayoutPanel1;
        Button naita;
        Button puhasta;
        Button taustvarv;
        Button sulgeNupp;
        OpenFileDialog openFileDialog1;
        ColorDialog colorDialog1;
        public Form1()
        {
            //tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            naita = new Button();
            puhasta = new Button();
            taustvarv = new Button();
            sulgeNupp = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();

            tableLayoutPanel1 = new TableLayoutPanel
            {
                ColumnCount = 2,                
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "tableLayoutPanel1",
                RowCount = 2,                
                Size = new Size(800, 450),
            };
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            // 
            // tableLayoutPanel1
            // 
            //tableLayoutPanel1.ColumnCount = 2;
            //tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            //tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            //tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            //tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            //tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            //tableLayoutPanel1.Dock = DockStyle.Fill;
            //tableLayoutPanel1.Location = new Point(0, 0);
            //tableLayoutPanel1.Name = "tableLayoutPanel1";
            //tableLayoutPanel1.RowCount = 2;
            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            //tableLayoutPanel1.Size = new Size(800, 450);

            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 399);


            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 408);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 20);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "stretch";
            checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);

            // 
            // flowLayoutPanel1
            // 

            flowLayoutPanel1.Controls.Add(this.naita);
            flowLayoutPanel1.Controls.Add(this.puhasta);
            flowLayoutPanel1.Controls.Add(this.taustvarv);
            flowLayoutPanel1.Controls.Add(this.sulgeNupp);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(123, 408);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(674, 39);

            // 
            // naita
            // 

            naita.AutoSize = true;
            naita.Location = new Point(596, 3);
            naita.Name = "naita";
            naita.Size = new Size(75, 26);
            naita.Text = "Näita pilt";
            naita.Click += new EventHandler(this.naita_Click);

            // 
            // puhasta
            // 

            this.puhasta.AutoSize = true;
            this.puhasta.Location = new Point(505, 3);
            this.puhasta.Name = "puhasta";
            this.puhasta.Size = new Size(85, 26);
            this.puhasta.TabIndex = 1;
            this.puhasta.Text = "puhasta pilt";
            this.puhasta.UseVisualStyleBackColor = true;
            this.puhasta.Click += new EventHandler(this.puhasta_Click);

            // 
            // taustvarv
            // 

            this.taustvarv.AutoSize = true;
            this.taustvarv.Location = new Point(363, 3);
            this.taustvarv.Name = "taustvarv";
            this.taustvarv.Size = new Size(136, 26);
            this.taustvarv.Text = "Määrake taustavärv";
            this.taustvarv.Click += new EventHandler(this.taustvarv_Click);

            // 
            // sulgeNupp
            // 

            this.sulgeNupp.AutoSize = true;
            this.sulgeNupp.Location = new Point(282, 3);
            this.sulgeNupp.Name = "sulgeNupp";
            this.sulgeNupp.Size = new Size(75, 26);
            this.sulgeNupp.Text = "sulge";
            this.sulgeNupp.Click += new EventHandler(this.sulgeNupp_Click);

            // 
            // openFileDialog1
            // 

            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
            "s (*.*)|*.*";
            this.openFileDialog1.Title = "Valige a pilt fail";

            // 
            // Form1
            // 

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        }
        private void puhasta_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void taustvarv_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }
        private void naita_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        private void sulgeNupp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}