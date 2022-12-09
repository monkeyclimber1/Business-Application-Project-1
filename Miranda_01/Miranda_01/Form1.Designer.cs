namespace Miranda_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.roomnumberLabel = new System.Windows.Forms.Label();
            this.totalnightsLabel = new System.Windows.Forms.Label();
            this.costpernightLabel = new System.Windows.Forms.Label();
            this.barLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.miscLabel = new System.Windows.Forms.Label();
            this.roomchargeLabel = new System.Windows.Forms.Label();
            this.additionalchargeLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomnumberTextBox = new System.Windows.Forms.TextBox();
            this.nightsTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.barTextBox = new System.Windows.Forms.TextBox();
            this.teleTextBox = new System.Windows.Forms.TextBox();
            this.miscTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grandtotalTextBox = new System.Windows.Forms.TextBox();
            this.grandtotalLabel = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.achargeTextBox = new System.Windows.Forms.TextBox();
            this.rchargeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(392, 141);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(221, 33);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Motorway Motel";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(49, 211);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "DATE:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(11, 16);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(86, 13);
            this.firstnameLabel.TabIndex = 3;
            this.firstnameLabel.Text = "FIRST NAME:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(11, 46);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(81, 13);
            this.lastnameLabel.TabIndex = 4;
            this.lastnameLabel.Text = "LAST NAME:";
            // 
            // roomnumberLabel
            // 
            this.roomnumberLabel.AutoSize = true;
            this.roomnumberLabel.Location = new System.Drawing.Point(11, 25);
            this.roomnumberLabel.Name = "roomnumberLabel";
            this.roomnumberLabel.Size = new System.Drawing.Size(105, 13);
            this.roomnumberLabel.TabIndex = 5;
            this.roomnumberLabel.Text = "ROOM NUMBER:";
            // 
            // totalnightsLabel
            // 
            this.totalnightsLabel.AutoSize = true;
            this.totalnightsLabel.Location = new System.Drawing.Point(11, 51);
            this.totalnightsLabel.Name = "totalnightsLabel";
            this.totalnightsLabel.Size = new System.Drawing.Size(102, 13);
            this.totalnightsLabel.TabIndex = 6;
            this.totalnightsLabel.Text = "TOTAL NIGHTS:";
            // 
            // costpernightLabel
            // 
            this.costpernightLabel.AutoSize = true;
            this.costpernightLabel.Location = new System.Drawing.Point(10, 77);
            this.costpernightLabel.Name = "costpernightLabel";
            this.costpernightLabel.Size = new System.Drawing.Size(44, 13);
            this.costpernightLabel.TabIndex = 7;
            this.costpernightLabel.Text = "RATE:";
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(11, 28);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(36, 13);
            this.barLabel.TabIndex = 8;
            this.barLabel.Text = "BAR:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(11, 57);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(85, 13);
            this.telephoneLabel.TabIndex = 9;
            this.telephoneLabel.Text = "TELEPHONE:";
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(11, 87);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(45, 13);
            this.miscLabel.TabIndex = 10;
            this.miscLabel.Text = "MISC.:";
            // 
            // roomchargeLabel
            // 
            this.roomchargeLabel.AutoSize = true;
            this.roomchargeLabel.Location = new System.Drawing.Point(6, 19);
            this.roomchargeLabel.Name = "roomchargeLabel";
            this.roomchargeLabel.Size = new System.Drawing.Size(103, 13);
            this.roomchargeLabel.TabIndex = 11;
            this.roomchargeLabel.Text = "ROOM CHARGE:";
            // 
            // additionalchargeLabel
            // 
            this.additionalchargeLabel.AutoSize = true;
            this.additionalchargeLabel.Location = new System.Drawing.Point(6, 72);
            this.additionalchargeLabel.Name = "additionalchargeLabel";
            this.additionalchargeLabel.Size = new System.Drawing.Size(141, 13);
            this.additionalchargeLabel.TabIndex = 12;
            this.additionalchargeLabel.Text = "ADDITIONAL CHARGE:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(6, 123);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(80, 13);
            this.subtotalLabel.TabIndex = 13;
            this.subtotalLabel.Text = "SUB TOTAL:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(6, 174);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(35, 13);
            this.taxLabel.TabIndex = 14;
            this.taxLabel.Text = "TAX:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(99, 208);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstnameLabel);
            this.groupBox1.Controls.Add(this.lastnameLabel);
            this.groupBox1.Controls.Add(this.firstnameTextBox);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUEST INFORMATION";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(148, 16);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 0;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(148, 46);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomnumberLabel);
            this.groupBox2.Controls.Add(this.totalnightsLabel);
            this.groupBox2.Controls.Add(this.costpernightLabel);
            this.groupBox2.Controls.Add(this.roomnumberTextBox);
            this.groupBox2.Controls.Add(this.nightsTextBox);
            this.groupBox2.Controls.Add(this.rateTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(91, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ROOM INFORMATION";
            // 
            // roomnumberTextBox
            // 
            this.roomnumberTextBox.Location = new System.Drawing.Point(148, 18);
            this.roomnumberTextBox.Name = "roomnumberTextBox";
            this.roomnumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomnumberTextBox.TabIndex = 0;
            // 
            // nightsTextBox
            // 
            this.nightsTextBox.Location = new System.Drawing.Point(148, 44);
            this.nightsTextBox.Name = "nightsTextBox";
            this.nightsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nightsTextBox.TabIndex = 1;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(148, 70);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.barLabel);
            this.groupBox3.Controls.Add(this.telephoneLabel);
            this.groupBox3.Controls.Add(this.miscLabel);
            this.groupBox3.Controls.Add(this.barTextBox);
            this.groupBox3.Controls.Add(this.teleTextBox);
            this.groupBox3.Controls.Add(this.miscTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(91, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 139);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADDITIONAL CHARGES";
            // 
            // barTextBox
            // 
            this.barTextBox.Location = new System.Drawing.Point(148, 19);
            this.barTextBox.Name = "barTextBox";
            this.barTextBox.Size = new System.Drawing.Size(100, 20);
            this.barTextBox.TabIndex = 0;
            // 
            // teleTextBox
            // 
            this.teleTextBox.Location = new System.Drawing.Point(148, 54);
            this.teleTextBox.Name = "teleTextBox";
            this.teleTextBox.Size = new System.Drawing.Size(100, 20);
            this.teleTextBox.TabIndex = 1;
            // 
            // miscTextBox
            // 
            this.miscTextBox.Location = new System.Drawing.Point(148, 84);
            this.miscTextBox.Name = "miscTextBox";
            this.miscTextBox.Size = new System.Drawing.Size(100, 20);
            this.miscTextBox.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.exitButton);
            this.groupBox4.Controls.Add(this.helpButton);
            this.groupBox4.Controls.Add(this.clearButton);
            this.groupBox4.Controls.Add(this.totalButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.grandtotalTextBox);
            this.groupBox4.Controls.Add(this.grandtotalLabel);
            this.groupBox4.Controls.Add(this.taxTextBox);
            this.groupBox4.Controls.Add(this.roomchargeLabel);
            this.groupBox4.Controls.Add(this.subtotalTextBox);
            this.groupBox4.Controls.Add(this.additionalchargeLabel);
            this.groupBox4.Controls.Add(this.achargeTextBox);
            this.groupBox4.Controls.Add(this.taxLabel);
            this.groupBox4.Controls.Add(this.rchargeTextBox);
            this.groupBox4.Controls.Add(this.subtotalLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(704, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 365);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BILLING INFORMATION";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(229, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(153, 288);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(81, 265);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(9, 244);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "TOTAL";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.MenuText;
            this.groupBox5.Location = new System.Drawing.Point(0, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 3);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // grandtotalTextBox
            // 
            this.grandtotalTextBox.Location = new System.Drawing.Point(153, 221);
            this.grandtotalTextBox.Name = "grandtotalTextBox";
            this.grandtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.grandtotalTextBox.TabIndex = 5;
            // 
            // grandtotalLabel
            // 
            this.grandtotalLabel.AutoSize = true;
            this.grandtotalLabel.Location = new System.Drawing.Point(6, 228);
            this.grandtotalLabel.Name = "grandtotalLabel";
            this.grandtotalLabel.Size = new System.Drawing.Size(99, 13);
            this.grandtotalLabel.TabIndex = 17;
            this.grandtotalLabel.Text = "GRAND TOTAL:";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(153, 167);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 4;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(153, 113);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 3;
            // 
            // achargeTextBox
            // 
            this.achargeTextBox.Location = new System.Drawing.Point(153, 65);
            this.achargeTextBox.Name = "achargeTextBox";
            this.achargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.achargeTextBox.TabIndex = 2;
            // 
            // rchargeTextBox
            // 
            this.rchargeTextBox.Location = new System.Drawing.Point(153, 19);
            this.rchargeTextBox.Name = "rchargeTextBox";
            this.rchargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rchargeTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1092, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Check-Out System Motorway Motel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label roomnumberLabel;
        private System.Windows.Forms.Label totalnightsLabel;
        private System.Windows.Forms.Label costpernightLabel;
        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label roomchargeLabel;
        private System.Windows.Forms.Label additionalchargeLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label grandtotalLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox roomnumberTextBox;
        private System.Windows.Forms.TextBox nightsTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox barTextBox;
        private System.Windows.Forms.TextBox teleTextBox;
        private System.Windows.Forms.TextBox miscTextBox;
        private System.Windows.Forms.TextBox grandtotalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox achargeTextBox;
        private System.Windows.Forms.TextBox rchargeTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button totalButton;
    }
}

