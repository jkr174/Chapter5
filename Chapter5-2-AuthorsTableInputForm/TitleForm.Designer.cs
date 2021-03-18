namespace Chapter5_2_AuthorsTableInputForm
{
    partial class frmTitles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitles));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grpFindTitle = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.picBooksTitle = new System.Windows.Forms.PictureBox();
            this.picBooks = new System.Windows.Forms.PictureBox();
            this.btnPrintTitles = new System.Windows.Forms.Button();
            this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.cboAuthor1 = new System.Windows.Forms.ComboBox();
            this.cboAuthor2 = new System.Windows.Forms.ComboBox();
            this.cboAuthor3 = new System.Windows.Forms.ComboBox();
            this.cboAuthor4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXAuthor1 = new System.Windows.Forms.Button();
            this.btnXAuthor2 = new System.Windows.Forms.Button();
            this.btnXAuthor3 = new System.Windows.Forms.Button();
            this.btnXAuthor4 = new System.Windows.Forms.Button();
            this.grpFindTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooksTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(112, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(347, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year Published";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(112, 113);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(59, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(222, 324);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "< Pervious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(303, 324);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 353);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(141, 382);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(384, 382);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(384, 411);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(215, 113);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(244, 20);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.Text = "_-_______-_-_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(112, 220);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(347, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(112, 246);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(347, 20);
            this.txtNotes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.White;
            this.txtSubject.Location = new System.Drawing.Point(112, 272);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(347, 20);
            this.txtSubject.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(112, 298);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(347, 20);
            this.txtComments.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(384, 324);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 25;
            this.btnLast.TabStop = false;
            this.btnLast.Text = "Last >|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(141, 324);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grpFindTitle
            // 
            this.grpFindTitle.Controls.Add(this.btnFind);
            this.grpFindTitle.Controls.Add(this.txtFind);
            this.grpFindTitle.Controls.Add(this.label8);
            this.grpFindTitle.Location = new System.Drawing.Point(12, 334);
            this.grpFindTitle.Name = "grpFindTitle";
            this.grpFindTitle.Size = new System.Drawing.Size(123, 100);
            this.grpFindTitle.TabIndex = 27;
            this.grpFindTitle.TabStop = false;
            this.grpFindTitle.Text = "Find Title";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(9, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 23);
            this.btnFind.TabIndex = 28;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.White;
            this.txtFind.Location = new System.Drawing.Point(9, 45);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(108, 20);
            this.txtFind.TabIndex = 28;
            this.txtFind.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type first few letters of Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboPublisher
            // 
            this.cboPublisher.BackColor = System.Drawing.Color.White;
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.Enabled = false;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(112, 193);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(347, 21);
            this.cboPublisher.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Publisher";
            // 
            // btnPublishers
            // 
            this.btnPublishers.Location = new System.Drawing.Point(263, 411);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(75, 23);
            this.btnPublishers.TabIndex = 30;
            this.btnPublishers.TabStop = false;
            this.btnPublishers.Text = "&Publishers";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 65);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Titles Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(263, 440);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 32;
            this.btnRecord.TabStop = false;
            this.btnRecord.Text = "Print &Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(141, 411);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(75, 23);
            this.btnAuthors.TabIndex = 33;
            this.btnAuthors.TabStop = false;
            this.btnAuthors.Text = "A&uthors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // picBooksTitle
            // 
            this.picBooksTitle.Image = global::Chapter5_2_AuthorsTableInputForm.Properties.Resources.books;
            this.picBooksTitle.Location = new System.Drawing.Point(15, 12);
            this.picBooksTitle.Name = "picBooksTitle";
            this.picBooksTitle.Size = new System.Drawing.Size(100, 65);
            this.picBooksTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBooksTitle.TabIndex = 14;
            this.picBooksTitle.TabStop = false;
            // 
            // picBooks
            // 
            this.picBooks.Image = global::Chapter5_2_AuthorsTableInputForm.Properties.Resources.books_icon;
            this.picBooks.Location = new System.Drawing.Point(344, 441);
            this.picBooks.Name = "picBooks";
            this.picBooks.Size = new System.Drawing.Size(24, 22);
            this.picBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBooks.TabIndex = 34;
            this.picBooks.TabStop = false;
            this.picBooks.Visible = false;
            // 
            // btnPrintTitles
            // 
            this.btnPrintTitles.Location = new System.Drawing.Point(141, 440);
            this.btnPrintTitles.Name = "btnPrintTitles";
            this.btnPrintTitles.Size = new System.Drawing.Size(75, 23);
            this.btnPrintTitles.TabIndex = 35;
            this.btnPrintTitles.TabStop = false;
            this.btnPrintTitles.Text = "Print &Titles";
            this.btnPrintTitles.UseVisualStyleBackColor = true;
            this.btnPrintTitles.Click += new System.EventHandler(this.btnPrintTitles_Click);
            // 
            // dlgPreview
            // 
            this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPreview.Enabled = true;
            this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
            this.dlgPreview.Name = "dlgPreview";
            this.dlgPreview.Visible = false;
            // 
            // cboAuthor1
            // 
            this.cboAuthor1.BackColor = System.Drawing.Color.White;
            this.cboAuthor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor1.FormattingEnabled = true;
            this.cboAuthor1.Location = new System.Drawing.Point(65, 139);
            this.cboAuthor1.Name = "cboAuthor1";
            this.cboAuthor1.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor1.TabIndex = 36;
            // 
            // cboAuthor2
            // 
            this.cboAuthor2.BackColor = System.Drawing.Color.White;
            this.cboAuthor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor2.FormattingEnabled = true;
            this.cboAuthor2.Location = new System.Drawing.Point(65, 166);
            this.cboAuthor2.Name = "cboAuthor2";
            this.cboAuthor2.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor2.TabIndex = 37;
            // 
            // cboAuthor3
            // 
            this.cboAuthor3.BackColor = System.Drawing.Color.White;
            this.cboAuthor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor3.FormattingEnabled = true;
            this.cboAuthor3.Location = new System.Drawing.Point(313, 139);
            this.cboAuthor3.Name = "cboAuthor3";
            this.cboAuthor3.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor3.TabIndex = 38;
            // 
            // cboAuthor4
            // 
            this.cboAuthor4.BackColor = System.Drawing.Color.White;
            this.cboAuthor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor4.FormattingEnabled = true;
            this.cboAuthor4.Location = new System.Drawing.Point(313, 166);
            this.cboAuthor4.Name = "cboAuthor4";
            this.cboAuthor4.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor4.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Author 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Author 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Author 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Author 4";
            // 
            // btnXAuthor1
            // 
            this.btnXAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor1.Location = new System.Drawing.Point(192, 139);
            this.btnXAuthor1.Name = "btnXAuthor1";
            this.btnXAuthor1.Size = new System.Drawing.Size(19, 23);
            this.btnXAuthor1.TabIndex = 44;
            this.btnXAuthor1.TabStop = false;
            this.btnXAuthor1.Text = "X";
            this.btnXAuthor1.UseVisualStyleBackColor = true;
            this.btnXAuthor1.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor2
            // 
            this.btnXAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor2.Location = new System.Drawing.Point(192, 166);
            this.btnXAuthor2.Name = "btnXAuthor2";
            this.btnXAuthor2.Size = new System.Drawing.Size(19, 23);
            this.btnXAuthor2.TabIndex = 45;
            this.btnXAuthor2.TabStop = false;
            this.btnXAuthor2.Text = "X";
            this.btnXAuthor2.UseVisualStyleBackColor = true;
            this.btnXAuthor2.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor3
            // 
            this.btnXAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor3.Location = new System.Drawing.Point(440, 137);
            this.btnXAuthor3.Name = "btnXAuthor3";
            this.btnXAuthor3.Size = new System.Drawing.Size(19, 23);
            this.btnXAuthor3.TabIndex = 46;
            this.btnXAuthor3.TabStop = false;
            this.btnXAuthor3.Text = "X";
            this.btnXAuthor3.UseVisualStyleBackColor = true;
            this.btnXAuthor3.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor4
            // 
            this.btnXAuthor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor4.Location = new System.Drawing.Point(440, 164);
            this.btnXAuthor4.Name = "btnXAuthor4";
            this.btnXAuthor4.Size = new System.Drawing.Size(19, 23);
            this.btnXAuthor4.TabIndex = 47;
            this.btnXAuthor4.TabStop = false;
            this.btnXAuthor4.Text = "X";
            this.btnXAuthor4.UseVisualStyleBackColor = true;
            this.btnXAuthor4.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 482);
            this.Controls.Add(this.btnXAuthor4);
            this.Controls.Add(this.btnXAuthor3);
            this.Controls.Add(this.btnXAuthor2);
            this.Controls.Add(this.btnXAuthor1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboAuthor4);
            this.Controls.Add(this.cboAuthor3);
            this.Controls.Add(this.cboAuthor2);
            this.Controls.Add(this.cboAuthor1);
            this.Controls.Add(this.btnPrintTitles);
            this.Controls.Add(this.picBooks);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.grpFindTitle);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picBooksTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpPublishers.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "frmTitles";
            this.hlpPublishers.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmAuthors_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAuthors_FormClosing);
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            this.grpFindTitle.ResumeLayout(false);
            this.grpFindTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooksTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox picBooksTitle;
        private System.Windows.Forms.HelpProvider hlpPublishers;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox grpFindTitle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.PictureBox picBooks;
        private System.Windows.Forms.Button btnPrintTitles;
        private System.Windows.Forms.PrintPreviewDialog dlgPreview;
        private System.Windows.Forms.ComboBox cboAuthor1;
        private System.Windows.Forms.ComboBox cboAuthor2;
        private System.Windows.Forms.ComboBox cboAuthor3;
        private System.Windows.Forms.ComboBox cboAuthor4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXAuthor1;
        private System.Windows.Forms.Button btnXAuthor2;
        private System.Windows.Forms.Button btnXAuthor3;
        private System.Windows.Forms.Button btnXAuthor4;
    }
}

