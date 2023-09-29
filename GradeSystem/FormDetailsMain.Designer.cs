﻿namespace GradeSystem
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
            this.TXTBoxFirstName = new System.Windows.Forms.TextBox();
            this.TXTBoxLastName = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.GBox = new System.Windows.Forms.GroupBox();
            this.RBteacher = new System.Windows.Forms.RadioButton();
            this.RBstudent = new System.Windows.Forms.RadioButton();
            this.CLBmodules = new System.Windows.Forms.CheckedListBox();
            this.TXTBoxGrade = new System.Windows.Forms.TextBox();
            this.TXTBoxModule = new System.Windows.Forms.TextBox();
            this.LBLgradeName = new System.Windows.Forms.Label();
            this.LBLmodName = new System.Windows.Forms.Label();
            this.GBoxBulk = new System.Windows.Forms.GroupBox();
            this.BTNimport = new System.Windows.Forms.Button();
            this.TXTBoxFile = new System.Windows.Forms.TextBox();
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
            this.GBox.SuspendLayout();
            this.GBoxBulk.SuspendLayout();
            this.PANELinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNClose
            // 
            this.BTNclose.Location = new System.Drawing.Point(1007, 613);
            this.BTNclose.Margin = new System.Windows.Forms.Padding(4);
            this.BTNclose.Name = "BTNClose";
            this.BTNclose.Size = new System.Drawing.Size(91, 36);
            this.BTNclose.TabIndex = 5;
            this.BTNclose.Text = "EXIT";
            this.BTNclose.UseVisualStyleBackColor = true;
            this.BTNclose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // LBLPerson
            // 
            this.LBLperson.AutoSize = true;
            this.LBLperson.Location = new System.Drawing.Point(102, 92);
            this.LBLperson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLperson.Name = "LBLPerson";
            this.LBLperson.Size = new System.Drawing.Size(122, 18);
            this.LBLperson.TabIndex = 6;
            this.LBLperson.Text = "Select Teacher:";
            this.LBLperson.Click += new System.EventHandler(this.LBLPerson_Click);
            // 
            // CLBDetails
            // 
            this.CLBdetails.CheckOnClick = true;
            this.CLBdetails.ColumnWidth = 200;
            this.CLBdetails.FormattingEnabled = true;
            this.CLBdetails.Location = new System.Drawing.Point(231, 50);
            this.CLBdetails.MultiColumn = true;
            this.CLBdetails.Name = "CLBDetails";
            this.CLBdetails.Size = new System.Drawing.Size(867, 277);
            this.CLBdetails.TabIndex = 7;
            this.CLBdetails.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBDetails_ItemCheck);
            this.CLBdetails.SelectedIndexChanged += new System.EventHandler(this.CLBDetails_SelectedIndexChanged);
            // 
            // label3
            // 
            this.LBLfirstName.AutoSize = true;
            this.LBLfirstName.Location = new System.Drawing.Point(15, 183);
            this.LBLfirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLfirstName.Name = "label3";
            this.LBLfirstName.Size = new System.Drawing.Size(101, 18);
            this.LBLfirstName.TabIndex = 9;
            this.LBLfirstName.Text = "First Name: ";
            // 
            // label4
            // 
            this.LBLlastName.AutoSize = true;
            this.LBLlastName.Location = new System.Drawing.Point(15, 247);
            this.LBLlastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLlastName.Name = "label4";
            this.LBLlastName.Size = new System.Drawing.Size(95, 18);
            this.LBLlastName.TabIndex = 10;
            this.LBLlastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.TXTBoxFirstName.Location = new System.Drawing.Point(18, 204);
            this.TXTBoxFirstName.Name = "textBoxFirstName";
            this.TXTBoxFirstName.ReadOnly = true;
            this.TXTBoxFirstName.Size = new System.Drawing.Size(207, 26);
            this.TXTBoxFirstName.TabIndex = 15;
            this.TXTBoxFirstName.TextChanged += new System.EventHandler(this.TXTBox_TextChanged);
            // 
            // textBoxLastName
            // 
            this.TXTBoxLastName.Location = new System.Drawing.Point(18, 268);
            this.TXTBoxLastName.Name = "textBoxLastName";
            this.TXTBoxLastName.ReadOnly = true;
            this.TXTBoxLastName.Size = new System.Drawing.Size(207, 26);
            this.TXTBoxLastName.TabIndex = 16;
            this.TXTBoxLastName.TextChanged += new System.EventHandler(this.TXTBox_TextChanged);
            // 
            // BtnAdd
            // 
            this.BTNadd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadd.Location = new System.Drawing.Point(231, 18);
            this.BTNadd.Margin = new System.Windows.Forms.Padding(4);
            this.BTNadd.Name = "BtnAdd";
            this.BTNadd.Size = new System.Drawing.Size(114, 25);
            this.BTNadd.TabIndex = 18;
            this.BTNadd.Text = "NEW TEACHER";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BTNupdate.Enabled = false;
            this.BTNupdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNupdate.Location = new System.Drawing.Point(942, 19);
            this.BTNupdate.Margin = new System.Windows.Forms.Padding(4);
            this.BTNupdate.Name = "BtnUpdate";
            this.BTNupdate.Size = new System.Drawing.Size(74, 24);
            this.BTNupdate.TabIndex = 19;
            this.BTNupdate.Text = "UPDATE";
            this.BTNupdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BTNdelete.Enabled = false;
            this.BTNdelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdelete.Location = new System.Drawing.Point(1024, 19);
            this.BTNdelete.Margin = new System.Windows.Forms.Padding(4);
            this.BTNdelete.Name = "BtnDelete";
            this.BTNdelete.Size = new System.Drawing.Size(74, 24);
            this.BTNdelete.TabIndex = 20;
            this.BTNdelete.Text = "DELETE";
            this.BTNdelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.GBox.Controls.Add(this.RBteacher);
            this.GBox.Controls.Add(this.RBstudent);
            this.GBox.Location = new System.Drawing.Point(12, 12);
            this.GBox.Name = "groupBox1";
            this.GBox.Size = new System.Drawing.Size(190, 47);
            this.GBox.TabIndex = 21;
            this.GBox.TabStop = false;
            this.GBox.Text = "Status";
            // 
            // RBTeacher
            // 
            this.RBteacher.AutoSize = true;
            this.RBteacher.Checked = true;
            this.RBteacher.Location = new System.Drawing.Point(6, 16);
            this.RBteacher.Name = "RBTeacher";
            this.RBteacher.Size = new System.Drawing.Size(83, 22);
            this.RBteacher.TabIndex = 1;
            this.RBteacher.TabStop = true;
            this.RBteacher.Text = "Teacher";
            this.RBteacher.UseVisualStyleBackColor = true;
            this.RBteacher.CheckedChanged += new System.EventHandler(this.RBStatus_CheckedChanged);
            // 
            // RBStudent
            // 
            this.RBstudent.AutoSize = true;
            this.RBstudent.Location = new System.Drawing.Point(93, 16);
            this.RBstudent.Name = "RBStudent";
            this.RBstudent.Size = new System.Drawing.Size(84, 22);
            this.RBstudent.TabIndex = 0;
            this.RBstudent.Text = "Student";
            this.RBstudent.UseVisualStyleBackColor = true;
            this.RBstudent.CheckedChanged += new System.EventHandler(this.RBStatus_CheckedChanged);
            // 
            // CLBModules
            // 
            this.CLBmodules.CheckOnClick = true;
            this.CLBmodules.ColumnWidth = 200;
            this.CLBmodules.FormattingEnabled = true;
            this.CLBmodules.Location = new System.Drawing.Point(231, 342);
            this.CLBmodules.MultiColumn = true;
            this.CLBmodules.Name = "CLBModules";
            this.CLBmodules.Size = new System.Drawing.Size(529, 130);
            this.CLBmodules.TabIndex = 22;
            this.CLBmodules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBModules_ItemCheck);
            this.CLBmodules.SelectedIndexChanged += new System.EventHandler(this.CLBModuleDetails_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.TXTBoxGrade.Location = new System.Drawing.Point(18, 429);
            this.TXTBoxGrade.Name = "textBoxGrade";
            this.TXTBoxGrade.ReadOnly = true;
            this.TXTBoxGrade.Size = new System.Drawing.Size(207, 26);
            this.TXTBoxGrade.TabIndex = 26;
            this.TXTBoxGrade.Visible = false;
            this.TXTBoxGrade.TextChanged += new System.EventHandler(this.TXTBoxGrade_TextChanged);
            // 
            // textBoxModule
            // 
            this.TXTBoxModule.Location = new System.Drawing.Point(18, 366);
            this.TXTBoxModule.Name = "textBoxModule";
            this.TXTBoxModule.ReadOnly = true;
            this.TXTBoxModule.Size = new System.Drawing.Size(207, 26);
            this.TXTBoxModule.TabIndex = 25;
            this.TXTBoxModule.TextChanged += new System.EventHandler(this.TXTBoxModule_TextChanged);
            // 
            // LBLGradeName
            // 
            this.LBLgradeName.AutoSize = true;
            this.LBLgradeName.Location = new System.Drawing.Point(15, 408);
            this.LBLgradeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLgradeName.Name = "LBLGradeName";
            this.LBLgradeName.Size = new System.Drawing.Size(60, 18);
            this.LBLgradeName.TabIndex = 24;
            this.LBLgradeName.Text = "Grade:";
            this.LBLgradeName.Visible = false;
            this.LBLgradeName.Click += new System.EventHandler(this.LBLGradeName_Click);
            // 
            // LBLModName
            // 
            this.LBLmodName.AutoSize = true;
            this.LBLmodName.Location = new System.Drawing.Point(15, 342);
            this.LBLmodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmodName.Name = "LBLModName";
            this.LBLmodName.Size = new System.Drawing.Size(122, 18);
            this.LBLmodName.TabIndex = 23;
            this.LBLmodName.Text = "Module Name: ";
            this.LBLmodName.Click += new System.EventHandler(this.LBLModName_Click);
            // 
            // groupBoxBulk
            // 
            this.GBoxBulk.Controls.Add(this.BTNimport);
            this.GBoxBulk.Controls.Add(this.TXTBoxFile);
            this.GBoxBulk.Controls.Add(this.BTNfile);
            this.GBoxBulk.Controls.Add(this.LBLfile);
            this.GBoxBulk.Controls.Add(this.RBcsv);
            this.GBoxBulk.Controls.Add(this.RBxml);
            this.GBoxBulk.Location = new System.Drawing.Point(777, 342);
            this.GBoxBulk.Name = "groupBoxBulk";
            this.GBoxBulk.Size = new System.Drawing.Size(322, 158);
            this.GBoxBulk.TabIndex = 27;
            this.GBoxBulk.TabStop = false;
            this.GBoxBulk.Text = "Bulk Imports";
            this.GBoxBulk.Visible = false;
            this.GBoxBulk.Enter += new System.EventHandler(this.GBoxBulk_Enter);
            // 
            // BTNImport
            // 
            this.BTNimport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNimport.Location = new System.Drawing.Point(192, 102);
            this.BTNimport.Name = "BTNImport";
            this.BTNimport.Size = new System.Drawing.Size(84, 24);
            this.BTNimport.TabIndex = 29;
            this.BTNimport.Text = "IMPORT";
            this.BTNimport.UseVisualStyleBackColor = true;
            this.BTNimport.Click += new System.EventHandler(this.BTNImport_Click);
            // 
            // TXTBoxFile
            // 
            this.TXTBoxFile.Location = new System.Drawing.Point(50, 70);
            this.TXTBoxFile.Name = "TXTBoxFile";
            this.TXTBoxFile.ReadOnly = true;
            this.TXTBoxFile.Size = new System.Drawing.Size(226, 26);
            this.TXTBoxFile.TabIndex = 28;
            this.TXTBoxFile.TextChanged += new System.EventHandler(this.TXTBoxFile_TextChanged);
            // 
            // BTNFile
            // 
            this.BTNfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfile.Location = new System.Drawing.Point(50, 102);
            this.BTNfile.Name = "BTNFile";
            this.BTNfile.Size = new System.Drawing.Size(45, 23);
            this.BTNfile.TabIndex = 28;
            this.BTNfile.Text = "FILE";
            this.BTNfile.UseVisualStyleBackColor = true;
            this.BTNfile.Click += new System.EventHandler(this.BTNFile_Click);
            // 
            // label1
            // 
            this.LBLfile.AutoSize = true;
            this.LBLfile.Location = new System.Drawing.Point(119, 46);
            this.LBLfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLfile.Name = "label1";
            this.LBLfile.Size = new System.Drawing.Size(82, 18);
            this.LBLfile.TabIndex = 28;
            this.LBLfile.Text = "Select File";
            this.LBLfile.Click += new System.EventHandler(this.LBLSelectFile_Click);
            // 
            // RBCSV
            // 
            this.RBcsv.AutoSize = true;
            this.RBcsv.Location = new System.Drawing.Point(69, 21);
            this.RBcsv.Name = "RBCSV";
            this.RBcsv.Size = new System.Drawing.Size(57, 22);
            this.RBcsv.TabIndex = 2;
            this.RBcsv.Text = "CSV";
            this.RBcsv.UseVisualStyleBackColor = true;
            this.RBcsv.CheckedChanged += new System.EventHandler(this.RBCSV_CheckedChanged);
            // 
            // RBXML
            // 
            this.RBxml.AutoSize = true;
            this.RBxml.Checked = true;
            this.RBxml.Location = new System.Drawing.Point(6, 21);
            this.RBxml.Name = "RBXML";
            this.RBxml.Size = new System.Drawing.Size(57, 22);
            this.RBxml.TabIndex = 2;
            this.RBxml.TabStop = true;
            this.RBxml.Text = "XML";
            this.RBxml.UseVisualStyleBackColor = true;
            this.RBxml.CheckedChanged += new System.EventHandler(this.RBXML_CheckedChanged);
            // 
            // BTNDeleteMod
            // 
            this.BTNdeleteMod.Enabled = false;
            this.BTNdeleteMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdeleteMod.Location = new System.Drawing.Point(695, 474);
            this.BTNdeleteMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNdeleteMod.Name = "BTNDeleteMod";
            this.BTNdeleteMod.Size = new System.Drawing.Size(65, 24);
            this.BTNdeleteMod.TabIndex = 30;
            this.BTNdeleteMod.Text = "DELETE";
            this.BTNdeleteMod.UseVisualStyleBackColor = true;
            this.BTNdeleteMod.Click += new System.EventHandler(this.BTNDeleteMod_Click);
            // 
            // BTNUpdateMod
            // 
            this.BTNupdateMod.Enabled = false;
            this.BTNupdateMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNupdateMod.Location = new System.Drawing.Point(617, 476);
            this.BTNupdateMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNupdateMod.Name = "BTNUpdateMod";
            this.BTNupdateMod.Size = new System.Drawing.Size(70, 21);
            this.BTNupdateMod.TabIndex = 29;
            this.BTNupdateMod.Text = "UPDATE";
            this.BTNupdateMod.UseVisualStyleBackColor = true;
            this.BTNupdateMod.Click += new System.EventHandler(this.BTNUpdateMod_Click);
            // 
            // BTNAddMod
            // 
            this.BTNaddMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNaddMod.Location = new System.Drawing.Point(231, 474);
            this.BTNaddMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNaddMod.Name = "BTNAddMod";
            this.BTNaddMod.Size = new System.Drawing.Size(108, 26);
            this.BTNaddMod.TabIndex = 28;
            this.BTNaddMod.Text = "NEW MODULE";
            this.BTNaddMod.UseVisualStyleBackColor = true;
            this.BTNaddMod.Click += new System.EventHandler(this.BTNAddMod_Click);
            // 
            // LBLInfo
            // 
            this.LBLinfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBLinfo.AutoSize = true;
            this.LBLinfo.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLinfo.Location = new System.Drawing.Point(122, 2);
            this.LBLinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLinfo.Name = "LBLInfo";
            this.LBLinfo.Size = new System.Drawing.Size(0, 16);
            this.LBLinfo.TabIndex = 31;
            this.LBLinfo.Click += new System.EventHandler(this.LBLInfo_Click);
            // 
            // PANELInfo
            // 
            this.PANELinfo.AutoScroll = true;
            this.PANELinfo.Controls.Add(this.LBLinfoPanel);
            this.PANELinfo.Controls.Add(this.LBLinfo);
            this.PANELinfo.Location = new System.Drawing.Point(18, 504);
            this.PANELinfo.Name = "PANELInfo";
            this.PANELinfo.Size = new System.Drawing.Size(960, 145);
            this.PANELinfo.TabIndex = 33;
            this.PANELinfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PANELInfo_Paint);
            // 
            // LBLInfoPanel
            // 
            this.LBLinfoPanel.AutoSize = true;
            this.LBLinfoPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinfoPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLinfoPanel.Location = new System.Drawing.Point(3, 0);
            this.LBLinfoPanel.Name = "LBLInfoPanel";
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
            this.Controls.Add(this.GBoxBulk);
            this.Controls.Add(this.TXTBoxGrade);
            this.Controls.Add(this.TXTBoxModule);
            this.Controls.Add(this.LBLgradeName);
            this.Controls.Add(this.LBLmodName);
            this.Controls.Add(this.CLBmodules);
            this.Controls.Add(this.GBox);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.BTNupdate);
            this.Controls.Add(this.BTNadd);
            this.Controls.Add(this.TXTBoxLastName);
            this.Controls.Add(this.TXTBoxFirstName);
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
            this.GBox.ResumeLayout(false);
            this.GBox.PerformLayout();
            this.GBoxBulk.ResumeLayout(false);
            this.GBoxBulk.PerformLayout();
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
        private System.Windows.Forms.TextBox TXTBoxFirstName;
        private System.Windows.Forms.TextBox TXTBoxLastName;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNupdate;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.GroupBox GBox;
        private System.Windows.Forms.RadioButton RBteacher;
        private System.Windows.Forms.RadioButton RBstudent;
        private System.Windows.Forms.CheckedListBox CLBmodules;
        private System.Windows.Forms.TextBox TXTBoxGrade;
        private System.Windows.Forms.TextBox TXTBoxModule;
        private System.Windows.Forms.Label LBLgradeName;
        private System.Windows.Forms.Label LBLmodName;
        private System.Windows.Forms.GroupBox GBoxBulk;
        private System.Windows.Forms.RadioButton RBxml;
        private System.Windows.Forms.RadioButton RBcsv;
        private System.Windows.Forms.Label LBLfile;
        private System.Windows.Forms.Button BTNfile;
        private System.Windows.Forms.Button BTNimport;
        private System.Windows.Forms.TextBox TXTBoxFile;
        private System.Windows.Forms.Button BTNdeleteMod;
        private System.Windows.Forms.Button BTNupdateMod;
        private System.Windows.Forms.Button BTNaddMod;
        private System.Windows.Forms.Label LBLinfo;
        private System.Windows.Forms.Panel PANELinfo;
        private System.Windows.Forms.Label LBLinfoPanel;
    }
}