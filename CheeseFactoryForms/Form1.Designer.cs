
namespace CheeseFactoryForms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddCheese = new System.Windows.Forms.Panel();
            this.btnAddCheese = new System.Windows.Forms.Button();
            this.bbDate = new System.Windows.Forms.DateTimePicker();
            this.lblBBDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.mDate = new System.Windows.Forms.DateTimePicker();
            this.edtBatchNum = new System.Windows.Forms.TextBox();
            this.lblBatchNum = new System.Windows.Forms.Label();
            this.edtCheeseID = new System.Windows.Forms.TextBox();
            this.lblCheeseID = new System.Windows.Forms.Label();
            this.lblCheeseName = new System.Windows.Forms.Label();
            this.edtCheeseName = new System.Windows.Forms.TextBox();
            this.lblCheeseList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edtFindID = new System.Windows.Forms.TextBox();
            this.lblFindCheeseID = new System.Windows.Forms.Label();
            this.lblFindCheese = new System.Windows.Forms.Label();
            this.redtCheeses = new System.Windows.Forms.RichTextBox();
            this.pnlAddCheese.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddCheese
            // 
            this.pnlAddCheese.Controls.Add(this.btnAddCheese);
            this.pnlAddCheese.Controls.Add(this.bbDate);
            this.pnlAddCheese.Controls.Add(this.lblBBDate);
            this.pnlAddCheese.Controls.Add(this.label1);
            this.pnlAddCheese.Controls.Add(this.lblManDate);
            this.pnlAddCheese.Controls.Add(this.mDate);
            this.pnlAddCheese.Controls.Add(this.edtBatchNum);
            this.pnlAddCheese.Controls.Add(this.lblBatchNum);
            this.pnlAddCheese.Controls.Add(this.edtCheeseID);
            this.pnlAddCheese.Controls.Add(this.lblCheeseID);
            this.pnlAddCheese.Controls.Add(this.lblCheeseName);
            this.pnlAddCheese.Controls.Add(this.edtCheeseName);
            this.pnlAddCheese.Location = new System.Drawing.Point(12, 12);
            this.pnlAddCheese.Name = "pnlAddCheese";
            this.pnlAddCheese.Size = new System.Drawing.Size(211, 290);
            this.pnlAddCheese.TabIndex = 0;
            // 
            // btnAddCheese
            // 
            this.btnAddCheese.Location = new System.Drawing.Point(1, 256);
            this.btnAddCheese.Name = "btnAddCheese";
            this.btnAddCheese.Size = new System.Drawing.Size(199, 23);
            this.btnAddCheese.TabIndex = 11;
            this.btnAddCheese.Text = "Add Cheese";
            this.btnAddCheese.UseVisualStyleBackColor = true;
            this.btnAddCheese.Click += new System.EventHandler(this.btnAddCheese_Click);
            // 
            // bbDate
            // 
            this.bbDate.Location = new System.Drawing.Point(0, 226);
            this.bbDate.Name = "bbDate";
            this.bbDate.Size = new System.Drawing.Size(200, 23);
            this.bbDate.TabIndex = 10;
            // 
            // lblBBDate
            // 
            this.lblBBDate.AutoSize = true;
            this.lblBBDate.Location = new System.Drawing.Point(1, 208);
            this.lblBBDate.Name = "lblBBDate";
            this.lblBBDate.Size = new System.Drawing.Size(93, 15);
            this.lblBBDate.TabIndex = 9;
            this.lblBBDate.Text = "Best Before Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a Cheese";
            // 
            // lblManDate
            // 
            this.lblManDate.AutoSize = true;
            this.lblManDate.Location = new System.Drawing.Point(0, 160);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(109, 15);
            this.lblManDate.TabIndex = 8;
            this.lblManDate.Text = "Manufactured Date";
            // 
            // mDate
            // 
            this.mDate.Location = new System.Drawing.Point(0, 178);
            this.mDate.Name = "mDate";
            this.mDate.Size = new System.Drawing.Size(200, 23);
            this.mDate.TabIndex = 7;
            // 
            // edtBatchNum
            // 
            this.edtBatchNum.Location = new System.Drawing.Point(0, 134);
            this.edtBatchNum.Name = "edtBatchNum";
            this.edtBatchNum.Size = new System.Drawing.Size(200, 23);
            this.edtBatchNum.TabIndex = 6;
            // 
            // lblBatchNum
            // 
            this.lblBatchNum.AutoSize = true;
            this.lblBatchNum.Location = new System.Drawing.Point(0, 116);
            this.lblBatchNum.Name = "lblBatchNum";
            this.lblBatchNum.Size = new System.Drawing.Size(125, 15);
            this.lblBatchNum.TabIndex = 5;
            this.lblBatchNum.Text = "Cheese Batch Number";
            // 
            // edtCheeseID
            // 
            this.edtCheeseID.Location = new System.Drawing.Point(0, 90);
            this.edtCheeseID.Name = "edtCheeseID";
            this.edtCheeseID.Size = new System.Drawing.Size(200, 23);
            this.edtCheeseID.TabIndex = 4;
            // 
            // lblCheeseID
            // 
            this.lblCheeseID.AutoSize = true;
            this.lblCheeseID.Location = new System.Drawing.Point(0, 72);
            this.lblCheeseID.Name = "lblCheeseID";
            this.lblCheeseID.Size = new System.Drawing.Size(59, 15);
            this.lblCheeseID.TabIndex = 3;
            this.lblCheeseID.Text = "Cheese ID";
            // 
            // lblCheeseName
            // 
            this.lblCheeseName.AutoSize = true;
            this.lblCheeseName.Location = new System.Drawing.Point(0, 28);
            this.lblCheeseName.Name = "lblCheeseName";
            this.lblCheeseName.Size = new System.Drawing.Size(80, 15);
            this.lblCheeseName.TabIndex = 2;
            this.lblCheeseName.Text = "Cheese Name";
            // 
            // edtCheeseName
            // 
            this.edtCheeseName.Location = new System.Drawing.Point(0, 46);
            this.edtCheeseName.Name = "edtCheeseName";
            this.edtCheeseName.Size = new System.Drawing.Size(200, 23);
            this.edtCheeseName.TabIndex = 1;
            // 
            // lblCheeseList
            // 
            this.lblCheeseList.AutoSize = true;
            this.lblCheeseList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheeseList.Location = new System.Drawing.Point(229, 12);
            this.lblCheeseList.Name = "lblCheeseList";
            this.lblCheeseList.Size = new System.Drawing.Size(138, 28);
            this.lblCheeseList.TabIndex = 0;
            this.lblCheeseList.Text = "List of Cheeses";
            this.lblCheeseList.Click += new System.EventHandler(this.lblAddTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.edtFindID);
            this.panel1.Controls.Add(this.lblFindCheeseID);
            this.panel1.Controls.Add(this.lblFindCheese);
            this.panel1.Location = new System.Drawing.Point(12, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 113);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtFindID
            // 
            this.edtFindID.Location = new System.Drawing.Point(1, 46);
            this.edtFindID.Name = "edtFindID";
            this.edtFindID.Size = new System.Drawing.Size(199, 23);
            this.edtFindID.TabIndex = 4;
            // 
            // lblFindCheeseID
            // 
            this.lblFindCheeseID.AutoSize = true;
            this.lblFindCheeseID.Location = new System.Drawing.Point(1, 28);
            this.lblFindCheeseID.Name = "lblFindCheeseID";
            this.lblFindCheeseID.Size = new System.Drawing.Size(89, 15);
            this.lblFindCheeseID.TabIndex = 3;
            this.lblFindCheeseID.Text = "Enter Cheese ID";
            // 
            // lblFindCheese
            // 
            this.lblFindCheese.AutoSize = true;
            this.lblFindCheese.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFindCheese.Location = new System.Drawing.Point(1, 0);
            this.lblFindCheese.Name = "lblFindCheese";
            this.lblFindCheese.Size = new System.Drawing.Size(131, 28);
            this.lblFindCheese.TabIndex = 2;
            this.lblFindCheese.Text = "Find a Cheese";
            // 
            // redtCheeses
            // 
            this.redtCheeses.Location = new System.Drawing.Point(229, 43);
            this.redtCheeses.Name = "redtCheeses";
            this.redtCheeses.ReadOnly = true;
            this.redtCheeses.Size = new System.Drawing.Size(292, 378);
            this.redtCheeses.TabIndex = 2;
            this.redtCheeses.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 433);
            this.Controls.Add(this.redtCheeses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddCheese);
            this.Controls.Add(this.lblCheeseList);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.pnlAddCheese.ResumeLayout(false);
            this.pnlAddCheese.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddCheese;
        private System.Windows.Forms.TextBox edtCheeseID;
        private System.Windows.Forms.Label lblCheeseID;
        private System.Windows.Forms.Label lblCheeseName;
        private System.Windows.Forms.TextBox edtCheeseName;
        private System.Windows.Forms.Label lblCheeseList;
        private System.Windows.Forms.TextBox edtBatchNum;
        private System.Windows.Forms.Label lblBatchNum;
        private System.Windows.Forms.DateTimePicker bbDate;
        private System.Windows.Forms.Label lblBBDate;
        private System.Windows.Forms.Label lblManDate;
        private System.Windows.Forms.DateTimePicker mDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox edtFindID;
        private System.Windows.Forms.Label lblFindCheeseID;
        private System.Windows.Forms.Label lblFindCheese;
        private System.Windows.Forms.Button btnAddCheese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox redtCheeses;
    }
}

