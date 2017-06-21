namespace Live_Peformance
{
    partial class GUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEllection = new System.Windows.Forms.TabPage();
            this.tabParty = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbEllections = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbKind = new System.Windows.Forms.TextBox();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbRunning = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.lblBeginDatum = new System.Windows.Forms.Label();
            this.lblZetels = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.lblLopend = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabEllection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEllection);
            this.tabControl.Controls.Add(this.tabParty);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1020, 474);
            this.tabControl.TabIndex = 0;
            // 
            // tabEllection
            // 
            this.tabEllection.Controls.Add(this.lblLopend);
            this.tabEllection.Controls.Add(this.lblEindDatum);
            this.tabEllection.Controls.Add(this.lblZetels);
            this.tabEllection.Controls.Add(this.lblBeginDatum);
            this.tabEllection.Controls.Add(this.lblSoort);
            this.tabEllection.Controls.Add(this.lblNaam);
            this.tabEllection.Controls.Add(this.tbRunning);
            this.tabEllection.Controls.Add(this.tbEndDate);
            this.tabEllection.Controls.Add(this.tbStartDate);
            this.tabEllection.Controls.Add(this.tbSeats);
            this.tabEllection.Controls.Add(this.tbKind);
            this.tabEllection.Controls.Add(this.tbName);
            this.tabEllection.Controls.Add(this.lbEllections);
            this.tabEllection.Controls.Add(this.btnEdit);
            this.tabEllection.Controls.Add(this.btnCreate);
            this.tabEllection.Controls.Add(this.btnDelete);
            this.tabEllection.Location = new System.Drawing.Point(4, 25);
            this.tabEllection.Name = "tabEllection";
            this.tabEllection.Padding = new System.Windows.Forms.Padding(3);
            this.tabEllection.Size = new System.Drawing.Size(1012, 445);
            this.tabEllection.TabIndex = 0;
            this.tabEllection.Text = "Verkiezingen";
            this.tabEllection.UseVisualStyleBackColor = true;
            // 
            // tabParty
            // 
            this.tabParty.Location = new System.Drawing.Point(4, 25);
            this.tabParty.Name = "tabParty";
            this.tabParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabParty.Size = new System.Drawing.Size(1012, 445);
            this.tabParty.TabIndex = 1;
            this.tabParty.Text = "Partijen";
            this.tabParty.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(824, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Verwijder Verkiezing";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(824, 311);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 52);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Maak nieuwe Verkiezing";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(824, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 59);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Pas Verkiezing aan";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbEllections
            // 
            this.lbEllections.FormattingEnabled = true;
            this.lbEllections.ItemHeight = 16;
            this.lbEllections.Location = new System.Drawing.Point(22, 7);
            this.lbEllections.Name = "lbEllections";
            this.lbEllections.Size = new System.Drawing.Size(382, 420);
            this.lbEllections.TabIndex = 3;
            this.lbEllections.Click += new System.EventHandler(this.lbEllections_Click);
            this.lbEllections.SelectedIndexChanged += new System.EventHandler(this.lbEllections_SelectedIndexChanged_1);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(493, 7);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(215, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbKind
            // 
            this.tbKind.Location = new System.Drawing.Point(493, 63);
            this.tbKind.Name = "tbKind";
            this.tbKind.Size = new System.Drawing.Size(215, 22);
            this.tbKind.TabIndex = 5;
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(493, 126);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(215, 22);
            this.tbSeats.TabIndex = 6;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(493, 194);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(215, 22);
            this.tbStartDate.TabIndex = 7;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(493, 266);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(215, 22);
            this.tbEndDate.TabIndex = 8;
            // 
            // tbRunning
            // 
            this.tbRunning.Location = new System.Drawing.Point(493, 345);
            this.tbRunning.Name = "tbRunning";
            this.tbRunning.Size = new System.Drawing.Size(215, 22);
            this.tbRunning.TabIndex = 9;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(429, 11);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Naam:";
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(429, 66);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(46, 17);
            this.lblSoort.TabIndex = 11;
            this.lblSoort.Text = "Soort:";
            // 
            // lblBeginDatum
            // 
            this.lblBeginDatum.AutoSize = true;
            this.lblBeginDatum.Location = new System.Drawing.Point(429, 194);
            this.lblBeginDatum.Name = "lblBeginDatum";
            this.lblBeginDatum.Size = new System.Drawing.Size(48, 17);
            this.lblBeginDatum.TabIndex = 12;
            this.lblBeginDatum.Text = "Begin:";
            // 
            // lblZetels
            // 
            this.lblZetels.AutoSize = true;
            this.lblZetels.Location = new System.Drawing.Point(432, 130);
            this.lblZetels.Name = "lblZetels";
            this.lblZetels.Size = new System.Drawing.Size(51, 17);
            this.lblZetels.TabIndex = 13;
            this.lblZetels.Text = "Zetels:";
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(432, 266);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(48, 17);
            this.lblEindDatum.TabIndex = 14;
            this.lblEindDatum.Text = "Einde:";
            // 
            // lblLopend
            // 
            this.lblLopend.AutoSize = true;
            this.lblLopend.Location = new System.Drawing.Point(432, 345);
            this.lblLopend.Name = "lblLopend";
            this.lblLopend.Size = new System.Drawing.Size(60, 17);
            this.lblLopend.TabIndex = 15;
            this.lblLopend.Text = "Lopend:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.tabControl);
            this.Name = "GUI";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabEllection.ResumeLayout(false);
            this.tabEllection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEllection;
        private System.Windows.Forms.TabPage tabParty;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.TextBox tbKind;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbEllections;
        private System.Windows.Forms.Label lblLopend;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.Label lblZetels;
        private System.Windows.Forms.Label lblBeginDatum;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbRunning;
    }
}

