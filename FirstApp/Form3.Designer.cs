
namespace FirstApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tab = new System.Windows.Forms.TabControl();
            this.cmh = new System.Windows.Forms.TabPage();
            this.removecmh = new System.Windows.Forms.Button();
            this.addcmh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nmh = new System.Windows.Forms.TabPage();
            this.removenmh = new System.Windows.Forms.Button();
            this.addnmh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pmh = new System.Windows.Forms.TabPage();
            this.removepmh = new System.Windows.Forms.Button();
            this.addpmh = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nwh = new System.Windows.Forms.TabPage();
            this.removenwh = new System.Windows.Forms.Button();
            this.addnwh = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.cmh.SuspendLayout();
            this.nmh.SuspendLayout();
            this.pmh.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.nwh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.cmh);
            this.tab.Controls.Add(this.nmh);
            this.tab.Controls.Add(this.pmh);
            this.tab.Controls.Add(this.nwh);
            this.tab.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(0, 3);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Drawing.Point(30, 6);
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(893, 470);
            this.tab.TabIndex = 0;
            // 
            // cmh
            // 
            this.cmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmh.Controls.Add(this.removecmh);
            this.cmh.Controls.Add(this.addcmh);
            this.cmh.Controls.Add(this.button1);
            this.cmh.Controls.Add(this.comboBox1);
            this.cmh.Controls.Add(this.label1);
            this.cmh.Controls.Add(this.search);
            this.cmh.Controls.Add(this.groupBox4);
            this.cmh.ForeColor = System.Drawing.Color.White;
            this.cmh.Location = new System.Drawing.Point(4, 37);
            this.cmh.Name = "cmh";
            this.cmh.Padding = new System.Windows.Forms.Padding(3);
            this.cmh.Size = new System.Drawing.Size(885, 429);
            this.cmh.TabIndex = 0;
            this.cmh.Text = "CMH";
            // 
            // removecmh
            // 
            this.removecmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removecmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removecmh.ForeColor = System.Drawing.Color.Black;
            this.removecmh.Location = new System.Drawing.Point(715, 11);
            this.removecmh.Name = "removecmh";
            this.removecmh.Size = new System.Drawing.Size(156, 31);
            this.removecmh.TabIndex = 20;
            this.removecmh.Text = "Remove entry";
            this.removecmh.UseVisualStyleBackColor = true;
            // 
            // addcmh
            // 
            this.addcmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addcmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcmh.ForeColor = System.Drawing.Color.Black;
            this.addcmh.Location = new System.Drawing.Point(573, 11);
            this.addcmh.Name = "addcmh";
            this.addcmh.Size = new System.Drawing.Size(123, 31);
            this.addcmh.TabIndex = 19;
            this.addcmh.Text = "Add entry";
            this.addcmh.UseVisualStyleBackColor = true;
            this.addcmh.Click += new System.EventHandler(this.addcmh_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(335, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Roll No.",
            "Branch",
            "Address"});
            this.comboBox1.Location = new System.Drawing.Point(190, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 31);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "by";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(15, 9);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(137, 31);
            this.search.TabIndex = 0;
            this.search.Text = "search here";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Location = new System.Drawing.Point(2, -8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(882, 58);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // nmh
            // 
            this.nmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nmh.Controls.Add(this.removenmh);
            this.nmh.Controls.Add(this.addnmh);
            this.nmh.Controls.Add(this.button2);
            this.nmh.Controls.Add(this.comboBox2);
            this.nmh.Controls.Add(this.label2);
            this.nmh.Controls.Add(this.search1);
            this.nmh.Controls.Add(this.groupBox2);
            this.nmh.Location = new System.Drawing.Point(4, 37);
            this.nmh.Name = "nmh";
            this.nmh.Padding = new System.Windows.Forms.Padding(3);
            this.nmh.Size = new System.Drawing.Size(885, 429);
            this.nmh.TabIndex = 1;
            this.nmh.Text = "NMH";
            // 
            // removenmh
            // 
            this.removenmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removenmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removenmh.Location = new System.Drawing.Point(715, 11);
            this.removenmh.Name = "removenmh";
            this.removenmh.Size = new System.Drawing.Size(156, 31);
            this.removenmh.TabIndex = 20;
            this.removenmh.Text = "Remove entry";
            this.removenmh.UseVisualStyleBackColor = true;
            // 
            // addnmh
            // 
            this.addnmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addnmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnmh.Location = new System.Drawing.Point(573, 11);
            this.addnmh.Name = "addnmh";
            this.addnmh.Size = new System.Drawing.Size(123, 31);
            this.addnmh.TabIndex = 19;
            this.addnmh.Text = "Add entry";
            this.addnmh.UseVisualStyleBackColor = true;
            this.addnmh.Click += new System.EventHandler(this.addnmh_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(335, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Name",
            "Roll No.",
            "Branch",
            "Address"});
            this.comboBox2.Location = new System.Drawing.Point(190, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 31);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "by";
            // 
            // search1
            // 
            this.search1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.ForeColor = System.Drawing.Color.Gray;
            this.search1.Location = new System.Drawing.Point(15, 9);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(137, 31);
            this.search1.TabIndex = 5;
            this.search1.Text = "search here";
            this.search1.Enter += new System.EventHandler(this.search1_Enter);
            this.search1.Leave += new System.EventHandler(this.search1_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(2, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 58);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // pmh
            // 
            this.pmh.BackColor = System.Drawing.Color.Teal;
            this.pmh.Controls.Add(this.removepmh);
            this.pmh.Controls.Add(this.addpmh);
            this.pmh.Controls.Add(this.comboBox3);
            this.pmh.Controls.Add(this.label3);
            this.pmh.Controls.Add(this.search2);
            this.pmh.Controls.Add(this.groupBox3);
            this.pmh.Location = new System.Drawing.Point(4, 37);
            this.pmh.Name = "pmh";
            this.pmh.Padding = new System.Windows.Forms.Padding(3);
            this.pmh.Size = new System.Drawing.Size(885, 429);
            this.pmh.TabIndex = 2;
            this.pmh.Text = "PMH";
            // 
            // removepmh
            // 
            this.removepmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removepmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removepmh.Location = new System.Drawing.Point(715, 11);
            this.removepmh.Name = "removepmh";
            this.removepmh.Size = new System.Drawing.Size(156, 31);
            this.removepmh.TabIndex = 20;
            this.removepmh.Text = "Remove entry";
            this.removepmh.UseVisualStyleBackColor = true;
            // 
            // addpmh
            // 
            this.addpmh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addpmh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpmh.Location = new System.Drawing.Point(573, 11);
            this.addpmh.Name = "addpmh";
            this.addpmh.Size = new System.Drawing.Size(123, 31);
            this.addpmh.TabIndex = 19;
            this.addpmh.Text = "Add entry";
            this.addpmh.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Name",
            "Roll No.",
            "Branch",
            "Address"});
            this.comboBox3.Location = new System.Drawing.Point(190, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 31);
            this.comboBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "by";
            // 
            // search2
            // 
            this.search2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2.ForeColor = System.Drawing.Color.Gray;
            this.search2.Location = new System.Drawing.Point(15, 9);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(137, 31);
            this.search2.TabIndex = 9;
            this.search2.Text = "search here";
            this.search2.Enter += new System.EventHandler(this.search2_Enter);
            this.search2.Leave += new System.EventHandler(this.search2_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(2, -8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 58);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // nwh
            // 
            this.nwh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nwh.Controls.Add(this.removenwh);
            this.nwh.Controls.Add(this.addnwh);
            this.nwh.Controls.Add(this.button4);
            this.nwh.Controls.Add(this.comboBox4);
            this.nwh.Controls.Add(this.label4);
            this.nwh.Controls.Add(this.search3);
            this.nwh.Controls.Add(this.groupBox1);
            this.nwh.Location = new System.Drawing.Point(4, 37);
            this.nwh.Name = "nwh";
            this.nwh.Padding = new System.Windows.Forms.Padding(3);
            this.nwh.Size = new System.Drawing.Size(885, 429);
            this.nwh.TabIndex = 3;
            this.nwh.Text = "NWH";
            // 
            // removenwh
            // 
            this.removenwh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removenwh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removenwh.Location = new System.Drawing.Point(715, 11);
            this.removenwh.Name = "removenwh";
            this.removenwh.Size = new System.Drawing.Size(156, 31);
            this.removenwh.TabIndex = 18;
            this.removenwh.Text = "Remove entry";
            this.removenwh.UseVisualStyleBackColor = true;
            // 
            // addnwh
            // 
            this.addnwh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addnwh.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnwh.Location = new System.Drawing.Point(573, 11);
            this.addnwh.Name = "addnwh";
            this.addnwh.Size = new System.Drawing.Size(123, 31);
            this.addnwh.TabIndex = 17;
            this.addnwh.Text = "Add entry";
            this.addnwh.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(335, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Name",
            "Roll No.",
            "Branch",
            "Address"});
            this.comboBox4.Location = new System.Drawing.Point(190, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(139, 31);
            this.comboBox4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "by";
            // 
            // search3
            // 
            this.search3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search3.ForeColor = System.Drawing.Color.Gray;
            this.search3.Location = new System.Drawing.Point(15, 9);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(137, 31);
            this.search3.TabIndex = 13;
            this.search3.Text = "search here";
            this.search3.Enter += new System.EventHandler(this.search3_Enter);
            this.search3.Leave += new System.EventHandler(this.search3_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 58);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(333, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 31);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(889, 474);
            this.Controls.Add(this.tab);
            this.Name = "Form3";
            this.Text = "Admin- Hostel database";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tab.ResumeLayout(false);
            this.cmh.ResumeLayout(false);
            this.cmh.PerformLayout();
            this.nmh.ResumeLayout(false);
            this.nmh.PerformLayout();
            this.pmh.ResumeLayout(false);
            this.pmh.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.nwh.ResumeLayout(false);
            this.nwh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage cmh;
        private System.Windows.Forms.TabPage nmh;
        private System.Windows.Forms.TabPage pmh;
        private System.Windows.Forms.TabPage nwh;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search3;
        private System.Windows.Forms.Button removecmh;
        private System.Windows.Forms.Button addcmh;
        private System.Windows.Forms.Button removenmh;
        private System.Windows.Forms.Button addnmh;
        private System.Windows.Forms.Button removepmh;
        private System.Windows.Forms.Button addpmh;
        private System.Windows.Forms.Button removenwh;
        private System.Windows.Forms.Button addnwh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
    }
}