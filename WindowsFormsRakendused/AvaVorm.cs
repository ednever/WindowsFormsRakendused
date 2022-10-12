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
    public partial class AvaVorm : Form
    {
        Form[] vormid = new Form[3] {new Form1(), new Form2(),new Form3()}; //massiiv vormidest
        string[] text = new string[4] { "Piltide vaatamine", "Matemaatika test", "Sobivus mäng", "Sulge" };
        public AvaVorm()
        {
            this.Text = "Pea vorm";
            this.ClientSize = new Size(250, 120);
            this.BackColor = Color.BlanchedAlmond;
            int y = 0;
            for (int i = 0; i < 4; i++)
            {                
                Button openButton = new Button
                {
                    Size = new Size(200,30),
                    Location = new Point(0,y),
                    Text = text[i]
                };                
                openButton.Click += openButton_Click;
                Controls.Add(openButton);
                y += 30;
            }
        }
        void openButton_Click(object sender, EventArgs e)
        {
            Button nupp = (Button)sender;
            for (int i = 0; i < 3; i++)
            {
                if (nupp.Text == text[i])
                    vormid[i].ShowDialog(); //avab vormi vormide massiivist 
            }
            if (nupp.Text == text[3])
            {
                Application.Exit();
            }
        }
    }
}