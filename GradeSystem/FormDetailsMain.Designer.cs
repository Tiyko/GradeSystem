namespace GradeSystem
{
    partial class FormDetailsMain
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
            this.BTNclose = new System.Windows.Forms.Button();
            this.LBLperson = new System.Windows.Forms.Label();
            this.CLBdetails = new System.Windows.Forms.CheckedListBox();
            this.LBLfirstName = new System.Windows.Forms.Label();
            this.LBLlastName = new System.Windows.Forms.Label();
            this.TXTBfirstName = new System.Windows.Forms.TextBox();
            this.TXTBlastName = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.RBteacher = new System.Windows.Forms.RadioButton();
            this.RBstudent = new System.Windows.Forms.RadioButton();
            this.CLBmodules = new System.Windows.Forms.CheckedListBox();
            this.TXTBgrade = new System.Windows.Forms.TextBox();
            this.TXTBmodule = new System.Windows.Forms.TextBox();
            this.LBLgradeName = new System.Windows.Forms.Label();
            this.LBLmodName = new System.Windows.Forms.Label();
            this.GBBulk = new System.Windows.Forms.GroupBox();
            this.BTNimport = new System.Windows.Forms.Button();
            this.TXTBfile = new System.Windows.Forms.TextBox();
            this.BTNfile = new System.Windows.Forms.Button();
            this.LBLfile = new System.Windows.Forms.Label();
            this.RBcsv = new System.Windows.Forms.RadioButton();
            this.RBxml = new System.Windows.Forms.RadioButton();
            this.BTNdeleteMod = new System.Windows.Forms.Button();
            this.BTNupdateMod = new System.Windows.Forms.Button();
            this.BTNaddMod = new System.Windows.Forms.Button();
            this.LBLinfo = new System.Windows.Forms.Label();
            this.PANELinfo = new System.Windows.Forms.Panel();
            this.LBLinfoPanel = new System.Windows.Forms.Label();
            this.GB.SuspendLayout();
            this.GBBulk.SuspendLayout();
            this.PANELinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNclose
            // 
            this.BTNclose.Location = new System.Drawing.Point(1007, 613);
            this.BTNclose.Margin = new System.Windows.Forms.Padding(4);
            this.BTNclose.Name = "BTNclose";
            this.BTNclose.Size = new System.Drawing.Size(91, 36);
            this.BTNclose.TabIndex = 5;
            this.BTNclose.Text = "EXIT";
            this.BTNclose.UseVisualStyleBackColor = true;
            this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
            // 
            // LBLperson
            // 
            this.LBLperson.AutoSize = true;
            this.LBLperson.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLperson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLperson.Location = new System.Drawing.Point(545, 24);
            this.LBLperson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLperson.Name = "LBLperson";
            this.LBLperson.Size = new System.Drawing.Size(170, 23);
            this.LBLperson.TabIndex = 6;
            this.LBLperson.Text = "Select Teacher";
            this.LBLperson.Click += new System.EventHandler(this.LBLperson_Click);
            // 
            // CLBdetails
            // 
            this.CLBdetails.CheckOnClick = true;
            this.CLBdetails.ColumnWidth = 200;
            this.CLBdetails.FormattingEnabled = true;
            this.CLBdetails.Location = new System.Drawing.Point(231, 50);
            this.CLBdetails.MultiColumn = true;
            this.CLBdetails.Name = "CLBdetails";
            this.CLBdetails.Size = new System.Drawing.Size(867, 277);
            this.CLBdetails.TabIndex = 7;
            this.CLBdetails.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBdetails_ItemCheck);
            this.CLBdetails.SelectedIndexChanged += new System.EventHandler(this.CLBdetails_SelectedIndexChanged);
            // 
            // LBLfirstName
            // 
            this.LBLfirstName.AutoSize = true;
            this.LBLfirstName.Location = new System.Drawing.Point(15, 134);
            this.LBLfirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLfirstName.Name = "LBLfirstName";
            this.LBLfirstName.Size = new System.Drawing.Size(101, 18);
            this.LBLfirstName.TabIndex = 9;
            this.LBLfirstName.Text = "First Name: ";
            // 
            // LBLlastName
            // 
            this.LBLlastName.AutoSize = true;
            this.LBLlastName.Location = new System.Drawing.Point(15, 198);
            this.LBLlastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLlastName.Name = "LBLlastName";
            this.LBLlastName.Size = new System.Drawing.Size(95, 18);
            this.LBLlastName.TabIndex = 10;
            this.LBLlastName.Text = "Last Name:";
            // 
            // TXTBfirstName
            // 
            this.TXTBfirstName.Location = new System.Drawing.Point(18, 155);
            this.TXTBfirstName.Name = "TXTBfirstName";
            this.TXTBfirstName.ReadOnly = true;
            this.TXTBfirstName.Size = new System.Drawing.Size(207, 26);
            this.TXTBfirstName.TabIndex = 15;
            this.TXTBfirstName.TextChanged += new System.EventHandler(this.TXTB_TextChanged);
            // 
            // TXTBlastName
            // 
            this.TXTBlastName.Location = new System.Drawing.Point(18, 219);
            this.TXTBlastName.Name = "TXTBlastName";
            this.TXTBlastName.ReadOnly = true;
            this.TXTBlastName.Size = new System.Drawing.Size(207, 26);
            this.TXTBlastName.TabIndex = 16;
            this.TXTBlastName.TextChanged += new System.EventHandler(this.TXTB_TextChanged);
            // 
            // BTNadd
            // 
            this.BTNadd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadd.Location = new System.Drawing.Point(231, 18);
            this.BTNadd.Margin = new System.Windows.Forms.Padding(4);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(114, 25);
            this.BTNadd.TabIndex = 18;
            this.BTNadd.Text = "NEW TEACHER";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // BTNupdate
            // 
            this.BTNupdate.Enabled = false;
            this.BTNupdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNupdate.Location = new System.Drawing.Point(783, 18);
            this.BTNupdate.Margin = new System.Windows.Forms.Padding(4);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(156, 24);
            this.BTNupdate.TabIndex = 19;
            this.BTNupdate.Text = "UPDATE TEACHER";
            this.BTNupdate.UseVisualStyleBackColor = true;
            this.BTNupdate.Click += new System.EventHandler(this.BTNupdate_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Enabled = false;
            this.BTNdelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(947, 19);
            this.BTNdelete.Margin = new System.Windows.Forms.Padding(4);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(136, 24);
            this.BTNdelete.TabIndex = 20;
            this.BTNdelete.Text = "DELETE TEACHER";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // GB
            // 
            this.GB.Controls.Add(this.RBteacher);
            this.GB.Controls.Add(this.RBstudent);
            this.GB.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB.Location = new System.Drawing.Point(12, 12);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(190, 47);
            this.GB.TabIndex = 21;
            this.GB.TabStop = false;
            this.GB.Text = "Click to change";
            // 
            // RBteacher
            // 
            this.RBteacher.AutoSize = true;
            this.RBteacher.Checked = true;
            this.RBteacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBteacher.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RBteacher.Location = new System.Drawing.Point(6, 16);
            this.RBteacher.Name = "RBteacher";
            this.RBteacher.Size = new System.Drawing.Size(83, 20);
            this.RBteacher.TabIndex = 1;
            this.RBteacher.TabStop = true;
            this.RBteacher.Text = "Teacher";
            this.RBteacher.UseVisualStyleBackColor = true;
            this.RBteacher.CheckedChanged += new System.EventHandler(this.RBstatus_CheckedChanged);
            // 
            // RBstudent
            // 
            this.RBstudent.AutoSize = true;
            this.RBstudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBstudent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RBstudent.Location = new System.Drawing.Point(93, 16);
            this.RBstudent.Name = "RBstudent";
            this.RBstudent.Size = new System.Drawing.Size(82, 20);
            this.RBstudent.TabIndex = 0;
            this.RBstudent.Text = "Student";
            this.RBstudent.UseVisualStyleBackColor = true;
            this.RBstudent.CheckedChanged += new System.EventHandler(this.RBstatus_CheckedChanged);
            // 
            // CLBmodules
            // 
            this.CLBmodules.CheckOnClick = true;
            this.CLBmodules.ColumnWidth = 200;
            this.CLBmodules.FormattingEnabled = true;
            this.CLBmodules.Location = new System.Drawing.Point(231, 342);
            this.CLBmodules.MultiColumn = true;
            this.CLBmodules.Name = "CLBmodules";
            this.CLBmodules.Size = new System.Drawing.Size(529, 130);
            this.CLBmodules.TabIndex = 22;
            this.CLBmodules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBmodules_ItemCheck);
            this.CLBmodules.SelectedIndexChanged += new System.EventHandler(this.CLBmoduleDetails_SelectedIndexChanged);
            // 
            // TXTBgrade
            // 
            this.TXTBgrade.Location = new System.Drawing.Point(18, 429);
            this.TXTBgrade.Name = "TXTBgrade";
            this.TXTBgrade.ReadOnly = true;
            this.TXTBgrade.Size = new System.Drawing.Size(207, 26);
            this.TXTBgrade.TabIndex = 26;
            this.TXTBgrade.Visible = false;
            this.TXTBgrade.TextChanged += new System.EventHandler(this.TXTBgrade_TextChanged);
            // 
            // TXTBmodule
            // 
            this.TXTBmodule.Location = new System.Drawing.Point(18, 366);
            this.TXTBmodule.Name = "TXTBmodule";
            this.TXTBmodule.ReadOnly = true;
            this.TXTBmodule.Size = new System.Drawing.Size(207, 26);
            this.TXTBmodule.TabIndex = 25;
            this.TXTBmodule.TextChanged += new System.EventHandler(this.TXTBmodule_TextChanged);
            // 
            // LBLgradeName
            // 
            this.LBLgradeName.AutoSize = true;
            this.LBLgradeName.Location = new System.Drawing.Point(15, 408);
            this.LBLgradeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLgradeName.Name = "LBLgradeName";
            this.LBLgradeName.Size = new System.Drawing.Size(60, 18);
            this.LBLgradeName.TabIndex = 24;
            this.LBLgradeName.Text = "Grade:";
            this.LBLgradeName.Visible = false;
            this.LBLgradeName.Click += new System.EventHandler(this.LBLgradeName_Click);
            // 
            // LBLmodName
            // 
            this.LBLmodName.AutoSize = true;
            this.LBLmodName.Location = new System.Drawing.Point(15, 342);
            this.LBLmodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmodName.Name = "LBLmodName";
            this.LBLmodName.Size = new System.Drawing.Size(122, 18);
            this.LBLmodName.TabIndex = 23;
            this.LBLmodName.Text = "Module Name: ";
            this.LBLmodName.Click += new System.EventHandler(this.LBLmodName_Click);
            // 
            // GBBulk
            // 
            this.GBBulk.Controls.Add(this.BTNimport);
            this.GBBulk.Controls.Add(this.TXTBfile);
            this.GBBulk.Controls.Add(this.BTNfile);
            this.GBBulk.Controls.Add(this.LBLfile);
            this.GBBulk.Controls.Add(this.RBcsv);
            this.GBBulk.Controls.Add(this.RBxml);
            this.GBBulk.Location = new System.Drawing.Point(777, 342);
            this.GBBulk.Name = "GBBulk";
            this.GBBulk.Size = new System.Drawing.Size(322, 158);
            this.GBBulk.TabIndex = 27;
            this.GBBulk.TabStop = false;
            this.GBBulk.Text = "Bulk Imports";
            this.GBBulk.Visible = false;
            this.GBBulk.Enter += new System.EventHandler(this.GBBulk_Enter);
            // 
            // BTNimport
            // 
            this.BTNimport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNimport.Location = new System.Drawing.Point(192, 102);
            this.BTNimport.Name = "BTNimport";
            this.BTNimport.Size = new System.Drawing.Size(84, 24);
            this.BTNimport.TabIndex = 29;
            this.BTNimport.Text = "IMPORT";
            this.BTNimport.UseVisualStyleBackColor = true;
            this.BTNimport.Click += new System.EventHandler(this.BTNimport_Click);
            // 
            // TXTBfile
            // 
            this.TXTBfile.Location = new System.Drawing.Point(50, 70);
            this.TXTBfile.Name = "TXTBfile";
            this.TXTBfile.ReadOnly = true;
            this.TXTBfile.Size = new System.Drawing.Size(226, 26);
            this.TXTBfile.TabIndex = 28;
            this.TXTBfile.TextChanged += new System.EventHandler(this.TXTBfile_TextChanged);
            // 
            // BTNfile
            // 
            this.BTNfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfile.Location = new System.Drawing.Point(50, 102);
            this.BTNfile.Name = "BTNfile";
            this.BTNfile.Size = new System.Drawing.Size(45, 23);
            this.BTNfile.TabIndex = 28;
            this.BTNfile.Text = "FILE";
            this.BTNfile.UseVisualStyleBackColor = true;
            this.BTNfile.Click += new System.EventHandler(this.BTNfile_Click);
            // 
            // LBLfile
            // 
            this.LBLfile.AutoSize = true;
            this.LBLfile.Location = new System.Drawing.Point(119, 46);
            this.LBLfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLfile.Name = "LBLfile";
            this.LBLfile.Size = new System.Drawing.Size(82, 18);
            this.LBLfile.TabIndex = 28;
            this.LBLfile.Text = "Select File";
            this.LBLfile.Click += new System.EventHandler(this.LBLfile_Click);
            // 
            // RBcsv
            // 
            this.RBcsv.AutoSize = true;
            this.RBcsv.Location = new System.Drawing.Point(69, 21);
            this.RBcsv.Name = "RBcsv";
            this.RBcsv.Size = new System.Drawing.Size(57, 22);
            this.RBcsv.TabIndex = 2;
            this.RBcsv.Text = "CSV";
            this.RBcsv.UseVisualStyleBackColor = true;
            this.RBcsv.CheckedChanged += new System.EventHandler(this.RBcsv_CheckedChanged);
            // 
            // RBxml
            // 
            this.RBxml.AutoSize = true;
            this.RBxml.Checked = true;
            this.RBxml.Location = new System.Drawing.Point(6, 21);
            this.RBxml.Name = "RBxml";
            this.RBxml.Size = new System.Drawing.Size(57, 22);
            this.RBxml.TabIndex = 2;
            this.RBxml.TabStop = true;
            this.RBxml.Text = "XML";
            this.RBxml.UseVisualStyleBackColor = true;
            this.RBxml.CheckedChanged += new System.EventHandler(this.RBxml_CheckedChanged);
            // 
            // BTNdeleteMod
            // 
            this.BTNdeleteMod.Enabled = false;
            this.BTNdeleteMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdeleteMod.Location = new System.Drawing.Point(695, 474);
            this.BTNdeleteMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNdeleteMod.Name = "BTNdeleteMod";
            this.BTNdeleteMod.Size = new System.Drawing.Size(65, 24);
            this.BTNdeleteMod.TabIndex = 30;
            this.BTNdeleteMod.Text = "DELETE";
            this.BTNdeleteMod.UseVisualStyleBackColor = true;
            this.BTNdeleteMod.Click += new System.EventHandler(this.BTNdeleteMod_Click);
            // 
            // BTNupdateMod
            // 
            this.BTNupdateMod.Enabled = false;
            this.BTNupdateMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNupdateMod.Location = new System.Drawing.Point(617, 476);
            this.BTNupdateMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNupdateMod.Name = "BTNupdateMod";
            this.BTNupdateMod.Size = new System.Drawing.Size(70, 21);
            this.BTNupdateMod.TabIndex = 29;
            this.BTNupdateMod.Text = "UPDATE";
            this.BTNupdateMod.UseVisualStyleBackColor = true;
            this.BTNupdateMod.Click += new System.EventHandler(this.BTNupdateMod_Click);
            // 
            // BTNaddMod
            // 
            this.BTNaddMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddMod.Location = new System.Drawing.Point(231, 474);
            this.BTNaddMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNaddMod.Name = "BTNaddMod";
            this.BTNaddMod.Size = new System.Drawing.Size(108, 26);
            this.BTNaddMod.TabIndex = 28;
            this.BTNaddMod.Text = "NEW MODULE";
            this.BTNaddMod.UseVisualStyleBackColor = true;
            this.BTNaddMod.Click += new System.EventHandler(this.BTNaddMod_Click);
            // 
            // LBLinfo
            // 
            this.LBLinfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBLinfo.AutoSize = true;
            this.LBLinfo.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLinfo.Location = new System.Drawing.Point(122, 2);
            this.LBLinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLinfo.Name = "LBLinfo";
            this.LBLinfo.Size = new System.Drawing.Size(0, 16);
            this.LBLinfo.TabIndex = 31;
            this.LBLinfo.Click += new System.EventHandler(this.LBLinfo_Click);
            // 
            // PANELinfo
            // 
            this.PANELinfo.AutoScroll = true;
            this.PANELinfo.Controls.Add(this.LBLinfoPanel);
            this.PANELinfo.Controls.Add(this.LBLinfo);
            this.PANELinfo.Location = new System.Drawing.Point(18, 504);
            this.PANELinfo.Name = "PANELinfo";
            this.PANELinfo.Size = new System.Drawing.Size(960, 145);
            this.PANELinfo.TabIndex = 33;
            this.PANELinfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PANELinfo_Paint);
            // 
            // LBLinfoPanel
            // 
            this.LBLinfoPanel.AutoSize = true;
            this.LBLinfoPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinfoPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLinfoPanel.Location = new System.Drawing.Point(3, 0);
            this.LBLinfoPanel.Name = "LBLinfoPanel";
            this.LBLinfoPanel.Size = new System.Drawing.Size(119, 18);
            this.LBLinfoPanel.TabIndex = 33;
            this.LBLinfoPanel.Text = "Information:";
            // 
            // FormDetailsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 656);
            this.Controls.Add(this.PANELinfo);
            this.Controls.Add(this.BTNdeleteMod);
            this.Controls.Add(this.BTNupdateMod);
            this.Controls.Add(this.BTNaddMod);
            this.Controls.Add(this.GBBulk);
            this.Controls.Add(this.TXTBgrade);
            this.Controls.Add(this.TXTBmodule);
            this.Controls.Add(this.LBLgradeName);
            this.Controls.Add(this.LBLmodName);
            this.Controls.Add(this.CLBmodules);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNupdate);
            this.Controls.Add(this.BTNadd);
            this.Controls.Add(this.TXTBlastName);
            this.Controls.Add(this.TXTBfirstName);
            this.Controls.Add(this.LBLlastName);
            this.Controls.Add(this.LBLfirstName);
            this.Controls.Add(this.CLBdetails);
            this.Controls.Add(this.LBLperson);
            this.Controls.Add(this.BTNclose);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDetailsMain";
            this.Text = "Teacher Details";
            this.Load += new System.EventHandler(this.FormDetailsMain_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.GBBulk.ResumeLayout(false);
            this.GBBulk.PerformLayout();
            this.PANELinfo.ResumeLayout(false);
            this.PANELinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNclose;
        private System.Windows.Forms.Label LBLperson;
        private System.Windows.Forms.CheckedListBox CLBdetails;
        private System.Windows.Forms.Label LBLfirstName;
        private System.Windows.Forms.Label LBLlastName;
        private System.Windows.Forms.TextBox TXTBfirstName;
        private System.Windows.Forms.TextBox TXTBlastName;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNupdate;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.RadioButton RBteacher;
        private System.Windows.Forms.RadioButton RBstudent;
        private System.Windows.Forms.CheckedListBox CLBmodules;
        private System.Windows.Forms.TextBox TXTBgrade;
        private System.Windows.Forms.TextBox TXTBmodule;
        private System.Windows.Forms.Label LBLgradeName;
        private System.Windows.Forms.Label LBLmodName;
        private System.Windows.Forms.GroupBox GBBulk;
        private System.Windows.Forms.RadioButton RBxml;
        private System.Windows.Forms.RadioButton RBcsv;
        private System.Windows.Forms.Label LBLfile;
        private System.Windows.Forms.Button BTNfile;
        private System.Windows.Forms.Button BTNimport;
        private System.Windows.Forms.TextBox TXTBfile;
        private System.Windows.Forms.Button BTNdeleteMod;
        private System.Windows.Forms.Button BTNupdateMod;
        private System.Windows.Forms.Button BTNaddMod;
        private System.Windows.Forms.Label LBLinfo;
        private System.Windows.Forms.Panel PANELinfo;
        private System.Windows.Forms.Label LBLinfoPanel;
    }
}