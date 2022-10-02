namespace WindowsFormsRakendused
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        //    this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //    this.checkBox1 = new System.Windows.Forms.CheckBox();
        //    this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        //    this.naita = new System.Windows.Forms.Button();
        //    this.puhasta = new System.Windows.Forms.Button();
        //    this.taustvarv = new System.Windows.Forms.Button();
        //    this.sulgeNupp = new System.Windows.Forms.Button();
        //    this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        //    this.colorDialog1 = new System.Windows.Forms.ColorDialog();
        //    this.tableLayoutPanel1.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //    this.flowLayoutPanel1.SuspendLayout();
        //    this.SuspendLayout();
        //    // 
        //    // tableLayoutPanel1
        //    // 
        //    this.tableLayoutPanel1.ColumnCount = 2;
        //    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        //    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
        //    this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
        //    this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
        //    this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
        //    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        //    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        //    this.tableLayoutPanel1.RowCount = 2;
        //    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
        //    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        //    this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
        //    this.tableLayoutPanel1.TabIndex = 0;
        //    // 
        //    // pictureBox1
        //    // 
        //    this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        //    this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
        //    this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.pictureBox1.Location = new System.Drawing.Point(3, 3);
        //    this.pictureBox1.Name = "pictureBox1";
        //    this.pictureBox1.Size = new System.Drawing.Size(794, 399);
        //    this.pictureBox1.TabIndex = 0;
        //    this.pictureBox1.TabStop = false;
        //    // 
        //    // checkBox1
        //    // 
        //    this.checkBox1.AutoSize = true;
        //    this.checkBox1.Location = new System.Drawing.Point(3, 408);
        //    this.checkBox1.Name = "checkBox1";
        //    this.checkBox1.Size = new System.Drawing.Size(68, 20);
        //    this.checkBox1.TabIndex = 1;
        //    this.checkBox1.Text = "stretch";
        //    this.checkBox1.UseVisualStyleBackColor = true;
        //    this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
        //    // 
        //    // flowLayoutPanel1
        //    // 
        //    this.flowLayoutPanel1.Controls.Add(this.naita);
        //    this.flowLayoutPanel1.Controls.Add(this.puhasta);
        //    this.flowLayoutPanel1.Controls.Add(this.taustvarv);
        //    this.flowLayoutPanel1.Controls.Add(this.sulgeNupp);
        //    this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        //    this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 408);
        //    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        //    this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 39);
        //    this.flowLayoutPanel1.TabIndex = 2;
        //    // 
        //    // naita
        //    // 
        //    this.naita.AutoSize = true;
        //    this.naita.Location = new System.Drawing.Point(596, 3);
        //    this.naita.Name = "naita";
        //    this.naita.Size = new System.Drawing.Size(75, 26);
        //    this.naita.TabIndex = 0;
        //    this.naita.Text = "Näita pilt";
        //    this.naita.UseVisualStyleBackColor = true;
        //    this.naita.Click += new System.EventHandler(this.naita_Click);
        //    // 
        //    // puhasta
        //    // 
        //    this.puhasta.AutoSize = true;
        //    this.puhasta.Location = new System.Drawing.Point(505, 3);
        //    this.puhasta.Name = "puhasta";
        //    this.puhasta.Size = new System.Drawing.Size(85, 26);
        //    this.puhasta.TabIndex = 1;
        //    this.puhasta.Text = "puhasta pilt";
        //    this.puhasta.UseVisualStyleBackColor = true;
        //    this.puhasta.Click += new System.EventHandler(this.puhasta_Click);
        //    // 
        //    // taustvarv
        //    // 
        //    this.taustvarv.AutoSize = true;
        //    this.taustvarv.Location = new System.Drawing.Point(363, 3);
        //    this.taustvarv.Name = "taustvarv";
        //    this.taustvarv.Size = new System.Drawing.Size(136, 26);
        //    this.taustvarv.TabIndex = 2;
        //    this.taustvarv.Text = "Määrake taustavärv";
        //    this.taustvarv.UseVisualStyleBackColor = true;
        //    this.taustvarv.Click += new System.EventHandler(this.taustvarv_Click);
        //    // 
        //    // sulgeNupp
        //    // 
        //    this.sulgeNupp.AutoSize = true;
        //    this.sulgeNupp.Location = new System.Drawing.Point(282, 3);
        //    this.sulgeNupp.Name = "sulgeNupp";
        //    this.sulgeNupp.Size = new System.Drawing.Size(75, 26);
        //    this.sulgeNupp.TabIndex = 3;
        //    this.sulgeNupp.Text = "sulge";
        //    this.sulgeNupp.UseVisualStyleBackColor = true;
        //    this.sulgeNupp.Click += new System.EventHandler(this.sulgeNupp_Click);
        //    // 
        //    // openFileDialog1
        //    // 
        //    this.openFileDialog1.FileName = "openFileDialog1";
        //    this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
        //    "s (*.*)|*.*";
        //    this.openFileDialog1.Title = "Valige a pilt fail";
        //    // 
        //    // Form1
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Controls.Add(this.tableLayoutPanel1);
        //    this.Name = "Form1";
        //    this.Text = "Form1";
        //    this.tableLayoutPanel1.ResumeLayout(false);
        //    this.tableLayoutPanel1.PerformLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //    this.flowLayoutPanel1.ResumeLayout(false);
        //    this.flowLayoutPanel1.PerformLayout();
        //    this.ResumeLayout(false);

        //}

        #endregion

        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.CheckBox checkBox1;
        //private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        //private System.Windows.Forms.Button naita;
        //private System.Windows.Forms.Button puhasta;
        //private System.Windows.Forms.Button taustvarv;
        //private System.Windows.Forms.Button sulgeNupp;
        //private System.Windows.Forms.OpenFileDialog openFileDialog1;
        //private System.Windows.Forms.ColorDialog colorDialog1;
    }
}