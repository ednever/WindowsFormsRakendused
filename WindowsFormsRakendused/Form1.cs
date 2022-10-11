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
        Button naita, puhasta, taustvarv, sulge, joonista, salvesta;        
        OpenFileDialog openFileDialog1;
        ColorDialog colorDialog1;

        Pen pen;
        Graphics g;
        bool moving = false;
        int x, y = -1;

        public Form1()
        {
            this.Text = "Piltide vaatamine";
            this.ClientSize = new Size(800, 450);

            Button[] nuppud = new Button[6] { naita, puhasta, taustvarv, sulge , joonista, salvesta }; //massiiv nuppudest
            string[] text = new string[6] { "Näita", "Puhasta", "Taustavärv", "Sulge", "Joonista" , "Salvesta" };

            tableLayoutPanel1 = new TableLayoutPanel //tabeli loomine
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            pictureBox1 = new PictureBox // pildikasti loomine
            {
                BorderStyle = BorderStyle.Fixed3D,
                Dock = DockStyle.Fill,
                Size = new Size(794, 399),
                
            };
            tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            pictureBox1.MouseDoubleClick += pictureBox1_MouseDoubleClick;
          
            checkBox1 = new CheckBox // märkeruudu loomine
            {
                AutoSize = true,
                Size = new Size(68, 20),
                Text = "Venita",
            };
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            flowLayoutPanel1 = new FlowLayoutPanel // voolu paigutuse paneli loomine
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Size = new Size(674, 39),
            };

            openFileDialog1 = new OpenFileDialog // ava failidialoogi loomine
            {
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
            };
            colorDialog1 = new ColorDialog();

            Controls.Add(tableLayoutPanel1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);

            for (int i = 0; i < text.Length; i++) //nuppude loomise tsükkel
            {
                nuppud[i] = new Button
                {
                    Size = new Size(100, 26),
                    Text = text[i]
                };
                nuppud[i].Click += Tegevus;
                flowLayoutPanel1.Controls.Add(nuppud[i]);
            }
        }
        void Tegevus(object sender, EventArgs e) //nuppude kontroll
        {
            Button nupp = (Button)sender;
            if (nupp.Text == "Näita")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Load(openFileDialog1.FileName);
            }
            else if (nupp.Text == "Puhasta")
            { 
                pictureBox1.Image = null;
            }
            else if (nupp.Text == "Taustavärv")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.BackColor = colorDialog1.Color;
            }
            else if (nupp.Text == "Sulge")
            {
                this.Close();
            }
            else if (nupp.Text == "Joonista")
            {                
                g = pictureBox1.CreateGraphics();
                pen = new Pen(Color.Black, 5);

                //pictureBox1.Paint += pictureBox1_Paint;

                pictureBox1.MouseDown += pictureBox1_MouseDown;
                pictureBox1.MouseMove += pictureBox1_MouseMove;
                pictureBox1.MouseUp += pictureBox1_MouseUp;                
            }
            else if (nupp.Text == "Salvesta")
            {
                if (pictureBox1.Image != null) //если в pictureBox есть изображение
                {
                    try
                    {
                        // path - путь, который был выбран в FolderBrowserDialog()
                        //image_name - имя для сохранения, можете сделать отдельный TextBox где будете сами его прописывать.
                        pictureBox1.Image.Save("bow");
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        void checkBox1_CheckedChanged(object sender, EventArgs e) //märkeruudu kontroll
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        void pictureBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;            
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }
        //void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    PictureBox p = (PictureBox)sender;
        //}
    }    
}