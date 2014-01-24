namespace Asg_01
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAddInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgContact = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statUpdate = new System.Windows.Forms.StatusStrip();
            this.lblUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.errZip = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbXml = new System.Windows.Forms.GroupBox();
            this.gbOpt = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.gbAddInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            this.gbXml.SuspendLayout();
            this.gbOpt.SuspendLayout();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(95, 24);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(166, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(95, 50);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(166, 20);
            this.txtLast.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(95, 76);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(166, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(95, 102);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(166, 20);
            this.txtZip.TabIndex = 4;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zip:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 128);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone #:";
            // 
            // gbAddInfo
            // 
            this.gbAddInfo.Controls.Add(this.label1);
            this.gbAddInfo.Controls.Add(this.label5);
            this.gbAddInfo.Controls.Add(this.btnClear);
            this.gbAddInfo.Controls.Add(this.txtFirst);
            this.gbAddInfo.Controls.Add(this.txtPhone);
            this.gbAddInfo.Controls.Add(this.txtLast);
            this.gbAddInfo.Controls.Add(this.label4);
            this.gbAddInfo.Controls.Add(this.txtStreet);
            this.gbAddInfo.Controls.Add(this.label3);
            this.gbAddInfo.Controls.Add(this.txtZip);
            this.gbAddInfo.Controls.Add(this.label2);
            this.gbAddInfo.Location = new System.Drawing.Point(12, 12);
            this.gbAddInfo.Name = "gbAddInfo";
            this.gbAddInfo.Size = new System.Drawing.Size(289, 187);
            this.gbAddInfo.TabIndex = 0;
            this.gbAddInfo.TabStop = false;
            this.gbAddInfo.Text = "Add Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgContact
            // 
            this.dgContact.AllowUserToAddRows = false;
            this.dgContact.AllowUserToDeleteRows = false;
            this.dgContact.AllowUserToResizeRows = false;
            this.dgContact.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgContact.Location = new System.Drawing.Point(8, 21);
            this.dgContact.MultiSelect = false;
            this.dgContact.Name = "dgContact";
            this.dgContact.ReadOnly = true;
            this.dgContact.RowHeadersVisible = false;
            this.dgContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContact.Size = new System.Drawing.Size(496, 227);
            this.dgContact.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgContact);
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(512, 256);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(86, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 33);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // statUpdate
            // 
            this.statUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUpdate});
            this.statUpdate.Location = new System.Drawing.Point(0, 280);
            this.statUpdate.Name = "statUpdate";
            this.statUpdate.Size = new System.Drawing.Size(846, 22);
            this.statUpdate.TabIndex = 14;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(210, 17);
            this.lblUpdate.Text = "Add Contact or Load Existing Contacts";
            // 
            // errZip
            // 
            this.errZip.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbXml
            // 
            this.gbXml.Controls.Add(this.btnLoad);
            this.gbXml.Controls.Add(this.btnAdd);
            this.gbXml.Location = new System.Drawing.Point(88, 205);
            this.gbXml.Name = "gbXml";
            this.gbXml.Size = new System.Drawing.Size(170, 63);
            this.gbXml.TabIndex = 10;
            this.gbXml.TabStop = false;
            this.gbXml.Text = "XML File";
            // 
            // gbOpt
            // 
            this.gbOpt.Controls.Add(this.rbText);
            this.gbOpt.Controls.Add(this.rbXml);
            this.gbOpt.Location = new System.Drawing.Point(12, 205);
            this.gbOpt.Name = "gbOpt";
            this.gbOpt.Size = new System.Drawing.Size(70, 63);
            this.gbOpt.TabIndex = 7;
            this.gbOpt.TabStop = false;
            this.gbOpt.Text = "OPTIONS";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(6, 42);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(53, 17);
            this.rbText.TabIndex = 9;
            this.rbText.Text = "TEXT";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbXml
            // 
            this.rbXml.AutoSize = true;
            this.rbXml.Checked = true;
            this.rbXml.Location = new System.Drawing.Point(6, 19);
            this.rbXml.Name = "rbXml";
            this.rbXml.Size = new System.Drawing.Size(47, 17);
            this.rbXml.TabIndex = 8;
            this.rbXml.TabStop = true;
            this.rbXml.Text = "XML";
            this.rbXml.UseVisualStyleBackColor = true;
            this.rbXml.CheckedChanged += new System.EventHandler(this.rbXml_CheckedChanged);
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.button1);
            this.gbText.Controls.Add(this.button2);
            this.gbText.Location = new System.Drawing.Point(88, 205);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(170, 63);
            this.gbText.TabIndex = 13;
            this.gbText.TabStop = false;
            this.gbText.Text = "TEXT File";
            this.gbText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 302);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbOpt);
            this.Controls.Add(this.gbXml);
            this.Controls.Add(this.statUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAddInfo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAddInfo.ResumeLayout(false);
            this.gbAddInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statUpdate.ResumeLayout(false);
            this.statUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            this.gbXml.ResumeLayout(false);
            this.gbOpt.ResumeLayout(false);
            this.gbOpt.PerformLayout();
            this.gbText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAddInfo;
        private System.Windows.Forms.DataGridView dgContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblUpdate;
        private System.Windows.Forms.ErrorProvider errZip;
        private System.Windows.Forms.ErrorProvider errPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbOpt;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.GroupBox gbXml;
        private System.Windows.Forms.GroupBox gbText;
    }
}

