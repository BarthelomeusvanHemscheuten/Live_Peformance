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
            this.tbRunning = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.lblBeginDatum = new System.Windows.Forms.Label();
            this.lblZetels = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.lblLopend = new System.Windows.Forms.Label();
            this.tbBegin = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbParties = new System.Windows.Forms.ListBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnAddParty = new System.Windows.Forms.Button();
            this.btnEditParty = new System.Windows.Forms.Button();
            this.lbCoalition = new System.Windows.Forms.ListBox();
            this.btnAddCoalition = new System.Windows.Forms.Button();
            this.lbCoalitionParties = new System.Windows.Forms.ListBox();
            this.lbEllectionParties = new System.Windows.Forms.ListBox();
            this.btnAddtoCoalition = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditCoalition = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCoalition = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbReceiver = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabEllection.SuspendLayout();
            this.tabParty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabEllection);
            this.tabControl.Controls.Add(this.tabParty);
            this.tabControl.Location = new System.Drawing.Point(210, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 657);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabEllection
            // 
            this.tabEllection.Controls.Add(this.btnCoalition);
            this.tabEllection.Controls.Add(this.btnEditParty);
            this.tabEllection.Controls.Add(this.btnAddParty);
            this.tabEllection.Controls.Add(this.lbResults);
            this.tabEllection.Controls.Add(this.lbParties);
            this.tabEllection.Controls.Add(this.btnRefresh);
            this.tabEllection.Controls.Add(this.tbEnd);
            this.tabEllection.Controls.Add(this.tbBegin);
            this.tabEllection.Controls.Add(this.lblLopend);
            this.tabEllection.Controls.Add(this.lblEindDatum);
            this.tabEllection.Controls.Add(this.lblZetels);
            this.tabEllection.Controls.Add(this.lblBeginDatum);
            this.tabEllection.Controls.Add(this.lblSoort);
            this.tabEllection.Controls.Add(this.lblNaam);
            this.tabEllection.Controls.Add(this.tbRunning);
            this.tabEllection.Controls.Add(this.tbSeats);
            this.tabEllection.Controls.Add(this.tbKind);
            this.tabEllection.Controls.Add(this.tbName);
            this.tabEllection.Controls.Add(this.lbEllections);
            this.tabEllection.Controls.Add(this.btnEdit);
            this.tabEllection.Controls.Add(this.btnCreate);
            this.tabEllection.Controls.Add(this.btnDelete);
            this.tabEllection.Location = new System.Drawing.Point(4, 28);
            this.tabEllection.Name = "tabEllection";
            this.tabEllection.Padding = new System.Windows.Forms.Padding(3);
            this.tabEllection.Size = new System.Drawing.Size(925, 625);
            this.tabEllection.TabIndex = 0;
            this.tabEllection.Text = "Verkiezingen";
            this.tabEllection.UseVisualStyleBackColor = true;
            // 
            // tabParty
            // 
            this.tabParty.Controls.Add(this.tbReceiver);
            this.tabParty.Controls.Add(this.tbSender);
            this.tabParty.Controls.Add(this.btnBack);
            this.tabParty.Controls.Add(this.btnExport);
            this.tabParty.Controls.Add(this.btnEditCoalition);
            this.tabParty.Controls.Add(this.btnRemove);
            this.tabParty.Controls.Add(this.btnAddtoCoalition);
            this.tabParty.Controls.Add(this.lbEllectionParties);
            this.tabParty.Controls.Add(this.lbCoalitionParties);
            this.tabParty.Controls.Add(this.btnAddCoalition);
            this.tabParty.Controls.Add(this.lbCoalition);
            this.tabParty.Location = new System.Drawing.Point(4, 28);
            this.tabParty.Name = "tabParty";
            this.tabParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabParty.Size = new System.Drawing.Size(1135, 625);
            this.tabParty.TabIndex = 1;
            this.tabParty.Text = "Partijen";
            this.tabParty.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(957, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Verwijder Verkiezing";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(957, 76);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 52);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Maak nieuwe Verkiezing";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(957, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 59);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Pas Verkiezing aan";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbEllections
            // 
            this.lbEllections.FormattingEnabled = true;
            this.lbEllections.ItemHeight = 16;
            this.lbEllections.Location = new System.Drawing.Point(22, 7);
            this.lbEllections.Name = "lbEllections";
            this.lbEllections.Size = new System.Drawing.Size(180, 420);
            this.lbEllections.TabIndex = 3;
            this.lbEllections.SelectedIndexChanged += new System.EventHandler(this.lbEllections_SelectedIndexChanged_1);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(598, 38);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(215, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbKind
            // 
            this.tbKind.Location = new System.Drawing.Point(598, 91);
            this.tbKind.Name = "tbKind";
            this.tbKind.ReadOnly = true;
            this.tbKind.Size = new System.Drawing.Size(215, 22);
            this.tbKind.TabIndex = 5;
            // 
            // tbSeats
            // 
            this.tbSeats.Location = new System.Drawing.Point(598, 148);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.ReadOnly = true;
            this.tbSeats.Size = new System.Drawing.Size(215, 22);
            this.tbSeats.TabIndex = 6;
            // 
            // tbRunning
            // 
            this.tbRunning.Location = new System.Drawing.Point(598, 307);
            this.tbRunning.Name = "tbRunning";
            this.tbRunning.ReadOnly = true;
            this.tbRunning.Size = new System.Drawing.Size(215, 22);
            this.tbRunning.TabIndex = 9;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(514, 41);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Naam:";
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(517, 91);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(46, 17);
            this.lblSoort.TabIndex = 11;
            this.lblSoort.Text = "Soort:";
            // 
            // lblBeginDatum
            // 
            this.lblBeginDatum.AutoSize = true;
            this.lblBeginDatum.Location = new System.Drawing.Point(517, 204);
            this.lblBeginDatum.Name = "lblBeginDatum";
            this.lblBeginDatum.Size = new System.Drawing.Size(48, 17);
            this.lblBeginDatum.TabIndex = 12;
            this.lblBeginDatum.Text = "Begin:";
            // 
            // lblZetels
            // 
            this.lblZetels.AutoSize = true;
            this.lblZetels.Location = new System.Drawing.Point(512, 148);
            this.lblZetels.Name = "lblZetels";
            this.lblZetels.Size = new System.Drawing.Size(51, 17);
            this.lblZetels.TabIndex = 13;
            this.lblZetels.Text = "Zetels:";
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(523, 258);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(48, 17);
            this.lblEindDatum.TabIndex = 14;
            this.lblEindDatum.Text = "Einde:";
            // 
            // lblLopend
            // 
            this.lblLopend.AutoSize = true;
            this.lblLopend.Location = new System.Drawing.Point(511, 307);
            this.lblLopend.Name = "lblLopend";
            this.lblLopend.Size = new System.Drawing.Size(60, 17);
            this.lblLopend.TabIndex = 15;
            this.lblLopend.Text = "Lopend:";
            // 
            // tbBegin
            // 
            this.tbBegin.Location = new System.Drawing.Point(598, 204);
            this.tbBegin.Name = "tbBegin";
            this.tbBegin.Size = new System.Drawing.Size(215, 22);
            this.tbBegin.TabIndex = 19;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(598, 258);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(215, 22);
            this.tbEnd.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(523, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 37);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Herlaad";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbParties
            // 
            this.lbParties.FormattingEnabled = true;
            this.lbParties.ItemHeight = 16;
            this.lbParties.Location = new System.Drawing.Point(208, 7);
            this.lbParties.Name = "lbParties";
            this.lbParties.Size = new System.Drawing.Size(301, 420);
            this.lbParties.TabIndex = 22;
            this.lbParties.SelectedIndexChanged += new System.EventHandler(this.lbParties_SelectedIndexChanged);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(22, 434);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(487, 180);
            this.lbResults.TabIndex = 23;
            // 
            // btnAddParty
            // 
            this.btnAddParty.Location = new System.Drawing.Point(957, 244);
            this.btnAddParty.Name = "btnAddParty";
            this.btnAddParty.Size = new System.Drawing.Size(172, 50);
            this.btnAddParty.TabIndex = 24;
            this.btnAddParty.Text = "Voeg Partij toe";
            this.btnAddParty.UseVisualStyleBackColor = true;
            this.btnAddParty.Click += new System.EventHandler(this.btnAddParty_Click);
            // 
            // btnEditParty
            // 
            this.btnEditParty.Location = new System.Drawing.Point(957, 301);
            this.btnEditParty.Name = "btnEditParty";
            this.btnEditParty.Size = new System.Drawing.Size(172, 44);
            this.btnEditParty.TabIndex = 25;
            this.btnEditParty.Text = "Pas Partij aan";
            this.btnEditParty.UseVisualStyleBackColor = true;
            this.btnEditParty.Click += new System.EventHandler(this.btnEditParty_Click);
            // 
            // lbCoalition
            // 
            this.lbCoalition.FormattingEnabled = true;
            this.lbCoalition.ItemHeight = 16;
            this.lbCoalition.Location = new System.Drawing.Point(7, 7);
            this.lbCoalition.Name = "lbCoalition";
            this.lbCoalition.Size = new System.Drawing.Size(232, 596);
            this.lbCoalition.TabIndex = 0;
            // 
            // btnAddCoalition
            // 
            this.btnAddCoalition.Location = new System.Drawing.Point(262, 483);
            this.btnAddCoalition.Name = "btnAddCoalition";
            this.btnAddCoalition.Size = new System.Drawing.Size(179, 47);
            this.btnAddCoalition.TabIndex = 2;
            this.btnAddCoalition.Text = "Voeg Coalitie toe";
            this.btnAddCoalition.UseVisualStyleBackColor = true;
            this.btnAddCoalition.Click += new System.EventHandler(this.btnAddCoalition_Click);
            // 
            // lbCoalitionParties
            // 
            this.lbCoalitionParties.FormattingEnabled = true;
            this.lbCoalitionParties.ItemHeight = 16;
            this.lbCoalitionParties.Location = new System.Drawing.Point(850, 7);
            this.lbCoalitionParties.Name = "lbCoalitionParties";
            this.lbCoalitionParties.Size = new System.Drawing.Size(269, 596);
            this.lbCoalitionParties.TabIndex = 7;
            // 
            // lbEllectionParties
            // 
            this.lbEllectionParties.FormattingEnabled = true;
            this.lbEllectionParties.ItemHeight = 16;
            this.lbEllectionParties.Location = new System.Drawing.Point(495, 3);
            this.lbEllectionParties.Name = "lbEllectionParties";
            this.lbEllectionParties.Size = new System.Drawing.Size(230, 596);
            this.lbEllectionParties.TabIndex = 8;
            this.lbEllectionParties.SelectedIndexChanged += new System.EventHandler(this.lbEllectionParties_SelectedIndexChanged);
            // 
            // btnAddtoCoalition
            // 
            this.btnAddtoCoalition.Location = new System.Drawing.Point(752, 182);
            this.btnAddtoCoalition.Name = "btnAddtoCoalition";
            this.btnAddtoCoalition.Size = new System.Drawing.Size(75, 38);
            this.btnAddtoCoalition.TabIndex = 9;
            this.btnAddtoCoalition.Text = "---->";
            this.btnAddtoCoalition.UseVisualStyleBackColor = true;
            this.btnAddtoCoalition.Click += new System.EventHandler(this.btnAddtoCoalition_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(752, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 38);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "<-----";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEditCoalition
            // 
            this.btnEditCoalition.Location = new System.Drawing.Point(262, 426);
            this.btnEditCoalition.Name = "btnEditCoalition";
            this.btnEditCoalition.Size = new System.Drawing.Size(179, 51);
            this.btnEditCoalition.TabIndex = 11;
            this.btnEditCoalition.Text = "Pas Coalitie aan";
            this.btnEditCoalition.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(262, 354);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(179, 56);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Exporteer Coalitie";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCoalition
            // 
            this.btnCoalition.Location = new System.Drawing.Point(957, 403);
            this.btnCoalition.Name = "btnCoalition";
            this.btnCoalition.Size = new System.Drawing.Size(175, 51);
            this.btnCoalition.TabIndex = 26;
            this.btnCoalition.Text = "Zie Coalities";
            this.btnCoalition.UseVisualStyleBackColor = true;
            this.btnCoalition.Click += new System.EventHandler(this.btnCoalition_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 536);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 50);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Ga Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(307, 298);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(100, 22);
            this.tbSender.TabIndex = 14;
            // 
            // tbReceiver
            // 
            this.tbReceiver.Location = new System.Drawing.Point(307, 326);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.Size = new System.Drawing.Size(100, 22);
            this.tbReceiver.TabIndex = 15;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 670);
            this.Controls.Add(this.tabControl);
            this.Name = "GUI";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabEllection.ResumeLayout(false);
            this.tabEllection.PerformLayout();
            this.tabParty.ResumeLayout(false);
            this.tabParty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEllection;
        private System.Windows.Forms.TabPage tabParty;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
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
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbBegin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddParty;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.ListBox lbParties;
        private System.Windows.Forms.Button btnEditParty;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEditCoalition;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddtoCoalition;
        private System.Windows.Forms.ListBox lbEllectionParties;
        private System.Windows.Forms.ListBox lbCoalitionParties;
        private System.Windows.Forms.Button btnAddCoalition;
        private System.Windows.Forms.ListBox lbCoalition;
        private System.Windows.Forms.Button btnCoalition;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbReceiver;
        private System.Windows.Forms.TextBox tbSender;
    }
}

