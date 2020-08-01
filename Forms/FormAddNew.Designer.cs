namespace TicketReservationSystem.Forms
{
    partial class AddNew
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
            this.labelfirstname = new System.Windows.Forms.Label();
            this.textfirstname = new System.Windows.Forms.TextBox();
            this.textlastname = new System.Windows.Forms.TextBox();
            this.labellastname = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.textgender = new System.Windows.Forms.ComboBox();
            this.labelheight = new System.Windows.Forms.Label();
            this.textheight = new System.Windows.Forms.NumericUpDown();
            this.textage = new System.Windows.Forms.NumericUpDown();
            this.textweight = new System.Windows.Forms.NumericUpDown();
            this.labelweight = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.labeljoindate = new System.Windows.Forms.Label();
            this.textjoindate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textweight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Location = new System.Drawing.Point(23, 42);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(84, 17);
            this.labelfirstname.TabIndex = 0;
            this.labelfirstname.Text = "First Name :";
            // 
            // textfirstname
            // 
            this.textfirstname.Location = new System.Drawing.Point(164, 42);
            this.textfirstname.Name = "textfirstname";
            this.textfirstname.Size = new System.Drawing.Size(282, 22);
            this.textfirstname.TabIndex = 1;
            // 
            // textlastname
            // 
            this.textlastname.Location = new System.Drawing.Point(164, 85);
            this.textlastname.Name = "textlastname";
            this.textlastname.Size = new System.Drawing.Size(282, 22);
            this.textlastname.TabIndex = 3;
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(23, 85);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(84, 17);
            this.labellastname.TabIndex = 2;
            this.labellastname.Text = "Last Name :";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(23, 166);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(41, 17);
            this.labelage.TabIndex = 4;
            this.labelage.Text = "Age :";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(164, 124);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(282, 22);
            this.textemail.TabIndex = 7;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(23, 124);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(50, 17);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "Email :";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(23, 204);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(64, 17);
            this.labelgender.TabIndex = 8;
            this.labelgender.Text = "Gender :";
            // 
            // textgender
            // 
            this.textgender.FormattingEnabled = true;
            this.textgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.textgender.Location = new System.Drawing.Point(164, 204);
            this.textgender.Name = "textgender";
            this.textgender.Size = new System.Drawing.Size(282, 24);
            this.textgender.TabIndex = 10;
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Location = new System.Drawing.Point(23, 249);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(57, 17);
            this.labelheight.TabIndex = 11;
            this.labelheight.Text = "Height :";
            // 
            // textheight
            // 
            this.textheight.Location = new System.Drawing.Point(164, 247);
            this.textheight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textheight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textheight.Name = "textheight";
            this.textheight.Size = new System.Drawing.Size(282, 22);
            this.textheight.TabIndex = 13;
            this.textheight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(164, 166);
            this.textage.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(282, 22);
            this.textage.TabIndex = 14;
            this.textage.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // textweight
            // 
            this.textweight.Location = new System.Drawing.Point(164, 286);
            this.textweight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textweight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textweight.Name = "textweight";
            this.textweight.Size = new System.Drawing.Size(282, 22);
            this.textweight.TabIndex = 16;
            this.textweight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(23, 288);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(60, 17);
            this.labelweight.TabIndex = 15;
            this.labelweight.Text = "Weight :";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(634, 39);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(364, 227);
            this.textaddress.TabIndex = 20;
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(536, 42);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(68, 17);
            this.labeladdress.TabIndex = 19;
            this.labeladdress.Text = "Address :";
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(634, 288);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(364, 22);
            this.textphone.TabIndex = 22;
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Location = new System.Drawing.Point(536, 291);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(57, 17);
            this.labelphone.TabIndex = 21;
            this.labelphone.Text = "Phone :";
            // 
            // labeljoindate
            // 
            this.labeljoindate.AutoSize = true;
            this.labeljoindate.Location = new System.Drawing.Point(272, 342);
            this.labeljoindate.Name = "labeljoindate";
            this.labeljoindate.Size = new System.Drawing.Size(76, 17);
            this.labeljoindate.TabIndex = 23;
            this.labeljoindate.Text = "Join Date :";
            // 
            // textjoindate
            // 
            this.textjoindate.CustomFormat = "yyyy-MM-dd";
            this.textjoindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textjoindate.Location = new System.Drawing.Point(374, 342);
            this.textjoindate.Name = "textjoindate";
            this.textjoindate.Size = new System.Drawing.Size(290, 22);
            this.textjoindate.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(374, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 39);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(529, 420);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 39);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 501);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textjoindate);
            this.Controls.Add(this.labeljoindate);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.textweight);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.textheight);
            this.Controls.Add(this.labelheight);
            this.Controls.Add(this.textgender);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.textlastname);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.textfirstname);
            this.Controls.Add(this.labelfirstname);
            this.Name = "AddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Add New";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textweight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.TextBox textfirstname;
        private System.Windows.Forms.TextBox textlastname;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.ComboBox textgender;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.NumericUpDown textheight;
        private System.Windows.Forms.NumericUpDown textage;
        private System.Windows.Forms.NumericUpDown textweight;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labeljoindate;
        private System.Windows.Forms.DateTimePicker textjoindate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
    }
}