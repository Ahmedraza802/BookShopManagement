namespace BookShopManagement.UserControls
{
    partial class UC_Sales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.DatalistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnfinish = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnaddbook = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTracking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbooktitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnpublisher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btndiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnqty = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Code:";
            // 
            // btnBarcode
            // 
            this.btnBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarcode.Location = new System.Drawing.Point(154, 126);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(179, 57);
            this.btnBarcode.TabIndex = 1;
            this.btnBarcode.TextChanged += new System.EventHandler(this.btnBarcode_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Controls.Add(this.DatalistView);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(726, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(259, 580);
            this.panelLeft.TabIndex = 3;
            // 
            // DatalistView
            // 
            this.DatalistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.DatalistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatalistView.GridLines = true;
            this.DatalistView.HideSelection = false;
            this.DatalistView.Location = new System.Drawing.Point(10, 0);
            this.DatalistView.Name = "DatalistView";
            this.DatalistView.Size = new System.Drawing.Size(239, 386);
            this.DatalistView.TabIndex = 5;
            this.DatalistView.UseCompatibleStateImageBehavior = false;
            this.DatalistView.View = System.Windows.Forms.View.Details;
            this.DatalistView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Title";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.btnfinish);
            this.panel5.Controls.Add(this.btnclear);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 386);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 194);
            this.panel5.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 44);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(239, 7);
            this.panel8.TabIndex = 5;
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.Color.SeaGreen;
            this.btnfinish.FlatAppearance.BorderSize = 0;
            this.btnfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinish.ForeColor = System.Drawing.Color.White;
            this.btnfinish.Location = new System.Drawing.Point(116, 144);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(116, 42);
            this.btnfinish.TabIndex = 2;
            this.btnfinish.Text = "Finish";
            this.btnfinish.UseVisualStyleBackColor = false;
            this.btnfinish.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(5, 144);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 42);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Amount:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnsubtract);
            this.panel7.Controls.Add(this.btndelete);
            this.panel7.Controls.Add(this.btnaddbook);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(239, 37);
            this.panel7.TabIndex = 4;
            // 
            // btnsubtract
            // 
            this.btnsubtract.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsubtract.FlatAppearance.BorderSize = 0;
            this.btnsubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubtract.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtract.ForeColor = System.Drawing.Color.White;
            this.btnsubtract.Location = new System.Drawing.Point(5, 3);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(33, 31);
            this.btnsubtract.TabIndex = 2;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = false;
            this.btnsubtract.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(82, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 31);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnaddbook
            // 
            this.btnaddbook.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnaddbook.FlatAppearance.BorderSize = 0;
            this.btnaddbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddbook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbook.ForeColor = System.Drawing.Color.White;
            this.btnaddbook.Location = new System.Drawing.Point(175, 3);
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(58, 31);
            this.btnaddbook.TabIndex = 2;
            this.btnaddbook.Text = "Add";
            this.btnaddbook.UseVisualStyleBackColor = false;
            this.btnaddbook.Click += new System.EventHandler(this.btnaddbook_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(43, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 7);
            this.panel6.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(249, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 580);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 580);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sell Books";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tracking ID:";
            // 
            // btnTracking
            // 
            this.btnTracking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTracking.Location = new System.Drawing.Point(462, 126);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(179, 57);
            this.btnTracking.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 47);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Title:";
            // 
            // btnbooktitle
            // 
            this.btnbooktitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbooktitle.Location = new System.Drawing.Point(154, 171);
            this.btnbooktitle.Name = "btnbooktitle";
            this.btnbooktitle.Size = new System.Drawing.Size(179, 57);
            this.btnbooktitle.TabIndex = 1;
            this.btnbooktitle.TextChanged += new System.EventHandler(this.btnbooktitle_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Author:";
            // 
            // btnAuthor
            // 
            this.btnAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthor.Location = new System.Drawing.Point(464, 168);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(179, 57);
            this.btnAuthor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 47);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publisher:";
            // 
            // btnpublisher
            // 
            this.btnpublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpublisher.Location = new System.Drawing.Point(154, 213);
            this.btnpublisher.Name = "btnpublisher";
            this.btnpublisher.Size = new System.Drawing.Size(250, 57);
            this.btnpublisher.TabIndex = 1;
            this.btnpublisher.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price:";
            // 
            // btnprice
            // 
            this.btnprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprice.Location = new System.Drawing.Point(154, 255);
            this.btnprice.Name = "btnprice";
            this.btnprice.Size = new System.Drawing.Size(179, 57);
            this.btnprice.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 47);
            this.label10.TabIndex = 0;
            this.label10.Text = "Discount:";
            // 
            // btndiscount
            // 
            this.btndiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndiscount.Location = new System.Drawing.Point(464, 255);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(179, 57);
            this.btndiscount.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 47);
            this.label11.TabIndex = 4;
            this.label11.Text = "Qty:";
            // 
            // btnqty
            // 
            this.btnqty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnqty.Location = new System.Drawing.Point(464, 216);
            this.btnqty.Name = "btnqty";
            this.btnqty.Size = new System.Drawing.Size(179, 57);
            this.btnqty.TabIndex = 5;
            // 
            // UC_Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnqty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndiscount);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnpublisher);
            this.Controls.Add(this.btnprice);
            this.Controls.Add(this.btnbooktitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(985, 580);
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListView DatalistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnaddbook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btnTracking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btnbooktitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox btnAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox btnpublisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox btnprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox btndiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox btnqty;
    }
}
