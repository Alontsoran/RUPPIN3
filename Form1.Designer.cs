namespace HW4_PART2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonremove = new System.Windows.Forms.Button();
            this.buttonprint = new System.Windows.Forms.Button();
            this.buttontotalprice = new System.Windows.Forms.Button();
            this.buttonchooseproduct = new System.Windows.Forms.Button();
            this.labelamzon = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picamazon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.nameof = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addtolist = new System.Windows.Forms.Button();
            this.HAT1 = new System.Windows.Forms.Button();
            this.GLOVES2 = new System.Windows.Forms.Button();
            this.SHIRT3 = new System.Windows.Forms.Button();
            this.PANTS4 = new System.Windows.Forms.Button();
            this.SHOES5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BUDGET1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picamazon)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(601, 456);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri(resources.GetString("webBrowser1.Url"), System.UriKind.Absolute);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(599, 93);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(171, 51);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "add product";
            this.buttonadd.UseVisualStyleBackColor = true;
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(802, 93);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(108, 51);
            this.buttonremove.TabIndex = 2;
            this.buttonremove.Text = "Remove : ";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // buttonprint
            // 
            this.buttonprint.Location = new System.Drawing.Point(926, 93);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(108, 51);
            this.buttonprint.TabIndex = 3;
            this.buttonprint.Text = "PRINT ALL DATA";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // buttontotalprice
            // 
            this.buttontotalprice.Location = new System.Drawing.Point(1058, 93);
            this.buttontotalprice.Name = "buttontotalprice";
            this.buttontotalprice.Size = new System.Drawing.Size(108, 51);
            this.buttontotalprice.TabIndex = 4;
            this.buttontotalprice.Text = "My Profit";
            this.buttontotalprice.UseVisualStyleBackColor = true;
            this.buttontotalprice.Click += new System.EventHandler(this.buttontotalprice_Click);
            // 
            // buttonchooseproduct
            // 
            this.buttonchooseproduct.Location = new System.Drawing.Point(1201, 93);
            this.buttonchooseproduct.Name = "buttonchooseproduct";
            this.buttonchooseproduct.Size = new System.Drawing.Size(108, 51);
            this.buttonchooseproduct.TabIndex = 5;
            this.buttonchooseproduct.Text = "button5";
            this.buttonchooseproduct.UseVisualStyleBackColor = true;
            // 
            // labelamzon
            // 
            this.labelamzon.AutoSize = true;
            this.labelamzon.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamzon.Location = new System.Drawing.Point(639, 29);
            this.labelamzon.Name = "labelamzon";
            this.labelamzon.Size = new System.Drawing.Size(214, 29);
            this.labelamzon.TabIndex = 6;
            this.labelamzon.Text = "amazon my budegt";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picamazon
            // 
            this.picamazon.Image = ((System.Drawing.Image)(resources.GetObject("picamazon.Image")));
            this.picamazon.Location = new System.Drawing.Point(1194, 12);
            this.picamazon.Name = "picamazon";
            this.picamazon.Size = new System.Drawing.Size(115, 46);
            this.picamazon.TabIndex = 7;
            this.picamazon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "choose type of product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // disbox
            // 
            this.disbox.Location = new System.Drawing.Point(607, 322);
            this.disbox.Multiline = true;
            this.disbox.Name = "disbox";
            this.disbox.Size = new System.Drawing.Size(163, 105);
            this.disbox.TabIndex = 10;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(607, 283);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(163, 20);
            this.namebox.TabIndex = 11;
            this.namebox.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(607, 446);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(163, 20);
            this.pricebox.TabIndex = 12;
            // 
            // nameof
            // 
            this.nameof.AutoSize = true;
            this.nameof.Location = new System.Drawing.Point(607, 267);
            this.nameof.Name = "nameof";
            this.nameof.Size = new System.Drawing.Size(36, 13);
            this.nameof.TabIndex = 13;
            this.nameof.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "disciption:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "price";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Font = new System.Drawing.Font("Gill Sans MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(926, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(109, 415);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addtolist
            // 
            this.addtolist.Location = new System.Drawing.Point(610, 472);
            this.addtolist.Name = "addtolist";
            this.addtolist.Size = new System.Drawing.Size(160, 86);
            this.addtolist.TabIndex = 22;
            this.addtolist.Text = "add ! ";
            this.addtolist.UseVisualStyleBackColor = true;
            this.addtolist.Click += new System.EventHandler(this.addtolist_Click);
            // 
            // HAT1
            // 
            this.HAT1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HAT1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HAT1.BackgroundImage")));
            this.HAT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HAT1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HAT1.Location = new System.Drawing.Point(607, 163);
            this.HAT1.Name = "HAT1";
            this.HAT1.Size = new System.Drawing.Size(54, 50);
            this.HAT1.TabIndex = 23;
            this.HAT1.UseVisualStyleBackColor = false;
            this.HAT1.Click += new System.EventHandler(this.HAT1_Click_1);
            // 
            // GLOVES2
            // 
            this.GLOVES2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GLOVES2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GLOVES2.BackgroundImage")));
            this.GLOVES2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GLOVES2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GLOVES2.Location = new System.Drawing.Point(667, 163);
            this.GLOVES2.Name = "GLOVES2";
            this.GLOVES2.Size = new System.Drawing.Size(54, 50);
            this.GLOVES2.TabIndex = 24;
            this.GLOVES2.UseVisualStyleBackColor = false;
            this.GLOVES2.Click += new System.EventHandler(this.GLOVES2_Click_1);
            // 
            // SHIRT3
            // 
            this.SHIRT3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SHIRT3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SHIRT3.BackgroundImage")));
            this.SHIRT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SHIRT3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHIRT3.Location = new System.Drawing.Point(727, 163);
            this.SHIRT3.Name = "SHIRT3";
            this.SHIRT3.Size = new System.Drawing.Size(54, 50);
            this.SHIRT3.TabIndex = 25;
            this.SHIRT3.UseVisualStyleBackColor = false;
            this.SHIRT3.Click += new System.EventHandler(this.SHIRT3_Click_1);
            // 
            // PANTS4
            // 
            this.PANTS4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PANTS4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PANTS4.BackgroundImage")));
            this.PANTS4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PANTS4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PANTS4.Location = new System.Drawing.Point(607, 219);
            this.PANTS4.Name = "PANTS4";
            this.PANTS4.Size = new System.Drawing.Size(54, 50);
            this.PANTS4.TabIndex = 26;
            this.PANTS4.UseVisualStyleBackColor = false;
            this.PANTS4.Click += new System.EventHandler(this.PANTS4_Click_1);
            // 
            // SHOES5
            // 
            this.SHOES5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SHOES5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SHOES5.BackgroundImage")));
            this.SHOES5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SHOES5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHOES5.Location = new System.Drawing.Point(667, 219);
            this.SHOES5.Name = "SHOES5";
            this.SHOES5.Size = new System.Drawing.Size(54, 50);
            this.SHOES5.TabIndex = 27;
            this.SHOES5.UseVisualStyleBackColor = false;
            this.SHOES5.Click += new System.EventHandler(this.SHOES5_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(802, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "type name of product";
            // 
            // BUDGET1
            // 
            this.BUDGET1.Location = new System.Drawing.Point(1058, 162);
            this.BUDGET1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BUDGET1.Name = "BUDGET1";
            this.BUDGET1.Size = new System.Drawing.Size(109, 20);
            this.BUDGET1.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total amount";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(1127, 193);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 33;
            this.result.Text = "label6";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1055, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Enter your budget";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1055, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total price";
            // 
            // sum1
            // 
            this.sum1.AutoSize = true;
            this.sum1.Location = new System.Drawing.Point(1127, 180);
            this.sum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(35, 13);
            this.sum1.TabIndex = 36;
            this.sum1.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BUDGET1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SHOES5);
            this.Controls.Add(this.PANTS4);
            this.Controls.Add(this.SHIRT3);
            this.Controls.Add(this.GLOVES2);
            this.Controls.Add(this.HAT1);
            this.Controls.Add(this.addtolist);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameof);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.disbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picamazon);
            this.Controls.Add(this.labelamzon);
            this.Controls.Add(this.buttonchooseproduct);
            this.Controls.Add(this.buttontotalprice);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picamazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonremove;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Button buttontotalprice;
        private System.Windows.Forms.Button buttonchooseproduct;
        private System.Windows.Forms.Label labelamzon;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox picamazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox disbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label nameof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addtolist;
        public System.Windows.Forms.Button HAT1;
        public System.Windows.Forms.Button GLOVES2;
        public System.Windows.Forms.Button SHIRT3;
        public System.Windows.Forms.Button PANTS4;
        public System.Windows.Forms.Button SHOES5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BUDGET1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sum1;
    }
}

