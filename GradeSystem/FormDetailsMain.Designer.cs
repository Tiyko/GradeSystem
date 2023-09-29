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
            this.BtnClose = new System.Windows.Forms.Button();
            this.LBLPerson = new System.Windows.Forms.Label();
            this.CLBDetails = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBTeacher = new System.Windows.Forms.RadioButton();
            this.RBStudent = new System.Windows.Forms.RadioButton();
            this.CLBModules = new System.Windows.Forms.CheckedListBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxModule = new System.Windows.Forms.TextBox();
            this.LBLGradeName = new System.Windows.Forms.Label();
            this.LBLModName = new System.Windows.Forms.Label();
            this.groupBoxBulk = new System.Windows.Forms.GroupBox();
            this.BTNImport = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.BTNFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RBCSV = new System.Windows.Forms.RadioButton();
            this.RBXML = new System.Windows.Forms.RadioButton();
            this.BTNDeleteMod = new System.Windows.Forms.Button();
            this.BTNUpdateMod = new System.Windows.Forms.Button();
            this.BTNAddMod = new System.Windows.Forms.Button();
            this.LBLInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxBulk.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(1007, 613);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(91, 36);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "EXIT";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LBLPerson
            // 
            this.LBLPerson.AutoSize = true;
            this.LBLPerson.Location = new System.Drawing.Point(102, 92);
            this.LBLPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLPerson.Name = "LBLPerson";
            this.LBLPerson.Size = new System.Drawing.Size(122, 18);
            this.LBLPerson.TabIndex = 6;
            this.LBLPerson.Text = "Select Teacher:";
            this.LBLPerson.Click += new System.EventHandler(this.LBLPerson_Click);
            // 
            // CLBDetails
            // 
            this.CLBDetails.CheckOnClick = true;
            this.CLBDetails.ColumnWidth = 200;
            this.CLBDetails.FormattingEnabled = true;
            this.CLBDetails.Location = new System.Drawing.Point(231, 50);
            this.CLBDetails.MultiColumn = true;
            this.CLBDetails.Name = "CLBDetails";
            this.CLBDetails.Size = new System.Drawing.Size(867, 277);
            this.CLBDetails.TabIndex = 7;
            this.CLBDetails.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBDetails_ItemCheck);
            this.CLBDetails.SelectedIndexChanged += new System.EventHandler(this.CLBDetails_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(18, 204);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(207, 26);
            this.textBoxFirstName.TabIndex = 15;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(18, 268);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(207, 26);
            this.textBoxLastName.TabIndex = 16;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(231, 18);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 25);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "NEW TEACHER";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(942, 19);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(74, 24);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1024, 19);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(74, 24);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBTeacher);
            this.groupBox1.Controls.Add(this.RBStudent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 47);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // RBTeacher
            // 
            this.RBTeacher.AutoSize = true;
            this.RBTeacher.Checked = true;
            this.RBTeacher.Location = new System.Drawing.Point(6, 16);
            this.RBTeacher.Name = "RBTeacher";
            this.RBTeacher.Size = new System.Drawing.Size(83, 22);
            this.RBTeacher.TabIndex = 1;
            this.RBTeacher.TabStop = true;
            this.RBTeacher.Text = "Teacher";
            this.RBTeacher.UseVisualStyleBackColor = true;
            this.RBTeacher.CheckedChanged += new System.EventHandler(this.RBStatus_CheckedChanged);
            // 
            // RBStudent
            // 
            this.RBStudent.AutoSize = true;
            this.RBStudent.Location = new System.Drawing.Point(93, 16);
            this.RBStudent.Name = "RBStudent";
            this.RBStudent.Size = new System.Drawing.Size(84, 22);
            this.RBStudent.TabIndex = 0;
            this.RBStudent.Text = "Student";
            this.RBStudent.UseVisualStyleBackColor = true;
            this.RBStudent.CheckedChanged += new System.EventHandler(this.RBStatus_CheckedChanged);
            // 
            // CLBModules
            // 
            this.CLBModules.CheckOnClick = true;
            this.CLBModules.ColumnWidth = 200;
            this.CLBModules.FormattingEnabled = true;
            this.CLBModules.Location = new System.Drawing.Point(231, 342);
            this.CLBModules.MultiColumn = true;
            this.CLBModules.Name = "CLBModules";
            this.CLBModules.Size = new System.Drawing.Size(529, 130);
            this.CLBModules.TabIndex = 22;
            this.CLBModules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBModules_ItemCheck);
            this.CLBModules.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(18, 429);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.ReadOnly = true;
            this.textBoxGrade.Size = new System.Drawing.Size(207, 26);
            this.textBoxGrade.TabIndex = 26;
            this.textBoxGrade.Visible = false;
            this.textBoxGrade.TextChanged += new System.EventHandler(this.textBoxGrade_TextChanged);
            // 
            // textBoxModule
            // 
            this.textBoxModule.Location = new System.Drawing.Point(18, 366);
            this.textBoxModule.Name = "textBoxModule";
            this.textBoxModule.ReadOnly = true;
            this.textBoxModule.Size = new System.Drawing.Size(207, 26);
            this.textBoxModule.TabIndex = 25;
            this.textBoxModule.TextChanged += new System.EventHandler(this.textBoxModule_TextChanged);
            // 
            // LBLGradeName
            // 
            this.LBLGradeName.AutoSize = true;
            this.LBLGradeName.Location = new System.Drawing.Point(15, 408);
            this.LBLGradeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLGradeName.Name = "LBLGradeName";
            this.LBLGradeName.Size = new System.Drawing.Size(60, 18);
            this.LBLGradeName.TabIndex = 24;
            this.LBLGradeName.Text = "Grade:";
            this.LBLGradeName.Visible = false;
            this.LBLGradeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLModName
            // 
            this.LBLModName.AutoSize = true;
            this.LBLModName.Location = new System.Drawing.Point(15, 342);
            this.LBLModName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLModName.Name = "LBLModName";
            this.LBLModName.Size = new System.Drawing.Size(122, 18);
            this.LBLModName.TabIndex = 23;
            this.LBLModName.Text = "Module Name: ";
            this.LBLModName.Click += new System.EventHandler(this.LBLModName_Click);
            // 
            // groupBoxBulk
            // 
            this.groupBoxBulk.Controls.Add(this.BTNImport);
            this.groupBoxBulk.Controls.Add(this.textBoxFile);
            this.groupBoxBulk.Controls.Add(this.BTNFile);
            this.groupBoxBulk.Controls.Add(this.label1);
            this.groupBoxBulk.Controls.Add(this.RBCSV);
            this.groupBoxBulk.Controls.Add(this.RBXML);
            this.groupBoxBulk.Location = new System.Drawing.Point(777, 342);
            this.groupBoxBulk.Name = "groupBoxBulk";
            this.groupBoxBulk.Size = new System.Drawing.Size(322, 158);
            this.groupBoxBulk.TabIndex = 27;
            this.groupBoxBulk.TabStop = false;
            this.groupBoxBulk.Text = "Bulk Imports";
            this.groupBoxBulk.Visible = false;
            this.groupBoxBulk.Enter += new System.EventHandler(this.groupBoxBulk_Enter);
            // 
            // BTNImport
            // 
            this.BTNImport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNImport.Location = new System.Drawing.Point(192, 102);
            this.BTNImport.Name = "BTNImport";
            this.BTNImport.Size = new System.Drawing.Size(84, 24);
            this.BTNImport.TabIndex = 29;
            this.BTNImport.Text = "IMPORT";
            this.BTNImport.UseVisualStyleBackColor = true;
            this.BTNImport.Click += new System.EventHandler(this.BTNImport_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(50, 70);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(226, 26);
            this.textBoxFile.TabIndex = 28;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // BTNFile
            // 
            this.BTNFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFile.Location = new System.Drawing.Point(50, 102);
            this.BTNFile.Name = "BTNFile";
            this.BTNFile.Size = new System.Drawing.Size(45, 23);
            this.BTNFile.TabIndex = 28;
            this.BTNFile.Text = "FILE";
            this.BTNFile.UseVisualStyleBackColor = true;
            this.BTNFile.Click += new System.EventHandler(this.BTNFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select File";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RBCSV
            // 
            this.RBCSV.AutoSize = true;
            this.RBCSV.Location = new System.Drawing.Point(69, 21);
            this.RBCSV.Name = "RBCSV";
            this.RBCSV.Size = new System.Drawing.Size(57, 22);
            this.RBCSV.TabIndex = 2;
            this.RBCSV.Text = "CSV";
            this.RBCSV.UseVisualStyleBackColor = true;
            this.RBCSV.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBXML
            // 
            this.RBXML.AutoSize = true;
            this.RBXML.Checked = true;
            this.RBXML.Location = new System.Drawing.Point(6, 21);
            this.RBXML.Name = "RBXML";
            this.RBXML.Size = new System.Drawing.Size(57, 22);
            this.RBXML.TabIndex = 2;
            this.RBXML.TabStop = true;
            this.RBXML.Text = "XML";
            this.RBXML.UseVisualStyleBackColor = true;
            this.RBXML.CheckedChanged += new System.EventHandler(this.RBXML_CheckedChanged);
            // 
            // BTNDeleteMod
            // 
            this.BTNDeleteMod.Enabled = false;
            this.BTNDeleteMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDeleteMod.Location = new System.Drawing.Point(695, 474);
            this.BTNDeleteMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDeleteMod.Name = "BTNDeleteMod";
            this.BTNDeleteMod.Size = new System.Drawing.Size(65, 24);
            this.BTNDeleteMod.TabIndex = 30;
            this.BTNDeleteMod.Text = "DELETE";
            this.BTNDeleteMod.UseVisualStyleBackColor = true;
            this.BTNDeleteMod.Click += new System.EventHandler(this.BTNDeleteMod_Click);
            // 
            // BTNUpdateMod
            // 
            this.BTNUpdateMod.Enabled = false;
            this.BTNUpdateMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUpdateMod.Location = new System.Drawing.Point(617, 476);
            this.BTNUpdateMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNUpdateMod.Name = "BTNUpdateMod";
            this.BTNUpdateMod.Size = new System.Drawing.Size(70, 21);
            this.BTNUpdateMod.TabIndex = 29;
            this.BTNUpdateMod.Text = "UPDATE";
            this.BTNUpdateMod.UseVisualStyleBackColor = true;
            this.BTNUpdateMod.Click += new System.EventHandler(this.BTNUpdateMod_Click);
            // 
            // BTNAddMod
            // 
            this.BTNAddMod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddMod.Location = new System.Drawing.Point(231, 474);
            this.BTNAddMod.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddMod.Name = "BTNAddMod";
            this.BTNAddMod.Size = new System.Drawing.Size(108, 26);
            this.BTNAddMod.TabIndex = 28;
            this.BTNAddMod.Text = "NEW MODULE";
            this.BTNAddMod.UseVisualStyleBackColor = true;
            this.BTNAddMod.Click += new System.EventHandler(this.BTNAddMod_Click);
            // 
            // LBLInfo
            // 
            this.LBLInfo.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLInfo.Location = new System.Drawing.Point(15, 509);
            this.LBLInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLInfo.Name = "LBLInfo";
            this.LBLInfo.Size = new System.Drawing.Size(987, 138);
            this.LBLInfo.TabIndex = 31;
            this.LBLInfo.Text = "Information:";
            this.LBLInfo.Click += new System.EventHandler(this.LBLInfo_Click);
            // 
            // FormDetailsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 656);
            this.Controls.Add(this.LBLInfo);
            this.Controls.Add(this.BTNDeleteMod);
            this.Controls.Add(this.BTNUpdateMod);
            this.Controls.Add(this.BTNAddMod);
            this.Controls.Add(this.groupBoxBulk);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxModule);
            this.Controls.Add(this.LBLGradeName);
            this.Controls.Add(this.LBLModName);
            this.Controls.Add(this.CLBModules);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLBDetails);
            this.Controls.Add(this.LBLPerson);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDetailsMain";
            this.Text = "Teacher Details";
            this.Load += new System.EventHandler(this.FormTeacherList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBulk.ResumeLayout(false);
            this.groupBoxBulk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LBLPerson;
        private System.Windows.Forms.CheckedListBox CLBDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBTeacher;
        private System.Windows.Forms.RadioButton RBStudent;
        private System.Windows.Forms.CheckedListBox CLBModules;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxModule;
        private System.Windows.Forms.Label LBLGradeName;
        private System.Windows.Forms.Label LBLModName;
        private System.Windows.Forms.GroupBox groupBoxBulk;
        private System.Windows.Forms.RadioButton RBXML;
        private System.Windows.Forms.RadioButton RBCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNFile;
        private System.Windows.Forms.Button BTNImport;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button BTNDeleteMod;
        private System.Windows.Forms.Button BTNUpdateMod;
        private System.Windows.Forms.Button BTNAddMod;
        private System.Windows.Forms.Label LBLInfo;
    }
}