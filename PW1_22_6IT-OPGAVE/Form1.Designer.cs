namespace PW1_22_6IT_OPGAVE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.productenLb = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenLijstCb = new System.Windows.Forms.ComboBox();
            this.klantenLijstLbl = new System.Windows.Forms.Label();
            this.productenLijstLbl = new System.Windows.Forms.Label();
            this.klantNaarBestelBon = new System.Windows.Forms.Button();
            this.productNaarBestelBon = new System.Windows.Forms.Button();
            this.bestelOverzichtTxt = new System.Windows.Forms.TextBox();
            this.bestelHoeveelheid = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bestelOverzichtLbl = new System.Windows.Forms.Label();
            this.bestelHoeveelheidLbl = new System.Windows.Forms.Label();
            this.toonBestelbedrag = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestelHoeveelheid)).BeginInit();
            this.SuspendLayout();
            // 
            // productenLb
            // 
            this.productenLb.Enabled = false;
            this.productenLb.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productenLb.FormattingEnabled = true;
            this.productenLb.ItemHeight = 20;
            this.productenLb.Location = new System.Drawing.Point(15, 191);
            this.productenLb.Name = "productenLb";
            this.productenLb.Size = new System.Drawing.Size(442, 364);
            this.productenLb.TabIndex = 0;
            this.productenLb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductenLb_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bestellingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1421, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.toolStripMenuItem1.Text = "Programma";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.AfsluitenToolStripMenuItem_Click);
            // 
            // bestellingToolStripMenuItem
            // 
            this.bestellingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.toolStripSeparator1,
            this.opslaanToolStripMenuItem});
            this.bestellingToolStripMenuItem.Name = "bestellingToolStripMenuItem";
            this.bestellingToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bestellingToolStripMenuItem.Text = "Bestelling";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.NieuwToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Enabled = false;
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.OpslaanToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.overToolStripMenuItem.Text = "Over";
            // 
            // klantenLijstCb
            // 
            this.klantenLijstCb.Enabled = false;
            this.klantenLijstCb.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.klantenLijstCb.FormattingEnabled = true;
            this.klantenLijstCb.Location = new System.Drawing.Point(15, 98);
            this.klantenLijstCb.Name = "klantenLijstCb";
            this.klantenLijstCb.Size = new System.Drawing.Size(442, 28);
            this.klantenLijstCb.TabIndex = 2;
            this.klantenLijstCb.SelectedIndexChanged += new System.EventHandler(this.KlantenLijstCb_SelectedIndexChanged);
            // 
            // klantenLijstLbl
            // 
            this.klantenLijstLbl.AutoSize = true;
            this.klantenLijstLbl.Font = new System.Drawing.Font("Siemens Sans SC Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.klantenLijstLbl.Location = new System.Drawing.Point(15, 58);
            this.klantenLijstLbl.Name = "klantenLijstLbl";
            this.klantenLijstLbl.Size = new System.Drawing.Size(138, 21);
            this.klantenLijstLbl.TabIndex = 3;
            this.klantenLijstLbl.Text = "KLANTENLIJST";
            // 
            // productenLijstLbl
            // 
            this.productenLijstLbl.AutoSize = true;
            this.productenLijstLbl.Font = new System.Drawing.Font("Siemens Sans SC Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productenLijstLbl.Location = new System.Drawing.Point(15, 156);
            this.productenLijstLbl.Name = "productenLijstLbl";
            this.productenLijstLbl.Size = new System.Drawing.Size(162, 21);
            this.productenLijstLbl.TabIndex = 4;
            this.productenLijstLbl.Text = "PRODUCTENLIJST";
            // 
            // klantNaarBestelBon
            // 
            this.klantNaarBestelBon.Enabled = false;
            this.klantNaarBestelBon.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.klantNaarBestelBon.Location = new System.Drawing.Point(490, 98);
            this.klantNaarBestelBon.Name = "klantNaarBestelBon";
            this.klantNaarBestelBon.Size = new System.Drawing.Size(127, 62);
            this.klantNaarBestelBon.TabIndex = 6;
            this.klantNaarBestelBon.Text = "⮕";
            this.klantNaarBestelBon.UseVisualStyleBackColor = true;
            this.klantNaarBestelBon.Click += new System.EventHandler(this.KlantNaarBestelBon_Click);
            // 
            // productNaarBestelBon
            // 
            this.productNaarBestelBon.Enabled = false;
            this.productNaarBestelBon.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNaarBestelBon.Location = new System.Drawing.Point(490, 373);
            this.productNaarBestelBon.Name = "productNaarBestelBon";
            this.productNaarBestelBon.Size = new System.Drawing.Size(127, 62);
            this.productNaarBestelBon.TabIndex = 7;
            this.productNaarBestelBon.Text = "⮕";
            this.productNaarBestelBon.UseVisualStyleBackColor = true;
            this.productNaarBestelBon.Click += new System.EventHandler(this.ProductNaarBestelBon_Click);
            // 
            // bestelOverzichtTxt
            // 
            this.bestelOverzichtTxt.BackColor = System.Drawing.SystemColors.Control;
            this.bestelOverzichtTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestelOverzichtTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bestelOverzichtTxt.HideSelection = false;
            this.bestelOverzichtTxt.Location = new System.Drawing.Point(647, 97);
            this.bestelOverzichtTxt.Multiline = true;
            this.bestelOverzichtTxt.Name = "bestelOverzichtTxt";
            this.bestelOverzichtTxt.ReadOnly = true;
            this.bestelOverzichtTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bestelOverzichtTxt.Size = new System.Drawing.Size(749, 478);
            this.bestelOverzichtTxt.TabIndex = 9;
            // 
            // bestelHoeveelheid
            // 
            this.bestelHoeveelheid.Enabled = false;
            this.bestelHoeveelheid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestelHoeveelheid.Location = new System.Drawing.Point(490, 293);
            this.bestelHoeveelheid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bestelHoeveelheid.Name = "bestelHoeveelheid";
            this.bestelHoeveelheid.Size = new System.Drawing.Size(127, 38);
            this.bestelHoeveelheid.TabIndex = 9;
            this.bestelHoeveelheid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bestelOverzichtLbl
            // 
            this.bestelOverzichtLbl.AutoSize = true;
            this.bestelOverzichtLbl.Font = new System.Drawing.Font("Siemens Sans SC Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestelOverzichtLbl.Location = new System.Drawing.Point(647, 58);
            this.bestelOverzichtLbl.Name = "bestelOverzichtLbl";
            this.bestelOverzichtLbl.Size = new System.Drawing.Size(172, 21);
            this.bestelOverzichtLbl.TabIndex = 10;
            this.bestelOverzichtLbl.Text = "BESTELOVERZICHT";
            // 
            // bestelHoeveelheidLbl
            // 
            this.bestelHoeveelheidLbl.AutoSize = true;
            this.bestelHoeveelheidLbl.Font = new System.Drawing.Font("Siemens Sans SC Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestelHoeveelheidLbl.Location = new System.Drawing.Point(476, 263);
            this.bestelHoeveelheidLbl.Name = "bestelHoeveelheidLbl";
            this.bestelHoeveelheidLbl.Size = new System.Drawing.Size(165, 18);
            this.bestelHoeveelheidLbl.TabIndex = 11;
            this.bestelHoeveelheidLbl.Text = "BESTELHOEVEELHEID";
            // 
            // toonBestelbedrag
            // 
            this.toonBestelbedrag.Enabled = false;
            this.toonBestelbedrag.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toonBestelbedrag.Location = new System.Drawing.Point(490, 508);
            this.toonBestelbedrag.Name = "toonBestelbedrag";
            this.toonBestelbedrag.Size = new System.Drawing.Size(124, 62);
            this.toonBestelbedrag.TabIndex = 12;
            this.toonBestelbedrag.Text = "Toon\r\nbestelbedrag";
            this.toonBestelbedrag.UseVisualStyleBackColor = true;
            this.toonBestelbedrag.Click += new System.EventHandler(this.ToonBestelbedrag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 596);
            this.Controls.Add(this.toonBestelbedrag);
            this.Controls.Add(this.bestelHoeveelheidLbl);
            this.Controls.Add(this.bestelOverzichtLbl);
            this.Controls.Add(this.bestelHoeveelheid);
            this.Controls.Add(this.bestelOverzichtTxt);
            this.Controls.Add(this.productNaarBestelBon);
            this.Controls.Add(this.klantNaarBestelBon);
            this.Controls.Add(this.productenLijstLbl);
            this.Controls.Add(this.klantenLijstLbl);
            this.Controls.Add(this.klantenLijstCb);
            this.Controls.Add(this.productenLb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bestelmodule";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestelHoeveelheid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox productenLb;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem bestellingToolStripMenuItem;
        private ToolStripMenuItem nieuwToolStripMenuItem;
        private ToolStripMenuItem opslaanToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem overToolStripMenuItem;
        private ComboBox klantenLijstCb;
        private Label klantenLijstLbl;
        private Label productenLijstLbl;
        private Button klantNaarBestelBon;
        private Button productNaarBestelBon;
        private TextBox bestelOverzichtTxt;
        private NumericUpDown bestelHoeveelheid;
        private SaveFileDialog saveFileDialog1;
        private Label bestelOverzichtLbl;
        private Label bestelHoeveelheidLbl;
        private ToolStripSeparator toolStripSeparator1;
        private Button toonBestelbedrag;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}